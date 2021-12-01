using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Coursework_Practic {
    public partial class LoginForm : Form {
        //Строка подключения к БД
        SqlConnection connection = new
       SqlConnection(Properties.Settings.Default.Database1ConnectionString);
        public LoginForm() {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        public SqlConnection getConnection() {
            return connection;
        }
        private void LoginButton_Click(object sender, EventArgs e) {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string loginUser = LoginTextBox.Text;
            string passUser = PasswordTextBox.Text;
            LoginForm db = new LoginForm();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE login = @uL AND pass = @uP",
            db.getConnection());
            command.Parameters.Add("@uL",
            SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP",
             SqlDbType.VarChar).Value = passUser;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(table);
            if (table.Rows.Count > 0) {
                Program.mainForm.Show();
                this.Hide();
            } else {
                MessageBox.Show("Логин или пароль неверный");
            }
        }
        private void login_Load(object sender, EventArgs e) {
            ToolTip t = new ToolTip();
            t.SetToolTip(LoginTextBox, "Логин — позволяет пользователям войти в систему.");

            t.SetToolTip(PasswordTextBox, "Пароль — условное слово или произвольный набор знаков, состоящий из букв, цифр и других символов, и предназначенный для подтверждения личности или полномочий.");

            PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}