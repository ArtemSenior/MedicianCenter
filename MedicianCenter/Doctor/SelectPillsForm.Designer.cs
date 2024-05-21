namespace MedicianCenter.Doctor
{
    partial class SelectPillsForm
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
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.PillsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PillsComboBox = new System.Windows.Forms.ComboBox();
            this.AddPillButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNewPillButton = new System.Windows.Forms.Button();
            this.PillDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PillNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PillsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пациент";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(107, 20);
            this.PatientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(216, 22);
            this.PatientNameTextBox.TabIndex = 1;
            // 
            // PillsDataGridView
            // 
            this.PillsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PillsDataGridView.Location = new System.Drawing.Point(346, 43);
            this.PillsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PillsDataGridView.Name = "PillsDataGridView";
            this.PillsDataGridView.ReadOnly = true;
            this.PillsDataGridView.RowHeadersWidth = 51;
            this.PillsDataGridView.Size = new System.Drawing.Size(537, 405);
            this.PillsDataGridView.TabIndex = 2;
            this.PillsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PillsDataGridView_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(456, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Назначенные лекарства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Лекарство";
            // 
            // PillsComboBox
            // 
            this.PillsComboBox.FormattingEnabled = true;
            this.PillsComboBox.Location = new System.Drawing.Point(107, 69);
            this.PillsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PillsComboBox.Name = "PillsComboBox";
            this.PillsComboBox.Size = new System.Drawing.Size(216, 24);
            this.PillsComboBox.TabIndex = 5;
            // 
            // AddPillButton
            // 
            this.AddPillButton.Location = new System.Drawing.Point(19, 101);
            this.AddPillButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPillButton.Name = "AddPillButton";
            this.AddPillButton.Size = new System.Drawing.Size(304, 40);
            this.AddPillButton.TabIndex = 6;
            this.AddPillButton.Text = "Назначить";
            this.AddPillButton.UseVisualStyleBackColor = true;
            this.AddPillButton.Click += new System.EventHandler(this.AddPillButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNewPillButton);
            this.groupBox1.Controls.Add(this.PillDescriptionTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PillNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(322, 268);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить лекарство";
            // 
            // AddNewPillButton
            // 
            this.AddNewPillButton.Location = new System.Drawing.Point(3, 217);
            this.AddNewPillButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddNewPillButton.Name = "AddNewPillButton";
            this.AddNewPillButton.Size = new System.Drawing.Size(304, 43);
            this.AddNewPillButton.TabIndex = 8;
            this.AddNewPillButton.Text = "Добавить";
            this.AddNewPillButton.UseVisualStyleBackColor = true;
            this.AddNewPillButton.Click += new System.EventHandler(this.AddNewPillButton_Click);
            // 
            // PillDescriptionTextBox
            // 
            this.PillDescriptionTextBox.Location = new System.Drawing.Point(117, 78);
            this.PillDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PillDescriptionTextBox.Name = "PillDescriptionTextBox";
            this.PillDescriptionTextBox.Size = new System.Drawing.Size(190, 133);
            this.PillDescriptionTextBox.TabIndex = 11;
            this.PillDescriptionTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Описание";
            // 
            // PillNameTextBox
            // 
            this.PillNameTextBox.Location = new System.Drawing.Point(117, 42);
            this.PillNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PillNameTextBox.Name = "PillNameTextBox";
            this.PillNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.PillNameTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Наименование";
            // 
            // SelectPillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddPillButton);
            this.Controls.Add(this.PillsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PillsDataGridView);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPillsForm";
            this.Text = "Назначить лекарства";
            this.Load += new System.EventHandler(this.SelectPillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PillsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.DataGridView PillsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PillsComboBox;
        private System.Windows.Forms.Button AddPillButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddNewPillButton;
        private System.Windows.Forms.RichTextBox PillDescriptionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PillNameTextBox;
        private System.Windows.Forms.Label label4;
    }
}