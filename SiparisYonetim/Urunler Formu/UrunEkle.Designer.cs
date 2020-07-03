namespace SiparisYonetim.Urunler_Formu
{
    partial class UrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._btnKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._cmbKategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtDetay = new System.Windows.Forms.TextBox();
            this._txtGram = new System.Windows.Forms.TextBox();
            this._txtUrunkod = new System.Windows.Forms.TextBox();
            this._chkYeniUrun = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _btnKaydet
            // 
            this._btnKaydet.Location = new System.Drawing.Point(11, 421);
            this._btnKaydet.Name = "_btnKaydet";
            this._btnKaydet.Size = new System.Drawing.Size(122, 45);
            this._btnKaydet.TabIndex = 20;
            this._btnKaydet.Text = "Kaydet";
            this._btnKaydet.UseVisualStyleBackColor = true;
            this._btnKaydet.Click += new System.EventHandler(this._btnKaydet_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dosya Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _cmbKategori
            // 
            this._cmbKategori.FormattingEnabled = true;
            this._cmbKategori.Location = new System.Drawing.Point(10, 173);
            this._cmbKategori.Name = "_cmbKategori";
            this._cmbKategori.Size = new System.Drawing.Size(317, 21);
            this._cmbKategori.TabIndex = 10;
            this._cmbKategori.SelectedIndexChanged += new System.EventHandler(this._cmbKategori_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miktar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Kodu:";
            // 
            // _txtDetay
            // 
            this._txtDetay.Location = new System.Drawing.Point(11, 318);
            this._txtDetay.Name = "_txtDetay";
            this._txtDetay.Size = new System.Drawing.Size(321, 20);
            this._txtDetay.TabIndex = 4;
            // 
            // _txtGram
            // 
            this._txtGram.Location = new System.Drawing.Point(10, 239);
            this._txtGram.Name = "_txtGram";
            this._txtGram.Size = new System.Drawing.Size(321, 20);
            this._txtGram.TabIndex = 2;
            // 
            // _txtUrunkod
            // 
            this._txtUrunkod.Location = new System.Drawing.Point(10, 112);
            this._txtUrunkod.Name = "_txtUrunkod";
            this._txtUrunkod.Size = new System.Drawing.Size(321, 20);
            this._txtUrunkod.TabIndex = 1;
            // 
            // _chkYeniUrun
            // 
            this._chkYeniUrun.AutoSize = true;
            this._chkYeniUrun.Location = new System.Drawing.Point(6, 45);
            this._chkYeniUrun.Name = "_chkYeniUrun";
            this._chkYeniUrun.Size = new System.Drawing.Size(73, 17);
            this._chkYeniUrun.TabIndex = 0;
            this._chkYeniUrun.Text = "Yeni Ürün";
            this._chkYeniUrun.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnKaydet);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this._cmbKategori);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtDetay);
            this.groupBox1.Controls.Add(this._txtGram);
            this.groupBox1.Controls.Add(this._txtUrunkod);
            this.groupBox1.Controls.Add(this._chkYeniUrun);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 485);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 540);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button _btnKaydet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox _cmbKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtDetay;
        private System.Windows.Forms.TextBox _txtGram;
        private System.Windows.Forms.TextBox _txtUrunkod;
        private System.Windows.Forms.CheckBox _chkYeniUrun;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}