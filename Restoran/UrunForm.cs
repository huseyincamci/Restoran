using System;
using System.Windows.Forms;

namespace Restoran
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text.Trim())) return;
            Urun urun = new Urun()
            {
                Adi = txtAd.Text.Trim(),
                Fiyat = nudFiyat.Value
            };
            Urun.UrunList.Add(urun);
            lstvUrunler.Items.Add(urun.ListOlustur());

            txtAd.Clear();
            nudFiyat.Value = 0;
            txtAd.Focus();
        }
    }
}
