namespace MedicianCenter.Registar
{
    partial class AddHistoryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DoctorNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeseaseTextBox = new System.Windows.Forms.TextBox();
            this.FindDoctorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FindPatientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DoctorNameTextBox);
            this.groupBox1.Controls.Add(this.PatientNameTextBox);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.TimeTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DeseaseTextBox);
            this.groupBox1.Controls.Add(this.FindDoctorButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FindPatientButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(410, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о приеме";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Болеет",
            "Не болеет"});
            this.StatusComboBox.Location = new System.Drawing.Point(16, 238);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(271, 24);
            this.StatusComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Статус:";
            // 
            // DoctorNameTextBox
            // 
            this.DoctorNameTextBox.Location = new System.Drawing.Point(16, 100);
            this.DoctorNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorNameTextBox.Name = "DoctorNameTextBox";
            this.DoctorNameTextBox.ReadOnly = true;
            this.DoctorNameTextBox.Size = new System.Drawing.Size(271, 22);
            this.DoctorNameTextBox.TabIndex = 14;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(16, 53);
            this.PatientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(271, 22);
            this.PatientNameTextBox.TabIndex = 13;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(17, 319);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(378, 45);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Добавить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(16, 289);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(271, 22);
            this.TimeTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Время:";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(16, 192);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(271, 22);
            this.DatePicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата записи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Диагноз:";
            // 
            // DeseaseTextBox
            // 
            this.DeseaseTextBox.Location = new System.Drawing.Point(16, 146);
            this.DeseaseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeseaseTextBox.Name = "DeseaseTextBox";
            this.DeseaseTextBox.Size = new System.Drawing.Size(379, 22);
            this.DeseaseTextBox.TabIndex = 6;
            // 
            // FindDoctorButton
            // 
            this.FindDoctorButton.Location = new System.Drawing.Point(295, 97);
            this.FindDoctorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindDoctorButton.Name = "FindDoctorButton";
            this.FindDoctorButton.Size = new System.Drawing.Size(100, 28);
            this.FindDoctorButton.TabIndex = 5;
            this.FindDoctorButton.Text = "Выбрать";
            this.FindDoctorButton.UseVisualStyleBackColor = true;
            this.FindDoctorButton.Click += new System.EventHandler(this.FindDoctorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Доктор:";
            // 
            // FindPatientButton
            // 
            this.FindPatientButton.Location = new System.Drawing.Point(295, 50);
            this.FindPatientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindPatientButton.Name = "FindPatientButton";
            this.FindPatientButton.Size = new System.Drawing.Size(100, 28);
            this.FindPatientButton.TabIndex = 3;
            this.FindPatientButton.Text = "Выбрать";
            this.FindPatientButton.UseVisualStyleBackColor = true;
            this.FindPatientButton.Click += new System.EventHandler(this.FindPatientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пациент:";
            // 
            // AddHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 408);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHistoryForm";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.AddHistoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindPatientButton;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeseaseTextBox;
        private System.Windows.Forms.Button FindDoctorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox DoctorNameTextBox;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label6;
    }
}