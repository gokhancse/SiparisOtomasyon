using SiparisYonetim;
using SiparisYonetim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetim
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        void Giris()
        {
                DB_Context db = new DB_Context();
                var User = db.Kullanicilar.FirstOrDefault(x => x.K_Adi == _Kullanici.Text && x.Parola == _parola.Text);
                if (User == null)
                {
                    MessageBox.Show("Lütfen kullanıcı adınızı ve parolanızı kontrol edip, tekrar deneyiniz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Oturum.User = User;
                var sirket = db.Sirketler.FirstOrDefault(x => x.SirketId == Oturum.User.SirketId);
                Oturum.Sirket = sirket;
                this.Hide();
                Menu FA = new Menu();
                FA.ShowDialog();
                Application.Exit();
        }

        private void GirisYap_Click(object sender, EventArgs e)
        {
            Giris();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
