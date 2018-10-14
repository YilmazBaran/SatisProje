namespace SatisProje
{
    partial class Muhasebe
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
            this.label6 = new System.Windows.Forms.Label();
            this.grd_Muhasebe = new System.Windows.Forms.DataGridView();
            this.btn_MuhasebeKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_MuhasebeIslemtipi = new System.Windows.Forms.ComboBox();
            this.cmb_MuhasebeMusteriadi = new System.Windows.Forms.ComboBox();
            this.tb_MuhasebeOdemetutari = new System.Windows.Forms.TextBox();
            this.tb_MuhasebeAciklama = new System.Windows.Forms.TextBox();
            this.dt_MuhasebeTarih = new System.Windows.Forms.DateTimePicker();
            this.btn_MuhasebeSil = new System.Windows.Forms.Button();
            this.btn_MuhasebeDuzenle = new System.Windows.Forms.Button();
            this.btn_MuhasebeListele = new System.Windows.Forms.Button();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Muhasebe)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(77, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "MUHASEBE EKRANI";
            // 
            // grd_Muhasebe
            // 
            this.grd_Muhasebe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Muhasebe.Location = new System.Drawing.Point(449, 51);
            this.grd_Muhasebe.Name = "grd_Muhasebe";
            this.grd_Muhasebe.RowTemplate.Height = 24;
            this.grd_Muhasebe.Size = new System.Drawing.Size(683, 391);
            this.grd_Muhasebe.TabIndex = 24;
            // 
            // btn_MuhasebeKaydet
            // 
            this.btn_MuhasebeKaydet.Location = new System.Drawing.Point(321, 406);
            this.btn_MuhasebeKaydet.Name = "btn_MuhasebeKaydet";
            this.btn_MuhasebeKaydet.Size = new System.Drawing.Size(75, 36);
            this.btn_MuhasebeKaydet.TabIndex = 23;
            this.btn_MuhasebeKaydet.Text = "Kaydet";
            this.btn_MuhasebeKaydet.UseVisualStyleBackColor = true;
            this.btn_MuhasebeKaydet.Click += new System.EventHandler(this.btn_MuhasebeKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ödeme Tutarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Müşteri Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "İşlem tipi";
            // 
            // cmb_MuhasebeIslemtipi
            // 
            this.cmb_MuhasebeIslemtipi.FormattingEnabled = true;
            this.cmb_MuhasebeIslemtipi.Items.AddRange(new object[] {
            "Ödeme Al",
            "Ödeme Yap"});
            this.cmb_MuhasebeIslemtipi.Location = new System.Drawing.Point(192, 57);
            this.cmb_MuhasebeIslemtipi.Name = "cmb_MuhasebeIslemtipi";
            this.cmb_MuhasebeIslemtipi.Size = new System.Drawing.Size(200, 24);
            this.cmb_MuhasebeIslemtipi.TabIndex = 26;
            this.cmb_MuhasebeIslemtipi.SelectedIndexChanged += new System.EventHandler(this.cmb_Muhasebeislemtipi_SelectedIndexChanged);
            // 
            // cmb_MuhasebeMusteriadi
            // 
            this.cmb_MuhasebeMusteriadi.FormattingEnabled = true;
            this.cmb_MuhasebeMusteriadi.Location = new System.Drawing.Point(192, 97);
            this.cmb_MuhasebeMusteriadi.Name = "cmb_MuhasebeMusteriadi";
            this.cmb_MuhasebeMusteriadi.Size = new System.Drawing.Size(200, 24);
            this.cmb_MuhasebeMusteriadi.TabIndex = 27;
            this.cmb_MuhasebeMusteriadi.SelectedIndexChanged += new System.EventHandler(this.cmb_MuhasebeMusteriadi_SelectedIndexChanged);
            // 
            // tb_MuhasebeOdemetutari
            // 
            this.tb_MuhasebeOdemetutari.Location = new System.Drawing.Point(192, 140);
            this.tb_MuhasebeOdemetutari.Name = "tb_MuhasebeOdemetutari";
            this.tb_MuhasebeOdemetutari.Size = new System.Drawing.Size(200, 22);
            this.tb_MuhasebeOdemetutari.TabIndex = 28;
            // 
            // tb_MuhasebeAciklama
            // 
            this.tb_MuhasebeAciklama.Location = new System.Drawing.Point(192, 238);
            this.tb_MuhasebeAciklama.Multiline = true;
            this.tb_MuhasebeAciklama.Name = "tb_MuhasebeAciklama";
            this.tb_MuhasebeAciklama.Size = new System.Drawing.Size(200, 91);
            this.tb_MuhasebeAciklama.TabIndex = 29;
            // 
            // dt_MuhasebeTarih
            // 
            this.dt_MuhasebeTarih.Location = new System.Drawing.Point(192, 184);
            this.dt_MuhasebeTarih.Name = "dt_MuhasebeTarih";
            this.dt_MuhasebeTarih.Size = new System.Drawing.Size(200, 22);
            this.dt_MuhasebeTarih.TabIndex = 30;
            this.dt_MuhasebeTarih.ValueChanged += new System.EventHandler(this.dt_MuhasebeTarih_ValueChanged);
            // 
            // btn_MuhasebeSil
            // 
            this.btn_MuhasebeSil.Location = new System.Drawing.Point(240, 406);
            this.btn_MuhasebeSil.Name = "btn_MuhasebeSil";
            this.btn_MuhasebeSil.Size = new System.Drawing.Size(75, 36);
            this.btn_MuhasebeSil.TabIndex = 31;
            this.btn_MuhasebeSil.Text = "Sil";
            this.btn_MuhasebeSil.UseVisualStyleBackColor = true;
            // 
            // btn_MuhasebeDuzenle
            // 
            this.btn_MuhasebeDuzenle.Location = new System.Drawing.Point(159, 406);
            this.btn_MuhasebeDuzenle.Name = "btn_MuhasebeDuzenle";
            this.btn_MuhasebeDuzenle.Size = new System.Drawing.Size(75, 36);
            this.btn_MuhasebeDuzenle.TabIndex = 32;
            this.btn_MuhasebeDuzenle.Text = "Düzenle";
            this.btn_MuhasebeDuzenle.UseVisualStyleBackColor = true;
            // 
            // btn_MuhasebeListele
            // 
            this.btn_MuhasebeListele.Location = new System.Drawing.Point(78, 406);
            this.btn_MuhasebeListele.Name = "btn_MuhasebeListele";
            this.btn_MuhasebeListele.Size = new System.Drawing.Size(75, 36);
            this.btn_MuhasebeListele.TabIndex = 33;
            this.btn_MuhasebeListele.Text = "Listele";
            this.btn_MuhasebeListele.UseVisualStyleBackColor = true;
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(82, 342);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(49, 17);
            this.lbl_bakiye.TabIndex = 34;
            this.lbl_bakiye.Text = "bakiye";
            // 
            // Muhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 493);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.btn_MuhasebeListele);
            this.Controls.Add(this.btn_MuhasebeDuzenle);
            this.Controls.Add(this.btn_MuhasebeSil);
            this.Controls.Add(this.dt_MuhasebeTarih);
            this.Controls.Add(this.tb_MuhasebeAciklama);
            this.Controls.Add(this.tb_MuhasebeOdemetutari);
            this.Controls.Add(this.cmb_MuhasebeMusteriadi);
            this.Controls.Add(this.cmb_MuhasebeIslemtipi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grd_Muhasebe);
            this.Controls.Add(this.btn_MuhasebeKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Muhasebe";
            this.Text = "Muhasebe";
            this.Load += new System.EventHandler(this.Muhasebe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Muhasebe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grd_Muhasebe;
        private System.Windows.Forms.Button btn_MuhasebeKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_MuhasebeIslemtipi;
        private System.Windows.Forms.ComboBox cmb_MuhasebeMusteriadi;
        private System.Windows.Forms.TextBox tb_MuhasebeOdemetutari;
        private System.Windows.Forms.TextBox tb_MuhasebeAciklama;
        private System.Windows.Forms.DateTimePicker dt_MuhasebeTarih;
        private System.Windows.Forms.Button btn_MuhasebeSil;
        private System.Windows.Forms.Button btn_MuhasebeDuzenle;
        private System.Windows.Forms.Button btn_MuhasebeListele;
        private System.Windows.Forms.Label lbl_bakiye;
    }
}