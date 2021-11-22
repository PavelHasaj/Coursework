namespace Coursework_Practic
{
    partial class GroupsForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseUpdateButton
            // 
            this.DatabaseUpdateButton.BackColor = System.Drawing.SystemColors.Control;
            this.DatabaseUpdateButton.Location = new System.Drawing.Point(256, 64);
            this.DatabaseUpdateButton.Name = "DatabaseUpdateButton";
            this.DatabaseUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.DatabaseUpdateButton.TabIndex = 30;
            this.DatabaseUpdateButton.Text = "Обновить";
            this.DatabaseUpdateButton.UseVisualStyleBackColor = true;
            this.DatabaseUpdateButton.Click += new System.EventHandler(this.DatabaseUpdateButton_Click);
            // 
            // PreviousFormButton
            // 
            this.PreviousFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.PreviousFormButton.Location = new System.Drawing.Point(87, 389);
            this.PreviousFormButton.Name = "PreviousFormButton";
            this.PreviousFormButton.Size = new System.Drawing.Size(77, 23);
            this.PreviousFormButton.TabIndex = 31;
            this.PreviousFormButton.Text = "Назад";
            this.PreviousFormButton.UseVisualStyleBackColor = true;
            this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
            // 
            // MainFormButton
            // 
            this.MainFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.MainFormButton.Location = new System.Drawing.Point(170, 389);
            this.MainFormButton.Name = "MainFormButton";
            this.MainFormButton.Size = new System.Drawing.Size(77, 23);
            this.MainFormButton.TabIndex = 32;
            this.MainFormButton.Text = "Главная";
            this.MainFormButton.UseVisualStyleBackColor = true;
            this.MainFormButton.Click += new System.EventHandler(this.MainFormButton_Click);
            // 
            // NextFormButton
            // 
            this.NextFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.NextFormButton.Location = new System.Drawing.Point(253, 389);
            this.NextFormButton.Name = "NextFormButton";
            this.NextFormButton.Size = new System.Drawing.Size(77, 23);
            this.NextFormButton.TabIndex = 33;
            this.NextFormButton.Text = "Вперед";
            this.NextFormButton.UseVisualStyleBackColor = true;
            this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
            // 
            // DataDeleteButton
            // 
            this.DataDeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataDeleteButton.Location = new System.Drawing.Point(13, 64);
            this.DataDeleteButton.Name = "DataDeleteButton";
            this.DataDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DataDeleteButton.TabIndex = 27;
            this.DataDeleteButton.Text = "Удалить";
            this.DataDeleteButton.UseVisualStyleBackColor = true;
            this.DataDeleteButton.Click += new System.EventHandler(this.DataDeleteButton_Click);
            // 
            // DataChangeButton
            // 
            this.DataChangeButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataChangeButton.Location = new System.Drawing.Point(94, 64);
            this.DataChangeButton.Name = "DataChangeButton";
            this.DataChangeButton.Size = new System.Drawing.Size(75, 23);
            this.DataChangeButton.TabIndex = 28;
            this.DataChangeButton.Text = "Изменить";
            this.DataChangeButton.UseVisualStyleBackColor = true;
            this.DataChangeButton.Click += new System.EventHandler(this.DataChangeButton_Click);
            // 
            // DataAddButton
            // 
            this.DataAddButton.BackColor = System.Drawing.SystemColors.Control;
            this.DataAddButton.Location = new System.Drawing.Point(175, 64);
            this.DataAddButton.Name = "DataAddButton";
            this.DataAddButton.Size = new System.Drawing.Size(75, 23);
            this.DataAddButton.TabIndex = 29;
            this.DataAddButton.Text = "Добавить";
            this.DataAddButton.UseVisualStyleBackColor = true;
            this.DataAddButton.Click += new System.EventHandler(this.DataAddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Название группы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID группы";
            // 
            // DisciplineNameTextBox
            // 
            this.DisciplineNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisciplineNameTextBox.Location = new System.Drawing.Point(112, 38);
            this.DisciplineNameTextBox.Name = "DisciplineNameTextBox";
            this.DisciplineNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.DisciplineNameTextBox.TabIndex = 26;
            // 
            // DisciplineIDTextBox
            // 
            this.DisciplineIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisciplineIDTextBox.Location = new System.Drawing.Point(112, 12);
            this.DisciplineIDTextBox.Name = "DisciplineIDTextBox";
            this.DisciplineIDTextBox.Size = new System.Drawing.Size(219, 20);
            this.DisciplineIDTextBox.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 401);
            this.dataGridView1.TabIndex = 22;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Control;
            this.SearchButton.Location = new System.Drawing.Point(13, 93);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(71, 23);
            this.SearchButton.TabIndex = 41;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.Location = new System.Drawing.Point(98, 96);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(233, 20);
            this.SearchTextBox.TabIndex = 40;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(769, 424);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
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
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группы";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox DisciplineNameTextBox;
        private System.Windows.Forms.TextBox DisciplineIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}