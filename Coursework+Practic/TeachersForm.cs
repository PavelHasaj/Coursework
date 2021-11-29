using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coursework_Practic {
    public partial class TeachersForm : Form {
        public TeachersForm() {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        Database1DataSet dataSet = new Database1DataSet();

        private void DatabaseUpdate() {
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();
            SqlCommand command_select = new SqlCommand("Select * From Teachers", connection);
            dataAdapter.SelectCommand = command_select;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
            dataGridView1.Columns[0].HeaderText = "ID преподавателя";
            dataGridView1.Columns[1].HeaderText = "ФИО";
        }

        private void TeachersForm_Load(object sender, EventArgs e) {
            DatabaseUpdate();
        }

        private void DataAddButton_Click(object sender, EventArgs e) {
            //добавление записи
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            SqlCommand comand = new SqlCommand("INSERT INTO Teachers VALUES (@Teacher_ID, @Teacher_FullName)", connection);
            comand.Parameters.AddWithValue("@Teacher_ID", TeacherIDTextBox.Text);
            comand.Parameters.AddWithValue("@Teacher_FullName", TeacherFullNameTextBox.Text);

            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();//вызов метода обновления dataGridView
        }

        private void DataChangeButton_Click(object sender, EventArgs e) {
            SqlCommand command = new SqlCommand("UPDATE Teachers SET Teacher_FullName=@Teacher_FullName WHERE Teacher_ID = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);
            command.Parameters.AddWithValue("@Teacher_FullName", TeacherFullNameTextBox.Text);
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();
        }

        private void DataDeleteButton_Click(object sender, EventArgs e) {
            SqlCommand command = new SqlCommand("DELETE FROM Teachers WHERE Teacher_ID = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);

            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();
        }

        private void NextFormButton_Click(object sender, EventArgs e) {
            DisciplinesForm form = new DisciplinesForm();
            form.Show();
            this.Close();
        }

        private void MainFormButton_Click(object sender, EventArgs e) {
            Program.mainForm.Show();
            this.Close();
        }

        private void DatabaseUpdateButton_Click(object sender, EventArgs e) {
            DatabaseUpdate();
        }

        private void PreviousFormButton_Click(object sender, EventArgs e) {
            Program.mainForm.Show();
            this.Close();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) {
            for (int i = 0; i < dataGridView1.RowCount; i++) {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text)) {
                            dataGridView1.Rows[i].Selected = true;
                            return;
                        }
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e) {
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();
            SqlCommand comand = new SqlCommand("SELECT * FROM Teachers WHERE Teacher_FullName LIKE @Teacher_FullName", connection);
            comand.Parameters.AddWithValue("@Teacher_FullName", "%" + FilterTextBox.Text + "%");
            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void TeachersForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.mainForm.Show();
            this.Close();
        }
    }
}
