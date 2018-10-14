namespace SatisProje
{
    partial class Tedarikci
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
            this.btn_TedarikciKaydet = new System.Windows.Forms.Button();
            this.tb_TedarikciAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grd_Tedarikci = new System.Windows.Forms.DataGridView();
            this.tb_TedarikciTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TedarikciEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TedarikciYetkilikisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TedarikciKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TedarikciDuzelt = new System.Windows.Forms.Button();
            this.btn_TedarikciListele = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_TedarikciKayitdurumu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Tedarikci)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TedarikciKaydet
            // 
            this.btn_TedarikciKaydet.Location = new System.Drawing.Point(358, 428);
            this.btn_TedarikciKaydet.Name = "btn_TedarikciKaydet";
            this.btn_TedarikciKaydet.Size = new System.Drawing.Size(75, 46);
            this.btn_TedarikciKaydet.TabIndex = 23;
            this.btn_TedarikciKaydet.Text = "Kaydet";
            this.btn_TedarikciKaydet.UseVisualStyleBackColor = true;
            this.btn_TedarikciKaydet.Click += new System.EventHandler(this.btn_TedarikciKaydet_Click);
            // 
            // tb_TedarikciAdres
            // 
            this.tb_TedarikciAdres.Location = new System.Drawing.Point(178, 278);
            this.tb_TedarikciAdres.Multiline = true;
            this.tb_TedarikciAdres.Name = "tb_TedarikciAdres";
            this.tb_TedarikciAdres.Size = new System.Drawing.Size(255, 115);
            this.tb_TedarikciAdres.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Adres";
            // 
            // grd_Tedarikci
            // 
            this.grd_Tedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Tedarikci.Location = new System.Drawing.Point(464, 30);
            this.grd_Tedarikci.Name = "grd_Tedarikci";
            this.grd_Tedarikci.RowTemplate.Height = 24;
            this.grd_Tedarikci.Size = new System.Drawing.Size(660, 444);
            this.grd_Tedarikci.TabIndex = 20;
            this.grd_Tedarikci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Tedarikci_CellDoubleClick);
            // 
            // tb_TedarikciTelefon
            // 
            this.tb_TedarikciTelefon.Location = new System.Drawing.Point(178, 157);
            this.tb_TedarikciTelefon.Name = "tb_TedarikciTelefon";
            this.tb_TedarikciTelefon.Size = new System.Drawing.Size(255, 22);
            this.tb_TedarikciTelefon.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // tb_TedarikciEmail
            // 
            this.tb_TedarikciEmail.Location = new System.Drawing.Point(178, 117);
            this.tb_TedarikciEmail.Name = "tb_TedarikciEmail";
            this.tb_TedarikciEmail.Size = new System.Drawing.Size(255, 22);
            this.tb_TedarikciEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefon";
            // 
            // tb_TedarikciYetkilikisi
            // 
            this.tb_TedarikciYetkilikisi.Location = new System.Drawing.Point(178, 77);
            this.tb_TedarikciYetkilikisi.Name = "tb_TedarikciYetkilikisi";
            this.tb_TedarikciYetkilikisi.Size = new System.Drawing.Size(255, 22);
            this.tb_TedarikciYetkilikisi.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Yetkili kişi";
            // 
            // tb_TedarikciKodu
            // 
            this.tb_TedarikciKodu.Location = new System.Drawing.Point(178, 37);
            this.tb_TedarikciKodu.Name = "tb_TedarikciKodu";
            this.tb_TedarikciKodu.Size = new System.Drawing.Size(255, 22);
            this.tb_TedarikciKodu.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kodu";
            // 
            // btn_TedarikciDuzelt
            // 
            this.btn_TedarikciDuzelt.Location = new System.Drawing.Point(268, 428);
            this.btn_TedarikciDuzelt.Name = "btn_TedarikciDuzelt";
            this.btn_TedarikciDuzelt.Size = new System.Drawing.Size(75, 46);
            this.btn_TedarikciDuzelt.TabIndex = 26;
            this.btn_TedarikciDuzelt.Text = "Düzelt";
            this.btn_TedarikciDuzelt.UseVisualStyleBackColor = true;
            this.btn_TedarikciDuzelt.Click += new System.EventHandler(this.btn_TedarikciDuzelt_Click);
            // 
            // btn_TedarikciListele
            // 
            this.btn_TedarikciListele.Location = new System.Drawing.Point(178, 428);
            this.btn_TedarikciListele.Name = "btn_TedarikciListele";
            this.btn_TedarikciListele.Size = new System.Drawing.Size(75, 46);
            this.btn_TedarikciListele.TabIndex = 24;
            this.btn_TedarikciListele.Text = "Listele";
            this.btn_TedarikciListele.UseVisualStyleBackColor = true;
            this.btn_TedarikciListele.Click += new System.EventHandler(this.btn_TedarikciListele_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Kayıt Durumu";
            // 
            // cmb_TedarikciKayitdurumu
            // 
            this.cmb_TedarikciKayitdurumu.FormattingEnabled = true;
            this.cmb_TedarikciKayitdurumu.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmb_TedarikciKayitdurumu.Location = new System.Drawing.Point(178, 208);
            this.cmb_TedarikciKayitdurumu.Name = "cmb_TedarikciKayitdurumu";
            this.cmb_TedarikciKayitdurumu.Size = new System.Drawing.Size(254, 24);
            this.cmb_TedarikciKayitdurumu.TabIndex = 55;
            // 
            // Tedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_TedarikciKayitdurumu);
            this.Controls.Add(this.btn_TedarikciDuzelt);
            this.Controls.Add(this.btn_TedarikciListele);
            this.Controls.Add(this.btn_TedarikciKaydet);
            this.Controls.Add(this.tb_TedarikciAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grd_Tedarikci);
            this.Controls.Add(this.tb_TedarikciTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_TedarikciEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_TedarikciYetkilikisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_TedarikciKodu);
            this.Controls.Add(this.label1);
            this.Name = "Tedarikci";
            this.Text = "Tedarikci";
            this.Load += new System.EventHandler(this.Tedarikci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Tedarikci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TedarikciKaydet;
        private System.Windows.Forms.TextBox tb_TedarikciAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grd_Tedarikci;
        private System.Windows.Forms.TextBox tb_TedarikciTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TedarikciEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TedarikciYetkilikisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TedarikciKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TedarikciDuzelt;
        private System.Windows.Forms.Button btn_TedarikciListele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_TedarikciKayitdurumu;
    }
}