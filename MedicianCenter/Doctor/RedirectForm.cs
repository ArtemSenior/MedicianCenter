using MedicianCenter.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace MedicianCenter.Doctor
{
    public partial class RedirectForm : Form
    {
        private string path;
        private med_card mc;
        public RedirectForm(string path, med_card mc)
        {
            InitializeComponent();
            this.path = path;
            this.mc = mc;
        }

        private void RedirectButton_Click(object sender, EventArgs e)
        {
            doctor doctor = StateSingleton.getInstance().authDoc;
            var doc = DocX.Create(path);

            doc.DifferentFirstPage = true;

            doc.InsertParagraph($"НАПРАВЛЕНИЕ").Bold().FontSize(32);
            doc.InsertParagraph($"Направление выдано {mc.surname} {mc.name} {mc.middle_name}").FontSize(16);
            doc.InsertParagraph($"{mc.surname} {mc.name[0]}. {mc.middle_name[0]}. направляется к специалисту: {SpecializationTextBox.Text}\n\n").FontSize(16);

            if (AnotherMedicianCheckBox.Checked)
                doc.InsertParagraph($"Наименовение медицинской организации: {NameTextBox.Text}, адрес: {AddressTextBox.Text}.\n").FontSize(16);

            doc.InsertParagraph($"\n\nЛечащий врач: _________________ {doctor.surname} {doctor.name[0]}. {doctor.middle_name[0]}.").FontSize(16);
            doc.InsertParagraph($"\t\t\t(Подпись, дата, Фамилия И.О.)").FontSize(9);
            doc.InsertParagraph($"\t\t\t\tМ.П.").FontSize(9);

            doc.Save();

            Close();
        }

        private void AnotherMedicianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AnotherMedicianCheckBox.Checked)
            {
                NameTextBox.Enabled = true;
                AddressTextBox.Enabled = true;
            }
            else
            {
                NameTextBox.Enabled = false;
                AddressTextBox.Enabled = false;
            }
        }
    }
}
