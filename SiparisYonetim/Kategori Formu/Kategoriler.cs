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

namespace SiparisYonetim.Kategori_Formu
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        List<Kategori> kategorilers;
        public void Listele()
        {
            _datakategori.ColumnCount = 2;
            _datakategori.Columns[0].Name = "KOD";
            _datakategori.Columns[0].Visible = false;
            _datakategori.Columns[1].Name = "KATEGORİLER";
            DB_Context db = new DB_Context();
            _datakategori.Rows.Clear();
            ArrayList row = new ArrayList();
            kategorilers = new List<Kategori>();

            var kategori = db.Kategoriler.Select(x => x).ToList();

            foreach (var item in kategori)
            {
                row = new ArrayList();
                row.Add(item.KategoriId);
                row.Add(item.KategoriAdi);

                //_dataMusteri.Rows.Add(
                //    item.SirketId,
                //    item.SirketAdi,
                //    item.Yetkili,
                //    item.Telefon,
                //    item.Telefon2,
                //    item.Eposta);

                _datakategori.Rows.Add(row.ToArray());
                kategorilers.Add(item);
            }

        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void _datakategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int duzenleid = Convert.ToInt32
        (_datakategori.Rows[_datakategori.CurrentRow.Index].Cells["KOD"].Value);

            //int duzenleid = (int)_dataMusteri.SelectedRows[0].Cells[0].Value;
            KategoriDuzenle md = new KategoriDuzenle();
            md.Kod = duzenleid;
            md.Kategori = Convert.ToString(_datakategori.Rows[_datakategori.CurrentRow.Index].Cells["KATEGORİLER"].Value);

            md.ShowDialog();
            Listele();
        }
    }
}
