namespace MedicianCenter.Doctor
{
    partial class RedirectForm
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
            this.SpecializationTextBox = new System.Windows.Forms.TextBox();
            this.AnotherMedicianCheckBox = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RedirectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Специальность врача";
            // 
            // SpecializationTextBox
            // 
            this.SpecializationTextBox.Location = new System.Drawing.Point(20, 31);
            this.SpecializationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpecializationTextBox.Name = "SpecializationTextBox";
            this.SpecializationTextBox.Size = new System.Drawing.Size(262, 22);
            this.SpecializationTextBox.TabIndex = 1;
            // 
            // AnotherMedicianCheckBox
            // 
            this.AnotherMedicianCheckBox.AutoSize = true;
            this.AnotherMedicianCheckBox.Checked = true;
            this.AnotherMedicianCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnotherMedicianCheckBox.Location = new System.Drawing.Point(20, 61);
            this.AnotherMedicianCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnotherMedicianCheckBox.Name = "AnotherMedicianCheckBox";
            this.AnotherMedicianCheckBox.Size = new System.Drawing.Size(141, 20);
            this.AnotherMedicianCheckBox.TabIndex = 2;
            this.AnotherMedicianCheckBox.Text = "Другая больница";
            this.AnotherMedicianCheckBox.UseVisualStyleBackColor = true;
            this.AnotherMedicianCheckBox.CheckedChanged += new System.EventHandler(this.AnotherMedicianCheckBox_CheckedChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(20, 118);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(262, 22);
            this.NameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование мед. организации";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(20, 166);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(262, 22);
            this.AddressTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес";
            // 
            // RedirectButton
            // 
            this.RedirectButton.Location = new System.Drawing.Point(20, 196);
            this.RedirectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RedirectButton.Name = "RedirectButton";
            this.RedirectButton.Size = new System.Drawing.Size(262, 52);
            this.RedirectButton.TabIndex = 7;
            this.RedirectButton.Text = "Направить";
            this.RedirectButton.UseVisualStyleBackColor = true;
            this.RedirectButton.Click += new System.EventHandler(this.RedirectButton_Click);
            // 
            // RedirectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.RedirectButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnotherMedicianCheckBox);
            this.Controls.Add(this.SpecializationTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RedirectForm";
            this.Text = "Направление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpecializationTextBox;
        private System.Windows.Forms.CheckBox AnotherMedicianCheckBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RedirectButton;
    }
}