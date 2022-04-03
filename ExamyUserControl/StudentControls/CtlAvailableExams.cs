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

namespace ExamyUserControl.StudentControls
{
    public partial class CtlAvailableExams : UserControl
    {
        public int studentId { get; set; }
        ExamyDbContext examyDb;
        public CtlAvailableExams()
        {
            InitializeComponent();
            examyDb = new ExamyDbContext();
        }

        private void CtlAvailableExams_Load(object sender, EventArgs e)
        {
            GetAllStudentExams();
            CreateDataGridViewColumn();
        }

        private void GetAllStudentExams()
        {
            var idParam = new SqlParameter { ParameterName = "@studId", DbType = DbType.Int32, Value = this.studentId };
            var exams = examyDb.Database.SqlQuery<AvailableExams>("EXEC [dbo].[GetAllStudentExams] @studId", idParam).ToList<AvailableExams>();
            dgvAvailableExams.DataSource = exams;
        }

        void CreateDataGridViewColumn()
        {
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn.Width = 64;
            dataGridViewImageColumn.Image = Properties.Resources.start_button;
            dgvAvailableExams.Columns.Add(dataGridViewImageColumn);
        }

        private void dgvAvailableExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell.ColumnIndex == 0)
            {
                int examNumber = (int)dgvAvailableExams.CurrentRow.Cells["ExamNumber"].Value;
                string courseName = (string)dgvAvailableExams.CurrentRow.Cells["CourseName"].Value;
                string instName = (string)dgvAvailableExams.CurrentRow.Cells["InstructorName"].Value;
                int courseId = examyDb.Courses.SingleOrDefault(c => c.Name == courseName).Id;
                int examDuration = (int)dgvAvailableExams.CurrentRow.Cells["Duration"].Value;
                
                FrmExam frmExam = new FrmExam()
                {
                    CourseName = courseName,
                    ExamNumber = examNumber,
                    StudentId = this.studentId,
                    ExamTimeHours = examDuration,
                    questions = GetExamQuestions(examNumber, courseId),
                    InstructorName = instName

                };
                frmExam.ShowDialog();
            }
        }

        private List<ExamQuestion> GetExamQuestions(int examNumber, int courseId)
        {
            var examNumberParam = new SqlParameter
            {
                ParameterName = "@ExamNumber",
                DbType = DbType.Int32,
                Value = examNumber,
            };

            var courseIdParam = new SqlParameter
            {
                ParameterName = "@courseId",
                DbType = DbType.Int32,
                Value = courseId
            };

            return examyDb.Database.SqlQuery<ExamQuestion>("EXECUTE [dbo].[GetAllExamQuestions] @ExamNumber, @courseId;", examNumberParam, courseIdParam).ToList<ExamQuestion>();
        }
    }
}
