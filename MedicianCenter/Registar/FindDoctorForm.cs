using MedicianCenter.Database.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace MedicianCenter.Registar
{
    public partial class FindDoctorForm : Form
    {
        private AddHistoryForm ahf;
        public FindDoctorForm(AddHistoryForm ahf)
        {
            InitializeComponent();
            this.ahf = ahf;
        }

        private void DoctorsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            doctor selectedDoc = DoctorsDataGridView.Rows[e.RowIndex].DataBoundItem as doctor;

            ahf.ChangeSelectedDoctor(selectedDoc);
            Close();

            
        }

        private async void FindDoctorForm_Load(object sender, EventArgs e)
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                DoctorsDataGridView.DataSource = await db.doctor
                    .Include(x => x.istoria_priemov)
                    .ToListAsync();

                DoctorsDataGridView.Columns["ID_doctor"].Visible = false;
                DoctorsDataGridView.Columns["surname"].HeaderText = "Фамилия";
                DoctorsDataGridView.Columns["name"].HeaderText = "Имя";
                DoctorsDataGridView.Columns["middle_name"].HeaderText = "Отчетство";
                DoctorsDataGridView.Columns["cabinet"].HeaderText = "Кабинет";
                DoctorsDataGridView.Columns["date_of_birth"].HeaderText = "Дата рождения";
                DoctorsDataGridView.Columns["work_number"].HeaderText = "Рабочий телефон";
                DoctorsDataGridView.Columns["specialization"].HeaderText = "Специализация";
                DoctorsDataGridView.Columns["istoria_priemov"].Visible = false;

                DoctorsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
