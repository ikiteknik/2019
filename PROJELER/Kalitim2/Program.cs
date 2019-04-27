using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a=9;
            Console.WriteLine("orjinal a =");

            degistir(out a);
            Console.WriteLine("sonrası  a =" + a);


            Console.ReadKey();
        }

        private static void degistir(out int a)
        {
            a = 63;
        }
    }





}
