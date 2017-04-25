using System.Collections.Generic;
using System.Windows.Forms;

namespace Restoran
{
    public class Salon : Button
    {
        public string Adi { get; set; }
        public string OnEk { get; set; }    
        public List<Masa> Masalar { get; set; } = new List<Masa>();
        public static List<Salon> Salonlar { get; set; } = new List<Salon>();

        public Salon()
        {
            
        }

        public Salon(string salonAdi, int masaSayisi, string masaOnEk)
        {
            Adi = salonAdi;
            OnEk = masaOnEk;
            for (int i = 1; i <= masaSayisi; i++)
            {
                Masa masa = new Masa { Kodu = $"{OnEk}{i}" };
                this.Masalar.Add(masa);
            }
            this.Text = Adi;
            this.Width = 100;
            this.Height = 100;
        }

        public ListViewItem ListOlustur()
        {
            ListViewItem item = new ListViewItem {Text = Adi};
            item.SubItems.Add(Masalar.Count.ToString());
            item.SubItems.Add(OnEk);
            return item;
        }
    }
}