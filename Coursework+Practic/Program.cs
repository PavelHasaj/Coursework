using System;
using System.Windows.Forms;

namespace Coursework_Practic {
    public static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static MainForm mainForm = new MainForm();
        public static TeachersForm teachersForm = new TeachersForm();
        public static DisciplinesForm disciplinesForm = new DisciplinesForm();
        public static GroupsForm groupsForm = new GroupsForm();
        //public static SyllabusForm syllabusForm = new SyllabusForm();

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm);
        }
    }
}
