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

        public static double StringToDouble(string text, ref bool isWrong) {
            bool isRight = double.TryParse(text, out double x);
            if (!isWrong) {
                isWrong = !isRight;
            }

            if (isRight) {
                return x;
            } else {
                MessageBox.Show("Число введено неверно", "Ошибка: введено не число");
                return Double.NaN;
            }
        }
        
        public static int StringToInt32(string a, ref bool isAlredyWrong) {
            bool isConvertationSuccesfully = int.TryParse(a, out int x);
            if (!isAlredyWrong) {
                isAlredyWrong = !isConvertationSuccesfully;
            }

            if (isConvertationSuccesfully) {
                return x;
            } else {
                MessageBox.Show("Число введено неверно", "Ошибка: введено не число");
                return 0;
            }
        }
    }
}
