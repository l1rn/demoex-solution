
using application.models.partner;
using Microsoft.EntityFrameworkCore;

namespace application.forms.partners
{
    public partial class AddPartner : Form
    {
        public AddPartner()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadComboBoxes()
        {
            using (var db = new models.ApplicationContext())
            {

                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = db.partnerTypes.ToList();

                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";
                comboBox2.DataSource = db.placeForSales.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            catch(Exception)
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

                var newPartner = new Partner
                {
                    directorName = directorNameText,
                    address = addressText,
                    INN = innToLong,
                    phone = phoneText,
                    email = emailText,
                    logo = "none",
                    rating = ratingToDouble,
                    partnerType = stringToType,
                    placeForSale = placeForSaleText
                };

                try
                {
                    db.partners.Add(newPartner);
                    db.SaveChanges();
                    MessageBox.Show("Персона успешно добавлена!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось добавить партнера!");
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
