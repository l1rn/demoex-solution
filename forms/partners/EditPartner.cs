using application.models.partner;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application.forms.partners
{
    public partial class EditPartner : Form
    {
        private int id = -1;
        private int maxId = 0;
        private int minId = 1;

        public EditPartner()
        {
            InitializeComponent();
            LoadPartners();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPartner_Load(object sender, EventArgs e)
        {

        }

        private void LoadPartners()
        {
            using (var db = new models.ApplicationContext())
            {
                var partners = db.partners
                    .Include(p => p.partnerType)
                    .Include(p => p.placeForSale)
                    .Select(p => new
                    {
                        p.id,
                        p.directorName,
                        p.address,
                        p.phone,
                        p.INN,
                        p.email,
                        partnerType = p.partnerType.name,
                        placeForSale = p.placeForSale.name,
                        p.rating
                    })
                    .ToList();
                maxId = partners.Count();
                if (id == -1)
                {
                    id = partners.First().id;
                }
                var partner = db.partners.Find(id);

                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = db.partnerTypes.ToList();

                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";
                comboBox2.DataSource = db.placeForSales.ToList();

                textBox1.Text = partner.directorName;
                textBox2.Text = partner.address;
                textBox3.Text = partner.phone;
                textBox4.Text = partner.INN.ToString();
                textBox5.Text = partner.rating.ToString();
                textBox6.Text = partner.email;

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (id >= maxId)
            {
                MessageBox.Show("НЕВАЛЯШКА БОльтшкуцйекцуепку");
                return;
            }
            id++;
            LoadPartners();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (id <= minId)
            {
                MessageBox.Show("НЕВАЛЯШКА МЕНЬШЕ");
                return;
            }

            id--;
            LoadPartners();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string directorNameText = textBox1.Text;
            string addressText = textBox2.Text;
            string INNText = textBox4.Text;
            string phoneText = textBox3.Text;
            string emailText = textBox6.Text;
            string ratingText = textBox5.Text;
            string partnerTypeText = comboBox1.Text;
            string salePlaceText = comboBox2.Text;

            if (string.IsNullOrEmpty(directorNameText) ||
                string.IsNullOrEmpty(addressText) ||
                string.IsNullOrEmpty(INNText) ||
                string.IsNullOrEmpty(phoneText) ||
                string.IsNullOrEmpty(emailText) ||
                string.IsNullOrEmpty(ratingText.ToString()) ||
                string.IsNullOrEmpty(partnerTypeText) ||
                string.IsNullOrEmpty(salePlaceText))
            {
                MessageBox.Show("Одно из полей пустое!");
                return;
            }

            long innToLong = 0;
            try
            {
                innToLong = long.Parse(INNText);
            }
            catch (Exception)
            {
                MessageBox.Show("ИНН должен быть числом!");
                return;
            }
            double ratingToDouble = 0;

            try
            {
                ratingToDouble = double.Parse(ratingText);
            }
            catch (Exception)
            {
                MessageBox.Show("Рейтинг должен быть числом!");
                return;
            }

            using (var db = new models.ApplicationContext())
            {
                PartnerType stringToType = new PartnerType();
                try
                {
                    foreach (PartnerType type in db.partnerTypes.ToList())
                    {
                        if (type.name.ToString() == partnerTypeText)
                        {
                            stringToType = type;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверно указан тип партнера");
                    return;
                }

                PlaceForSale placeForSaleText = new PlaceForSale();

                try
                {
                    foreach (PlaceForSale sale in db.placeForSales.ToList())
                    {
                        if (sale.name.ToString() == salePlaceText)
                        {
                            placeForSaleText = sale;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверно указан");
                    return;
                }

                
                try
                {

                    Partner existPartner = db.partners.Find(id);
                    existPartner.id = id;
                    existPartner.directorName = directorNameText;
                    existPartner.address = addressText;
                    existPartner.phone = phoneText;
                    existPartner.email = emailText;
                    existPartner.logo = "NONE";
                    existPartner.rating = ratingToDouble;
                    existPartner.partnerType = stringToType;
                    existPartner.placeForSale = placeForSaleText;
                    db.SaveChanges();
                    MessageBox.Show("Персона успешно сохранена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось видо-изменить партнера!");
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
