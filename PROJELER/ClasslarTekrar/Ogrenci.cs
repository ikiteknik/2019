using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasslarTekrar
{
    public class Ogrenci
    {

        public Ogrenci()
        {
            OgrenciSayi++;
        }

        ~Ogrenci()
        {
            OgrenciSayi--;
        }



        private string myVar;
        public string OgrenciAdi
        {
            get { return myVar; }

            set
            {
                value = value.ToUpper();         
                myVar = value;
            }
        }



        public string OgrenciNo { get; set; }

        public static int OgrenciSayi { get; set; } = 0;

        public int Ogsayi()
        {
            return OgrenciSayi;
        }


    }









}
