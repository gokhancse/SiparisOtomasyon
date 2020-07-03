using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetim.Müşteriler_Formu
{
    public partial class MusteriDuzenle : Form
    {
        public MusteriDuzenle()
        {
            InitializeComponent();
        }
        public int? MusteriDuzenleId { get; set; }
        public int? YeniMusteriId { get; set; }
        public bool Guncelle { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Eposta { get; set; }
        public string Firmaadi { get; set; }
        public string Yetkili { get; set; }
        DB_Context db;

        private void MusteriDuzenle_Load(object sender, EventArgs e)
        {
            _txtFirmaadi.Text = Firmaadi;
            _txtYetkili.Text = Yetkili;
            _txtTelefon1.Text = Telefon1;
            _txtTelefon2.Text = Telefon2;
            _txtEposta.Text = Eposta;
        }

        private void _btnSil_Click(object sender, EventArgs e)
        {
            db = new DB_Context();
            var kayit = db.Sirketler.FirstOrDefault(x => x.SirketId == MusteriDuzenleId);
            db.Sirketler.Remove(kayit);
            db.SaveChanges();
            _txtFirmaadi.Clear();
            _txtYetkili.Clear();
            _txtTelefon1.Clear();
            _txtTelefon2.Clear();
            _txtEposta.Clear();
            MessageBox.Show("Kayıt Silindi.",
                      "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void _btnGuncelle_Click(object sender, EventArgs e)
        {
            db = new DB_Context();
            var kayit = db.Sirketler.Single(x => x.SirketId == MusteriDuzenleId);
            kayit.SirketAdi = _txtFirmaadi.Text;
            kayit.Eposta = _txtEposta.Text;
            kayit.Yetkili = _txtYetkili.Text;
            kayit.Telefon = _txtTelefon1.Text;
            kayit.Telefon2 = _txtTelefon2.Text;
            db.SaveChanges();
            _txtFirmaadi.Clear();
            _txtYetkili.Clear();
            _txtTelefon1.Clear();
            _txtTelefon2.Clear();
            _txtEposta.Clear();
            MessageBox.Show("Kayıt Güncellendi.",
                      "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
