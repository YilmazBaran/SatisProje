namespace SatisProje
{
    partial class Form1
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
            this.btn_Musteri = new System.Windows.Forms.Button();
            this.btn_Tedarikci = new System.Windows.Forms.Button();
            this.pnlislem = new System.Windows.Forms.Panel();
            this.btn_Urunler = new System.Windows.Forms.Button();
            this.btn_Urunal = new System.Windows.Forms.Button();
            this.btn_Urunsat = new System.Windows.Forms.Button();
            this.btn_Muhasebe = new System.Windows.Forms.Button();
            this.btn_Parametreler = new System.Windows.Forms.Button();
            this.btn_Raporlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Musteri
            // 
            this.btn_Musteri.Location = new System.Drawing.Point(1, -1);
            this.btn_Musteri.Name = "btn_Musteri";
            this.btn_Musteri.Size = new System.Drawing.Size(130, 67);
            this.btn_Musteri.TabIndex = 0;
            this.btn_Musteri.Text = "Müşteri";
            this.btn_Musteri.UseVisualStyleBackColor = true;
            this.btn_Musteri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Tedarikci
            // 
            this.btn_Tedarikci.Location = new System.Drawing.Point(1, 62);
            this.btn_Tedarikci.Name = "btn_Tedarikci";
            this.btn_Tedarikci.Size = new System.Drawing.Size(130, 71);
            this.btn_Tedarikci.TabIndex = 1;
            this.btn_Tedarikci.Text = "Tedarikçi";
            this.btn_Tedarikci.UseVisualStyleBackColor = true;
            this.btn_Tedarikci.Click += new System.EventHandler(this.btn_Tedarikci_Click);
            // 
            // pnlislem
            // 
            this.pnlislem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlislem.Location = new System.Drawing.Point(137, -1);
            this.pnlislem.Name = "pnlislem";
            this.pnlislem.Size = new System.Drawing.Size(1195, 662);
            this.pnlislem.TabIndex = 2;
            // 
            // btn_Urunler
            // 
            this.btn_Urunler.Location = new System.Drawing.Point(1, 129);
            this.btn_Urunler.Name = "btn_Urunler";
            this.btn_Urunler.Size = new System.Drawing.Size(130, 79);
            this.btn_Urunler.TabIndex = 3;
            this.btn_Urunler.Text = "Ürünler";
            this.btn_Urunler.UseVisualStyleBackColor = true;
            this.btn_Urunler.Click += new System.EventHandler(this.btn_Urunler_Click);
            // 
            // btn_Urunal
            // 
            this.btn_Urunal.Location = new System.Drawing.Point(1, 203);
            this.btn_Urunal.Name = "btn_Urunal";
            this.btn_Urunal.Size = new System.Drawing.Size(130, 68);
            this.btn_Urunal.TabIndex = 4;
            this.btn_Urunal.Text = "Ürün al";
            this.btn_Urunal.UseVisualStyleBackColor = true;
            this.btn_Urunal.Click += new System.EventHandler(this.btn_Urunal_Click);
            // 
            // btn_Urunsat
            // 
            this.btn_Urunsat.Location = new System.Drawing.Point(1, 261);
            this.btn_Urunsat.Name = "btn_Urunsat";
            this.btn_Urunsat.Size = new System.Drawing.Size(130, 76);
            this.btn_Urunsat.TabIndex = 5;
            this.btn_Urunsat.Text = "Ürün sat";
            this.btn_Urunsat.UseVisualStyleBackColor = true;
            this.btn_Urunsat.Click += new System.EventHandler(this.btn_Urunsat_Click);
            // 
            // btn_Muhasebe
            // 
            this.btn_Muhasebe.Location = new System.Drawing.Point(1, 334);
            this.btn_Muhasebe.Name = "btn_Muhasebe";
            this.btn_Muhasebe.Size = new System.Drawing.Size(130, 73);
            this.btn_Muhasebe.TabIndex = 6;
            this.btn_Muhasebe.Text = "Muhasebe";
            this.btn_Muhasebe.UseVisualStyleBackColor = true;
            this.btn_Muhasebe.Click += new System.EventHandler(this.btn_Muhasebe_Click);
            // 
            // btn_Parametreler
            // 
            this.btn_Parametreler.Location = new System.Drawing.Point(1, 403);
            this.btn_Parametreler.Name = "btn_Parametreler";
            this.btn_Parametreler.Size = new System.Drawing.Size(130, 66);
            this.btn_Parametreler.TabIndex = 7;
            this.btn_Parametreler.Text = "Parametreler";
            this.btn_Parametreler.UseVisualStyleBackColor = true;
            this.btn_Parametreler.Click += new System.EventHandler(this.btn_Parametreler_Click);
            // 
            // btn_Raporlar
            // 
            this.btn_Raporlar.Location = new System.Drawing.Point(1, 468);
            this.btn_Raporlar.Name = "btn_Raporlar";
            this.btn_Raporlar.Size = new System.Drawing.Size(130, 60);
            this.btn_Raporlar.TabIndex = 8;
            this.btn_Raporlar.Text = "Raporlar";
            this.btn_Raporlar.UseVisualStyleBackColor = true;
            this.btn_Raporlar.Click += new System.EventHandler(this.btn_Raporlar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 663);
            this.Controls.Add(this.btn_Raporlar);
            this.Controls.Add(this.btn_Parametreler);
            this.Controls.Add(this.btn_Muhasebe);
            this.Controls.Add(this.btn_Urunsat);
            this.Controls.Add(this.btn_Urunal);
            this.Controls.Add(this.btn_Urunler);
            this.Controls.Add(this.pnlislem);
            this.Controls.Add(this.btn_Tedarikci);
            this.Controls.Add(this.btn_Musteri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Musteri;
        private System.Windows.Forms.Button btn_Tedarikci;
        private System.Windows.Forms.Panel pnlislem;
        private System.Windows.Forms.Button btn_Urunler;
        private System.Windows.Forms.Button btn_Urunal;
        private System.Windows.Forms.Button btn_Urunsat;
        private System.Windows.Forms.Button btn_Muhasebe;
        private System.Windows.Forms.Button btn_Parametreler;
        private System.Windows.Forms.Button btn_Raporlar;
    }
}

