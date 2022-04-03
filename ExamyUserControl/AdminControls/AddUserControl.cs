using ExamDatabase.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExamyUserControl.Admin
{
    public partial class AddUserControl : UserControl
    {
        private ExamyDbContext _examyDb;

        public AddUserControl()
        {
            InitializeComponent();
            _examyDb = new ExamyDbContext();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please Enter Course Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudCourseDuration.Value <= nudCourseDuration.Minimum || nudCourseDuration.Value > nudCourseDuration.Maximum)
            {
                MessageBox.Show("Course Duration Must be Greater than 1 and less than 100 hour", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudTotalGrade.Value <= nudTotalGrade.Minimum || nudTotalGrade.Value > nudTotalGrade.Maximum)
            {
                MessageBox.Show("Course Total Grade Must be Greater than 1 and less than 100 Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to insert {txtCourseName.Text} Course", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Course course = new Course();
                    course.Name = txtCourseName.Text;
                    course.Duration = (int)nudCourseDuration.Value;
                    course.TotalGrade = (int)nudTotalGrade.Value;
                    _examyDb.Courses.Add(course);
                    _examyDb.SaveChanges();
                    MessageBox.Show($"{txtCourseName.Text} Course inserted Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAddCourseFields();
                }

            }
        }

        private void ResetAddCourseFields()
        {
            txtCourseName.Text = string.Empty;
            nudCourseDuration.Value = nudTotalGrade.Value = nudCourseDuration.Minimum;
        }


        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInstructorName.Text))
            {
                MessageBox.Show("Please Enter Intructor Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudSalary.Value < nudSalary.Minimum || nudSalary.Value > nudSalary.Maximum)
            {
                MessageBox.Show("Salary Must be Positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbDegrees.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Instructor Degree", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbInstDepartments.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Instructor Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtInstAddress.Text))
            {
                MessageBox.Show("Please Enter Instructor Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to insert Instructor {txtInstructorName.Text}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ExamDatabase.Models.Instructor instructor = new ExamDatabase.Models.Instructor();
                    instructor.Name = txtInstructorName.Text;
                    instructor.Address = txtInstAddress.Text;
                    instructor.Degree = cmbDegrees.Text;
                    instructor.DeptId = (int)cmbInstDepartments.SelectedValue;
                    instructor.Salary = nudSalary.Value;
                    _examyDb.Instructors.Add(instructor);
                    _examyDb.SaveChanges();
                    MessageBox.Show($"Instructor {txtInstructorName.Text} inserted Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAddInstructorFields();
                }

            }
        }

        private void ResetAddInstructorFields()
        {
            txtInstructorName.Text = txtInstAddress.Text = string.Empty;
            nudSalary.Value = nudSalary.Minimum;
            cmbDegrees.SelectedIndex = cmbInstDepartments.SelectedIndex = 0;
        }



        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSudentName.Text))
            {
                MessageBox.Show("Please Enter Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nupAge.Value < nupAge.Minimum || nupAge.Value > nupAge.Maximum)
            {
                MessageBox.Show($"Student Age Must be between {nupAge.Minimum} and {nupAge.Maximum}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtStudentEmail.Text) || txtStudentEmail.Text.Length < 10 || !txtStudentEmail.Text.Contains('@'))
            {
                MessageBox.Show("Please Enter valid Student Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtStudentPassword.Text))
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbStudDepartments.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Student Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtStudAddress.Text))
            {
                MessageBox.Show("Please Enter studnet Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to insert student {txtSudentName.Text}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Student student = new Student();
                    student.Name = txtSudentName.Text;
                    student.Email = txtStudentEmail.Text;
                    student.Password = txtStudentPassword.Text;
                    student.Age = (int?)nupAge.Value;
                    student.Address = txtStudAddress.Text;
                    student.DeptId = (int?)cmbStudDepartments.SelectedValue;
                    _examyDb.Students.Add(student);
                    _examyDb.SaveChanges();
                    MessageBox.Show($"Student {txtSudentName.Text} inserted Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAddStudentFields();

                }
            }
        }

        private void ResetAddStudentFields()
        {
            txtSudentName.Text = txtStudentEmail.Text = txtStudentPassword.Text = txtStudAddress.Text = string.Empty;
            nupAge.Value = nupAge.Minimum;
            cmbStudDepartments.SelectedIndex = 0;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeptname.Text))
            {
                MessageBox.Show("Please Enter Department Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbDeptManagers.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Department Manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtDeptDesc.Text))
            {
                MessageBox.Show("Please Enter Department Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to insert{txtDeptname.Text} Department", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Department department = new Department();
                    department.Name = txtDeptname.Text;
                    department.Description = txtDeptDesc.Text;
                    department.ManagerId = (int?)cmbDeptManagers.SelectedValue;
                    department.HireDate = picHireDate.Value;
                    _examyDb.Departments.Add(department);
                    _examyDb.SaveChanges();
                    MessageBox.Show($"Depatment {txtDeptname.Text} inserted Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAddDepartmentFields();
                }
            }

        }

        private void ResetAddDepartmentFields()
        {
            txtDeptname.Text = txtDeptDesc.Text = string.Empty;
            cmbDeptManagers.SelectedIndex = 0;
            picHireDate.Value = DateTime.Now.Date;
        }

        private void LoadDepartments(ComboBox comboBox)
        {
            //var depts = _examyDb.Departments.SqlQuery("EXEC GetAllDepartments").ToList();
            var depts = _examyDb.Departments.Select(d => new { d.Id, d.Name }).ToList();
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
            depts.Insert(0, new { Id = 0, Name = "Please Select Department..." });
            comboBox.DataSource = depts;

        }

        private void tbAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((TabControl)sender).SelectedIndex)
            {
                case 1:
                    LoadDepartments(cmbInstDepartments);
                    cmbDegrees.SelectedIndex = 0;
                    cmbInstDepartments.SelectedIndex = 0;
                    break;
                case 2:
                    LoadDepartments(cmbStudDepartments);
                    cmbStudDepartments.SelectedIndex = 0;
                    break;
                case 3:
                    cmbDeptManagers.SelectedIndex = 0;
                    break;
            }
        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {
            LoadDepartments(cmbInstDepartments);
            LoadDepartments(cmbStudDepartments);
            LoadDeptManagers();

        }

        private void LoadDeptManagers()
        {
            var instructors = _examyDb.Instructors.Select(i => new { i.Id, i.Name }).ToList();
            cmbDeptManagers.ValueMember = "Id";
            cmbDeptManagers.DisplayMember = "Name";
            instructors.Insert(0, new { Id = 0, Name = "Please Select Manager..." });
            cmbDeptManagers.DataSource = instructors;
        }
    }
}
