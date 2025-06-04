using application.forms;
using application.forms.partners;

namespace application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllPartners allPartners = new AllPartners();

            allPartners.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPartner addPartner = new AddPartner();

            addPartner.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HistoryPartner historyPartner = new HistoryPartner();

            historyPartner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPartner editPartner = new EditPartner();

            editPartner.Show();
        }
    }
}
