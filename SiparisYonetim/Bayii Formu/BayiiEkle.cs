using SiparisYonetim.Müşteriler_Formu;
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

namespace SiparisYonetim.Bayii_Formu
{
    public partial class BayiiEkle : Form
    {
        public BayiiEkle()
        {
            InitializeComponent();
        }
        DB_Context db = new DB_Context();
        public void GrupListele()
        {
            _cmbMusteriler.Items.Clear();
            db = new DB_Context();
            var kayit = db.Sirketler.Where(x => x.UstSirketId == 3).Select(x => x.SirketAdi);

            foreach (var item in kayit)
            {
                _cmbMusteriler.Items.Add(item);
            }
        }

        private void BayiiEkle_Load(object sender, EventArgs e)
        {
            GrupListele();
        }

        private void _btnEkle_Click(object sender, EventArgs e)
        {
            if (_cmbMusteriler.Text == "")
            {
                MessageBox.Show("lütfen bayi seçiniz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                int id = 0;
                var kayit = db.Sirketler.Where(x => x.SirketAdi == _cmbMusteriler.Text);
                foreach (var item in kayit)
                {
                    id = item.SirketId;
                }

                Sirket sirket = new Sirket();
                sirket.SirketAdi = _txtFirmadi.Text;
                sirket.Yetkili = _txtYetkili.Text;
                sirket.Telefon = _txtTel1.Text;
                sirket.Telefon2 = _txtTel2.Text;
                sirket.Eposta = _txtEposta.Text;
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
        }
    }
}
