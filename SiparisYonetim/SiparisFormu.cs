using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Collections;
using SiparisYonetim.Tablolar;
using SiparisYonetim.Helpers;

namespace SiparisYonetim
{
    public partial class SiparisFormu : Form
    {
        public SiparisFormu()
        {
            InitializeComponent();
        }
        DB_Context db = new DB_Context();
        List<Urun> Urunlerr;
        int urunid=0, toplamadet=0, kategoriid=0;
        string urunadi="";

        public void Siparis()
        {
            db = new DB_Context();
            Siparis_Detay detay = new Siparis_Detay();
            Siparis siparis = new Siparis();

            siparis.SiparisVerenSirketId = Oturum.Sirket.SirketId;
            siparis.TeslimTarihi = DateTime.Now.AddDays(10);
            siparis.ToplamAdet = toplamadet;
            siparis.SirketId = Convert.ToInt32(Oturum.Sirket.UstSirketId);
            siparis.KullaniciId = Oturum.User.KullaniciId;
            siparis.SiparisTarihi = DateTime.Now;
            //siparis.ToplamUrunCesidi = 2;
            db.Siparis.Add(siparis);
            db.SaveChanges();
            detay.SiparisId = siparis.SiparisId;
            detay.SirketId = Oturum.Sirket.SirketId;
            detay.UrunAdi = _cmbKategori.Text;
            detay.Kod = _cmbUrun.Text;
            detay.UrunNotu = richTextBox2.Text;
            detay.ToplamAdet = toplamadet;
            detay.UrunId = urunid;
            //detay.RenkBedenDetayi = "test";
            detay.ModelCheck = Guid.Parse("F1FE990C-4525-4BFE-9E2C-A7AFFF0DDA1F");
            db.SiparisDetaylar.Add(detay);
            db.SaveChanges();

            //db.Siparis.Add(siparis);
            //db.SaveChanges();
        }
        //public void SiparisDetay()
        //{
        //    Siparis siparis = new Siparis();
        //    Siparis_Detay detay = new Siparis_Detay();
        //    detay.SiparisId = siparis.SiparisId;
        //    detay.SirketId = Oturum.Sirket.SirketId;
        //    detay.UrunAdi = _cmbKategori.SelectedText;
        //    detay.Kod = _cmbUrun.SelectedText;
        //    detay.RenkAdet = toplamadet;
        //    detay.UrunNotu = richTextBox2.Text;
        //    detay.ToplamGramaj = Convert.ToInt32(label9.Text);
        //    detay.ToplamAdet = toplamadet;
        //    detay.UrunId = urunid;
        //    detay.ModelCheck = Guid.Parse("F1FE990C-4525-4BFE-9E2C-A7AFFF0DDA1F");

        //}
        private void button1_Click(object sender, EventArgs e)
        {
            Siparis();
            //SiparisDetay();
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("");
            msg.To.Add("");
            msg.Subject = "Deneme";
            msg.Body = "Deneme amaçlı gönderildi.";
            using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("", "");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(msg);
            }
            MessageBox.Show("İşlem Başarılı!");
        }
      
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseHover);
            Size size = new Size(1000, 3000);
            pictureBox1.Size = size;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.MouseLeave += new EventHandler(pictureBox1_MouseLeave);
            Size size = new Size(700, 700);
            pictureBox1.Size = size;
        }
      
        public void ListeleUrun()
        {
            _cmbUrun.Items.Clear();
            ArrayList row = new ArrayList();
            var urun = db.Urunler.Where(x => x.KategoriId == kategoriid).Select(x => x).ToList();

            foreach (var item in urun)
            {
                _cmbUrun.Items.Add(item.Kod);
                //urunid = item.UrunId;

            }
        }
        public void ListeleKategori()
        {
            db = new DB_Context();
            _cmbKategori.Items.Clear();
            ArrayList row = new ArrayList();
            var kategori = db.Kategoriler.Select(x => x).ToList();

            foreach (var item in kategori)
            {
                row = new ArrayList();
                _cmbKategori.Items.Add(item.KategoriAdi);
            }
        }

        private void SiparisFormu_Load(object sender, EventArgs e)
        {
            ListeleKategori();
        }

        private void _cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList row = new ArrayList();
            row.Clear();
            var kategori = db.Kategoriler.Where(x => x.KategoriAdi == _cmbKategori.Text).Select(x => x.KategoriId);
            foreach (var item in kategori)
            {
                kategoriid = Convert.ToInt32(item.ToString());
            }
            _cmbUrun.Text = "";
            ListeleUrun();
        }

        private void _cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList row = new ArrayList();
            var urun = db.Urunler.Where(x => x.Kod == _cmbUrun.Text).Select(x => x).ToList();
            Urunlerr = new List<Urun>();
            var urunn = db.Urunler.Where(x => x.Kod == _cmbUrun.Text).Select(x => x.UrunResmi);
            foreach (var item in urunn)
            {
                urunadi = Convert.ToString(item);
            }
            string yol = Application.StartupPath;
            pictureBox1.Image = Image.FromFile(yol + "\\resimler\\" + urunadi);
        }

    }
}
