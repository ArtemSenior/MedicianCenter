namespace MedicianCenter.Doctor
{
    partial class NextVisitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NextVisitDayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NotVisitCheckbox = new System.Windows.Forms.CheckBox();
            this.CreateExtractButton = new System.Windows.Forms.Button();
            this.HistoryCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата и время следующего посещения";
            // 
            // NextVisitDayTimePicker
            // 
            this.NextVisitDayTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.NextVisitDayTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NextVisitDayTimePicker.Location = new System.Drawing.Point(66, 43);
            this.NextVisitDayTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextVisitDayTimePicker.Name = "NextVisitDayTimePicker";
            this.NextVisitDayTimePicker.Size = new System.Drawing.Size(159, 22);
            this.NextVisitDayTimePicker.TabIndex = 2;
            // 
            // NotVisitCheckbox
            // 
            this.NotVisitCheckbox.AutoSize = true;
            this.NotVisitCheckbox.Location = new System.Drawing.Point(87, 73);
            this.NotVisitCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotVisitCheckbox.Name = "NotVisitCheckbox";
            this.NotVisitCheckbox.Size = new System.Drawing.Size(120, 20);
            this.NotVisitCheckbox.TabIndex = 3;
            this.NotVisitCheckbox.Text = "Не указывать";
            this.NotVisitCheckbox.UseVisualStyleBackColor = true;
            this.NotVisitCheckbox.CheckedChanged += new System.EventHandler(this.NotVisitCheckbox_CheckedChanged);
            // 
            // CreateExtractButton
            // 
            this.CreateExtractButton.Location = new System.Drawing.Point(19, 129);
            this.CreateExtractButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateExtractButton.Name = "CreateExtractButton";
            this.CreateExtractButton.Size = new System.Drawing.Size(247, 38);
            this.CreateExtractButton.TabIndex = 4;
            this.CreateExtractButton.Text = "Сделать выписку";
            this.CreateExtractButton.UseVisualStyleBackColor = true;
            this.CreateExtractButton.Click += new System.EventHandler(this.CreateExtractButton_Click);
            // 
            // HistoryCheckBox
            // 
            this.HistoryCheckBox.AutoSize = true;
            this.HistoryCheckBox.Location = new System.Drawing.Point(48, 101);
            this.HistoryCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HistoryCheckBox.Name = "HistoryCheckBox";
            this.HistoryCheckBox.Size = new System.Drawing.Size(202, 20);
            this.HistoryCheckBox.TabIndex = 5;
            this.HistoryCheckBox.Text = "Указать историю приемов";
            this.HistoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // NextVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 185);
            this.Controls.Add(this.HistoryCheckBox);
            this.Controls.Add(this.CreateExtractButton);
            this.Controls.Add(this.NotVisitCheckbox);
            this.Controls.Add(this.NextVisitDayTimePicker);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NextVisitForm";
            this.Text = "Выписка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NextVisitDayTimePicker;
        private System.Windows.Forms.CheckBox NotVisitCheckbox;
        private System.Windows.Forms.Button CreateExtractButton;
        private System.Windows.Forms.CheckBox HistoryCheckBox;
    }
}