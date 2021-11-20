using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursework_Practic {
    public partial class MainForm : Form {
        public MainForm() {
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
        }

        private void Form1_Load(object sender, EventArgs e) {
            DatabaseUpdate();
        }

        private void DatabaseUpdateButton_Click(object sender, EventArgs e) {
            DatabaseUpdate();
        }

        private void DataAddButton_Click(object sender, EventArgs e) {
            //добавление записи
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            SqlCommand comand = new SqlCommand("Insert Into Pairs Values (@Pair_id, @Pair_number, @Teacher_name, @Group_name)", connection);
            comand.Parameters.AddWithValue("@Pair_id", Convert.ToInt32(textBox1.Text));
            comand.Parameters.AddWithValue("@Teacher_name", textBox3.Text);

            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
            DatabaseUpdate();//вызов метода обновления dataGridView
        }
    }
}
