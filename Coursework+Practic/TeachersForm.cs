using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            SqlCommand command_select = new SqlCommand("Select * From Abonents", connection);
            dataAdapter.SelectCommand = command_select;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        void DataAdd() {
            //добавление записи
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            SqlCommand comand = new SqlCommand("Insert Into Abonents Values (@Nomer_licevogo_cheta, @FIO, @Adres)", connection);
            comand.Parameters.AddWithValue("@Nomer_licevogo_cheta", textBox1.Text);
            comand.Parameters.AddWithValue("@FIO", textBox2.Text);

            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();//вызов метода обновления dataGridView
        }

        void DataChange() {
            SqlCommand command = new SqlCommand("Update Abonents set FullName=@FullName, Adress=@Adress Where AbonentID = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            command.Parameters.AddWithValue("@FullName", textBox2.Text);

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();
        }

        void DataDelete() {
            SqlCommand command = new SqlCommand("Delete From Abonents where AbonentID = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);

            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DatabaseUpdate();
        }

        private void add_button(object sender, EventArgs e) {
            DataAdd();
        }

        private void data_change_button(object sender, EventArgs e) {
            DataChange();
        }

        private void data_delete_button(object sender, EventArgs e) {
            DataDelete();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.disciplinesForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DatabaseUpdate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }
    }
}
