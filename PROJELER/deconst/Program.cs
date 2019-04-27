using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deconst
{
    class Program
    {
        static void Main(string[] args)
        {
            ogr o = new ogr();
            o = null;
            GC.Collect();

            Console.ReadKey();
        }
    }



    public class ogr
    {
        public ogr()
        {

            Console.WriteLine("obje olusatu");
        }

        ~ogr()
        {
            Console.WriteLine("obje silindi");
        }


        public string Adi { get; set; }
    }
}
