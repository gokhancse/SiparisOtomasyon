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
using SiparisYonetim.Helpers;
using SiparisYonetim.Tablolar;

namespace SiparisYonetim.Müşteriler_Formu
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        List<Sirket> Sirketler;
        public void Listele()
        {
            _dataMusteri.ColumnCount = 6;
            _dataMusteri.Columns[0].Name = "KOD";
            _dataMusteri.Columns[1].Name = "FİRMA";
            _dataMusteri.Columns[2].Name = "YETKİLİ";
            _dataMusteri.Columns[3].Name = "TELEFON1";
            _dataMusteri.Columns[4].Name = "TELEFON2";
            _dataMusteri.Columns[5].Name = "E-POSTA";
            DB_Context db = new DB_Context();
            _dataMusteri.Rows.Clear();
            ArrayList row = new ArrayList();
            Sirketler = new List<Sirket>();

            var sirket = db.Sirketler.Where(x => x.UstSirketId == Oturum.User.SirketId).ToList();

            foreach (var item in sirket)
            {
                row = new ArrayList();
                row.Add(item.SirketId);
                row.Add(item.SirketAdi);
                row.Add(item.Yetkili);
                row.Add(item.Telefon);
                row.Add(item.Telefon2);
                row.Add(item.Eposta);
                //_dataMusteri.Rows.Add(
                //    item.SirketId,
                //    item.SirketAdi,
                //    item.Yetkili,
                //    item.Telefon,
                //    item.Telefon2,
                //    item.Eposta);

                _dataMusteri.Rows.Add(row.ToArray());
                Sirketler.Add(item);
            }

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void _btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle ekle = new MusteriEkle();
            ekle.ShowDialog();
            Listele();
        }

        private void _dataMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int duzenleid = Convert.ToInt32
                      (_dataMusteri.Rows[_dataMusteri.CurrentRow.Index].Cells["KOD"].Value);

            //int duzenleid = (int)_dataMusteri.SelectedRows[0].Cells[0].Value;
            MusteriDuzenle md = new MusteriDuzenle();
            md.MusteriDuzenleId = duzenleid;
            md.Guncelle = true;
            md.Firmaadi = Convert.ToString(_dataMusteri.Rows[_dataMusteri.CurrentRow.Index].Cells["FİRMA"].Value);
            md.Yetkili = Convert.ToString(_dataMusteri.Rows[_dataMusteri.CurrentRow.Index].Cells["YETKİLİ"].Value);
            md.Telefon1 = Convert.ToString(_dataMusteri.Rows[_dataMusteri.CurrentRow.Index].Cells["TELEFON1"].Value);
            md.Telefon2 = Convert.ToString(_dataMusteri.Rows[_dataMusteri.CurrentRow.Index].Cells["TELEFON1"].Value);
            md.Eposta = Convert.ToString(_dataMusteri.Rows[_dataMusteri.CurrentRow.Index].Cells["E-POSTA"].Value);
            md.ShowDialog();
            Listele();
        }
    }
}
