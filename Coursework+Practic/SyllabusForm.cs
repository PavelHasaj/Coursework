using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursework_Practic {
    public partial class SyllabusForm : Form {
        public SyllabusForm() {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        Database1DataSet dataSet = new Database1DataSet();

        private void DatabaseUpdate() {
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();
            SqlCommand command_select = new SqlCommand("Select * From Syllabus", connection);
            dataAdapter.SelectCommand = command_select;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void SyllabusForm_Load(object sender, EventArgs e) {
            DatabaseUpdate();
        }

        private void DataAddButton_Click(object sender, EventArgs e) {
            //добавление записи
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            SqlCommand comand = new SqlCommand("INSERT INTO Syllabus VALUES (@ID_zap, @GroupID, @TeacherID, @DisciplineID, @Number_of_hours, @Class_time)", connection);
            comand.Parameters.AddWithValue("@ID_zap", IDZapTextBox.Text);
            comand.Parameters.AddWithValue("@GroupID", GroupIDTextBox.Text);
            comand.Parameters.AddWithValue("@TeacherID", TeacherIDTextBox.Text);
            comand.Parameters.AddWithValue("@DisciplineID", DisciplineIDTextBox.Text);
            comand.Parameters.AddWithValue("@Number_of_hours", NumberOfHoursTextBox.Text);
            comand.Parameters.AddWithValue("@Class_time", ClassTimeTextBox.Text);

            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();//вызов метода обновления dataGridView
        }

        private void DataChangeButton_Click(object sender, EventArgs e) {
            SqlCommand comand = new SqlCommand("UPDATE Syllabus SET GroupID=@GroupID, TeacherID=@TeacherID, DisciplineID=@DisciplineID, Number_of_hours=@Number_of_hours, Class_time=@Class_time WHERE ID_zap = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);
            comand.Parameters.AddWithValue("@GroupID", GroupIDTextBox.Text);
            comand.Parameters.AddWithValue("@TeacherID", TeacherIDTextBox.Text);
            comand.Parameters.AddWithValue("@DisciplineID", DisciplineIDTextBox.Text);
            comand.Parameters.AddWithValue("@Number_of_hours", NumberOfHoursTextBox.Text);
            comand.Parameters.AddWithValue("@Class_time", ClassTimeTextBox.Text);

            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();
        }

        private void DataDeleteButton_Click(object sender, EventArgs e) {
            SqlCommand command = new SqlCommand("DELETE FROM Syllabus WHERE ID_zap = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);

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
            Program.mainForm.Show();
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
            GroupsForm form = new GroupsForm();
            form.Show();
            this.Close();
        }
    }
}
