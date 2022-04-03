using ExamDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamyUserControl.InstructorControls
{
    public partial class CtlCreateExam : UserControl
    {
        ExamyDbContext examyDbContext;
        public int InstructorId { get; set; }

        public CtlCreateExam()
        {
            InitializeComponent();
            examyDbContext = new ExamyDbContext();
        }

        private void CtlCreateExam_Load(object sender, EventArgs e)
        {
            GetAllInstructorCourses();
            GetCreatedExams();
        }

        private void GetCreatedExams()
        {
            var IdParam = new SqlParameter { ParameterName = "@InstructorId", Value = InstructorId };
            var selectedExams = examyDbContext.Database.SqlQuery<CreatedExams>("Exec [dbo].[GetAllInstructorExams] @InstructorId", IdParam).ToList();
            dgvExams.DataSource = selectedExams;
        }

        private void GetAllInstructorCourses()
        {
            var IdParam = new SqlParameter { ParameterName = "@InstructorId", Value = InstructorId };
            var courses = examyDbContext.Database.SqlQuery<SelectedCourses>("Exec [dbo].[GetAllInstructorCourses] @InstructorId",IdParam).ToList();

            cmbCourseNames.ValueMember = "Id";
            cmbCourseNames.DisplayMember = "Name";
            courses.Insert(0, new SelectedCourses { Id = 0, Name = "Please Select Course Name..." });
            cmbCourseNames.DataSource = courses;
        }

        private void btnGenerateExam_Click(object sender, EventArgs e)
        {
            if (cmbCourseNames.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Course Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (nudTrueFalseQ.Value == nudTrueFalseQ.Minimum && nudMCQ.Value == nudMCQ.Minimum)
            {
                MessageBox.Show("Can not Create Exam with zero Question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                var instructorName = examyDbContext.Instructors.SingleOrDefault(i => i.Id == InstructorId).Name;

                // Create Query Parameters
                var instructorNameParam = new SqlParameter { ParameterName = "@InstructorName" , Value = instructorName };
                var courseNameParam = new SqlParameter { ParameterName = "@CourseName", Value = cmbCourseNames.Text };
                var numberOfTrueFalseParam = new SqlParameter { ParameterName = "@NumberOfTrueFalseQ", DbType = DbType.Int32, Value = nudTrueFalseQ.Value };
                var numberOfMCQParam = new SqlParameter { ParameterName = "@NumberOfMCQ", DbType = DbType.Int32, Value = nudMCQ.Value };
                var durationParam = new SqlParameter { ParameterName = "@Duration" , DbType = DbType.Int32, Value = nudDuration.Value };
                var startDateParam = new SqlParameter { ParameterName = "@StartDate",DbType = DbType.DateTime,Value = picExamDate.Value};

                // output 
                var output = new SqlParameter { ParameterName = "@ExamNumber", DbType = DbType.Int32, Direction = ParameterDirection.Output };
                
                // Execute Query
                //var IsGenerated = examyDbContext.Database.SqlQuery<int>("Exec [dbo].[GenerateExam] @InstructorName, @CourseName, @NumberOfTrueFalseQ, @NumberOfMCQ, @Duration, @StartDate, @ExamNumber out;", instructorNameParam,courseNameParam,numberOfTrueFalseParam,numberOfMCQParam,durationParam,startDateParam,output).ToList<int>();

                var IsGenerated = examyDbContext.Database.ExecuteSqlCommand("Exec [dbo].[GenerateExam] @InstructorName, @CourseName, @NumberOfTrueFalseQ, @NumberOfMCQ, @Duration, @StartDate, @ExamNumber out;", instructorNameParam, courseNameParam, numberOfTrueFalseParam, numberOfMCQParam, durationParam, startDateParam, output);

                // Load Created Exam Again
                GetCreatedExams();

                // For Test 
                MessageBox.Show($"Exam with Number {output.Value} Is Created","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                // Reset All Fields
                ResetAllField();

            }

            void ResetAllField()
            {
                cmbCourseNames.SelectedIndex = 0;
                nudMCQ.Value = nudTrueFalseQ.Value = 0;
                nudDuration.Value = nudDuration.Minimum;
                picExamDate.Value = DateTime.Now.Date;
            }
        }
    }
}
