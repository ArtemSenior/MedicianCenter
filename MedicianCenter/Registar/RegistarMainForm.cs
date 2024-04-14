using MedicianCenter.Admin;
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

namespace MedicianCenter.Registar
{
    public partial class RegistarMainForm : Form
    {
        public RegistarMainForm()
        {
            InitializeComponent();
            UpdateHistoryDataGrid();
            UpdateMedCardsDataGrid();
        }

        private async void UpdateHistoryDataGrid()
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                var history = await db.istoria_priemov
                    .Include(x => x.doctor)
                    .Include(x => x.healing)
                    .Include(x => x.med_card)
                    .ToListAsync();

                HistoryDataGridView.DataSource = history;

                HistoryDataGridView.Columns["ID_istoria_priemov"].Visible = false;
                HistoryDataGridView.Columns["disease"].HeaderText = "Болезнь";
                HistoryDataGridView.Columns["date_of_priem"].HeaderText = "Дата приема";
                HistoryDataGridView.Columns["time"].HeaderText = "Время";
                HistoryDataGridView.Columns["status"].HeaderText = "Статус";
                HistoryDataGridView.Columns["ID_med_card"].Visible = false;
                HistoryDataGridView.Columns["ID_healing"].Visible = false;
                HistoryDataGridView.Columns["ID_doctor"].Visible = false;
                HistoryDataGridView.Columns["doctor"].Visible = false;
                HistoryDataGridView.Columns["healing"].Visible = false;
                HistoryDataGridView.Columns["med_card"].Visible = false;

                HistoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private async void UpdateMedCardsDataGrid()
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                var medCards = await db.med_card
                    .Include(x => x.med_card_contra)
                    .Include(x => x.istoria_priemov)
                    .ToListAsync();

                MedCardsDataGridView.DataSource = medCards;

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

                MedCardsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        // Контекстное меню для таблицы истории приемов
        private void HistoryDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = HistoryDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Изменить", (s, se) =>
                    {
                        // Изменить запись
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var ip = db.istoria_priemov
                                .Find(HistoryDataGridView.Rows[currentMouseOverRow].Cells["ID_istoria_priemov"].Value);
                            AddHistoryForm ahf = new AddHistoryForm(ip);
                            ahf.FormClosed += Ahf_FormClosed;
                            ahf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Удалить", (s, se) =>
                    {
                        // Удалить запись
                        using (Database.Model.Context db = new Context())
                        {
                            var dIp = db.istoria_priemov
                                .Remove(db.istoria_priemov.Find(HistoryDataGridView.Rows[currentMouseOverRow].Cells["ID_istoria_priemov"].Value));
                            db.SaveChanges();
                        }

                        MessageBox.Show("Запись успешно удалена!");
                        UpdateHistoryDataGrid();
                    }));
                }

                m.Show(HistoryDataGridView, new Point(e.X, e.Y));
            }
        }

        private void RegistarMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        private void AddHistoryButton_Click(object sender, EventArgs e)
        {
            AddHistoryForm ahf = new AddHistoryForm();
            ahf.FormClosed += Ahf_FormClosed;
            ahf.ShowDialog();
        }

        private void Ahf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateHistoryDataGrid();
        }
    }
}
