using System.Collections.Generic;
using System.Windows.Forms;

namespace Restoran
{
    public class Masa : Button
    {
        public Masa()
        {
            this.Text = Kodu;
            this.Width = 70;
            this.Height = 70;
        }

        private string _musteriTelefon;
        public string _kodu;
        public string MusteriAdi { get; set; }
        public bool Rezerve { get; set; } = false;
        public bool Dolu { get; set; } = false;

        public decimal Tutar
        {
            get
            {
                decimal s = 0;
                foreach (var urun in Urunler)
                {
                    s += urun.Fiyat;
                }
                return s;
            }
        }

        public string MusteriTelefon
        {
            get { return _musteriTelefon; }
            set
            {
                if (value.Length != 12)
                {
                    return;
                }
                _musteriTelefon = value;
            }
        }

        public string Kodu
        {
            get { return _kodu; }
            set { _kodu = this.Text = value; }
        }

        public List<Urun> Urunler = new List<Urun>();
    }
}