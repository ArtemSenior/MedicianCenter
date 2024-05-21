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
    public partial class FindPatientForm : Form
    {
        private AddHistoryForm ahf;
        public FindPatientForm(AddHistoryForm ahf)
        {
            InitializeComponent();
            this.ahf = ahf;
        }

        private async void FindPatientForm_Load(object sender, EventArgs e)
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
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
                MedCardsDataGridView.Columns["place_of_residence"].Visible = false;
                MedCardsDataGridView.Columns["settlenment"].Visible = false;
                MedCardsDataGridView.Columns["street"].Visible = false;
                MedCardsDataGridView.Columns["number_house"].Visible = false;
                MedCardsDataGridView.Columns["number_room"].Visible = false;
                MedCardsDataGridView.Columns["profession"].Visible = false;
                MedCardsDataGridView.Columns["healing_list_pills"].Visible = false;
                MedCardsDataGridView.Columns["istoria_priemov"].Visible = false;
                MedCardsDataGridView.Columns["med_card_contra"].Visible = false;

                MedCardsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void MedCardsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            med_card selectedCard = MedCardsDataGridView.Rows[e.RowIndex].DataBoundItem as med_card;

            ahf.ChangeSelectedPatient(selectedCard);
            Close();
        }
    }
}
