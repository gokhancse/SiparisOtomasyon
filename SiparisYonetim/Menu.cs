using SiparisYonetim.Bayii_Formu;
using SiparisYonetim.Helpers;
using SiparisYonetim.Kategori_Formu;
using SiparisYonetim.Müşteriler_Formu;
using SiparisYonetim.Urunler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetim
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FtpAktarimFormu ftp = new FtpAktarimFormu();
            ftp.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Urunler.Urunler urun = new Urunler.Urunler();
            urun.ShowDialog();
        }

        private void btnkategoriler_Click_1(object sender, EventArgs e)
        {
            Kategoriler kategori = new Kategoriler();
            kategori.ShowDialog();
        }

        private void _btnMusteri_Click_1(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bayiiler bayii = new Bayiiler();
            bayii.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SiparisFormu siparis = new SiparisFormu();
            siparis.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label3.Text = Oturum.Sirket.SirketAdi.ToString();
            if (Oturum.Sirket.SirketId!=1)
            {
                button2.Enabled = false;
            }
        }
    }
}
