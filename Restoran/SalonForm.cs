using System;
using System.Windows.Forms;

namespace Restoran
{
    public partial class SalonForm : Form
    {
        public SalonForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalonAdi.Text.Trim()) && string.IsNullOrEmpty(txtMasaOnEk.Text.Trim())) return;
            Salon salon = new Salon(txtSalonAdi.Text.Trim(), (int)nudMasaSayisi.Value, txtMasaOnEk.Text.Trim());
            Salon.Salonlar.Add(salon);

            lstvSalonlar.Items.Add(salon.ListOlustur());

            txtSalonAdi.Clear();
            txtMasaOnEk.Clear();
            nudMasaSayisi.Value = 0;
            txtSalonAdi.Focus();
        }
    }
}
