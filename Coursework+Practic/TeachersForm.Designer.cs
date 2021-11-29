
namespace Coursework_Practic {
    partial class TeachersForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Coursework_Practic.Database1DataSet();
            this.TeacherIDTextBox = new System.Windows.Forms.TextBox();
            this.TeacherFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataAddButton = new System.Windows.Forms.Button();
            this.DataChangeButton = new System.Windows.Forms.Button();
            this.DataDeleteButton = new System.Windows.Forms.Button();
            this.NextFormButton = new System.Windows.Forms.Button();
            this.MainFormButton = new System.Windows.Forms.Button();
            this.PreviousFormButton = new System.Windows.Forms.Button();
            this.DatabaseUpdateButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "SampleDatabaseDataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TeacherIDTextBox
            // 
            this.TeacherIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TeacherIDTextBox.Location = new System.Drawing.Point(116, 12);
            this.TeacherIDTextBox.Name = "TeacherIDTextBox";
            this.TeacherIDTextBox.Size = new System.Drawing.Size(218, 20);
            this.TeacherIDTextBox.TabIndex = 1;
            // 
            // TeacherFullNameTextBox
            // 
            this.TeacherFullNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TeacherFullNameTextBox.Location = new System.Drawing.Point(116, 34);
            this.TeacherFullNameTextBox.Name = "TeacherFullNameTextBox";
            this.TeacherFullNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.TeacherFullNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID преподавателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // DataAddButton
            // 
            this.DataAddButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataAddButton.Location = new System.Drawing.Point(174, 64);
            this.DataAddButton.Name = "DataAddButton";
            this.DataAddButton.Size = new System.Drawing.Size(75, 23);
            this.DataAddButton.TabIndex = 5;
            this.DataAddButton.Text = "Добавить";
            this.DataAddButton.UseVisualStyleBackColor = true;
            this.DataAddButton.Click += new System.EventHandler(this.DataAddButton_Click);
            // 
            // DataChangeButton
            // 
            this.DataChangeButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataChangeButton.Location = new System.Drawing.Point(93, 64);
            this.DataChangeButton.Name = "DataChangeButton";
            this.DataChangeButton.Size = new System.Drawing.Size(75, 23);
            this.DataChangeButton.TabIndex = 4;
            this.DataChangeButton.Text = "Изменить";
            this.DataChangeButton.UseVisualStyleBackColor = true;
            this.DataChangeButton.Click += new System.EventHandler(this.DataChangeButton_Click);
            // 
            // DataDeleteButton
            // 
            this.DataDeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataDeleteButton.Location = new System.Drawing.Point(15, 64);
            this.DataDeleteButton.Name = "DataDeleteButton";
            this.DataDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DataDeleteButton.TabIndex = 3;
            this.DataDeleteButton.Text = "Удалить";
            this.DataDeleteButton.UseVisualStyleBackColor = true;
            this.DataDeleteButton.Click += new System.EventHandler(this.DataDeleteButton_Click);
            // 
            // NextFormButton
            // 
            this.NextFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.NextFormButton.Location = new System.Drawing.Point(259, 386);
            this.NextFormButton.Name = "NextFormButton";
            this.NextFormButton.Size = new System.Drawing.Size(75, 23);
            this.NextFormButton.TabIndex = 9;
            this.NextFormButton.Text = "Вперед";
            this.NextFormButton.UseVisualStyleBackColor = true;
            this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
            // 
            // MainFormButton
            // 
            this.MainFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.MainFormButton.Location = new System.Drawing.Point(178, 386);
            this.MainFormButton.Name = "MainFormButton";
            this.MainFormButton.Size = new System.Drawing.Size(75, 23);
            this.MainFormButton.TabIndex = 8;
            this.MainFormButton.Text = "Главная";
            this.MainFormButton.UseVisualStyleBackColor = true;
            this.MainFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
            // 
            // PreviousFormButton
            // 
            this.PreviousFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.PreviousFormButton.Location = new System.Drawing.Point(97, 386);
            this.PreviousFormButton.Name = "PreviousFormButton";
            this.PreviousFormButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousFormButton.TabIndex = 7;
            this.PreviousFormButton.Text = "Назад";
            this.PreviousFormButton.UseVisualStyleBackColor = true;
            this.PreviousFormButton.Click += new System.EventHandler(this.MainFormButton_Click);
            // 
            // DatabaseUpdateButton
            // 
            this.DatabaseUpdateButton.BackColor = System.Drawing.SystemColors.Control;
            this.DatabaseUpdateButton.Location = new System.Drawing.Point(259, 64);
            this.DatabaseUpdateButton.Name = "DatabaseUpdateButton";
            this.DatabaseUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.DatabaseUpdateButton.TabIndex = 6;
            this.DatabaseUpdateButton.Text = "Обновить";
            this.DatabaseUpdateButton.UseVisualStyleBackColor = true;
            this.DatabaseUpdateButton.Click += new System.EventHandler(this.DatabaseUpdateButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.Location = new System.Drawing.Point(134, 96);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.SearchTextBox.TabIndex = 44;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FilterTextBox.Location = new System.Drawing.Point(134, 124);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(200, 20);
            this.FilterTextBox.TabIndex = 44;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поиск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Фильтрация по ФИО";
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DatabaseUpdateButton);
            this.Controls.Add(this.PreviousFormButton);
            this.Controls.Add(this.MainFormButton);
            this.Controls.Add(this.NextFormButton);
            this.Controls.Add(this.DataDeleteButton);
            this.Controls.Add(this.DataChangeButton);
            this.Controls.Add(this.DataAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherFullNameTextBox);
            this.Controls.Add(this.TeacherIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeachersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Преподаватели";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeachersForm_FormClosing);
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.TextBox TeacherIDTextBox;
        private System.Windows.Forms.TextBox TeacherFullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DataAddButton;
        private System.Windows.Forms.Button DataChangeButton;
        private System.Windows.Forms.Button DataDeleteButton;
        private System.Windows.Forms.Button NextFormButton;
        private System.Windows.Forms.Button MainFormButton;
        private System.Windows.Forms.Button PreviousFormButton;
        private System.Windows.Forms.Button DatabaseUpdateButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

