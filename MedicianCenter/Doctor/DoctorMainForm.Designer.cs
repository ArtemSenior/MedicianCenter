namespace MedicianCenter.Doctor
{
    partial class DoctorMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медицинскаяКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MedCardsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.VisitHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FutureVisitsDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedCardsDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisitHistoryDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FutureVisitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медицинскаяКартаToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // медицинскаяКартаToolStripMenuItem
            // 
            this.медицинскаяКартаToolStripMenuItem.Name = "медицинскаяКартаToolStripMenuItem";
            this.медицинскаяКартаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.медицинскаяКартаToolStripMenuItem.Text = "Медицинская карта";
            this.медицинскаяКартаToolStripMenuItem.Click += new System.EventHandler(this.AddMedCardToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MedCardsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Медицинские карты пациентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MedCardsDataGridView
            // 
            this.MedCardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedCardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedCardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedCardsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.MedCardsDataGridView.Name = "MedCardsDataGridView";
            this.MedCardsDataGridView.ReadOnly = true;
            this.MedCardsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.MedCardsDataGridView.TabIndex = 0;
            this.MedCardsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MedCardsDataGridView_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.VisitHistoryDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "История приемов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // VisitHistoryDataGridView
            // 
            this.VisitHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisitHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisitHistoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.VisitHistoryDataGridView.Name = "VisitHistoryDataGridView";
            this.VisitHistoryDataGridView.ReadOnly = true;
            this.VisitHistoryDataGridView.Size = new System.Drawing.Size(792, 400);
            this.VisitHistoryDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FutureVisitsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Предварительные записи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FutureVisitsDataGridView
            // 
            this.FutureVisitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FutureVisitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FutureVisitsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FutureVisitsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FutureVisitsDataGridView.Name = "FutureVisitsDataGridView";
            this.FutureVisitsDataGridView.ReadOnly = true;
            this.FutureVisitsDataGridView.Size = new System.Drawing.Size(792, 400);
            this.FutureVisitsDataGridView.TabIndex = 0;
            // 
            // DoctorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorMainForm";
            this.Text = "Доктор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorMainForm_FormClosed);
            this.Load += new System.EventHandler(this.DoctorMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedCardsDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisitHistoryDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FutureVisitsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView MedCardsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медицинскаяКартаToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView VisitHistoryDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView FutureVisitsDataGridView;
    }
}