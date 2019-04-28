using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Uygulama2
{
    public partial class Form1 : Form
    {

        List<KisiVeHobiler> listholer = new List<KisiVeHobiler>();
        int say = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 200;
            timer1.Tick += new EventHandler(ikiteknik);
            timer1.Enabled = true;
        }

        private void ikiteknik(object sender, EventArgs e)
        {
            if (say != 6)
            {
                lbltimer.Text = say.ToString();
                say++;             
            }

            else {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }
        }

        private void btnhobiekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txthobi.Text))
            {
                chlistbox.Items.Add(txthobi.Text);
            }

        }

        private void btnkisikaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtkisi.Text))
                return;

            listboxhobiler.Items.Clear();

            string secilenKisi = txtkisi.Text;

            for (int i = 0; i < chlistbox.Items.Count; i++)
            {
                if (chlistbox.GetItemChecked(i))
                {
                    string secilenhobi = (string)chlistbox.Items[i];

                    KisiVeHobiler s = new KisiVeHobiler();
                    s.Adi = secilenKisi;
                    s.HobiAdi = secilenhobi;

                    listholer.Add(s);
                }
            }

            foreach (KisiVeHobiler item in listholer)
            {
                listboxhobiler.Items.Add(item.Adi + "-" + item.HobiAdi);
            }

        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {

            listboxhobiler.Items.Clear();

            for (int i = 0; i < chlistbox.Items.Count; i++)
            {
                if (!chlistbox.GetItemChecked(i))
                {
                    string secilenveri = (string)chlistbox.Items[i];
                    KisiVeHobiler XX = listholer.Where(x => x.HobiAdi == secilenveri).FirstOrDefault();
                    listholer.Remove(XX);
                }
            }

            foreach (KisiVeHobiler item in listholer)
            {
                listboxhobiler.Items.Add(item.Adi + "-" + item.HobiAdi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void bntyas_Click(object sender, EventArgs e)
        {



            int s1 = dateTimePicker2.Value.Year;
            int s2 = dateTimePicker1.Value.Year;

            MessageBox.Show((s1 - s2).ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }


}
