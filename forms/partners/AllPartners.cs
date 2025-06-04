using Microsoft.EntityFrameworkCore;
using System.Data;

namespace application.forms
{
    public partial class AllPartners : Form
    {
        public AllPartners()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            using (var db = new models.ApplicationContext())
            {
                var partners = db.partners
                    .Include(p => p.partnerType)
                    .Include(p => p.placeForSale)
                    .Select(p => new
                    {
                        p.directorName,
                        p.address,
                        p.phone,
                        p.INN,
                        partnerType = p.partnerType.name,
                        placeForSale = p.placeForSale.name,
                        p.rating
                    })
                    .ToList();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = partners;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "directorName",
                    HeaderText = "Директор"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "address",
                    HeaderText = "Адрес"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "phone",
                    HeaderText = "Телефон"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "INN",
                    HeaderText = "ИНН"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "partnerType",
                    HeaderText = "Тип партнера"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "placeForSale",
                    HeaderText = "Место продаж"
                });

                // Колонка с рейтингом
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "rating",
                    HeaderText = "Рейтинг"
                });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllPartners_Load(object sender, EventArgs e)
        {

        }
    }
}
