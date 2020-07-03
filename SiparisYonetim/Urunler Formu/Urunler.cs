using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiparisYonetim;
using SiparisYonetim.Tablolar;
using SiparisYonetim.Urunler;
using System.IO;
using SiparisYonetim.Urunler_Formu;

namespace SiparisYonetim.Urunler
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        DB_Context db = new DB_Context();
        List<Urun> Urunlerr;
        public void Listele()
        {
            _datakategori.ColumnCount = 6;
            _datakategori.Columns[0].Name = "KATEGORI";
            _datakategori.Columns[1].Name = "KOD";
            _datakategori.Columns[2].Name = "DETAY";
            _datakategori.Columns[3].Name = "AGIRLIK";
            _datakategori.Columns[4].Name = "AYAR";
            _datakategori.Columns[5].Name = "ResimAdı";
            _datakategori.Rows.Clear();
            ArrayList row = new ArrayList();
            Urunlerr = new List<Urun>();
            var urun = db.Urunler.Select(x => x);
            foreach (var item in urun)
            {
                row = new ArrayList();
                row.Add(item.UrunId);
                row.Add(item.Kod);
                row.Add(item.Detay);
                row.Add(item.Bilesen_Agirligi);
                row.Add(item.Ayar);
                row.Add(item.UrunResmi);
                //_datakategori.Rows.Add(
                //    item.UrunId,
                //    item.Kod,
                //    item.Detay,
                //    item.Bilesen_Agirligi,
                //    item.Ayar,
                //    Image.FromFile(item.UrunResmi));
                _datakategori.Rows.Add(row.ToArray());
                Urunlerr.Add(item);
            }
        }
        private void Urunler_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void _datakategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string resimadi = Convert.ToString(_datakategori.Rows[_datakategori.CurrentRow.Index].Cells["ResimAdı"].Value);
            if (resimadi == null || resimadi == "")
            {
                MessageBox.Show("Bu ürünün resmi mevcut değildir.");
            }
            else
            {
                ResimGor resim = new ResimGor();
                resim.ResimAdi = resimadi;
                resim.ShowDialog();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle urunekle = new UrunEkle();
            urunekle.ShowDialog();
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunEkle urunekle = new UrunEkle();
            urunekle.ShowDialog();
            Listele();
        }
    }
}
