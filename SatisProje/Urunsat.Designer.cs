namespace SatisProje
{
    partial class Urunsat
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
            this.btn_UrunsatKaydet = new System.Windows.Forms.Button();
            this.grd_Urunsat = new System.Windows.Forms.DataGridView();
            this.tb_UrunsatAciklama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_UrunsatPesinodenen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_UrunsatBirimfiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_UrunsatMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_UrunsatBirimalttipi = new System.Windows.Forms.ComboBox();
            this.cmb_UrunsatBirimtipi = new System.Windows.Forms.ComboBox();
            this.cmb_UrunsatTedarikci = new System.Windows.Forms.ComboBox();
            this.cmb_UrunsatUrunadi = new System.Windows.Forms.ComboBox();
            this.cmb_UrunsatKategori = new System.Windows.Forms.ComboBox();
            this.dt_UrunsatTarih = new System.Windows.Forms.DateTimePicker();
            this.tb_UrunsatToplamfiyat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_UrunsatListele = new System.Windows.Forms.Button();
            this.lbl_Urunsat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Urunsat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UrunsatKaydet
            // 
            this.btn_UrunsatKaydet.Location = new System.Drawing.Point(276, 443);
            this.btn_UrunsatKaydet.Name = "btn_UrunsatKaydet";
            this.btn_UrunsatKaydet.Size = new System.Drawing.Size(75, 41);
            this.btn_UrunsatKaydet.TabIndex = 45;
            this.btn_UrunsatKaydet.Text = "Kaydet";
            this.btn_UrunsatKaydet.UseVisualStyleBackColor = true;
            this.btn_UrunsatKaydet.Click += new System.EventHandler(this.btn_UrunsatKaydet_Click);
            // 
            // grd_Urunsat
            // 
            this.grd_Urunsat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Urunsat.Location = new System.Drawing.Point(387, 56);
            this.grd_Urunsat.Name = "grd_Urunsat";
            this.grd_Urunsat.RowTemplate.Height = 24;
            this.grd_Urunsat.Size = new System.Drawing.Size(771, 428);
            this.grd_Urunsat.TabIndex = 44;
            // 
            // tb_UrunsatAciklama
            // 
            this.tb_UrunsatAciklama.Location = new System.Drawing.Point(164, 358);
            this.tb_UrunsatAciklama.Multiline = true;
            this.tb_UrunsatAciklama.Name = "tb_UrunsatAciklama";
            this.tb_UrunsatAciklama.Size = new System.Drawing.Size(187, 63);
            this.tb_UrunsatAciklama.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Açıklama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tarih";
            // 
            // tb_UrunsatPesinodenen
            // 
            this.tb_UrunsatPesinodenen.Location = new System.Drawing.Point(164, 302);
            this.tb_UrunsatPesinodenen.Name = "tb_UrunsatPesinodenen";
            this.tb_UrunsatPesinodenen.Size = new System.Drawing.Size(184, 22);
            this.tb_UrunsatPesinodenen.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Peşin Ödenen";
            // 
            // tb_UrunsatBirimfiyat
            // 
            this.tb_UrunsatBirimfiyat.Location = new System.Drawing.Point(167, 230);
            this.tb_UrunsatBirimfiyat.Name = "tb_UrunsatBirimfiyat";
            this.tb_UrunsatBirimfiyat.Size = new System.Drawing.Size(184, 22);
            this.tb_UrunsatBirimfiyat.TabIndex = 37;
            this.tb_UrunsatBirimfiyat.TextChanged += new System.EventHandler(this.tb_UrunsatBirimfiyat_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Birim Fiyat";
            // 
            // tb_UrunsatMiktar
            // 
            this.tb_UrunsatMiktar.Location = new System.Drawing.Point(167, 202);
            this.tb_UrunsatMiktar.Name = "tb_UrunsatMiktar";
            this.tb_UrunsatMiktar.Size = new System.Drawing.Size(184, 22);
            this.tb_UrunsatMiktar.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Birim Alt Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Birim Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Müşteri Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ürün adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "ÜRÜN SATMA EKRANI";
            // 
            // cmb_UrunsatBirimalttipi
            // 
            this.cmb_UrunsatBirimalttipi.FormattingEnabled = true;
            this.cmb_UrunsatBirimalttipi.Location = new System.Drawing.Point(167, 174);
            this.cmb_UrunsatBirimalttipi.Name = "cmb_UrunsatBirimalttipi";
            this.cmb_UrunsatBirimalttipi.Size = new System.Drawing.Size(181, 24);
            this.cmb_UrunsatBirimalttipi.TabIndex = 50;
            this.cmb_UrunsatBirimalttipi.SelectedIndexChanged += new System.EventHandler(this.cmb_UrunsatBirimalttipi_SelectedIndexChanged);
            // 
            // cmb_UrunsatBirimtipi
            // 
            this.cmb_UrunsatBirimtipi.Enabled = false;
            this.cmb_UrunsatBirimtipi.FormattingEnabled = true;
            this.cmb_UrunsatBirimtipi.Location = new System.Drawing.Point(167, 146);
            this.cmb_UrunsatBirimtipi.Name = "cmb_UrunsatBirimtipi";
            this.cmb_UrunsatBirimtipi.Size = new System.Drawing.Size(181, 24);
            this.cmb_UrunsatBirimtipi.TabIndex = 49;
            this.cmb_UrunsatBirimtipi.SelectedIndexChanged += new System.EventHandler(this.cmb_UrunsatBirimtipi_SelectedIndexChanged);
            // 
            // cmb_UrunsatTedarikci
            // 
            this.cmb_UrunsatTedarikci.FormattingEnabled = true;
            this.cmb_UrunsatTedarikci.Location = new System.Drawing.Point(167, 118);
            this.cmb_UrunsatTedarikci.Name = "cmb_UrunsatTedarikci";
            this.cmb_UrunsatTedarikci.Size = new System.Drawing.Size(181, 24);
            this.cmb_UrunsatTedarikci.TabIndex = 48;
            this.cmb_UrunsatTedarikci.SelectedIndexChanged += new System.EventHandler(this.cmb_UrunsatTedarikci_SelectedIndexChanged);
            // 
            // cmb_UrunsatUrunadi
            // 
            this.cmb_UrunsatUrunadi.FormattingEnabled = true;
            this.cmb_UrunsatUrunadi.Location = new System.Drawing.Point(167, 87);
            this.cmb_UrunsatUrunadi.Name = "cmb_UrunsatUrunadi";
            this.cmb_UrunsatUrunadi.Size = new System.Drawing.Size(181, 24);
            this.cmb_UrunsatUrunadi.TabIndex = 47;
            this.cmb_UrunsatUrunadi.SelectedIndexChanged += new System.EventHandler(this.cmb_UrunsatUrunadi_SelectedIndexChanged_1);
            // 
            // cmb_UrunsatKategori
            // 
            this.cmb_UrunsatKategori.FormattingEnabled = true;
            this.cmb_UrunsatKategori.Location = new System.Drawing.Point(167, 59);
            this.cmb_UrunsatKategori.Name = "cmb_UrunsatKategori";
            this.cmb_UrunsatKategori.Size = new System.Drawing.Size(181, 24);
            this.cmb_UrunsatKategori.TabIndex = 46;
            this.cmb_UrunsatKategori.SelectedIndexChanged += new System.EventHandler(this.cmb_UrunsatKategori_SelectedIndexChanged);
            // 
            // dt_UrunsatTarih
            // 
            this.dt_UrunsatTarih.Location = new System.Drawing.Point(151, 330);
            this.dt_UrunsatTarih.Name = "dt_UrunsatTarih";
            this.dt_UrunsatTarih.Size = new System.Drawing.Size(200, 22);
            this.dt_UrunsatTarih.TabIndex = 51;
            // 
            // tb_UrunsatToplamfiyat
            // 
            this.tb_UrunsatToplamfiyat.Enabled = false;
            this.tb_UrunsatToplamfiyat.Location = new System.Drawing.Point(167, 266);
            this.tb_UrunsatToplamfiyat.Name = "tb_UrunsatToplamfiyat";
            this.tb_UrunsatToplamfiyat.Size = new System.Drawing.Size(181, 22);
            this.tb_UrunsatToplamfiyat.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Toplam Fiyat";
            // 
            // btn_UrunsatListele
            // 
            this.btn_UrunsatListele.Location = new System.Drawing.Point(167, 443);
            this.btn_UrunsatListele.Name = "btn_UrunsatListele";
            this.btn_UrunsatListele.Size = new System.Drawing.Size(75, 41);
            this.btn_UrunsatListele.TabIndex = 54;
            this.btn_UrunsatListele.Text = "Listele";
            this.btn_UrunsatListele.UseVisualStyleBackColor = true;
            this.btn_UrunsatListele.Click += new System.EventHandler(this.btn_UrunsatListele_Click);
            // 
            // lbl_Urunsat
            // 
            this.lbl_Urunsat.AutoSize = true;
            this.lbl_Urunsat.Location = new System.Drawing.Point(48, 455);
            this.lbl_Urunsat.Name = "lbl_Urunsat";
            this.lbl_Urunsat.Size = new System.Drawing.Size(37, 17);
            this.lbl_Urunsat.TabIndex = 55;
            this.lbl_Urunsat.Text = "Borç";
            // 
            // Urunsat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 529);
            this.Controls.Add(this.lbl_Urunsat);
            this.Controls.Add(this.btn_UrunsatListele);
            this.Controls.Add(this.tb_UrunsatToplamfiyat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dt_UrunsatTarih);
            this.Controls.Add(this.cmb_UrunsatBirimalttipi);
            this.Controls.Add(this.cmb_UrunsatBirimtipi);
            this.Controls.Add(this.cmb_UrunsatTedarikci);
            this.Controls.Add(this.cmb_UrunsatUrunadi);
            this.Controls.Add(this.cmb_UrunsatKategori);
            this.Controls.Add(this.btn_UrunsatKaydet);
            this.Controls.Add(this.grd_Urunsat);
            this.Controls.Add(this.tb_UrunsatAciklama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_UrunsatPesinodenen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_UrunsatBirimfiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_UrunsatMiktar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Urunsat";
            this.Text = "Urunsat";
            this.Load += new System.EventHandler(this.Urunsat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Urunsat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UrunsatKaydet;
        private System.Windows.Forms.DataGridView grd_Urunsat;
        private System.Windows.Forms.TextBox tb_UrunsatAciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_UrunsatPesinodenen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_UrunsatBirimfiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_UrunsatMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_UrunsatBirimalttipi;
        private System.Windows.Forms.ComboBox cmb_UrunsatBirimtipi;
        private System.Windows.Forms.ComboBox cmb_UrunsatTedarikci;
        private System.Windows.Forms.ComboBox cmb_UrunsatUrunadi;
        private System.Windows.Forms.ComboBox cmb_UrunsatKategori;
        private System.Windows.Forms.DateTimePicker dt_UrunsatTarih;
        private System.Windows.Forms.TextBox tb_UrunsatToplamfiyat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_UrunsatListele;
        private System.Windows.Forms.Label lbl_Urunsat;
    }
}