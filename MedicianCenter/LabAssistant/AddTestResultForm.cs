using MedicianCenter.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicianCenter.LabAssistant
{
    public partial class AddTestResultForm : Form
    {
        private list_tests test;
        public AddTestResultForm(list_tests test)
        {
            InitializeComponent();
            this.test = test;
        }

        private void AddTestResultForm_Load(object sender, EventArgs e)
        {
            UpdateTestResultsDataGridView();
            UpdateTemplatesComboBox();
        }

        private void UpdateTestResultsDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                TestResultsDataGridView.DataSource = db.TestResults
                    .Include(x => x.list_tests)
                    .Include(x => x.Template)
                    .Where(x => x.TestId == test.ID_list_tests)
                    .Select(x => new
                    {
                        x.Id,
                        x.Key,
                        x.Template.Minimum,
                        x.Template.Maximum,
                        x.Value,
                        x.TestId
                    })
                    .ToList();

            TestResultsDataGridView.Columns["Id"].Visible = false;
            TestResultsDataGridView.Columns["Key"].HeaderText = "Название";
            TestResultsDataGridView.Columns["Value"].HeaderText = "Значение";
            TestResultsDataGridView.Columns["Maximum"].HeaderText = "Максимум";
            TestResultsDataGridView.Columns["Minimum"].HeaderText = "Минимум";
            TestResultsDataGridView.Columns["TestId"].Visible = false;

            TestResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AddResultButton_Click(object sender, EventArgs e)
        {
            TestResult testResult = new TestResult();
            testResult.Key = KeyTextBox.Text;
            testResult.Value = ValueTextBox.Text;
            testResult.TestId = test.ID_list_tests;
            testResult.TemplateId = (TemplateComboBox.SelectedItem as Template).Id;

            using (Database.Model.Context db = new Context())
            {
                db.TestResults.Add(testResult);
                db.SaveChanges();
            }

            UpdateTestResultsDataGridView();
        }

        private void TestResultsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = TestResultsDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Удалить результат", (s, se) =>
                    {
                        // Удалить результат
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            db.TestResults.Remove(db.TestResults.Find(TestResultsDataGridView.Rows[currentMouseOverRow].Cells["id"].Value));
                            db.SaveChangesAsync();
                            UpdateTestResultsDataGridView();
                        }
                    }));
                }

                m.Show(TestResultsDataGridView, new Point(e.X, e.Y));
            }
        }

        private void AddTemplateButton_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                Template template = new Template();
                template.Name = TemplateNameTextBox.Text;
                template.Minimum = TemplateMinimumTextBox.Text;
                template.Maximum = TemplateMaximumTextBox.Text;

                db.Templates.Add(template);
                db.SaveChanges();
            }

            UpdateTemplatesComboBox();
        }

        private void UpdateTemplatesComboBox()
        {
            using (Context db = new Context())
                TemplateComboBox.DataSource = db.Templates
                    .ToList();
            TemplateComboBox.DisplayMember = "Name";
        }
    }
}
