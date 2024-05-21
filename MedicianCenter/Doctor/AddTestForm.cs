using MedicianCenter.Database.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MedicianCenter.Doctor
{
    public partial class AddTestForm : Form
    {
        private med_card mc;
        public AddTestForm(med_card mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void AddTestForm_Load(object sender, EventArgs e)
        {
            UpdateTemplates();
        }

        private void UpdateTemplates()
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                var templates = db.Templates.ToList();

                TestTypeComboBox.DataSource = templates;
                TestTypeComboBox.DisplayMember = "Name";
                TestTypeComboBox.SelectedIndex = 0;

                MinMaxLabel.Text = $"Минимум: {(TestTypeComboBox.SelectedItem as Template).Minimum}, максимум: {(TestTypeComboBox.SelectedItem as Template).Maximum}";
            }
        }


        private void AddTestButton_Click(object sender, EventArgs e)
        {
            list_tests lt = new list_tests
            {
                name = TestTypeComboBox.Text,
                opisanie = TestDescriptionTextBox.Text,
                ID_med_card = mc.ID_med_card
            };

            using (Database.Model.Context db = new Context())
            {
                // Добавляем новый анализ
                var test = db.list_tests.Add(lt);
                db.SaveChanges();
            }

            MessageBox.Show("Анализ успешно добавлен!");
            this.Close();
        }

        private void TestTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinMaxLabel.Text = $"Минимум: {(TestTypeComboBox.SelectedItem as Template).Minimum}, максимум: {(TestTypeComboBox.SelectedItem as Template).Maximum}";
        }
    }
}
