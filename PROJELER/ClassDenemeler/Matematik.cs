using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDenemeler
{
    public class Matematik: Ders
    {
        public string Geometri { get; set; }

        public override string OrtakVeriYAzdir()
        {
            return "Matematik in yazdırdık";
        }
    }
}
