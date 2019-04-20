using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GenelProje.Ders;

namespace GenelProje
{
    public partial class Form1 : Form
    {
        List<Ogrenci> ogrenciListe = new List<Ogrenci>();
        public Form1()
        {
            InitializeComponent();
            YukleComboboxVerilerini();
        }

        private void YukleComboboxVerilerini()
        {
            cbDers.DataSource = Enum.GetValues(typeof(Dersler));

        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci og = new Ogrenci();
            Ders dr = new Ders();

            dgridListe.AutoGenerateColumns = false;

            Dersler secilenders = (Dersler)cbDers.SelectedValue;
            dr.DersAdi = secilenders;
            dr.VizeNotu1 = Convert.ToInt32(txtvize1.Text);
            dr.VizeNotu2 = Convert.ToInt32(txtvize2.Text);
            dr.FinalNotu = Convert.ToInt32(txtfinal.Text);

            og.OgrenciAdi = txtogrenciadi.Text;
            og.OgrenciSoyadi = txtogrencisoyad.Text;
            og.DorumTarihi = dtDogumTarih.Value;
            og.Cinsiyet = cbCinsiyet.SelectedIndex == 0 ? "BAYAN" : "BAY";
            og.Telefon = txttelefon.Text;
            og.Adres = txtadres.Text;
            og.EPosta = txteposta.Text;
            og.OgrenciDersi = dr;
            ogrenciListe.Add(og);

            dgridListe.Rows.Clear();

            foreach (Ogrenci item in ogrenciListe)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgridListe);
                row.Cells[0].Value = item.OgrenciAdi;
                row.Cells[1].Value = item.OgrenciSoyadi;
                row.Cells[2].Value = item.OgrenciDersi.DersAdi;
                row.Cells[3].Value = item.OgrenciDersi.VizeNotu1;
                row.Cells[4].Value = item.OgrenciDersi.VizeNotu2;
                row.Cells[5].Value = item.OgrenciDersi.FinalNotu;           
                row.Cells[6].Value = item.OgrenciDersi.OrtalamaHesapla();


                dgridListe.Rows.Add(row);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
