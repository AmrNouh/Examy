using ExamDatabase.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExamyUI
{
    public partial class FrmLogin : Form
    {
        ExamyDbContext dbContext;
        public bool UserSuccessfullyAuthenticated { get; private set; }
        private string _username = string.Empty;
        private string _password = string.Empty;

        public FrmLogin()
        {
            InitializeComponent();
            dbContext = new ExamyDbContext();
        }

        private void FrmLogin_Load(object sender, EventArgs e) => cmbUserType.SelectedIndex = 0;

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            _username = txtEmail.Text;
            _password = txtPassword.Text;

            if (IsValidUser(_username,_password))
            {
                switch (cmbUserType.SelectedIndex)
                {
                    case 1:
                        // check if This UserName and password is already exists in database
                        var student = IsRealStudent(_username, _password);
                        if (student != null)
                        {
                            UserSuccessfullyAuthenticated = true;
                            Program._mainForm = new FrmStudentMain() { StudentId = student.Id};
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Email or Password Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        break;

                    case 2:
                        var instructor = IsRealInstructor(int.Parse(_password),_username);
                        if (instructor != null)
                        {
                            UserSuccessfullyAuthenticated = true;
                            Program._mainForm = new FrmInstructorMain() { InstructorId = instructor.Id};
                            Close();
                        }
                        break;
                    case 3:
                        if (txtEmail.Text.ToLower().Trim() == "admin" && txtPassword.Text.ToLower().Trim() == "admin")
                        {
                            UserSuccessfullyAuthenticated = true;
                            Program._mainForm = new FrmAdimMain();
                            Close();
                        }
                        break;
                    default:
                        MessageBox.Show("Please Select Who You Are", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Email or Password Incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        bool IsValidUser(string userName,string password)
        {
            if (String.IsNullOrWhiteSpace(userName) || String.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            return true;
        }

        Student IsRealStudent(string userName, string password)
        {
            return dbContext.Students.SingleOrDefault(s => s.Email == userName && s.Password == password);
        }

        Instructor IsRealInstructor(int id, string name)
        {
            return dbContext.Instructors.SingleOrDefault(i => i.Id == id && i.Name == name);
        }
    }
}
