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
    public partial class Form1 : Form
    {

        int say = 0;
        bool x = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(aaaa);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void aaaa(object sender, EventArgs e)
        {
            label1.Text = say.ToString();
            say++;

            label2.Text = DateTime.Now.TimeOfDay.ToString();


            x = !x;

            if (x)
            {
                tabControl1.SelectedTab = tabPage1;
                tabPage1.BackColor = Color.Red;

            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
                tabPage2.BackColor = Color.Green;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string x = txtverigonder.Text;
            // MessageBox.Show(Convert.ToInt32(x).ToString());


            int y;

            int ggg = int.Parse(x);

            if (int.TryParse(x, out y))
            {
                MessageBox.Show("OLDU");
            }
            else {
                MessageBox.Show("OLMADI");

            }



        }
    }
}