using System;
using System.Windows.Forms;

namespace ExamyUserControl.Admin
{
    public partial class CtlAdminReports : UserControl
    {
        public CtlAdminReports()
        {
            InitializeComponent();
        }

        private void CtlAdminReports_Load(object sender, EventArgs e) => cmbReports.SelectedIndex = 0;
    }
}
