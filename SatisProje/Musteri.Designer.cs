namespace SatisProje
{
    partial class Musteri
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MusteriKodu = new System.Windows.Forms.TextBox();
            this.tb_MusteriYetkilikisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MusteriTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MusteriEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grd_Musteri = new System.Windows.Forms.DataGridView();
            this.tb_MusteriAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_MusteriKaydet = new System.Windows.Forms.Button();
            this.btn_MusteriListele = new System.Windows.Forms.Button();
            this.btn_MusteriDuzelt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_MusteriKayitdurumu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Musteri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kodu";
            // 
            // tb_MusteriKodu
            // 
            this.tb_MusteriKodu.Location = new System.Drawing.Point(166, 36);
            this.tb_MusteriKodu.Name = "tb_MusteriKodu";
            this.tb_MusteriKodu.Size = new System.Drawing.Size(255, 22);
            this.tb_MusteriKodu.TabIndex = 1;
            // 
            // tb_MusteriYetkilikisi
            // 
            this.tb_MusteriYetkilikisi.Location = new System.Drawing.Point(166, 79);
            this.tb_MusteriYetkilikisi.Name = "tb_MusteriYetkilikisi";
            this.tb_MusteriYetkilikisi.Size = new System.Drawing.Size(255, 22);
            this.tb_MusteriYetkilikisi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yetkili kişi";
            // 
            // tb_MusteriTelefon
            // 
            this.tb_MusteriTelefon.Location = new System.Drawing.Point(166, 166);
            this.tb_MusteriTelefon.Name = "tb_MusteriTelefon";
            this.tb_MusteriTelefon.Size = new System.Drawing.Size(255, 22);
            this.tb_MusteriTelefon.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // tb_MusteriEmail
            // 
            this.tb_MusteriEmail.Location = new System.Drawing.Point(166, 123);
            this.tb_MusteriEmail.Name = "tb_MusteriEmail";
            this.tb_MusteriEmail.Size = new System.Drawing.Size(255, 22);
            this.tb_MusteriEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon";
            // 
            // grd_Musteri
            // 
            this.grd_Musteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Musteri.Location = new System.Drawing.Point(452, 36);
            this.grd_Musteri.Name = "grd_Musteri";
            this.grd_Musteri.RowTemplate.Height = 24;
            this.grd_Musteri.Size = new System.Drawing.Size(660, 444);
            this.grd_Musteri.TabIndex = 8;
            this.grd_Musteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Musteri_CellContentClick);
            this.grd_Musteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Musteri_CellDoubleClick);
            // 
            // tb_MusteriAdres
            // 
            this.tb_MusteriAdres.Location = new System.Drawing.Point(166, 262);
            this.tb_MusteriAdres.Multiline = true;
            this.tb_MusteriAdres.Name = "tb_MusteriAdres";
            this.tb_MusteriAdres.Size = new System.Drawing.Size(255, 115);
            this.tb_MusteriAdres.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adres";
            // 
            // btn_MusteriKaydet
            // 
            this.btn_MusteriKaydet.Location = new System.Drawing.Point(346, 434);
            this.btn_MusteriKaydet.Name = "btn_MusteriKaydet";
            this.btn_MusteriKaydet.Size = new System.Drawing.Size(75, 46);
            this.btn_MusteriKaydet.TabIndex = 11;
            this.btn_MusteriKaydet.Text = "Kaydet";
            this.btn_MusteriKaydet.UseVisualStyleBackColor = true;
            this.btn_MusteriKaydet.Click += new System.EventHandler(this.btn_MusteriKaydet_Click);
            // 
            // btn_MusteriListele
            // 
            this.btn_MusteriListele.Location = new System.Drawing.Point(166, 434);
            this.btn_MusteriListele.Name = "btn_MusteriListele";
            this.btn_MusteriListele.Size = new System.Drawing.Size(75, 46);
            this.btn_MusteriListele.TabIndex = 12;
            this.btn_MusteriListele.Text = "Listele";
            this.btn_MusteriListele.UseVisualStyleBackColor = true;
            this.btn_MusteriListele.Click += new System.EventHandler(this.btn_MusteriListele_Click);
            // 
            // btn_MusteriDuzelt
            // 
            this.btn_MusteriDuzelt.Location = new System.Drawing.Point(256, 434);
            this.btn_MusteriDuzelt.Name = "btn_MusteriDuzelt";
            this.btn_MusteriDuzelt.Size = new System.Drawing.Size(75, 46);
            this.btn_MusteriDuzelt.TabIndex = 14;
            this.btn_MusteriDuzelt.Text = "Düzelt";
            this.btn_MusteriDuzelt.UseVisualStyleBackColor = true;
            this.btn_MusteriDuzelt.Click += new System.EventHandler(this.btn_MusteriDuzelt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Kayıt Durumu";
            // 
            // cmb_MusteriKayitdurumu
            // 
            this.cmb_MusteriKayitdurumu.FormattingEnabled = true;
            this.cmb_MusteriKayitdurumu.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmb_MusteriKayitdurumu.Location = new System.Drawing.Point(166, 209);
            this.cmb_MusteriKayitdurumu.Name = "cmb_MusteriKayitdurumu";
            this.cmb_MusteriKayitdurumu.Size = new System.Drawing.Size(254, 24);
            this.cmb_MusteriKayitdurumu.TabIndex = 55;
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 522);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_MusteriKayitdurumu);
            this.Controls.Add(this.btn_MusteriDuzelt);
            this.Controls.Add(this.btn_MusteriListele);
            this.Controls.Add(this.btn_MusteriKaydet);
            this.Controls.Add(this.tb_MusteriAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grd_Musteri);
            this.Controls.Add(this.tb_MusteriTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_MusteriEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_MusteriYetkilikisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MusteriKodu);
            this.Controls.Add(this.label1);
            this.Name = "Musteri";
            this.Text = "Musteri";
            this.Load += new System.EventHandler(this.Musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Musteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MusteriKodu;
        private System.Windows.Forms.TextBox tb_MusteriYetkilikisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MusteriTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MusteriEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grd_Musteri;
        private System.Windows.Forms.TextBox tb_MusteriAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_MusteriKaydet;
        private System.Windows.Forms.Button btn_MusteriListele;
        private System.Windows.Forms.Button btn_MusteriDuzelt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_MusteriKayitdurumu;
    }
}