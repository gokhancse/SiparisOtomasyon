namespace SiparisYonetim.Müşteriler_Formu
{
    partial class Musteriler
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
            this._btnMusteriEkle = new System.Windows.Forms.Button();
            this._dataMusteri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._dataMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnMusteriEkle
            // 
            this._btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnMusteriEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this._btnMusteriEkle.Location = new System.Drawing.Point(298, 27);
            this._btnMusteriEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnMusteriEkle.Name = "_btnMusteriEkle";
            this._btnMusteriEkle.Size = new System.Drawing.Size(121, 43);
            this._btnMusteriEkle.TabIndex = 20;
            this._btnMusteriEkle.Text = "Müşteri Ekle";
            this._btnMusteriEkle.UseVisualStyleBackColor = true;
            this._btnMusteriEkle.Click += new System.EventHandler(this._btnMusteriEkle_Click);
            // 
            // _dataMusteri
            // 
            this._dataMusteri.AllowUserToAddRows = false;
            this._dataMusteri.AllowUserToDeleteRows = false;
            this._dataMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataMusteri.Location = new System.Drawing.Point(23, 98);
            this._dataMusteri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._dataMusteri.Name = "_dataMusteri";
            this._dataMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataMusteri.Size = new System.Drawing.Size(652, 214);
            this._dataMusteri.TabIndex = 19;
            this._dataMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataMusteri_CellDoubleClick);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 326);
            this.Controls.Add(this._btnMusteriEkle);
            this.Controls.Add(this._dataMusteri);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnMusteriEkle;
        private System.Windows.Forms.DataGridView _dataMusteri;
    }
}