using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetim.Kategori_Formu
{
    public partial class KategoriDuzenle : Form
    {
        public KategoriDuzenle()
        {
            InitializeComponent();
        }
        public int? Kod { get; set; }
        public string Kategori { get; set; }

        DB_Context db = new DB_Context();

        private void button1_Click(object sender, EventArgs e)
        {
            db = new DB_Context();
            var kayit = db.Kategoriler.Single(x => x.KategoriId == Kod);
            kayit.KategoriAdi = textBox1.Text;

            db.SaveChanges();
            textBox1.Clear();

            MessageBox.Show("Kayıt Güncellendi.",
                      "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void KategoriDuzenle_Load(object sender, EventArgs e)
        {
            textBox1.Text = Kategori;
        }
    }
}
