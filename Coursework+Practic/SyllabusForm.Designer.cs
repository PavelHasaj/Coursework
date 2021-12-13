
namespace Coursework_Practic {
    partial class SyllabusForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DatabaseUpdateButton = new System.Windows.Forms.Button();
            this.PreviousFormButton = new System.Windows.Forms.Button();
            this.MainFormButton = new System.Windows.Forms.Button();
            this.NextFormButton = new System.Windows.Forms.Button();
            this.DataDeleteButton = new System.Windows.Forms.Button();
            this.DataChangeButton = new System.Windows.Forms.Button();
            this.DataAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupIDTextBox = new System.Windows.Forms.TextBox();
            this.IDZapTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeacherIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DisciplineIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfHoursTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfPairsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectFromTablesButton = new System.Windows.Forms.Button();
            this.ToExcelButton = new System.Windows.Forms.Button();
            this.SumOfHoursByGroups = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilterCueTextBox = new Coursework_Practic.CueTextBox();
            this.DisciplineFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.FilterButton = new System.Windows.Forms.Button();
            this.TeacherFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupFilterRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseUpdateButton
            // 
            this.DatabaseUpdateButton.BackColor = System.Drawing.SystemColors.Control;
            this.DatabaseUpdateButton.Location = new System.Drawing.Point(266, 169);
            this.DatabaseUpdateButton.Name = "DatabaseUpdateButton";
            this.DatabaseUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.DatabaseUpdateButton.TabIndex = 10;
            this.DatabaseUpdateButton.Text = "Обновить";
            this.DatabaseUpdateButton.UseVisualStyleBackColor = true;
            this.DatabaseUpdateButton.Click += new System.EventHandler(this.DatabaseUpdateButton_Click);
            // 
            // PreviousFormButton
            // 
            this.PreviousFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.PreviousFormButton.Location = new System.Drawing.Point(12, 349);
            this.PreviousFormButton.Name = "PreviousFormButton";
            this.PreviousFormButton.Size = new System.Drawing.Size(107, 23);
            this.PreviousFormButton.TabIndex = 16;
            this.PreviousFormButton.Text = "Назад";
            this.PreviousFormButton.UseVisualStyleBackColor = true;
            this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
            // 
            // MainFormButton
            // 
            this.MainFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.MainFormButton.Location = new System.Drawing.Point(125, 349);
            this.MainFormButton.Name = "MainFormButton";
            this.MainFormButton.Size = new System.Drawing.Size(103, 23);
            this.MainFormButton.TabIndex = 17;
            this.MainFormButton.Text = "Главная";
            this.MainFormButton.UseVisualStyleBackColor = true;
            this.MainFormButton.Click += new System.EventHandler(this.MainFormButton_Click);
            // 
            // NextFormButton
            // 
            this.NextFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.NextFormButton.Location = new System.Drawing.Point(234, 349);
            this.NextFormButton.Name = "NextFormButton";
            this.NextFormButton.Size = new System.Drawing.Size(107, 23);
            this.NextFormButton.TabIndex = 18;
            this.NextFormButton.Text = "Вперед";
            this.NextFormButton.UseVisualStyleBackColor = true;
            this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
            // 
            // DataDeleteButton
            // 
            this.DataDeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataDeleteButton.Location = new System.Drawing.Point(12, 169);
            this.DataDeleteButton.Name = "DataDeleteButton";
            this.DataDeleteButton.Size = new System.Drawing.Size(76, 23);
            this.DataDeleteButton.TabIndex = 7;
            this.DataDeleteButton.Text = "Удалить";
            this.DataDeleteButton.UseVisualStyleBackColor = true;
            this.DataDeleteButton.Click += new System.EventHandler(this.DataDeleteButton_Click);
            // 
            // DataChangeButton
            // 
            this.DataChangeButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataChangeButton.Location = new System.Drawing.Point(98, 169);
            this.DataChangeButton.Name = "DataChangeButton";
            this.DataChangeButton.Size = new System.Drawing.Size(76, 23);
            this.DataChangeButton.TabIndex = 8;
            this.DataChangeButton.Text = "Изменить";
            this.DataChangeButton.UseVisualStyleBackColor = true;
            this.DataChangeButton.Click += new System.EventHandler(this.DataChangeButton_Click);
            // 
            // DataAddButton
            // 
            this.DataAddButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataAddButton.Location = new System.Drawing.Point(180, 169);
            this.DataAddButton.Name = "DataAddButton";
            this.DataAddButton.Size = new System.Drawing.Size(76, 23);
            this.DataAddButton.TabIndex = 9;
            this.DataAddButton.Text = "Добавить";
            this.DataAddButton.UseVisualStyleBackColor = true;
            this.DataAddButton.Click += new System.EventHandler(this.DataAddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "ID группы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID записи";
            // 
            // GroupIDTextBox
            // 
            this.GroupIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.GroupIDTextBox.Location = new System.Drawing.Point(122, 39);
            this.GroupIDTextBox.Name = "GroupIDTextBox";
            this.GroupIDTextBox.Size = new System.Drawing.Size(219, 20);
            this.GroupIDTextBox.TabIndex = 2;
            // 
            // IDZapTextBox
            // 
            this.IDZapTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IDZapTextBox.Location = new System.Drawing.Point(122, 13);
            this.IDZapTextBox.Name = "IDZapTextBox";
            this.IDZapTextBox.Size = new System.Drawing.Size(219, 20);
            this.IDZapTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(618, 360);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.TabStop = false;
            // 
            // TeacherIDTextBox
            // 
            this.TeacherIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TeacherIDTextBox.Location = new System.Drawing.Point(122, 65);
            this.TeacherIDTextBox.Name = "TeacherIDTextBox";
            this.TeacherIDTextBox.Size = new System.Drawing.Size(219, 20);
            this.TeacherIDTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID преподавателя";
            // 
            // DisciplineIDTextBox
            // 
            this.DisciplineIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisciplineIDTextBox.Location = new System.Drawing.Point(122, 91);
            this.DisciplineIDTextBox.Name = "DisciplineIDTextBox";
            this.DisciplineIDTextBox.Size = new System.Drawing.Size(219, 20);
            this.DisciplineIDTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID дисциплины";
            // 
            // NumberOfHoursTextBox
            // 
            this.NumberOfHoursTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberOfHoursTextBox.Location = new System.Drawing.Point(122, 117);
            this.NumberOfHoursTextBox.Name = "NumberOfHoursTextBox";
            this.NumberOfHoursTextBox.Size = new System.Drawing.Size(219, 20);
            this.NumberOfHoursTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Кол-во часов";
            // 
            // NumberOfPairsTextBox
            // 
            this.NumberOfPairsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberOfPairsTextBox.Location = new System.Drawing.Point(122, 143);
            this.NumberOfPairsTextBox.Name = "NumberOfPairsTextBox";
            this.NumberOfPairsTextBox.Size = new System.Drawing.Size(219, 20);
            this.NumberOfPairsTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Кол-во пар";
            // 
            // SelectFromTablesButton
            // 
            this.SelectFromTablesButton.Location = new System.Drawing.Point(180, 291);
            this.SelectFromTablesButton.Name = "SelectFromTablesButton";
            this.SelectFromTablesButton.Size = new System.Drawing.Size(161, 23);
            this.SelectFromTablesButton.TabIndex = 14;
            this.SelectFromTablesButton.Text = "Выборка";
            this.SelectFromTablesButton.UseVisualStyleBackColor = true;
            this.SelectFromTablesButton.Click += new System.EventHandler(this.SelectFromTablesButton_Click);
            // 
            // ToExcelButton
            // 
            this.ToExcelButton.Location = new System.Drawing.Point(12, 291);
            this.ToExcelButton.Name = "ToExcelButton";
            this.ToExcelButton.Size = new System.Drawing.Size(162, 23);
            this.ToExcelButton.TabIndex = 13;
            this.ToExcelButton.Text = "Вывод в Excel";
            this.ToExcelButton.UseVisualStyleBackColor = true;
            this.ToExcelButton.Click += new System.EventHandler(this.ToExcelButton_Click);
            // 
            // SumOfHoursByGroups
            // 
            this.SumOfHoursByGroups.Location = new System.Drawing.Point(12, 320);
            this.SumOfHoursByGroups.Name = "SumOfHoursByGroups";
            this.SumOfHoursByGroups.Size = new System.Drawing.Size(329, 23);
            this.SumOfHoursByGroups.TabIndex = 15;
            this.SumOfHoursByGroups.Text = "Найти общее кол-во часов группы";
            this.SumOfHoursByGroups.UseVisualStyleBackColor = true;
            this.SumOfHoursByGroups.Click += new System.EventHandler(this.SumOfHoursByGroups_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilterCueTextBox);
            this.groupBox1.Controls.Add(this.DisciplineFilterRadioButton);
            this.groupBox1.Controls.Add(this.FilterButton);
            this.groupBox1.Controls.Add(this.TeacherFilterRadioButton);
            this.groupBox1.Controls.Add(this.GroupFilterRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 87);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // FilterCueTextBox
            // 
            this.FilterCueTextBox.Cue = "Параметр фильтра";
            this.FilterCueTextBox.Location = new System.Drawing.Point(133, 19);
            this.FilterCueTextBox.Name = "FilterCueTextBox";
            this.FilterCueTextBox.Size = new System.Drawing.Size(190, 20);
            this.FilterCueTextBox.TabIndex = 48;
            // 
            // DisciplineFilterRadioButton
            // 
            this.DisciplineFilterRadioButton.AutoSize = true;
            this.DisciplineFilterRadioButton.Location = new System.Drawing.Point(6, 65);
            this.DisciplineFilterRadioButton.Name = "DisciplineFilterRadioButton";
            this.DisciplineFilterRadioButton.Size = new System.Drawing.Size(102, 17);
            this.DisciplineFilterRadioButton.TabIndex = 47;
            this.DisciplineFilterRadioButton.TabStop = true;
            this.DisciplineFilterRadioButton.Text = "По дисциплине";
            this.DisciplineFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(133, 45);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(190, 23);
            this.FilterButton.TabIndex = 13;
            this.FilterButton.Text = "Отфильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // TeacherFilterRadioButton
            // 
            this.TeacherFilterRadioButton.AutoSize = true;
            this.TeacherFilterRadioButton.Location = new System.Drawing.Point(6, 42);
            this.TeacherFilterRadioButton.Name = "TeacherFilterRadioButton";
            this.TeacherFilterRadioButton.Size = new System.Drawing.Size(121, 17);
            this.TeacherFilterRadioButton.TabIndex = 47;
            this.TeacherFilterRadioButton.TabStop = true;
            this.TeacherFilterRadioButton.Text = "По преподавателю";
            this.TeacherFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // GroupFilterRadioButton
            // 
            this.GroupFilterRadioButton.AutoSize = true;
            this.GroupFilterRadioButton.Checked = true;
            this.GroupFilterRadioButton.Location = new System.Drawing.Point(6, 19);
            this.GroupFilterRadioButton.Name = "GroupFilterRadioButton";
            this.GroupFilterRadioButton.Size = new System.Drawing.Size(76, 17);
            this.GroupFilterRadioButton.TabIndex = 47;
            this.GroupFilterRadioButton.TabStop = true;
            this.GroupFilterRadioButton.Text = "По группе";
            this.GroupFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // SyllabusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SumOfHoursByGroups);
            this.Controls.Add(this.ToExcelButton);
            this.Controls.Add(this.SelectFromTablesButton);
            this.Controls.Add(this.DatabaseUpdateButton);
            this.Controls.Add(this.PreviousFormButton);
            this.Controls.Add(this.MainFormButton);
            this.Controls.Add(this.NextFormButton);
            this.Controls.Add(this.DataDeleteButton);
            this.Controls.Add(this.DataChangeButton);
            this.Controls.Add(this.DataAddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfPairsTextBox);
            this.Controls.Add(this.NumberOfHoursTextBox);
            this.Controls.Add(this.DisciplineIDTextBox);
            this.Controls.Add(this.TeacherIDTextBox);
            this.Controls.Add(this.GroupIDTextBox);
            this.Controls.Add(this.IDZapTextBox);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SyllabusForm";
            this.Text = "Учебный план";
            this.Load += new System.EventHandler(this.SyllabusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DatabaseUpdateButton;
        private System.Windows.Forms.Button PreviousFormButton;
        private System.Windows.Forms.Button MainFormButton;
        private System.Windows.Forms.Button NextFormButton;
        private System.Windows.Forms.Button DataDeleteButton;
        private System.Windows.Forms.Button DataChangeButton;
        private System.Windows.Forms.Button DataAddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupIDTextBox;
        private System.Windows.Forms.TextBox IDZapTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TeacherIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DisciplineIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberOfHoursTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumberOfPairsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SelectFromTablesButton;
        private System.Windows.Forms.Button ToExcelButton;
        private System.Windows.Forms.Button SumOfHoursByGroups;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DisciplineFilterRadioButton;
        private System.Windows.Forms.RadioButton TeacherFilterRadioButton;
        private System.Windows.Forms.RadioButton GroupFilterRadioButton;
        private CueTextBox FilterCueTextBox;
        private System.Windows.Forms.Button FilterButton;
    }
}