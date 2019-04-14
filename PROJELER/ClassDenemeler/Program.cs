using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDenemeler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("class ogrenme");


            #region clas1
            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrenciAdi = "huseyin";
            ogr1.OgrenciSoyadi = "Atmaca";
            int sonc = ogr1.ToplamaMetod(8, 9);
            string sonc1 = ogr1.ToplamaMetod("8","9");
            #endregion


            #region dersler

            Matematik m = new Matematik();
            m.DersAdi = "mat1";
            m.DersNotu = 99;
            // Console.WriteLine(m.DersAdi + ":" + m.DersNotuYazdir());
            Console.WriteLine(m.OrtakVeriYAzdir());



            Fizik f = new Fizik();
            f.DersNotu = 77;
            f.DersAdi = "fizik1";
           // Console.WriteLine(f.DersAdi +":" +  f.DersNotuYazdir());
            Console.WriteLine(f.OrtakVeriYAzdir());
            #endregion

            //Console.WriteLine(sonc.ToString());
            //Console.WriteLine(sonc1.ToString());
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
