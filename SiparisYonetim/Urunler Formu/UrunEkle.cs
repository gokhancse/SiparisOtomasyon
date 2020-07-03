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
using SiparisYonetim.Tablolar;
using System.IO;

namespace SiparisYonetim.Urunler_Formu
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        DB_Context db = new DB_Context();
        List<Kategori> kategorilers;
        int kategorid;
        string DosyaYolu;
        public void ListeleKategori()
        {
            _cmbKategori.Items.Clear();
            ArrayList row = new ArrayList();
            kategorilers = new List<Kategori>();
            var kategori = db.Kategoriler.Select(x => x).ToList();
            foreach (var item in kategori)
            {
                row = new ArrayList();
                _cmbKategori.Items.Add(item.KategoriAdi);
                kategorilers.Add(item);
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            ListeleKategori();
        }
        private void _btnKaydet_Click_1(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Adi = _cmbKategori.SelectedItem.ToString();
            urun.Kod = _txtUrunkod.Text;
            urun.Miktar = Convert.ToDouble(_txtGram.Text);
            urun.Detay = _txtDetay.Text;
            urun.KategoriId = kategorid;
            if (_chkYeniUrun.Checked)
                urun.YeniUrun = true;
            else
                urun.YeniUrun = false;
            urun.SirketId = 1;
            urun.EklenmeTarihi = DateTime.Now;
            urun.UrunResmi = DosyaYolu;
            db.Urunler.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Eklendi.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _txtUrunkod.Clear();
            _txtGram.Clear();
            _txtDetay.Clear();
            _chkYeniUrun.Checked = false;
        }

        private void _cmbKategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ArrayList row = new ArrayList();
            row.Clear();
            kategorilers = new List<Kategori>();
            var kategori = db.Kategoriler.Where(x => x.KategoriAdi == _cmbKategori.Text).Select(x => x.KategoriId);
            foreach (var item in kategori)
            {
                row = new ArrayList();
                kategorid = Convert.ToInt32(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            DosyaYolu = dosya.SafeFileName;
        }
    }
}
