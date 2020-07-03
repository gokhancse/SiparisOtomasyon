using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetim.Urunler
{
    public partial class ResimGor : Form
    {
        public ResimGor()
        {
            InitializeComponent();
        }
        public string ResimAdi { get; set; }
        DB_Context db = new DB_Context();
        private void ResimGor_Load(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath;

            pictureBox1.Image = Image.FromFile(dizin + "\\resimler\\" + ResimAdi);
            //pictureBox1.ImageLocation = ResimAdi;
        }
    }
}
