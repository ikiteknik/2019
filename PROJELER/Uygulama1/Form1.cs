using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RadiobutonKontrol();
        }

        private void txtfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {

            char okunan = e.KeyChar;

            if (!char.IsDigit(okunan) && okunan != Convert.ToChar("."))
            {
                e.Handled = true;
            }


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            double girilenveri = 0;
            double sonucverisi = 0;

            if (!string.IsNullOrEmpty(txtfiyat.Text))
            {
                girilenveri = Convert.ToDouble(txtfiyat.Text);
                sonucverisi = girilenveri;
            }


            if (cbindirim.Checked)
            {

                if (rbotuz.Checked)
                {
                    sonucverisi = girilenveri - (girilenveri * 30 / 100);

                }
                else if (rbyirmi.Checked)
                {
                    sonucverisi = girilenveri - (girilenveri * 20 / 100);
                }
                else
                {
                    MessageBox.Show("Indirim Oranı Seçmediniz");
                }
            }


            listBox1.Items.Add("Girilen Ürün : " + sonucverisi);

        }

        private void cbindirim_CheckedChanged(object sender, EventArgs e)
        {

            RadiobutonKontrol();


        }

        private void RadiobutonKontrol()
        {
            if (cbindirim.Checked)
            {
                rbotuz.Enabled = true;
                rbyirmi.Enabled = true;
            }
            else
            {
                rbotuz.Enabled = false;
                rbyirmi.Enabled = false;
                rbotuz.Checked = false;
                rbyirmi.Checked = false;
            }
        }
    }
}
