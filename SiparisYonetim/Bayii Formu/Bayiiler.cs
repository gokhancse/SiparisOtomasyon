using SiparisYonetim.Tablolar;
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

namespace SiparisYonetim.Bayii_Formu
{
    public partial class Bayiiler : Form
    {
        public Bayiiler()
        {
            InitializeComponent();
        }
        DB_Context db = new DB_Context();
        public void GrupListele()
        {
            comboBox1.Items.Clear();


            db = new DB_Context();
            var kayit = db.Sirketler.Where(x => x.UstSirketId == 1).Select(x => x.SirketAdi);

            foreach (var item in kayit)
            {
                comboBox1.Items.Add(item);
            }

        }
        List<Sirket> Sirketler;
        public void Listele()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "KOD";
            dataGridView1.Columns[1].Name = "FİRMA";
            dataGridView1.Columns[2].Name = "YETKİLİ";
            dataGridView1.Columns[3].Name = "TELEFON1";
            dataGridView1.Columns[4].Name = "TELEFON2";
            dataGridView1.Columns[5].Name = "E-POSTA";

            dataGridView1.Rows.Clear();
            ArrayList row = new ArrayList();
            Sirketler = new List<Sirket>();
            int id = 0;
            var kayit = db.Sirketler.Where(x => x.SirketAdi == comboBox1.Text);
            foreach (var item in kayit)
            {
                id = item.SirketId;
            }

            var sirket = db.Sirketler.Where(x => x.UstSirketId == id).ToList();

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

                dataGridView1.Rows.Add(row.ToArray());
                Sirketler.Add(item);
            }

        }

        private void Bayiiler_Load(object sender, EventArgs e)
        {
            GrupListele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbayiekle_Click(object sender, EventArgs e)
        {
            BayiiEkle bayi = new BayiiEkle();
            bayi.ShowDialog();
            Listele();
        }
    }
}
