using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiparisYonetim.Tablolar;
using SiparisYonetim.Helpers;

namespace SiparisYonetim.Müşteriler_Formu
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        int id;
        bool admin = Helpers.Oturum.SirketSec();

        DB_Context db = new DB_Context();
        public void GrupListele()
        {
            _cmbBayiiler.Items.Clear();
            var kayit = db.Sirketler.Where(x => x.UstSirketId == 1).Select(x => x.SirketAdi);

            foreach (var item in kayit)
            {
                _cmbBayiiler.Items.Add(item);
            }
        }

        private void _btnEkle_Click(object sender, EventArgs e)
        {
            if (!admin)
            MusteriEkleBayii();
            else
            MusteriEkleAdmin();
        }
        public void MusteriEkleBayii()
        {
            Sirket sirket = new Sirket();
            sirket.SirketAdi = _txtFirmadi.Text;
            sirket.Yetkili = _txtYetkili.Text;
            sirket.Telefon = _txtTel1.Text;
            sirket.Telefon2 = _txtTel2.Text;
            sirket.Eposta = _txtEposta.Text;
            sirket.UstSirketId = Oturum.Sirket.SirketId;
            db.Sirketler.Add(sirket);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Eklendi.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Musteriler must = new Musteriler();
            must.Listele();
            _txtYetkili.Clear();
            _txtFirmadi.Clear();
            _txtYetkili.Clear();
            _txtTel1.Clear();
            _txtTel2.Clear();
            _txtEposta.Clear();
        }
        public void MusteriEkleAdmin()
        {
                Sirket sirket = new Sirket();
                sirket.SirketAdi = _txtFirmadi.Text;
                sirket.Yetkili = _txtYetkili.Text;
                sirket.Telefon = _txtTel1.Text;
                sirket.Telefon2 = _txtTel2.Text;
                sirket.Eposta = _txtEposta.Text;
                var kayit = db.Sirketler.Where(x => x.SirketAdi == _cmbBayiiler.Text);
                foreach (var item in kayit)
                {
                    id = item.SirketId;
                }
                sirket.UstSirketId = id;
                db.Sirketler.Add(sirket);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarıyla Eklendi.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Musteriler must = new Musteriler();
                must.Listele();
                _txtYetkili.Clear();
                _txtFirmadi.Clear();
                _txtYetkili.Clear();
                _txtTel1.Clear();
                _txtTel2.Clear();
                _txtEposta.Clear();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            
            if (!admin)
            {
                _cmbBayiiler.Visible = false;
                label6.Visible = false;
            }
            GrupListele();
        }
    }
}
