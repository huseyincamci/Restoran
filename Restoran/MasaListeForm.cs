using System;
using System.Windows.Forms;

namespace Restoran
{
    public partial class MasaListeForm : Form
    {
        public MasaListeForm()
        {
            InitializeComponent();
        }

        public Salon Salon { get; set; }

        private void MasaListeForm_Load(object sender, System.EventArgs e)
        {
            lblSalonAdi.Text = Salon.Adi;

            foreach (var masa in Salon.Masalar)
            {
                masa.Click += Masa_Click;
                flwMasalar.Controls.Add(masa);
            }
        }

        private void Masa_Click(object sender, EventArgs e)
        {
            MasaDetayForm masaDetayForm = new MasaDetayForm
            {
                Masa = sender as Masa,
                MdiParent = this.MdiParent
            };
            masaDetayForm.Show();
        }

        private void MasaListeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
