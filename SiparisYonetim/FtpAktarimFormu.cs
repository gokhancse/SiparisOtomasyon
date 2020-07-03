using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetim
{
    public partial class FtpAktarimFormu : Form
    {
        public FtpAktarimFormu()
        {
            InitializeComponent();
        }
        void DosyaYukle()
        {
            try
            {
                FileInfo filei = new FileInfo(textEditYuklenecekDosya.Text);
                string adres = textEditYuklenecekLink.Text;
                string path = adres + filei.Name;
                progressBar2.Value += 5;
                FtpWebRequest FTP;
                FTP = (FtpWebRequest)FtpWebRequest.Create(path);
                FTP.Credentials = new NetworkCredential(textEditKullaniciAd.Text, textEditParola.Text);
                progressBar2.Value += 15;
                FTP.KeepAlive = false;
                FTP.Method = WebRequestMethods.Ftp.UploadFile;
                FTP.UseBinary = true;
                FTP.ContentLength = filei.Length;
                progressBar2.Value += 15;
                int buffLength = 1024;
                byte[] buff = new byte[buffLength];
                int contentLen;
                FileStream FS = filei.OpenRead();
                progressBar2.Value += 15;
                try
                {
                    Stream strm = FTP.GetRequestStream(); contentLen = FS.Read(buff, 0, buffLength); while (contentLen != 0)
                    {
                        strm.Write(buff, 0, contentLen); contentLen = FS.Read(buff, 0, buffLength);
                    }
                    progressBar2.Value += 50;
                    strm.Close();
                    FS.Close();
                    MessageBox.Show("Yükleme işlemi başarılı. Dosya " + path + " adresine yüklendi.");
                    progressBar2.Value = 0;
                }
                catch
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                progressBar2.Value = 0;
            }
        }
        private void FileDownload()
        {
            try
            {
                NetworkCredential credentials = new NetworkCredential(textEditKullaniciAd.Text, textEditParola.Text);

                WebRequest sizeRequest = WebRequest.Create(textEditDosyaLink.Text);
                sizeRequest.Credentials = credentials;
                sizeRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                int size = (int)sizeRequest.GetResponse().ContentLength;

                WebRequest request = WebRequest.Create(textEditDosyaLink.Text);
                request.Credentials = credentials;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                {
                    using (Stream fileStream = File.Create($"{Application.StartupPath}\\{"resimler.rar"}"))
                    {
                        byte[] buffer = new byte[10240];
                        int read;
                        while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, read);
                            int position = (int)fileStream.Position;
                        }
                    }
                }
                MessageBox.Show("DOSYA İNDİRİLDİ LÜTFEN RARDAN ÇIKARTINIZ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RarCikar()
        {
            string yol = Application.StartupPath;
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("Winrar.exe", "e " + yol + "\\resimler.rar  " + yol + "\\resimler\\");
            p.Start();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textEditYuklenecekDosya.Text = openFileDialog1.FileName;
        }
        private void FtpAktarim_Load(object sender, EventArgs e)
        {
            string yol = Application.StartupPath;
            textEditKayitYeri.Text = yol;
            textEditYuklenecekLink.Text = ""; // FTP Adresi 
            textBox1.Text = ""; // IP adresi
            textEditKullaniciAd.Text = ""; // mail adresi
            textEditParola.Text = ""; // parola
            textEditDosyaLink.Text = ""; // IP Adresi dosya ismi
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FileDownload();
            RarCikar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DosyaYukle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void FtpAktarimFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
