using System.Diagnostics.Eventing.Reader;

namespace hava_sıcaklıgı_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sicaklik;
            sicaklik=Convert.ToInt32(txtSıcaklık.Text);
            if (sicaklik <= 10)
            {
                MessageBox.Show("HAVA SOĞUK"); 
            }
            else if (sicaklik >= 25)
            {
                MessageBox.Show("HAVA SICAK");
            }
        }
    }
}