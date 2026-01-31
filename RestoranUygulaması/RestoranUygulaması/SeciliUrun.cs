using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması
{
    public class SeciliUrun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }

        public decimal ToplamFiyat()
        {
            return Fiyat * Adet;
        }
    }
}
