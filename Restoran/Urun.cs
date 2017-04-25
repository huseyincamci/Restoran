using System.Collections.Generic;
using System.Windows.Forms;

namespace Restoran
{
    public class Urun
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }

        public Urun()
        {
            
        }

        public Urun(string adi, decimal fiyat)
        {
            UrunList.Add(this);
        }

        public static List<Urun> UrunList = new List<Urun>();

        public ListViewItem ListOlustur()
        {
            var item = new ListViewItem() { Text = Adi };
            item.SubItems.Add(Fiyat.ToString("C2"));
            return item;
        }

        public override string ToString()
        {
            return this.Adi;
        }
    }
}
