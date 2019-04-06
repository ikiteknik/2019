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

            if (!char.IsDigit(okunanchar) && okunanchar != 8)  // okunan karakter digit değil ve silme tuşu değil ise 
            {
                e.Handled = true; // textboxa girilmesini önle
            }

        }

        private void btnRandomUret1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x=rnd.Next(0, 100);
            btnRandomUret1.Text = x.ToString();

        }

        private void btnEkle1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsirasayi1.Text))
                return;

            int okunan = Convert.ToInt32(txtsirasayi1.Text);

            if (okunan < 0)
            {
                List2.Items.Add(okunan.ToString());
            }
            else
            {
                List1.Items.Add(okunan.ToString());
            }
        }

      
        private void btnbuyuktokucuk_Click(object sender, EventArgs e)
        {
            int gecici;

            /////// Pozitif Liste
            for (int i = 0; i < List1.Items.Count; i++)
            {
                int x = Convert.ToInt32(List1.Items[i]);

                for (int k = i; k < List1.Items.Count; k++)
                {                  
                    int y = Convert.ToInt32(List1.Items[k]);
                    if (x < y)
                    {
                        gecici = y;
                        List1.Items[k] = List1.Items[i];
                        List1.Items[i] = gecici;
                    }
                }
            }

            /////// Negatif Liste
            int gecici2;
            for (int i = 0; i < List2.Items.Count; i++)
            {
                int x = Convert.ToInt32(List2.Items[i]);

                for (int k = i; k < List2.Items.Count; k++)
                {
                    int y = Convert.ToInt32(List2.Items[k]);
                    if (x < y)
                    {
                        gecici2 = y;
                        List2.Items[k] = List2.Items[i];
                        List2.Items[i] = gecici2;
                    }
                }
            }
        }

        private void btnkucuktobuyuk_Click(object sender, EventArgs e)
        {
            int gecici;

            /////// Pozitif Liste

            for (int i = 0; i < List1.Items.Count; i++)
            {
                int x = Convert.ToInt32(List1.Items[i]);

                for (int k =i; k < List1.Items.Count; k++)
                {                  
                    int y = Convert.ToInt32(List1.Items[k]);

                    if (x > y)
                    {
                        gecici = y;
                        List1.Items[k] = List1.Items[i];
                        List1.Items[i] = gecici;
                    }
                }
            }

            /////// Negatif Liste

            int gecici2;
            for (int i = 0; i < List2.Items.Count; i++)
            {
                int x = Convert.ToInt32(List2.Items[i]);

                for (int k = i; k < List2.Items.Count; k++)
                {
                    int y = Convert.ToInt32(List2.Items[k]);
                    if (x > y)
                    {
                        gecici2 = y;
                        List2.Items[k] = List2.Items[i];
                        List2.Items[i] = gecici2;
                    }
                }
            }

        }

        private void btnformac1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void btnformac2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

     
    }
}
