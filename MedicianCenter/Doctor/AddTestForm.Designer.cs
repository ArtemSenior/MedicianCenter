namespace MedicianCenter.Doctor
{
    partial class AddTestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.TestDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MinMaxLabel = new System.Windows.Forms.Label();
            this.TestTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddTestButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид анализа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание:";
            // 
            // TestDescriptionTextBox
            // 
            this.TestDescriptionTextBox.Location = new System.Drawing.Point(12, 105);
            this.TestDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TestDescriptionTextBox.Name = "TestDescriptionTextBox";
            this.TestDescriptionTextBox.Size = new System.Drawing.Size(415, 153);
            this.TestDescriptionTextBox.TabIndex = 5;
            this.TestDescriptionTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MinMaxLabel);
            this.groupBox2.Controls.Add(this.TestTypeComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TestDescriptionTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(20, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(435, 274);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об анализе";
            // 
            // MinMaxLabel
            // 
            this.MinMaxLabel.AutoSize = true;
            this.MinMaxLabel.Location = new System.Drawing.Point(8, 59);
            this.MinMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinMaxLabel.Name = "MinMaxLabel";
            this.MinMaxLabel.Size = new System.Drawing.Size(53, 16);
            this.MinMaxLabel.TabIndex = 7;
            this.MinMaxLabel.Text = "MinMax";
            // 
            // TestTypeComboBox
            // 
            this.TestTypeComboBox.FormattingEnabled = true;
            this.TestTypeComboBox.Location = new System.Drawing.Point(115, 27);
            this.TestTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TestTypeComboBox.Name = "TestTypeComboBox";
            this.TestTypeComboBox.Size = new System.Drawing.Size(312, 24);
            this.TestTypeComboBox.TabIndex = 6;
            this.TestTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TestTypeComboBox_SelectedIndexChanged);
            // 
            // AddTestButton
            // 
            this.AddTestButton.Location = new System.Drawing.Point(20, 306);
            this.AddTestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddTestButton.Name = "AddTestButton";
            this.AddTestButton.Size = new System.Drawing.Size(435, 43);
            this.AddTestButton.TabIndex = 10;
            this.AddTestButton.Text = "Добавить анализ";
            this.AddTestButton.UseVisualStyleBackColor = true;
            this.AddTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 357);
            this.Controls.Add(this.AddTestButton);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTestForm";
            this.Text = "Добавить анализ";
            this.Load += new System.EventHandler(this.AddTestForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TestDescriptionTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddTestButton;
        private System.Windows.Forms.ComboBox TestTypeComboBox;
        private System.Windows.Forms.Label MinMaxLabel;
    }
}