using ExamyUserControl.Instructor;
using ExamyUserControl.InstructorControls;
using System.Drawing;
using System.Windows.Forms;

namespace ExamyUI
{
    public partial class FrmInstructorMain : Form
    {
        public int InstructorId { get; set; }

        public FrmInstructorMain()
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

        private void tbReports_Click(object sender, System.EventArgs e)
        {
            CtlInstructorReports reports = new CtlInstructorReports();
            AddControl(reports, 0, 0, DockStyle.Fill);
        }

        private void tbCreateExam_Click(object sender, System.EventArgs e)
        {
            CtlCreateExam createExam = new CtlCreateExam() { InstructorId = InstructorId };
            AddControl(createExam, 0, 0, DockStyle.Fill);
        }
    }
}
