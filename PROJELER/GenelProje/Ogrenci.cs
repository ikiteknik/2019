using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelProje
{
    public class Ogrenci
    {  
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string Cinsiyet { get; set; }

        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string EPosta { get; set; }

        public DateTime DorumTarihi { get; set; }
        public Ders OgrenciDersi { get; set; }
        public string ResimPath { get; set; }



    }


}
