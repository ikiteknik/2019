using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDenemeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("class ogrenme");

            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrenciAdi = "huseyin";
            ogr1.OgrenciSoyadi = "Atmaca";


            int sonc = ogr1.ToplamaMetod(8, 9);
            string sonc1 = ogr1.ToplamaMetod("8","9");

            Console.WriteLine(sonc.ToString());
            Console.WriteLine(sonc1.ToString());
            Console.ReadKey();
        }
    }
    public class Ogrenci
    {
        //fields
        //constructor method
        //normal methods
        //property
        //events
        //delegate
        //nested class


        /////// fields
        public string OgrenciAdi;
        public string OgrenciSoyadi;

        /////// constructor (yapıcı metod)
        public Ogrenci()
        {
            //MessageBox.Show("constructor Class Olustu");
        }

        /////// deconstructor (yapıcı metod)
        ~Ogrenci()
        {
            //MessageBox.Show("Class öldü");
        }

        /////// normal metod
        public int NormalMetod()
        {
            return 999;
        }

        public int ToplamaMetod(int say1, int sayi2)
        {
            return say1 + sayi2;
        }

        public string ToplamaMetod(string say1, string sayi2)
        {
            return say1 + sayi2;
        }

    }


}
