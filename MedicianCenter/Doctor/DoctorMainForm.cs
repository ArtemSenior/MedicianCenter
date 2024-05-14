using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using MedicianCenter.Admin;
using MedicianCenter.Database.Model;
using Xceed.Document.NET;
using Xceed.Words.NET;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace MedicianCenter.Doctor
{
    public partial class DoctorMainForm : Form
    {
        public DoctorMainForm()
        {
            InitializeComponent();
        }

        private void DoctorMainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Доктор {StateSingleton.getInstance().authDoc.surname} {StateSingleton.getInstance().authDoc.name} {StateSingleton.getInstance().authDoc.middle_name}";
            UpdateMedCardsDataGridView();
            UpdateVisitHistoryDataGridView();
            UpdateFutureVisitsDataGrid();
        }

        private void UpdateFutureVisitsDataGrid()
        {
            using (Database.Model.Context db = new Context())
            {
                int curDocID = StateSingleton.getInstance().authDoc.ID_doctor;
                FutureVisitsDataGridView.DataSource = db.visit_history
                    .Where(x => x.ID_doctor == curDocID
                    && x.date_of_priem > DateTime.Now)
                    .ToList();

                FutureVisitsDataGridView.Columns["ID_doctor"].Visible = false;
                FutureVisitsDataGridView.Columns["Expr1"].HeaderText = "Фамилия";
                FutureVisitsDataGridView.Columns["Expr2"].HeaderText = "Имя";
                FutureVisitsDataGridView.Columns["Expr3"].HeaderText = "Отчество";
                FutureVisitsDataGridView.Columns["surname"].Visible = false;
                FutureVisitsDataGridView.Columns["middle_name"].Visible = false;
                FutureVisitsDataGridView.Columns["name"].Visible = false;
                FutureVisitsDataGridView.Columns["cabinet"].Visible = false;
                FutureVisitsDataGridView.Columns["work_number"].Visible = false;
                FutureVisitsDataGridView.Columns["specialization"].Visible = false;
                FutureVisitsDataGridView.Columns["ID_istoria_priemov"].Visible = false;
                FutureVisitsDataGridView.Columns["disease"].HeaderText = "Болезнь";
                FutureVisitsDataGridView.Columns["date_of_priem"].HeaderText = "Дата приема";
                FutureVisitsDataGridView.Columns["time"].HeaderText = "Время";
                FutureVisitsDataGridView.Columns["status"].Visible = false;
                FutureVisitsDataGridView.Columns["ID_med_card"].Visible = false;
                FutureVisitsDataGridView.Columns["date_of_birth"].Visible = false;
                FutureVisitsDataGridView.Columns["phone_number"].Visible = false;
                FutureVisitsDataGridView.Columns["number_passport"].Visible = false;
                FutureVisitsDataGridView.Columns["snils"].Visible = false;
                FutureVisitsDataGridView.Columns["seria_passport"].Visible = false;
                FutureVisitsDataGridView.Columns["place_of_residence"].Visible = false;
                FutureVisitsDataGridView.Columns["settlenment"].Visible = false;
                FutureVisitsDataGridView.Columns["street"].Visible = false;
                FutureVisitsDataGridView.Columns["number_house"].Visible = false;
                FutureVisitsDataGridView.Columns["number_room"].Visible = false;
                FutureVisitsDataGridView.Columns["profession"].Visible = false;


                FutureVisitsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private async void UpdateMedCardsDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                MedCardsDataGridView.DataSource = await db.med_card
                    .Include(x => x.med_card_contra)
                    .Include(x => x.istoria_priemov)
                    .Include(x => x.healing_list_pills)
                    .Include(x => x.list_tests)
                    .ToListAsync();

            MedCardsDataGridView.Columns["ID_med_card"].Visible = false;
            MedCardsDataGridView.Columns["surname"].HeaderText = "Фамилия";
            MedCardsDataGridView.Columns["name"].HeaderText = "Имя";
            MedCardsDataGridView.Columns["middle_name"].HeaderText = "Отчетство";
            MedCardsDataGridView.Columns["date_of_birth"].HeaderText = "Дата рождения";
            MedCardsDataGridView.Columns["phone_number"].HeaderText = "Номер телефона";
            MedCardsDataGridView.Columns["number_passport"].HeaderText = "Номер паспорта";
            MedCardsDataGridView.Columns["seria_passport"].HeaderText = "Серия паспорта";
            MedCardsDataGridView.Columns["snils"].HeaderText = "СНИЛС";
            MedCardsDataGridView.Columns["place_of_residence"].HeaderText = "Регион";
            MedCardsDataGridView.Columns["settlenment"].HeaderText = "Город";
            MedCardsDataGridView.Columns["street"].HeaderText = "Улица";
            MedCardsDataGridView.Columns["number_house"].HeaderText = "Номер дома";
            MedCardsDataGridView.Columns["number_room"].HeaderText = "Квартира";
            MedCardsDataGridView.Columns["profession"].HeaderText = "Профессия";
            MedCardsDataGridView.Columns["healing_list_pills"].Visible = false;
            MedCardsDataGridView.Columns["istoria_priemov"].Visible = false;
            MedCardsDataGridView.Columns["med_card_contra"].Visible = false;
            MedCardsDataGridView.Columns["list_tests"].Visible = false;

            MedCardsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DoctorMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        // Для контекстного меню таблицы MedCardsDataGridView
        private void MedCardsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = MedCardsDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Изменить", (s, se) =>
                    {
                        // Изменить карту
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);
                            Admin.AddMedCardForm amcf = new AddMedCardForm(mc);
                            amcf.FormClosed += Amcf_FormClosed;
                            amcf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Назначить лекарства", (s, se) =>
                    {
                        // Назначить анализы
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);
                            Doctor.SelectPillsForm spf = new SelectPillsForm(mc);
                            spf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Назначить анализы", (s, se) =>
                    {
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);

                            Doctor.AddTestForm atf = new AddTestForm(mc);
                            atf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Отчет по анализам", (s, se) =>
                    {
                        // Отчет по анализам
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);

                            Doctor.ViewTestsResultsForm vtrf = new ViewTestsResultsForm(mc);
                            vtrf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Составить справку о нетрудоспособности", (s, se) =>
                    {
                        string savePath = null;
                        using (var sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "Word документ (*.docx)|*.docx";
                            DialogResult result = sfd.ShowDialog();

                            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.FileName))
                                savePath = sfd.FileName;
                        }
                        // Составить выписку
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);
                            CreateCertificate(savePath, mc, DateTime.Now, DateTime.Now.AddDays(7));
                        }
                    }));
                    //m.MenuItems.Add(new MenuItem("Направить к специалисту", (s, se) =>
                    //{
                    //    // Направить к специалисту
                    //    using (Database.Model.Context db = new Database.Model.Context())
                    //    {

                    //    }
                    //}));
                    m.MenuItems.Add(new MenuItem("Удалить", (s, se) =>
                    {
                        // Удалить карту
                        using (Database.Model.Context db = new Context())
                        {
                            db.med_card
                            .Remove(db.med_card.Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value));
                            db.SaveChanges();
                        }

                        MessageBox.Show("Карта успешно удалена!");
                        UpdateMedCardsDataGridView();
                    }));
                }

                m.Show(MedCardsDataGridView, new Point(e.X, e.Y));
            }
        }

        private void UpdateVisitHistoryDataGridView()
        {
            using (Context db = new Context())
            {
                int curDocID = StateSingleton.getInstance().authDoc.ID_doctor;
                VisitHistoryDataGridView.DataSource = db.visit_history
                    .Where(x => x.ID_doctor == curDocID)
                    .ToList();

                VisitHistoryDataGridView.Columns["ID_doctor"].Visible = false;
                VisitHistoryDataGridView.Columns["Expr1"].HeaderText = "Фамилия";
                VisitHistoryDataGridView.Columns["Expr2"].HeaderText = "Имя";
                VisitHistoryDataGridView.Columns["Expr3"].HeaderText = "Отчество";
                VisitHistoryDataGridView.Columns["surname"].Visible = false;
                VisitHistoryDataGridView.Columns["middle_name"].Visible = false;
                VisitHistoryDataGridView.Columns["name"].Visible = false;
                VisitHistoryDataGridView.Columns["cabinet"].Visible = false;
                VisitHistoryDataGridView.Columns["work_number"].Visible = false;
                VisitHistoryDataGridView.Columns["specialization"].Visible = false;
                VisitHistoryDataGridView.Columns["ID_istoria_priemov"].Visible = false;
                VisitHistoryDataGridView.Columns["disease"].HeaderText = "Болезнь";
                VisitHistoryDataGridView.Columns["date_of_priem"].HeaderText = "Дата приема";
                VisitHistoryDataGridView.Columns["time"].HeaderText = "Время";
                VisitHistoryDataGridView.Columns["status"].HeaderText = "Статус";
                VisitHistoryDataGridView.Columns["ID_med_card"].Visible = false;
                VisitHistoryDataGridView.Columns["date_of_birth"].Visible = false;
                VisitHistoryDataGridView.Columns["phone_number"].Visible = false;
                VisitHistoryDataGridView.Columns["number_passport"].Visible = false;
                VisitHistoryDataGridView.Columns["snils"].Visible = false;
                VisitHistoryDataGridView.Columns["seria_passport"].Visible = false;
                VisitHistoryDataGridView.Columns["place_of_residence"].Visible = false;
                VisitHistoryDataGridView.Columns["settlenment"].Visible = false;
                VisitHistoryDataGridView.Columns["street"].Visible = false;
                VisitHistoryDataGridView.Columns["number_house"].Visible = false;
                VisitHistoryDataGridView.Columns["number_room"].Visible = false;
                VisitHistoryDataGridView.Columns["profession"].Visible = false;


                VisitHistoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void CreateCertificate(string path, med_card mc, DateTime begin, DateTime end)
        {
            doctor doctor = StateSingleton.getInstance().authDoc;

            var doc = DocX.Create(path);

            doc.DifferentFirstPage = true;

            doc.InsertParagraph($"СПРАВКА О НЕТРУДОСПОСОБНОСТИ").Bold().FontSize(28);
            doc.InsertParagraph($"\n").Bold().FontSize(23);
            doc.InsertParagraph($"Справка о временной нетрудоспособности заявляет о том, что {mc.surname} {mc.name} {mc.middle_name} с {begin.Date.ToString("dd.MM.yyyy")} по {end.Date.ToString("dd.MM.yyyy")} не может выполнять свои трудовые обязанности.\n").FontSize(16);

            doc.InsertParagraph($"\n\nЛечащий врач: _________________ {doctor.surname} {doctor.name[0]}. {doctor.middle_name[0]}.").FontSize(16);
            doc.InsertParagraph($"\t\t\t\t(Дата, подпись)").FontSize(9);
            doc.InsertParagraph($"\t\t\t\tМ.П.").FontSize(9);

            doc.Save();
        }

        private void CreateExtract(string path, med_card mc)
        {
            var doc = DocX.Create(path);

            doc.DifferentFirstPage = true;

            doc.InsertParagraph($"СПРАВКА").Bold().FontSize(32);
            doc.InsertParagraph($"Справка выдана {mc.surname} {mc.name} {mc.middle_name}").FontSize(16);
            doc.InsertParagraph($"Перенес следующие заболевания:\n").FontSize(16);

            using (Database.Model.Context db = new Context())
            {
                var visits = db.istoria_priemov
                    .Where(x => x.ID_med_card == mc.ID_med_card)
                    .ToList();

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

                doc.InsertParagraph($"\n\nЛечащий врач: _________________").FontSize(16);
                doc.InsertParagraph($"\t\t\t(Подпись, дата, Фамилия И.О.)").FontSize(9);
                doc.InsertParagraph($"\t\t\t\tМ.П.").FontSize(9);
            }

            doc.Save();
        }
        private void Amcf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateMedCardsDataGridView();
        }

        private void AddMedCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.AddMedCardForm amcf = new AddMedCardForm();
            amcf.FormClosed += Amcf_FormClosed;
            amcf.ShowDialog();
        }
    }
}
