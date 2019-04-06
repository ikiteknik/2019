using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string okunan = e.KeyChar.ToString().ToUpper();

            if (okunan == "T" || okunan == "Ç")
            {
                if (string.IsNullOrEmpty(txtsayi1.Text))
                {
                    MessageBox.Show("Sayı 1 Girin");
                    return;
                }

                if (string.IsNullOrEmpty(txtsayi2.Text))
                {
                    MessageBox.Show("Sayı 2 Girin");
                    return;
                }

                int x = Convert.ToInt32(txtsayi1.Text);
                int y = Convert.ToInt32(txtsayi2.Text);

                if (okunan == "T")
                {                 
                    MessageBox.Show((x+y).ToString());
                }

                if (okunan == "Ç")
                {                  
                    MessageBox.Show((x*y).ToString());
                }
            }
                

           
        }

        private void txtsayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char okunanchar = e.KeyChar;    // txtsayi1 textbox giriş yapılır yapılmaz veriyi kontrol et

            if (!char.IsDigit(okunanchar))  // okunan karakter digit değil ise
            {
                e.Handled = true; // textboxa girilmesini önle
            }
        }

        private void txtsayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char okunanchar = e.KeyChar;    // txtsayi2 textbox giriş yapılır yapılmaz veriyi kontrol et

            if (!char.IsDigit(okunanchar))  // okunan karakter digit değil ise
            {
                e.Handled = true; // textboxa girilmesini önle
            }

        }
    }
}
