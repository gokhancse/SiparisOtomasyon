namespace SiparisYonetim.Kategori_Formu
{
    partial class Kategoriler
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
            this._datakategori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._datakategori)).BeginInit();
            this.SuspendLayout();
            // 
            // _datakategori
            // 
            this._datakategori.AllowUserToAddRows = false;
            this._datakategori.AllowUserToDeleteRows = false;
            this._datakategori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._datakategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._datakategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._datakategori.Location = new System.Drawing.Point(23, 92);
            this._datakategori.Name = "_datakategori";
            this._datakategori.Size = new System.Drawing.Size(755, 266);
            this._datakategori.TabIndex = 3;
            this._datakategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._datakategori_CellDoubleClick);
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._datakategori);
            this.Name = "Kategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this._datakategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _datakategori;
    }
}