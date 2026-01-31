namespace RestoranUygulaması
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }




        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMasaYonetimi_Click(object sender, EventArgs e)
        {
            MasaYonetimiForm masaYonetimiForm = new MasaYonetimiForm(); masaYonetimiForm.Show();
        }

        private void btnSiparisYonetimi_Click(object sender, EventArgs e)
        {
            SiparisYonetimiForm siparisYonetimiForm = new SiparisYonetimiForm(); siparisYonetimiForm.Show();
        }

        private void btnGarsonYonetimi_Click(object sender, EventArgs e)
        {
            GarsonYonetimiForm garsonYonetimiForm = new GarsonYonetimiForm(); garsonYonetimiForm.Show();
        }

        private void btnMenuYonetimi_Click(object sender, EventArgs e)
        {
            MenuYonetimiForm menuYonetimiForm = new MenuYonetimiForm(); menuYonetimiForm.Show();
        }

       
    }
}
