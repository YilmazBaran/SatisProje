using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProje
{
    public partial class Urunsat : Form
    {
        public Urunsat()
        {
            InitializeComponent();
        }

        private void btn_UrunsatKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();


                int urun_id = Convert.ToInt32(cmb_UrunsatUrunadi.SelectedValue.ToString());


                int iliski_id = Convert.ToInt32(cmb_UrunsatTedarikci.SelectedValue.ToString());

                int birim_alttipi_id = Convert.ToInt32(cmb_UrunsatBirimalttipi.SelectedValue.ToString());

                en.URUNISLEMLERI_INSERT("S", urun_id, iliski_id, birim_alttipi_id, Convert.ToInt32(tb_UrunsatMiktar.Text), Convert.ToDecimal(tb_UrunsatBirimfiyat.Text), Convert.ToDecimal(tb_UrunsatToplamfiyat.Text), Convert.ToDecimal(tb_UrunsatPesinodenen.Text), Convert.ToDecimal(tb_UrunsatToplamfiyat.Text) - Convert.ToDecimal(tb_UrunsatPesinodenen.Text), dt_UrunsatTarih.Value, tb_UrunsatAciklama.Text);

                tb_UrunsatAciklama.Clear();
                tb_UrunsatBirimfiyat.Clear();
                tb_UrunsatMiktar.Clear();
                tb_UrunsatPesinodenen.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Urunsat_Load(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            cmb_UrunsatKategori.DisplayMember = "Adi";
            cmb_UrunsatKategori.ValueMember = "Id";
            cmb_UrunsatKategori.DataSource = en.Kategori.ToList();

            //var dizi2 = en.Urunler.ToList();
            //foreach (var item in dizi2)
            //{
            //    cmb_UrunsatUrunadi.Items.Add(item.Adi);

            //}


            //var dizi3 = en.Iliskiler.Where(t => t.Iliski_tipi == "M").ToList();
            //foreach (var item in dizi3)
            //{
            //    cmb_UrunsatTedarikci.Items.Add(item.Yetkili_kisi);

            //}

            cmb_UrunsatTedarikci.DisplayMember = "Yetkili_kisi";
            cmb_UrunsatTedarikci.ValueMember = "Id";
            cmb_UrunsatTedarikci.DataSource = en.Iliskiler.Where(t => t.Iliski_tipi == "M").ToList();

            //var dizi4 = en.Birimtipi.ToList();
            //foreach (var item in dizi4)
            //{
            //    cmb_UrunsatBirimtipi.Items.Add(item.Adi);

            //}

            cmb_UrunsatBirimtipi.DisplayMember = "Adi";
            cmb_UrunsatBirimtipi.ValueMember = "Id";
            cmb_UrunsatBirimtipi.DataSource = en.Birimtipi.ToList();

        }

        private void tb_UrunsatBirimfiyat_TextChanged(object sender, EventArgs e)
        {
            if (tb_UrunsatBirimfiyat.Text != "")
                tb_UrunsatToplamfiyat.Text = (Convert.ToDecimal(tb_UrunsatBirimfiyat.Text) * Convert.ToDecimal(tb_UrunsatMiktar.Text)).ToString();
        }

        private void cmb_UrunsatBirimalttipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_UrunsatKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cmb_UrunsatUrunadi.Items.Clear();
            SatisProjeEntities en = new SatisProjeEntities();
            // int kategori_id = en.Kategori.Where(a => a.Adi == cmb_UrunsatKategori.Text).FirstOrDefault().Id;
            if (cmb_UrunsatKategori.SelectedIndex > -1)
            {
                int kategori_id = Convert.ToInt32(cmb_UrunsatKategori.SelectedValue.ToString());


                //var dizi6 = en.Urunler.Where(kat => kat.Kategori_id == kategori_id).ToList();
                //foreach (var item in dizi6)
                //{
                //    cmb_UrunsatUrunadi.Items.Add(item.Adi);

                //}

                cmb_UrunsatUrunadi.DisplayMember = "Adi";
                cmb_UrunsatUrunadi.ValueMember = "Id";
                cmb_UrunsatUrunadi.DataSource = en.Urunler.Where(kat => kat.Kategori_id == kategori_id).ToList();
            }
        }


        private void cmb_UrunsatBirimtipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();
            int birim_tipi_id = Convert.ToInt32(cmb_UrunsatBirimtipi.SelectedValue.ToString());

            cmb_UrunsatBirimalttipi.DisplayMember = "Adi";
            cmb_UrunsatBirimalttipi.ValueMember = "Id";
            cmb_UrunsatBirimalttipi.DataSource = en.Birimalttipi.Where(bat => bat.Birim_tipi_id == birim_tipi_id).ToList();
        }

        private void cmb_UrunsatUrunadi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();
            int birimtipi_id = en.Urunler.Where(a => a.Adi == cmb_UrunsatUrunadi.Text).FirstOrDefault().Birim_tipi;
            // var birimtipi_adi = en.Birimtipi.Where(bat => bat.Id == birimtipi_id).FirstOrDefault().Adi;
            cmb_UrunsatBirimtipi.SelectedValue = birimtipi_id;
        }

        private void btn_UrunsatListele_Click(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            grd_Urunsat.DataSource = en.Siparisler.Where(u => u.Islem_tipi == "S").Select(u => new urunsatlist
            {

                Urun_adi = en.Urunler.Where(i => i.Id == u.Urun_id).FirstOrDefault().Adi,
                Kategori = en.Kategori.Where(b => b.Id == (en.Urunler.Where(t => t.Id == u.Urun_id)).FirstOrDefault().Kategori_id).FirstOrDefault().Adi,
                Musteri_adi = en.Iliskiler.Where(i => i.Id == u.Iliski_id).FirstOrDefault().Yetkili_kisi,
                Birim_tipi = en.Birimtipi.Where(b => b.Id == (en.Birimalttipi.Where(t => t.Id == u.Birim_alttipi_id)).FirstOrDefault().Birim_tipi_id).FirstOrDefault().Adi,
                Birim_alt_tipi = en.Birimalttipi.Where(b => b.Id == u.Birim_alttipi_id).FirstOrDefault().Adi,
                Miktar = u.Miktar,
                Birim_fiyat = u.Birim_fiyat,
                Toplam_fiyat = u.Toplam_fiyat,
                Pesin_odenen = u.Pesin_odenen,
                Tarih = u.Tarih,
                Aciklama = u.Aciklama

            }).ToList();
        }

        private void cmb_UrunsatTedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            int iliski_id = Convert.ToInt32(cmb_UrunsatTedarikci.SelectedValue.ToString());

            decimal sum = en.Siparisler.Where(s => s.Iliski_id == iliski_id).ToList().Select(b => b.Islem_bakiye).Sum();

            decimal sum2 = en.Odemeler.Where(s => s.Iliski_id == iliski_id).ToList().Select(b => b.Islem_bakiye).Sum();

            lbl_Urunsat.Text = (sum - sum2).ToString();
        }
    }
}
