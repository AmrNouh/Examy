using ExamDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ExamyUserControl.Admin
{
    public partial class CtlOpenClass : UserControl
    {
        private ExamyDbContext examDb;
        private List<int> selectedStudentsIds;

        public CtlOpenClass()
        {
            InitializeComponent();
            examDb = new ExamyDbContext();
            selectedStudentsIds = new List<int>();
        }

        private void CtlOpenClass_Load(object sender, EventArgs e)
        {
            GetAllCourses();
            cmbCourseNames.SelectedIndex = 0;
            GetAllInstructor();
            cmbCourseInstructor.SelectedIndex = 0;
            GetAllStudents();
        }

        private void GetAllStudents()
        {
            var students = examDb.Students.Select(s => new { s.Id, s.Name, s.Age, s.Address }).ToList();
            dgvStudents.DataSource = students;
        }

        private void GetAllInstructor()
        {
            var instructors = examDb.Instructors.Select(i => new { i.Id, i.Name }).ToList();
            cmbCourseInstructor.ValueMember = "Id";
            cmbCourseInstructor.DisplayMember = "Name";
            instructors.Insert(0, new { Id = 0, Name = "Please Select Instructor.." });
            cmbCourseInstructor.DataSource = instructors;
        }
        private void GetAllCourses()
        {
            var courses = examDb.Courses.Select(c => new { c.Id, c.Name }).ToList();
            cmbCourseNames.ValueMember = "Id";
            cmbCourseNames.DisplayMember = "Name";
            courses.Insert(0, new { Id = 0, Name = "Please Select Course" });
            cmbCourseNames.DataSource = courses;
        }



        private void btnOpenClass_Click(object sender, EventArgs e)
        {
            if (GetSelectedStudents() == 0)
            {
                MessageBox.Show("Can not Create Class without Students", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCourseNames.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Course Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCourseInstructor.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Course Instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if instructor Already Teach This Course
                int courseId = (int)cmbCourseNames.SelectedValue;
                int instructorId = (int)cmbCourseInstructor.SelectedValue;

                InstructorCourse IsAlreadyTeachs = examDb.InstructorCourses.SingleOrDefault(ic => ic.CourseId == courseId && ic.InstructorId == instructorId);

                if (IsAlreadyTeachs != null)
                {
                    MessageBox.Show("This Instructor is already teachs This Course, Please Change Instructor", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Check if any Student Already Take This Course
                foreach (int studentId in selectedStudentsIds)
                {
                    StudentCourse IsAlreadyTakes = examDb.StudentCourses.SingleOrDefault(sc => sc.course_Id == courseId && sc.sudent_Id == studentId);
                    if (IsAlreadyTakes != null)
                    {
                        MessageBox.Show("This Student is already Take This Course, Please Deselect him from student Table", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedStudentsIds.Clear();
                        return;
                    }
                }
                // Insert In InstructorCourses Table
                InstructorCourse instructorCourse = new InstructorCourse();
                instructorCourse.CourseId = (int)cmbCourseNames.SelectedValue;
                instructorCourse.InstructorId = (int)cmbCourseInstructor.SelectedValue;
                examDb.InstructorCourses.Add(instructorCourse);

                // Insert All Select Student In Selected Course
                foreach (int studentId in selectedStudentsIds)
                {
                    StudentCourse studentCourse = new StudentCourse();
                    studentCourse.sudent_Id = studentId;
                    studentCourse.course_Id = courseId;
                    examDb.StudentCourses.Add(studentCourse);

                }

                // Save all Changes
                examDb.SaveChanges();
                cmbCourseNames.SelectedIndex = cmbCourseInstructor.SelectedIndex = 0;
                DeselectAllStudents();
                MessageBox.Show($"Class Opened Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetSelectedStudents()
        {
            int studentCount = 0;
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[0].Value);
                if (isSelected)
                {
                    studentCount++;
                    MessageBox.Show($"{(int)row.Cells["Id"].Value}");
                    selectedStudentsIds.Add((int)row.Cells["Id"].Value);
                }
            }

            return studentCount;
        }

        private void DeselectAllStudents()
        {
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                row.Cells[0].Value = false;
            }
        }
    }
}
