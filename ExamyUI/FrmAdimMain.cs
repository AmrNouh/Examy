using ExamyUserControl.Admin;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExamyUI
{
    public partial class FrmAdimMain : Form
    {
        public FrmAdimMain()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserControl add = new AddUserControl();
            AddControl(add, 0, 0, DockStyle.None);
        }

        private void btnOpenClass_Click(object sender, EventArgs e)
        {
            CtlOpenClass openClass = new CtlOpenClass();
            AddControl(openClass, 0, 0, DockStyle.Fill);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            CtlAdminReports adminReports = new CtlAdminReports();
            AddControl(adminReports, 0, 0, DockStyle.Fill);
        }
    }
}
