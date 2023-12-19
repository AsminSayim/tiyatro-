using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiyatro_.Resources
{
    internal class Tiyatro
    {
        int id;
        string oyunAdi;
        string sahne;
        double fiyat;
        DateTime tarih;
        int sure;
        bool müzikal;
        
        

        public int Id { get => id; set => id = value; }
        public string OyunAdi { get => oyunAdi; set => oyunAdi = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public int Sure { get => sure; set => sure = value; }
        public bool Müzikal { get => müzikal; set => müzikal = value; }

        public Tiyatro(int id, string oyunAdi, string sahne, double fiyat, DateTime tarih, int sure, bool müzikal)
        {
            this.id = id;
            this.oyunAdi = oyunAdi;
            this.sahne = sahne;
            this.fiyat = fiyat;
            this.tarih = tarih;
            this.sure = sure;
            this.müzikal = müzikal;
        }

        
    }
}
