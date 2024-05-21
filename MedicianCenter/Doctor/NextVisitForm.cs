using MedicianCenter.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace MedicianCenter.Doctor
{
    public partial class NextVisitForm : Form
    {
        private string path;
        private med_card mc;
        public NextVisitForm(string path, med_card mc)
        {
            InitializeComponent();
            this.path = path;
            this.mc = mc;
        }

        private void NotVisitCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NotVisitCheckbox.Checked)
                NextVisitDayTimePicker.Enabled = false;
            else
                NextVisitDayTimePicker.Enabled = true;
        }

        private void CreateExtractButton_Click(object sender, EventArgs e)
        {
            doctor doctor = StateSingleton.getInstance().authDoc;
            var doc = DocX.Create(path);

            doc.DifferentFirstPage = true;

            doc.InsertParagraph($"СПРАВКА").Bold().FontSize(32);
            doc.InsertParagraph($"{mc.surname} {mc.name} {mc.middle_name}").FontSize(16);
            doc.InsertParagraph($"Перенес следующие заболевания:\n").FontSize(16);

            using (Database.Model.Context db = new Context())
            {
                var visits = db.istoria_priemov
                    .Where(x => x.ID_med_card == mc.ID_med_card)
                    .ToList();

                var pills = db.healing_list_pills
                    .Where(x => x.ID_med_card == mc.ID_med_card)
                    .Include(x => x.list_pills)
                    .ToList();

                var analysis = db.TestResults
                    .Include(x => x.Template)
                    .Include(x => x.list_tests)
                    .Where(x => x.list_tests.ID_med_card == mc.ID_med_card)
                    .ToList();

                var history = db.istoria_priemov
                    .Include(x => x.doctor)
                    .Where(x => x.ID_med_card == mc.ID_med_card)
                    .ToList();

                // Диагнозы
                var t = doc.AddTable(visits.Count + 1, 2);
                t.Alignment = Alignment.center;

                t.Rows[0].Cells[0].Paragraphs.First().Append("Диагноз");
                t.Rows[0].Cells[1].Paragraphs.First().Append("Статус");

                for (int i = 0; i < visits.Count; i++)
                {
                    t.Rows[i + 1].Cells[0].Paragraphs.First().Append(visits[i].disease);
                    t.Rows[i + 1].Cells[1].Paragraphs.First().Append(visits[i].status);
                }

                doc.InsertTable(t);

                // Лекарства
                doc.InsertParagraph($"\n\nНазначенные лекарства:\n").FontSize(16);
                var p = doc.AddTable(pills.Count + 1, 2);
                p.Alignment = Alignment.center;

                p.Rows[0].Cells[0].Paragraphs.First().Append("Наименование лекарства");
                p.Rows[0].Cells[1].Paragraphs.First().Append("Описание");

                for (int i = 0; i < pills.Count; i++)
                {
                    p.Rows[i + 1].Cells[0].Paragraphs.First().Append(pills[i].list_pills.name);
                    p.Rows[i + 1].Cells[1].Paragraphs.First().Append(pills[i].list_pills.opisanie);
                }

                doc.InsertTable(p);

                // Анализы
                if (analysis.Count > 0)
                {
                    doc.InsertParagraph($"\n\nРезультаты анализов:\n").FontSize(16);
                    var a = doc.AddTable(analysis.Count + 1, 4);
                    a.Alignment = Alignment.center;

                    a.Rows[0].Cells[0].Paragraphs.First().Append("Наименование анализа");
                    a.Rows[0].Cells[1].Paragraphs.First().Append("Минимум");
                    a.Rows[0].Cells[2].Paragraphs.First().Append("Максимум");
                    a.Rows[0].Cells[3].Paragraphs.First().Append("Текущее значение");

                    for (int i = 0; i < analysis.Count; i++)
                    {
                        a.Rows[i + 1].Cells[0].Paragraphs.First().Append(analysis[i].list_tests.name);
                        a.Rows[i + 1].Cells[1].Paragraphs.First().Append(analysis[i].Template.Minimum);
                        a.Rows[i + 1].Cells[2].Paragraphs.First().Append(analysis[i].Template.Maximum);
                        a.Rows[i + 1].Cells[3].Paragraphs.First().Append(analysis[i].Value);
                    }

                    doc.InsertTable(a);
                }

                // История посещений
                if (history.Count > 0 && HistoryCheckBox.Checked)
                {
                    doc.InsertParagraph($"\n\nИстория посещений:\n").FontSize(16);
                    var d = doc.AddTable(history.Count + 1, 2);
                    d.Alignment = Alignment.center;

                    d.Rows[0].Cells[0].Paragraphs.First().Append("Доктор");
                    d.Rows[0].Cells[1].Paragraphs.First().Append("Дата");

                    for (int i = 0; i < history.Count; i++)
                    {
                        d.Rows[i + 1].Cells[0].Paragraphs.First().Append($"{history[i].doctor.surname} {history[i].doctor.name} {history[i].doctor.middle_name}");
                        d.Rows[i + 1].Cells[1].Paragraphs.First().Append(history[i].date_of_priem.ToString());
                    }

                    doc.InsertTable(d);
                }

                if (!NotVisitCheckbox.Checked)
                    doc.InsertParagraph($"\n\nРекомендуемая дата и время следующего посещения врача: {NextVisitDayTimePicker.Value.ToString()}\n").FontSize(16);

                doc.InsertParagraph($"\n\nЛечащий врач: _________________ {doctor.surname} {doctor.name[0]}. {doctor.middle_name[0]}.").FontSize(16);
                doc.InsertParagraph($"\t\t\t(Подпись, дата, Фамилия И.О.)").FontSize(9);
                doc.InsertParagraph($"\t\t\t\tМ.П.").FontSize(9);
            }

            doc.Save();

            Close();
        }
    }
}
