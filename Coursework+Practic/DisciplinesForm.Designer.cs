
namespace Coursework_Practic
{
    partial class DisciplinesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database1DataSet = new Coursework_Practic.Database1DataSet();
            this.sampleDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseUpdateButton = new System.Windows.Forms.Button();
            this.PreviousFormButton = new System.Windows.Forms.Button();
            this.MainFormButton = new System.Windows.Forms.Button();
            this.NextFormButton = new System.Windows.Forms.Button();
            this.DataDeleteButton = new System.Windows.Forms.Button();
            this.DataChangeButton = new System.Windows.Forms.Button();
            this.DataAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DisciplineNameTextBox = new System.Windows.Forms.TextBox();
            this.DisciplineIDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampleDatabaseDataSetBindingSource
            // 
            this.sampleDatabaseDataSetBindingSource.DataSource = this.database1DataSet;
            this.sampleDatabaseDataSetBindingSource.Position = 0;
            // 
            // DatabaseUpdateButton
            // 
            this.DatabaseUpdateButton.BackColor = System.Drawing.SystemColors.Control;
            this.DatabaseUpdateButton.Location = new System.Drawing.Point(281, 60);
            this.DatabaseUpdateButton.Name = "DatabaseUpdateButton";
            this.DatabaseUpdateButton.Size = new System.Drawing.Size(77, 23);
            this.DatabaseUpdateButton.TabIndex = 18;
            this.DatabaseUpdateButton.Text = "Обновить";
            this.DatabaseUpdateButton.UseVisualStyleBackColor = true;
            this.DatabaseUpdateButton.Click += new System.EventHandler(this.DatabaseUpdateButton_Click);
            // 
            // PreviousFormButton
            // 
            this.PreviousFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.PreviousFormButton.Location = new System.Drawing.Point(115, 389);
            this.PreviousFormButton.Name = "PreviousFormButton";
            this.PreviousFormButton.Size = new System.Drawing.Size(77, 23);
            this.PreviousFormButton.TabIndex = 19;
            this.PreviousFormButton.Text = "Назад";
            this.PreviousFormButton.UseVisualStyleBackColor = true;
            this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
            // 
            // MainFormButton
            // 
            this.MainFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.MainFormButton.Location = new System.Drawing.Point(198, 389);
            this.MainFormButton.Name = "MainFormButton";
            this.MainFormButton.Size = new System.Drawing.Size(77, 23);
            this.MainFormButton.TabIndex = 20;
            this.MainFormButton.Text = "Главная";
            this.MainFormButton.UseVisualStyleBackColor = true;
            this.MainFormButton.Click += new System.EventHandler(this.MainFormButton_Click);
            // 
            // NextFormButton
            // 
            this.NextFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.NextFormButton.Location = new System.Drawing.Point(281, 389);
            this.NextFormButton.Name = "NextFormButton";
            this.NextFormButton.Size = new System.Drawing.Size(77, 23);
            this.NextFormButton.TabIndex = 21;
            this.NextFormButton.Text = "Вперед";
            this.NextFormButton.UseVisualStyleBackColor = true;
            this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
            // 
            // DataDeleteButton
            // 
            this.DataDeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataDeleteButton.Location = new System.Drawing.Point(15, 60);
            this.DataDeleteButton.Name = "DataDeleteButton";
            this.DataDeleteButton.Size = new System.Drawing.Size(80, 23);
            this.DataDeleteButton.TabIndex = 15;
            this.DataDeleteButton.Text = "Удалить";
            this.DataDeleteButton.UseVisualStyleBackColor = true;
            this.DataDeleteButton.Click += new System.EventHandler(this.DataDeleteButton_Click);
            // 
            // DataChangeButton
            // 
            this.DataChangeButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataChangeButton.Location = new System.Drawing.Point(104, 60);
            this.DataChangeButton.Name = "DataChangeButton";
            this.DataChangeButton.Size = new System.Drawing.Size(80, 23);
            this.DataChangeButton.TabIndex = 16;
            this.DataChangeButton.Text = "Изменить";
            this.DataChangeButton.UseVisualStyleBackColor = true;
            this.DataChangeButton.Click += new System.EventHandler(this.DataChangeButton_Click);
            // 
            // DataAddButton
            // 
            this.DataAddButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataAddButton.Location = new System.Drawing.Point(192, 60);
            this.DataAddButton.Name = "DataAddButton";
            this.DataAddButton.Size = new System.Drawing.Size(80, 23);
            this.DataAddButton.TabIndex = 17;
            this.DataAddButton.Text = "Добавить";
            this.DataAddButton.UseVisualStyleBackColor = true;
            this.DataAddButton.Click += new System.EventHandler(this.DataAddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Название дисциплины";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID дисциплины";
            // 
            // DisciplineNameTextBox
            // 
            this.DisciplineNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisciplineNameTextBox.Location = new System.Drawing.Point(140, 34);
            this.DisciplineNameTextBox.Name = "DisciplineNameTextBox";
            this.DisciplineNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.DisciplineNameTextBox.TabIndex = 14;
            // 
            // DisciplineIDTextBox
            // 
            this.DisciplineIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisciplineIDTextBox.Location = new System.Drawing.Point(140, 8);
            this.DisciplineIDTextBox.Name = "DisciplineIDTextBox";
            this.DisciplineIDTextBox.Size = new System.Drawing.Size(218, 20);
            this.DisciplineIDTextBox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 401);
            this.dataGridView1.TabIndex = 10;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FilterTextBox.Location = new System.Drawing.Point(167, 115);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(191, 20);
            this.FilterTextBox.TabIndex = 47;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.Location = new System.Drawing.Point(167, 89);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(191, 20);
            this.SearchTextBox.TabIndex = 48;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Фильтрация по дисциплине";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Поиск";
            // 
            // DisciplinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatabaseUpdateButton);
            this.Controls.Add(this.PreviousFormButton);
            this.Controls.Add(this.MainFormButton);
            this.Controls.Add(this.NextFormButton);
            this.Controls.Add(this.DataDeleteButton);
            this.Controls.Add(this.DataChangeButton);
            this.Controls.Add(this.DataAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisciplineNameTextBox);
            this.Controls.Add(this.DisciplineIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisciplinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисциплины";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisciplinesForm_FormClosing);
            this.Load += new System.EventHandler(this.DisciplinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sampleDatabaseDataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Button DatabaseUpdateButton;
        private System.Windows.Forms.Button PreviousFormButton;
        private System.Windows.Forms.Button MainFormButton;
        private System.Windows.Forms.Button NextFormButton;
        private System.Windows.Forms.Button DataDeleteButton;
        private System.Windows.Forms.Button DataChangeButton;
        private System.Windows.Forms.Button DataAddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DisciplineNameTextBox;
        private System.Windows.Forms.TextBox DisciplineIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}