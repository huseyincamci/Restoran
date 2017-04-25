using System;
using System.Windows.Forms;

namespace Restoran
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            foreach (var salon in Salon.Salonlar)
            {
                salon.Click += Salon_Click;
                flwSalonlar.Controls.Add(salon);
            }
        }

        private void Salon_Click(object sender, EventArgs e)
        {
            Salon salon = sender as Salon;
            MasaListeForm masaListeForm = new MasaListeForm();
            masaListeForm.MdiParent = this.MdiParent;
            masaListeForm.Salon = salon;
            masaListeForm.Show();
        }

        private void SiparisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var salon in Salon.Salonlar)
            {
                salon.Click -= Salon_Click;
            }
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
