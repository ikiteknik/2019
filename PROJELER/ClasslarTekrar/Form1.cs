using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasslarTekrar
{
    public partial class Form1 : Form
    {
        List<Ogrenci> liste = new List<Ogrenci>();
        bool siralama = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int s = Convert.ToInt32(txtname.Text);
            //Ogrenci o = new Ogrenci();
            //o.OgrenciAdi = txtname.Text;
            //o.OgrenciNo = txtno.Text;

            //liste.Add(o);

            listBox1.Items.Add(s);

            //lblogrsayi.Text = o.Ogsayi().ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string secilenad = listBox1.SelectedItem.ToString();

            listBox1.Items.Remove(listBox1.SelectedItem);


            lblogrsayi.Text = listBox1.Items.Count.ToString();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {

            int sonuc = listBox1.FindString(txtname.Text);

            if (sonuc > -1)
            {
                MessageBox.Show("bulduk");
            }



        }

        private void btnsirala_Click(object sender, EventArgs e)
        {
            siralama = !siralama;

            if (siralama)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    for (int k = i; k < listBox1.Items.Count; k++)
                    {
                        if (Convert.ToInt32(listBox1.Items[k]) > Convert.ToInt32(listBox1.Items[i]))
                        {
                            int temp = Convert.ToInt32(listBox1.Items[i]);
                            listBox1.Items[i] = listBox1.Items[k];
                            listBox1.Items[k] = temp;
                        }

                    }
                }
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    for (int k = i; k < listBox1.Items.Count; k++)
                    {
                        if (Convert.ToInt32(listBox1.Items[k]) < Convert.ToInt32(listBox1.Items[i]))
                        {
                            int temp = Convert.ToInt32(listBox1.Items[i]);
                            listBox1.Items[i] = listBox1.Items[k];
                            listBox1.Items[k] = temp;
                        }

                    }
                }
            }



        }

        private void btncarpim_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 9; i++)
            {
                listBox1.Items.Add("/////////////////////" + i + "//////////////////");
                for (int k = 0; k < 10; k++)
                {
                    listBox1.Items.Add(i + "*" + k + "=" + i * k);
                }
            }


        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int say1 = Convert.ToInt32(txtsayi1.Text);
            int say2 = Convert.ToInt32(txtsayi2.Text);

            int islem = comboBox1.SelectedIndex;

            switch (islem)
            {
                case 0:
                    lblsonuc.Text = (say1 * say2).ToString();break;
                case 1:
                    lblsonuc.Text = (say1 / say2).ToString(); break;
                case 2:
                    lblsonuc.Text = (say1 + say2).ToString(); break;
                case 3:
                    lblsonuc.Text = (say1 - say2).ToString(); break;
                default:
                    lblsonuc.Text = "işlem tipi seç";

                    break;
            }
        }
    }
}
