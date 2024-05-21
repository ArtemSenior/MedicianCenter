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
        }

        private async void UpdateHistoryDataGrid()
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                var history = await db.visit_history.ToListAsync();

                HistoryDataGridView.DataSource = history;

                HistoryDataGridView.Columns["ID_doctor"].Visible = false;
                HistoryDataGridView.Columns["Expr1"].HeaderText = "Фамилия";
                HistoryDataGridView.Columns["Expr2"].HeaderText = "Имя";
                HistoryDataGridView.Columns["Expr3"].HeaderText = "Отчество";
                HistoryDataGridView.Columns["surname"].Visible = false;
                HistoryDataGridView.Columns["middle_name"].Visible = false;
                HistoryDataGridView.Columns["name"].Visible = false;
                HistoryDataGridView.Columns["cabinet"].Visible = false;
                HistoryDataGridView.Columns["work_number"].Visible = false;
                HistoryDataGridView.Columns["specialization"].Visible = false;
                HistoryDataGridView.Columns["ID_istoria_priemov"].Visible = false;
                HistoryDataGridView.Columns["disease"].HeaderText = "Болезнь";
                HistoryDataGridView.Columns["date_of_priem"].HeaderText = "Дата приема";
                HistoryDataGridView.Columns["time"].HeaderText = "Время";
                HistoryDataGridView.Columns["status"].HeaderText = "Статус";
                HistoryDataGridView.Columns["ID_med_card"].Visible = false;
                HistoryDataGridView.Columns["date_of_birth"].Visible = false;
                HistoryDataGridView.Columns["phone_number"].Visible = false;
                HistoryDataGridView.Columns["number_passport"].Visible = false;
                HistoryDataGridView.Columns["snils"].Visible = false;
                HistoryDataGridView.Columns["seria_passport"].Visible = false;
                HistoryDataGridView.Columns["place_of_residence"].Visible = false;
                HistoryDataGridView.Columns["settlenment"].Visible = false;
                HistoryDataGridView.Columns["street"].Visible = false;
                HistoryDataGridView.Columns["number_house"].Visible = false;
                HistoryDataGridView.Columns["number_room"].Visible = false;
                HistoryDataGridView.Columns["profession"].Visible = false;


                HistoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
