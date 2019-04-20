using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelProje
{
    public class Ders
    {
        public Dersler DersAdi { get; set;}
        public double VizeNotu1 { get; set; }
        public double VizeNotu2 { get; set; }
        public double FinalNotu { get; set; }



        public double OrtalamaHesapla()
        {
            double ortalama = (VizeNotu1 * 30 / 100) + (VizeNotu2 * 30 / 100) + (FinalNotu * 40 / 100);
            return ortalama;
        }


        public enum Dersler
        {
            Matematik,
            Fen,
            Fizik,
            Beden
        }
    }



}
