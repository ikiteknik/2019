using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelProje
{
    public class Ders
    {
        public dersler DersAdi { get; set;}
        public double VizeNotu1 { get; set; }
        public double VizeNotu2 { get; set; }
        public double FinalNotu { get; set; }



        public double OrtalamaHesapla(double v1,double v2,double final)
        {
            double sonuc = 0;

            return sonuc;
        }
    }


    public enum dersler
    {
        Matematik,
        Fen,
        Fizik,
        Beden
    }
}
