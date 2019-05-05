using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Mayis
{
    public partial class Form2 : Form
    {
        private string gonderilecekveri;

        public Form2()
        {
        }

        public Form2(string p)
        {
            InitializeComponent();

           label1.Text = Ortak.Yas.ToString();



        }
    }
}
