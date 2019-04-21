using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiOlustur
{
    public partial class KisiDetay : Form
    {
        private string tcno;

        public KisiDetay()
        {
            

        }

        public KisiDetay(Ogrenci obj)
        {
            InitializeComponent();
            lblad.Text = obj.Ad;
            lblsoyad.Text = obj.Soyad;
            lbldogumtar.Text = obj.DogumTar.ToShortDateString();
            lblorta.Text = obj.Ortamala.ToString();
            lbltcno.Text = obj.TcNo;
            picturekisi.ImageLocation = obj.ImagePath;

       
        }

        private void ptnYazdir_Click(object sender, EventArgs e)
        {
          
        }
    }
}
