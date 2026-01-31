using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması
{
    public class Garson
    {
        public int GarsonID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public override string ToString()
        {
            return $"{Ad} {Soyad}"; // ListBox'ta gösterilecek format    }

        }
    }
}
