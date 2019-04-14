using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDenemeler
{
    public abstract class Ders
    {
        public string DersAdi { get; set; }  // autoproperty, full property
        public string SinifNo;
        public int DersNotu;
        public string DersNotuYazdir()
        {
            return DersNotu.ToString();
        }

        public virtual string OrtakVeriYAzdir()
        {
            return "ortak veri";
        }


    }



}
