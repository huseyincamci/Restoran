using System.Windows.Forms;

namespace Restoran
{
    public partial class MasaDetayForm : Form
    {
        public Masa Masa { get; set; }  
        public MasaDetayForm()
        {
            InitializeComponent();
        }

        private void MasaDetayForm_Load(object sender, System.EventArgs e)
        {
            lblMasaNo.Text = Masa.Kodu;
            lblTutar.Text = Masa.Tutar.ToString("C2");

            foreach (var urun in Masa.Urunler)
            {
                lstvUrunler.Items.Add(urun.ListOlustur());
            }
            cmbUrun.DataSource = Urun.UrunList;
        }

        private void btnEkle_Click(object sender, System.EventArgs e)
        {
            Urun urun = cmbUrun.SelectedItem as Urun;
            Masa.Urunler.Add(urun);
            if(urun == null) return;
            lstvUrunler.Items.Add(urun.ListOlustur());
        }

        private void MasaDetayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
