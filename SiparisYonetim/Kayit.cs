using SiparisYonetim.Tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetim
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Context db = new DB_Context();
            Sirket sirket = new Sirket();
            sirket.SirketAdi = textBox2.Text;
            sirket.Silindi = false;
            db.Sirketler.Add(sirket);
            db.SaveChanges();
            Kullanici kullanici = new Kullanici();
            var sirketid = db.Sirketler.OrderByDescending(x => x.SirketId).FirstOrDefault();

            kullanici.SirketId = sirketid.SirketId;
            kullanici.Ad = textBox1.Text;
            kullanici.Soyad = Soyad.Text;
            kullanici.K_Adi = textBox3.Text;
            kullanici.Parola = _parola.Text;
            kullanici.SonBasarisizGirisTarihi = DateTime.Now;
            kullanici.SonGirisTarihi = DateTime.Now;
            kullanici.YanlisGirisAdedi = 0;
            db.Kullanicilar.Add(kullanici);
            db.SaveChanges();

        }
    }
}
