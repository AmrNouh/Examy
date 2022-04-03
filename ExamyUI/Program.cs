using System;
using System.Windows.Forms;

namespace ExamyUI
{
    internal static class Program
    {
        public static Form _mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin loginForm = new FrmLogin();
            Application.Run(loginForm);

            if (loginForm.UserSuccessfullyAuthenticated)
            {
                if (!(_mainForm is null))
                {
                    Application.Run(_mainForm);
                }
            }
        }
    }
}
