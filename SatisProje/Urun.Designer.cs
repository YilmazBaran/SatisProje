namespace SatisProje
{
    partial class Urun
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
            this.btn_UrunListele = new System.Windows.Forms.Button();
            this.btn_UrunDuzelt = new System.Windows.Forms.Button();
            this.tb_UrunUyarilimiti = new System.Windows.Forms.TextBox();
            this.cmb_UrunKategoriadi = new System.Windows.Forms.ComboBox();
            this.cmb_UrunBirimTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grd_Urun = new System.Windows.Forms.DataGridView();
            this.btn_UrunKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_UrunAdi = new System.Windows.Forms.TextBox();
            this.tb_UrunKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_UrunKayitdurumu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Urun)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UrunListele
            // 
            this.btn_UrunListele.Location = new System.Drawing.Point(159, 434);
            this.btn_UrunListele.Name = "btn_UrunListele";
            this.btn_UrunListele.Size = new System.Drawing.Size(75, 36);
            this.btn_UrunListele.TabIndex = 49;
            this.btn_UrunListele.Text = "Listele";
            this.btn_UrunListele.UseVisualStyleBackColor = true;
            this.btn_UrunListele.Click += new System.EventHandler(this.btn_UrunListele_Click);
            // 
            // btn_UrunDuzelt
            // 
            this.btn_UrunDuzelt.Location = new System.Drawing.Point(253, 434);
            this.btn_UrunDuzelt.Name = "btn_UrunDuzelt";
            this.btn_UrunDuzelt.Size = new System.Drawing.Size(75, 36);
            this.btn_UrunDuzelt.TabIndex = 47;
            this.btn_UrunDuzelt.Text = "Duzelt";
            this.btn_UrunDuzelt.UseVisualStyleBackColor = true;
            this.btn_UrunDuzelt.Click += new System.EventHandler(this.btn_UrunDuzelt_Click);
            // 
            // tb_UrunUyarilimiti
            // 
            this.tb_UrunUyarilimiti.Location = new System.Drawing.Point(189, 277);
            this.tb_UrunUyarilimiti.Name = "tb_UrunUyarilimiti";
            this.tb_UrunUyarilimiti.Size = new System.Drawing.Size(200, 22);
            this.tb_UrunUyarilimiti.TabIndex = 44;
            // 
            // cmb_UrunKategoriadi
            // 
            this.cmb_UrunKategoriadi.FormattingEnabled = true;
            this.cmb_UrunKategoriadi.Location = new System.Drawing.Point(189, 217);
            this.cmb_UrunKategoriadi.Name = "cmb_UrunKategoriadi";
            this.cmb_UrunKategoriadi.Size = new System.Drawing.Size(200, 24);
            this.cmb_UrunKategoriadi.TabIndex = 43;
            // 
            // cmb_UrunBirimTipi
            // 
            this.cmb_UrunBirimTipi.FormattingEnabled = true;
            this.cmb_UrunBirimTipi.Location = new System.Drawing.Point(189, 332);
            this.cmb_UrunBirimTipi.Name = "cmb_UrunBirimTipi";
            this.cmb_UrunBirimTipi.Size = new System.Drawing.Size(200, 24);
            this.cmb_UrunBirimTipi.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(70, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 41;
            this.label6.Text = "URUN EKRANI";
            // 
            // grd_Urun
            // 
            this.grd_Urun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Urun.Location = new System.Drawing.Point(442, 79);
            this.grd_Urun.Name = "grd_Urun";
            this.grd_Urun.RowTemplate.Height = 24;
            this.grd_Urun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Urun.Size = new System.Drawing.Size(704, 391);
            this.grd_Urun.TabIndex = 40;
            this.grd_Urun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Urun_CellDoubleClick);
            // 
            // btn_UrunKaydet
            // 
            this.btn_UrunKaydet.Location = new System.Drawing.Point(334, 434);
            this.btn_UrunKaydet.Name = "btn_UrunKaydet";
            this.btn_UrunKaydet.Size = new System.Drawing.Size(75, 36);
            this.btn_UrunKaydet.TabIndex = 39;
            this.btn_UrunKaydet.Text = "Kaydet";
            this.btn_UrunKaydet.UseVisualStyleBackColor = true;
            this.btn_UrunKaydet.Click += new System.EventHandler(this.btn_UrunKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Birim tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Uyarı Limiti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kodu";
            // 
            // tb_UrunAdi
            // 
            this.tb_UrunAdi.Location = new System.Drawing.Point(189, 165);
            this.tb_UrunAdi.Name = "tb_UrunAdi";
            this.tb_UrunAdi.Size = new System.Drawing.Size(200, 22);
            this.tb_UrunAdi.TabIndex = 50;
            // 
            // tb_UrunKodu
            // 
            this.tb_UrunKodu.Location = new System.Drawing.Point(189, 114);
            this.tb_UrunKodu.Name = "tb_UrunKodu";
            this.tb_UrunKodu.Size = new System.Drawing.Size(200, 22);
            this.tb_UrunKodu.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Kategori_Adı";
            // 
            // cmb_UrunKayitdurumu
            // 
            this.cmb_UrunKayitdurumu.FormattingEnabled = true;
            this.cmb_UrunKayitdurumu.Location = new System.Drawing.Point(189, 377);
            this.cmb_UrunKayitdurumu.Name = "cmb_UrunKayitdurumu";
            this.cmb_UrunKayitdurumu.Size = new System.Drawing.Size(200, 24);
            this.cmb_UrunKayitdurumu.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Kayıt Durumu";
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 528);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_UrunKayitdurumu);
            this.Controls.Add(this.tb_UrunKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_UrunAdi);
            this.Controls.Add(this.btn_UrunListele);
            this.Controls.Add(this.btn_UrunDuzelt);
            this.Controls.Add(this.tb_UrunUyarilimiti);
            this.Controls.Add(this.cmb_UrunKategoriadi);
            this.Controls.Add(this.cmb_UrunBirimTipi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grd_Urun);
            this.Controls.Add(this.btn_UrunKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Urun";
            this.Text = "Urun";
            this.Load += new System.EventHandler(this.Urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Urun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UrunListele;
        private System.Windows.Forms.Button btn_UrunDuzelt;
        private System.Windows.Forms.TextBox tb_UrunUyarilimiti;
        private System.Windows.Forms.ComboBox cmb_UrunKategoriadi;
        private System.Windows.Forms.ComboBox cmb_UrunBirimTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grd_Urun;
        private System.Windows.Forms.Button btn_UrunKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_UrunAdi;
        private System.Windows.Forms.TextBox tb_UrunKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_UrunKayitdurumu;
        private System.Windows.Forms.Label label7;
    }
}