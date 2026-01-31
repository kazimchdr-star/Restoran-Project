using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması
{
    public class Menu
    {
        public int UrunID { get; set; }
        public string UrunAdı { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return $"{UrunAdı} - {Fiyat:C}"; // ListBox'ta gösterilecek format
        }
    }

}
