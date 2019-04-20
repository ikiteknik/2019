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
    public partial class Form1 : Form
    {
        List<Ogrenci> liste = new List<Ogrenci>();
        string imageloc;
        public Form1()
        {
            InitializeComponent();
            comboboxyukle();
        }

        private void comboboxyukle()
        {
            cbdersler.Items.Add("Matemetik");
            cbdersler.Items.Add("Fizik");
            cbdersler.Items.Add("Biyoloji");
            cbdersler.Items.Add("Beden");
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Ogrenci x = new Ogrenci();

            x.Ad = txtad.Text;
            x.Soyad = txtsoyad.Text;
            x.DersAdi = cbdersler.Text;   // combobox dan aldık veriyi
            x.DogumTar = dateTimePicker1.Value; // date time picker den aldık veriyi

            x.Vize1 = Convert.ToDouble(txtvize1.Text);
            x.Vize2 = Convert.ToDouble(txtvize2.Text);
            x.Final = Convert.ToDouble(txtfinal.Text);

            x.Ortamala = (Convert.ToDouble(txtvize1.Text) * 30 / 100) +
                         (Convert.ToDouble(txtvize2.Text) * 30 / 100) +
                         (Convert.ToDouble(txtfinal.Text) * 40 / 100);

            x.ImagePath = imageloc;


            liste.Add(x);


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = liste;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            dataGridView1.Select();
        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                imageloc = d.FileName;
                pictureBox1.ImageLocation = imageloc;
            }
        }
    }
}
