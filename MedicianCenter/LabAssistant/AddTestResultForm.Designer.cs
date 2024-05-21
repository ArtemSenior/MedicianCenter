namespace MedicianCenter.LabAssistant
{
    partial class AddTestResultForm
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
            this.TestResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddResultButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TemplateComboBox = new System.Windows.Forms.ComboBox();
            this.AddTemplateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TemplateMaximumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TemplateMinimumTextBox = new System.Windows.Forms.TextBox();
            this.TemplateNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TestResultsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestResultsDataGridView
            // 
            this.TestResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestResultsDataGridView.Location = new System.Drawing.Point(357, 15);
            this.TestResultsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TestResultsDataGridView.Name = "TestResultsDataGridView";
            this.TestResultsDataGridView.RowHeadersWidth = 51;
            this.TestResultsDataGridView.Size = new System.Drawing.Size(555, 487);
            this.TestResultsDataGridView.TabIndex = 0;
            this.TestResultsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TestResultsDataGridView_MouseClick);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(41, 48);
            this.KeyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(274, 22);
            this.KeyTextBox.TabIndex = 1;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(41, 94);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(274, 22);
            this.ValueTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование результата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Значение результата";
            // 
            // AddResultButton
            // 
            this.AddResultButton.Location = new System.Drawing.Point(33, 172);
            this.AddResultButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddResultButton.Name = "AddResultButton";
            this.AddResultButton.Size = new System.Drawing.Size(296, 39);
            this.AddResultButton.TabIndex = 5;
            this.AddResultButton.Text = "Добавить результат";
            this.AddResultButton.UseVisualStyleBackColor = true;
            this.AddResultButton.Click += new System.EventHandler(this.AddResultButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Шаблон";
            // 
            // TemplateComboBox
            // 
            this.TemplateComboBox.FormattingEnabled = true;
            this.TemplateComboBox.Location = new System.Drawing.Point(41, 140);
            this.TemplateComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemplateComboBox.Name = "TemplateComboBox";
            this.TemplateComboBox.Size = new System.Drawing.Size(274, 24);
            this.TemplateComboBox.TabIndex = 7;
            // 
            // AddTemplateButton
            // 
            this.AddTemplateButton.Location = new System.Drawing.Point(20, 176);
            this.AddTemplateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddTemplateButton.Name = "AddTemplateButton";
            this.AddTemplateButton.Size = new System.Drawing.Size(296, 42);
            this.AddTemplateButton.TabIndex = 8;
            this.AddTemplateButton.Text = "Добавить шаблон";
            this.AddTemplateButton.UseVisualStyleBackColor = true;
            this.AddTemplateButton.Click += new System.EventHandler(this.AddTemplateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TemplateMaximumTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddTemplateButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TemplateMinimumTextBox);
            this.groupBox1.Controls.Add(this.TemplateNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(336, 228);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить шаблон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Максимум";
            // 
            // TemplateMaximumTextBox
            // 
            this.TemplateMaximumTextBox.Location = new System.Drawing.Point(28, 146);
            this.TemplateMaximumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemplateMaximumTextBox.Name = "TemplateMaximumTextBox";
            this.TemplateMaximumTextBox.Size = new System.Drawing.Size(274, 22);
            this.TemplateMaximumTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Минимум";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Наименование шаблона";
            // 
            // TemplateMinimumTextBox
            // 
            this.TemplateMinimumTextBox.Location = new System.Drawing.Point(28, 100);
            this.TemplateMinimumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemplateMinimumTextBox.Name = "TemplateMinimumTextBox";
            this.TemplateMinimumTextBox.Size = new System.Drawing.Size(274, 22);
            this.TemplateMinimumTextBox.TabIndex = 11;
            // 
            // TemplateNameTextBox
            // 
            this.TemplateNameTextBox.Location = new System.Drawing.Point(28, 54);
            this.TemplateNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemplateNameTextBox.Name = "TemplateNameTextBox";
            this.TemplateNameTextBox.Size = new System.Drawing.Size(274, 22);
            this.TemplateNameTextBox.TabIndex = 10;
            // 
            // AddTestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TemplateComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddResultButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.TestResultsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTestResultForm";
            this.Text = "Добавить результаты";
            this.Load += new System.EventHandler(this.AddTestResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestResultsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TestResultsDataGridView;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddResultButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TemplateComboBox;
        private System.Windows.Forms.Button AddTemplateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TemplateMaximumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TemplateMinimumTextBox;
        private System.Windows.Forms.TextBox TemplateNameTextBox;
    }
}