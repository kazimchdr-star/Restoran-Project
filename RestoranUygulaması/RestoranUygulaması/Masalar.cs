using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Masa
{
    public int MasaID { get; set; }
    public string MasaNumarası { get; set; }
    public string Durum { get; set; }

    public override string ToString()
    {
        return $"{MasaNumarası} - {Durum}";
    }
}

