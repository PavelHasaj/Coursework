﻿using System;
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
            SqlCommand command = new SqlCommand("SELECT * FROM Syllabus", connection);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
            dataGridView1.Columns[0].HeaderText = "ID записи";
            dataGridView1.Columns[1].HeaderText = "ID группы";
            dataGridView1.Columns[2].HeaderText = "ID преподавателя";
            dataGridView1.Columns[3].HeaderText = "ID дисциплины";
            dataGridView1.Columns[4].HeaderText = "Кол-во часов";
            dataGridView1.Columns[5].HeaderText = "Кол-во пар";
            Program.DeleteEmptyColumns(dataGridView1);
        }

        private void SyllabusForm_Load(object sender, EventArgs e) {
            DatabaseUpdate();
        }

        private void DataAddButton_Click(object sender, EventArgs e) {
            //добавление записи
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();

            SqlCommand comand = new SqlCommand("INSERT INTO Syllabus VALUES (@ID_zap, @GroupID, @TeacherID, @DisciplineID, @Number_of_hours, @Number_of_pairs)", connection);
            comand.Parameters.AddWithValue("@ID_zap", IDZapTextBox.Text);
            comand.Parameters.AddWithValue("@GroupID", GroupIDTextBox.Text);
            comand.Parameters.AddWithValue("@TeacherID", TeacherIDTextBox.Text);
            comand.Parameters.AddWithValue("@DisciplineID", DisciplineIDTextBox.Text);
            comand.Parameters.AddWithValue("@Number_of_hours", NumberOfHoursTextBox.Text);
            comand.Parameters.AddWithValue("@Number_of_pairs", ClassTimeTextBox.Text);

            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            DatabaseUpdate();//вызов метода обновления dataGridView
        }

        private void DataChangeButton_Click(object sender, EventArgs e) {
            SqlCommand comand = new SqlCommand("UPDATE Syllabus SET GroupID=@GroupID, TeacherID=@TeacherID, DisciplineID=@DisciplineID, Number_of_hours=@Number_of_hours, Number_of_pairs=@Number_of_pairs WHERE ID_zap = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value, connection);
            comand.Parameters.AddWithValue("@GroupID", GroupIDTextBox.Text);
            comand.Parameters.AddWithValue("@TeacherID", TeacherIDTextBox.Text);
            comand.Parameters.AddWithValue("@DisciplineID", DisciplineIDTextBox.Text);
            comand.Parameters.AddWithValue("@Number_of_hours", NumberOfHoursTextBox.Text);
            comand.Parameters.AddWithValue("@Number_of_pairs", ClassTimeTextBox.Text);

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
                for (int j = 0; j < dataGridView1.ColumnCount; j++) {
                    if (dataGridView1.Rows[i].Cells[j].Value != null) {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text)) {
                            dataGridView1.Rows[i].Selected = true;
                            return;
                        }
                    }
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

            dataGridView1.Columns[0].HeaderText = "ID записи";
            dataGridView1.Columns[1].HeaderText = "ID группы";
            dataGridView1.Columns[2].HeaderText = "ID преподавателя";
            dataGridView1.Columns[3].HeaderText = "ID дисциплины";
            dataGridView1.Columns[4].HeaderText = "Кол-во часов";
            dataGridView1.Columns[5].HeaderText = "Время пары";
        }

        private void SelectFromTablesButton_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();
            SqlCommand comand = new SqlCommand("SELECT Syllabus.Id_zap, Syllabus.Number_of_hours, Syllabus.Number_of_pairs, Groups.Group_Name, Teachers.Teacher_FullName, Disciplines.Discipline_Name FROM Syllabus INNER JOIN Groups ON Syllabus.GroupID=Groups.Group_ID LEFT JOIN Teachers ON Syllabus.TeacherID=Teachers.Teacher_ID LEFT JOIN Disciplines ON Syllabus.DisciplineID=Disciplines.Discipline_ID", connection);
            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            Program.DeleteEmptyColumns(dataGridView1);
            dataGridView1.Columns[0].HeaderText = "ID записи";
            dataGridView1.Columns[1].HeaderText = "Кол-во часов";
            dataGridView1.Columns[2].HeaderText = "Кол-во пар";
            dataGridView1.Columns[3].HeaderText = "Группа";
            dataGridView1.Columns[4].HeaderText = "Преподаватель";
            dataGridView1.Columns[5].HeaderText = "Дисциплина";
        }

        private void ToExcelButton_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();
            SqlCommand comand = new SqlCommand("SELECT Syllabus.Number_of_hours, Syllabus.Number_of_pairs, Groups.Group_Name, Teachers.Teacher_FullName, Disciplines.Discipline_Name FROM Syllabus INNER JOIN Groups ON Syllabus.GroupID=Groups.Group_ID LEFT JOIN Teachers ON Syllabus.TeacherID=Teachers.Teacher_ID LEFT JOIN Disciplines ON Syllabus.DisciplineID=Disciplines.Discipline_ID", connection);
            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            Program.DeleteEmptyColumns(dataGridView1);
            dataGridView1.Columns[0].HeaderText = "Кол-во часов";
            dataGridView1.Columns[1].HeaderText = "Кол-во пар";
            dataGridView1.Columns[2].HeaderText = "Группа";
            dataGridView1.Columns[3].HeaderText = "Преподаватель";
            dataGridView1.Columns[4].HeaderText = "Дисциплина";

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            //Создаем рабочую книгу:
            ExcelApp.Application.Workbooks.Add(Type.Missing);

            //Вывод дня недели и номера пары
            int indent = 2;
            ExcelApp.Cells[1, 1] = "Расписание занятий. Подготовил: ...";
            ExcelApp.Cells[3, 1] = "Понедельник";
            ExcelApp.Cells[7, 1] = "Вторник";
            ExcelApp.Cells[11, 1] = "Среда";
            ExcelApp.Cells[15, 1] = "Четверг";
            ExcelApp.Cells[19, 1] = "Пятница";
            ExcelApp.Cells[23, 1] = "Суббота";
            for (int days = 0; days < 6; days++) {
                for (int pairs = 1; pairs < 5; pairs++) {
                    ExcelApp.Cells[indent + (days * 4) + pairs, 2] = pairs;
                }
            }

            ExcelApp.Cells[2, 1] = "День недели";
            ExcelApp.Cells[2, 2] = "Номер пары";
            ExcelApp.Cells[2, 3] = "Группа";
            ExcelApp.Cells[2, 4] = "Преподаватель";
            ExcelApp.Cells[2, 5] = "Дисциплина";
            indent++;
            int indentFromTop = 0;
            int DisciplinesCount = dataGridView1.RowCount - 1;
            for (int dicipline = 0; dicipline < DisciplinesCount; dicipline++) { //для всех дисциплин
                int MaxPairs = Convert.ToInt32(dataGridView1.Rows[dicipline].Cells[1].Value);
                for (int pair = indent + dicipline; pair < MaxPairs + indent + dicipline; pair++) { //для пар по дисциплине
                    for (int cells = 2; cells < dataGridView1.ColumnCount; cells++) { //записать строку
                        ExcelApp.Cells[pair + indentFromTop, cells + 1] = dataGridView1[cells, dicipline].Value.ToString();
                    }
                    if ((pair + indentFromTop - 1) % 4 == 0)
                        indentFromTop++;
                }
                indentFromTop += MaxPairs - 1;
            }

            ExcelApp.Columns.AutoFit(); //
            ExcelApp.Visible = true;
        }

        private void SumOfHoursByGroups_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = null;
            dataSet.Clear();
            connection.Open();
            SqlCommand comand = new SqlCommand("SELECT Groups.Group_Name, SUM(Syllabus.Number_of_hours) AS NumberOfOrders FROM Syllabus LEFT JOIN Groups ON Syllabus.GroupID = Groups.Group_ID GROUP BY Group_Name; ", connection);
            dataAdapter.SelectCommand = comand;
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

            Program.DeleteEmptyColumns(dataGridView1);
            dataGridView1.Columns[0].HeaderText = "Название группы";
            dataGridView1.Columns[1].HeaderText = "Кол-во часов";
        }
    }
}
