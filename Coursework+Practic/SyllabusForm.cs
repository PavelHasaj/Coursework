using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            SqlCommand command_select = new SqlCommand("SELECT * FROM Syllabus", connection);
            dataAdapter.SelectCommand = command_select;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
            dataGridView1.Columns[0].HeaderText = "ID записи";
            dataGridView1.Columns[1].HeaderText = "ID группы";
            dataGridView1.Columns[2].HeaderText = "ID преподавателя";
            dataGridView1.Columns[3].HeaderText = "ID дисциплины";
            dataGridView1.Columns[4].HeaderText = "Кол-во часов";
            dataGridView1.Columns[5].HeaderText = "Время пары";
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
            SqlCommand comand = new SqlCommand("SELECT * FROM Syllabus WHERE Number_of_hours LIKE @Number_of_hours", connection);
            comand.Parameters.AddWithValue("@Number_of_hours", "%" + FilterTextBox.Text + "%");
            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void SelectFromTablesButton_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();
            SqlCommand comand = new SqlCommand("SELECT Syllabus.Id_zap, Syllabus.Number_of_hours, Syllabus.Class_time, Groups.Group_Name, Teachers.Teacher_FullName, Disciplines.Discipline_Name FROM Syllabus INNER JOIN Groups ON Syllabus.GroupID=Groups.Group_ID LEFT JOIN Teachers ON Syllabus.TeacherID=Teachers.Teacher_ID LEFT JOIN Disciplines ON Syllabus.DisciplineID=Disciplines.Discipline_ID", connection);
            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            bool IsColumnEmpty;

            for (int i = 0; i < dataGridView1.Columns.Count; i++) {
                IsColumnEmpty = dataGridView1.Rows[0].Cells[i].Value.ToString() == "";
                if (IsColumnEmpty) {
                    dataGridView1.Columns.RemoveAt(i);
                    i--;
                }
            }
        }

        private void ToExcelButton_Click(object sender, EventArgs e) {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            //Создаем рабочую книгу:
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            //Нам доступно редактирование некоторых параметров, в качестве примера изменим ширину столбцов:
            ExcelApp.Columns.ColumnWidth = 15;
            //Задать значение ячейки можно так:
            ExcelApp.Cells[1, 1] = "ID записи";
            ExcelApp.Cells[1, 2] = "ID группы";
            ExcelApp.Cells[1, 3] = "ID преподавателя";
            ExcelApp.Cells[1, 4] = "ID лисциплины";
            ExcelApp.Cells[1, 5] = "Кол-во часов";
            ExcelApp.Cells[1, 6] = "Время пары";
            //Для переноса данных применил такой цикл (dgvHadTovar — это имя моего компонента DataGridView):
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                for (int j = 0; j < dataGridView1.RowCount; j++) {
                    ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
                }
            }
            //j + 2, потому что первая строка отведена для подписей столбцов!
            //И для отображения полученного результата, необходимо показать документ:
            ExcelApp.Visible = true;
        }
    }
}
