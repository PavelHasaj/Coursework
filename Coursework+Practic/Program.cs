using System;
using System.Windows.Forms;

namespace Coursework_Practic {
    public static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static MainForm mainForm = new MainForm();

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm);
        }
    }
}
