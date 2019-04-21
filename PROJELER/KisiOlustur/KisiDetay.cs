using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //this.tcno = tcno;
            InitializeComponent();
            lbltcno.Text = obj.TcNo;

        }




    }
}
