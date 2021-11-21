using System;
using System.Windows.Forms;

namespace Coursework_Practic {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void TeachersButton_Click(object sender, EventArgs e) {
            TeachersForm form = new TeachersForm();
            form.Show();
            this.Hide();
        }

        private void GroupsButton_Click(object sender, EventArgs e) {
            GroupsForm form = new GroupsForm();
            form.Show();
            this.Hide();
        }

        private void DisciplinesButton_Click(object sender, EventArgs e) {
            DisciplinesForm form = new DisciplinesForm();
            form.Show();
            this.Hide();
        }

        private void SyllabusButton_Click(object sender, EventArgs e) {
            SyllabusForm form = new SyllabusForm();
            form.Show();
            this.Hide();
        }

        private void AppExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
