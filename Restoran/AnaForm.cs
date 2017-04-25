using System;
using System.Windows.Forms;

namespace Restoran
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void urunTool_Click(object sender, EventArgs e)
        {
            UrunForm urunForm = new UrunForm {MdiParent = this};
            urunForm.Show();
        }

        private void salonTool_Click(object sender, EventArgs e)
        {
            SalonForm salonForm = new SalonForm {MdiParent = this};
            salonForm.Show();
        }

        private void siparisTool_Click(object sender, EventArgs e)
        {
            SiparisForm siparisForm = new SiparisForm();
            siparisForm.MdiParent = this;
            siparisForm.Show();
        }
    }
}
