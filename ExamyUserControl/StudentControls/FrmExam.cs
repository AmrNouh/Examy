using ExamDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ExamyUserControl.StudentControls
{
    public partial class FrmExam : Form
    {
        private static int questionIndex;
        private ExamyDbContext db;

        public int ExamTimeHours { get; set; }
        public int ExamTimeMinutes { get; set; }
        public int ExamTimeSeconds { get; set; }

        public int StudentId { get; set; }
        public int ExamNumber { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public int ExamTotalGrade { get; set; }

        public List<ExamQuestion> questions;
        private Dictionary<int, char> questionAnswers;

        public FrmExam()
        {
            InitializeComponent();
            ExamTimeMinutes = 0;
            ExamTimeSeconds = 0;
            questionIndex = 0;
            db = new ExamyDbContext();
            questionAnswers = new Dictionary<int, char>();
        }

        private void FrmExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure You Want to Close Exam, by closing The Exam Your Answers Will Submited automatically and you will never can Examine it agin", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                examDuration.Stop();
        }

        private void FrmExam_Load(object sender, EventArgs e)
        {
            lblExamTime.Text = string.Format("{0} : {1} : {2}", ExamTimeHours.ToString().PadLeft(2, '0'), ExamTimeMinutes.ToString().PadLeft(2, '0'), ExamTimeSeconds.ToString().PadLeft(2, '0'));
            examDuration.Enabled = true;
            examDuration.Start();

            // Setup Exam Basic Info
            lblExamHeader.Text = $"Online Test - {this.CourseName}";
            lblTotalNumberofQuestons.Text = $"{questionIndex + 1} / {this.questions.Count}";
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
            lblInstructorName.Text = this.InstructorName;
            CreateQuestion(questionIndex);
            CalculateExamTotalGrade();
            lblExamGrade.Text = ExamTotalGrade.ToString();
        }

        private void examDuration_Tick(object sender, EventArgs e)
        {
            if (ExamTimeHours > 0 && ExamTimeMinutes == 0 && ExamTimeSeconds == 0)
            {
                ExamTimeHours -= 1;
                ExamTimeMinutes = 59;
                ExamTimeSeconds = 59;
            }
            else if (ExamTimeHours > 0 && ExamTimeMinutes > 0 && ExamTimeSeconds == 0)
            {
                ExamTimeMinutes -= 1;
                ExamTimeSeconds = 59;
            }
            else if (ExamTimeHours == 0 && ExamTimeMinutes > 0 && ExamTimeSeconds == 0)
            {
                ExamTimeMinutes -= 1;
                ExamTimeSeconds = 59;
            }
            else if (ExamTimeHours == 0 && ExamTimeMinutes == 0 && ExamTimeSeconds == 0)
            {
                examDuration.Stop();
                this.Close();
            }
            else
            {
                ExamTimeSeconds -= 1;
            }
            lblExamTime.Text = string.Format("{0} : {1} : {2}", ExamTimeHours.ToString().PadLeft(2, '0'), ExamTimeMinutes.ToString().PadLeft(2, '0'), ExamTimeSeconds.ToString().PadLeft(2, '0'));

            // Question Counter
            lblTotalNumberofQuestons.Text = $"{questionIndex + 1} / {this.questions.Count}";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            char studentAnswer = CheckedRadioButton();
            questionAnswers.Add(questions[questionIndex].Id, studentAnswer);

            if (questionIndex < questions.Count - 1)
            {
                CreateQuestion(++questionIndex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (questionIndex > 0)
            {
                CreateQuestion(--questionIndex);
            }
        }

        private void btnSubmitExam_Click(object sender, EventArgs e)
        {
            var studIdParam = new SqlParameter
            {
                ParameterName = "@StudentId",
                DbType = DbType.Int32,
                Value = this.StudentId
            };
            var examNumberParam = new SqlParameter
            {
                ParameterName = "@ExamNumber",
                DbType = DbType.Int32,
                Value = this.ExamNumber
            };

            var answerTable = ConvertToDataTable(questionAnswers);
            var questionAnswersParam = new SqlParameter
            {
                SqlDbType = SqlDbType.Structured,
                ParameterName = "@QuestionAnswers",
                TypeName = "[dbo].[StudentQuestionAnswersTable]",
                Value = answerTable
            };

            var submit = db.Database.ExecuteSqlCommand("EXECUTE [dbo].[ExamAnswers] @ExamNumber, @StudentId, @QuestionAnswers;", examNumberParam, studIdParam, questionAnswersParam);

            // Correct Exam
            var totalGradeParam = new SqlParameter
            {
                ParameterName = "@TotalGrade",
                DbType = DbType.Int32,
                Direction = ParameterDirection.Output,
                Value = 0
            };
            var correct = db.Database.ExecuteSqlCommand("EXECUTE [dbo].[CorrectExam] @ExamNumber, @StudentId, @TotalGrade OUTPUT;", examNumberParam, studIdParam, totalGradeParam);

            MessageBox.Show($"Thank You,\nCourse Name: {this.CourseName}\nInstructor Name: {this.InstructorName}\nYour Gade is: {totalGradeParam.Value} / {ExamTotalGrade}\nGood Luck!", "Exam Submited Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CreateQuestion(int index)
        {
            rdChoice03.Visible = rdChoice04.Visible = true;
            lblQuestionNumber.Text = $"Quant - Question {index + 1}";
            lblQuestionGrade.Text = $"[ {questions[index].Grade} Marks ]";
            lblQuestionBody.Text = questions[index].Body;
            SqlParameter questionIdParam = new SqlParameter
            {
                ParameterName = "@QuestionId",
                DbType = DbType.Int32,
                Value = this.questions[index].Id
            };
            List<QuestionChoice> choices = db.Database.SqlQuery<QuestionChoice>("EXECUTE [dbo].[GetQuestionChoices] @QuestionId;", questionIdParam).ToList<QuestionChoice>();

            switch (this.questions[index].Type)
            {
                case "MCQ":
                    rdChoice01.Text = choices[0].choice;
                    rdChoice02.Text = choices[1].choice;
                    rdChoice03.Text = choices[2].choice;
                    rdChoice04.Text = choices[3].choice;
                    break;
                case "True or False":
                    rdChoice01.Text = choices[0].choice;
                    rdChoice02.Text = choices[1].choice;
                    rdChoice03.Visible = rdChoice04.Visible = false;
                    break;
            }

        }

        char CheckedRadioButton()
        {
            var checkedButton = pnlRadioContainer.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                if (checkedButton.Name == rdChoice01.Name)
                {
                    return 'a';
                }
                else if (checkedButton.Name == rdChoice02.Name)
                {
                    return 'b';
                }
                else if (checkedButton.Name == rdChoice03.Name)
                {
                    return 'c';
                }
                else if (checkedButton.Name == rdChoice04.Name)
                {
                    return 'd';
                }
            }
            return ' ';
        }


        private static DataTable ConvertToDataTable(Dictionary<int, char> dict)
        {
            var dt = new DataTable();
            dt.Columns.Add("QuestionId", typeof(int));
            dt.Columns.Add("StudentAnswer", typeof(char));
            foreach (var pair in dict)
            {
                var row = dt.NewRow();
                row["QuestionId"] = pair.Key;
                row["StudentAnswer"] = pair.Value;
                dt.Rows.Add(row);
            }
            return dt;
        }

        void CalculateExamTotalGrade()
        {
            foreach (var question in questions)
            {
                ExamTotalGrade += question.Grade;
            }
        }
    }
}
