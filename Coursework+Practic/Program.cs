using System;
using System.Windows.Forms;

namespace Coursework_Practic {
    public static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static MainForm mainForm = new MainForm();
        public static LoginForm loginForm = new LoginForm();

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(loginForm);
        }

        public static void DeleteEmptyColumns(DataGridView dataGridView1) {
            bool IsColumnEmpty;
            for (int i = 0; i < dataGridView1.Columns.Count; i++) {
                IsColumnEmpty = dataGridView1.Rows[0].Cells[i].Value.ToString() == "";
                if (IsColumnEmpty) {
                    dataGridView1.Columns.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
