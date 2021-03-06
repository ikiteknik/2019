﻿using System;
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
            x.TcNo = txttcno.Text;
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


            ResimKaydet(txttcno.Text);
        }

        private void ResimKaydet(string p)
        {
            Bitmap b = new Bitmap(imageloc);
            b.Save(@"D:\HuseyinAtmaca\Github\PROJELER\KisiOlustur\KisiResimler\" + p +".jpg");
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

   
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                var ss = row.Cells["Ad"].Value.ToString();
                var tcno = row.Cells["TcNo"].Value.ToString();

                Ogrenci secilenogr=liste.Where(x => x.TcNo == tcno).FirstOrDefault();

                KisiDetay w = new KisiDetay(secilenogr);
         
                w.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci s = new Ogrenci();
           
            

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {

             e.KeyChar.ToString().ToUpper();
           

        }
    }
}
