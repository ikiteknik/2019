using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiOlustur
{
    public class Ogrenci
    {
        //public string Ad { get; set; }

        private string _ad;

        public string Ad
        {
            get { return _ad; }

            set
            {
                value = value.Trim().Replace(" ", "");
                _ad = value.ToUpper();
            }
        }




        public string Soyad { get; set; }
        public string DersAdi { get; set; }
        public DateTime DogumTar { get; set; }
        public double Vize1 { get; set; }
        public double Vize2 { get; set; }
        public double Final { get; set; }
        public double Ortamala { get; set; }
        public string TcNo { get; set; }
        public string ImagePath { get; set; }
        public static int OgrenciSayisi { set; get; } = 0;


        public Ogrenci()
        {
            OgrenciSayisi = OgrenciSayisi + 1;

            MessageBox.Show(OgrenciSayisi.ToString());
        }

        static Ogrenci()
        {
            MessageBox.Show("ogrenci class olustu");
        }



    }
}
