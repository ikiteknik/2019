using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDenemeler
{
    public class Fizik: Ders
    {
        public string LabaratuarNo { get; set; }


        public override string OrtakVeriYAzdir()
        {
            return "Fizik yazdırıldı";
        }
    }
}
