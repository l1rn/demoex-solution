using application.forms;

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
    }
}
