using ExamyUserControl.StudentControls;
using System.Drawing;
using System.Windows.Forms;

namespace ExamyUI
{
    public partial class FrmStudentMain : Form
    {
        public int StudentId { get; set; }
        public FrmStudentMain()
        {
            InitializeComponent();
        }

        private void AddControl(UserControl control, int x, int y, DockStyle dockStyle)
        {
            pnlContainer.Controls.Clear();
            control.Location = new Point(x, y);
            control.Dock = dockStyle;
            pnlContainer.Controls.Add(control);
        }

        private void FrmStudentMain_Load(object sender, System.EventArgs e)
        {

        }

        private void tbExams_Click(object sender, System.EventArgs e)
        {
            CtlAvailableExams exams = new CtlAvailableExams() { studentId = this.StudentId};
            AddControl(exams, 0, 0, DockStyle.Fill);
        }
    }
}
