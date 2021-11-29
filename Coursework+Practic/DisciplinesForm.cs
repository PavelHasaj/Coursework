using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coursework_Practic {
    public partial class DisciplinesForm : Form {
        public DisciplinesForm() {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        Database1DataSet dataSet = new Database1DataSet();

        private void DatabaseUpdate() {
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();
            SqlCommand command_select = new SqlCommand("Select * From Disciplines", connection);
            dataAdapter.SelectCommand = command_select;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
            dataGridView1.Columns[0].HeaderText = "ID дисциплины";
            dataGridView1.Columns[1].HeaderText = "Название дисциплины";
        }

        private void DisciplinesForm_Load(object sender, EventArgs e) {
            DatabaseUpdate();
        }

        private void DataAddButton_Click(object sender, EventArgs e) {
            //добавление записи
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            SqlCommand comand = new SqlCommand("INSERT INTO Disciplines VALUES (@Discipline_ID, @Discipline_Name)", connection);
            comand.Parameters.AddWithValue("@Discipline_ID", DisciplineIDTextBox.Text);
            comand.Parameters.AddWithValue("@Discipline_Name", DisciplineNameTextBox.Text);

            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();//вызов метода обновления dataGridView
        }

        private void DataChangeButton_Click(object sender, EventArgs e) {
            SqlCommand command = new SqlCommand("UPDATE Disciplines SET Discipline_Name=@Discipline_Name WHERE Discipline_ID = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);
            command.Parameters.AddWithValue("@Discipline_Name", DisciplineNameTextBox.Text);
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
            SqlCommand command = new SqlCommand("DELETE FROM Disciplines WHERE Discipline_ID = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);

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
            GroupsForm form = new GroupsForm();
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
            TeachersForm form = new TeachersForm();
            form.Show();
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
            SqlCommand comand = new SqlCommand("SELECT * FROM Disciplines WHERE Discipline_Name LIKE @Discipline_Name", connection);
            comand.Parameters.AddWithValue("@Discipline_Name", "%" + FilterTextBox.Text + "%");
            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void DisciplinesForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.mainForm.Show();
            this.Close();
        }
    }
}
