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
    public partial class Urunal : Form
    {
        public Urunal()
        {
            InitializeComponent();
        }

        private void btn_UrunalKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();


                int urun_id = Convert.ToInt32(cmb_UrunalUrunadi.SelectedValue.ToString());


                int iliski_id = Convert.ToInt32(cmb_UrunalTedarikci.SelectedValue.ToString());

                int birim_alttipi_id = Convert.ToInt32(cmb_UrunalBirimalttipi.SelectedValue.ToString());


                // en.URUNISLEMLERI_INSERT("A", Convert.ToInt32(cmb_Urunalkategori.Text), Convert.ToInt32(cmb_UrunalUrunadi.Text), Convert.ToInt32(cmb_UrunalTedarikci.Text), Convert.ToInt32(cmb_UrunalBirimtipi.Text), Convert.ToInt32(cmb_UrunalBirimalttipi.Text), Convert.ToInt32(tb_UrunalMiktar.Text), Convert.ToDecimal(tb_UrunalBirimfiyat.Text), Convert.ToDecimal(tb_UrunalPesinodenen.Text), Convert.ToDateTime(dt_UrunalTarih), tb_UrunalAciklama.Text);
                en.URUNISLEMLERI_INSERT("A", urun_id, iliski_id, birim_alttipi_id, Convert.ToInt32(tb_UrunalMiktar.Text), Convert.ToDecimal(tb_UrunalBirimfiyat.Text), Convert.ToDecimal(tb_UrunalToplamfiyat.Text), Convert.ToDecimal(tb_UrunalPesinodenen.Text), Convert.ToDecimal(tb_UrunalToplamfiyat.Text) - Convert.ToDecimal(tb_UrunalPesinodenen.Text), dt_UrunalTarih.Value, tb_UrunalAciklama.Text);

                tb_UrunalAciklama.Clear();
                tb_UrunalBirimfiyat.Clear();
                tb_UrunalMiktar.Clear();
                tb_UrunalPesinodenen.Clear();
            }
                  
                //   MessageBox.Show("Bu müşteri başarıyla kaydedildi");

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Urunal_Load(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();
            //var dizi = en.Kategori.ToList();
            //foreach (var item in dizi)
            //{
            //    cmb_Urunalkategori.Items.Add(item.Adi);

            //}
            cmb_Urunalkategori.DisplayMember = "Adi";
            cmb_Urunalkategori.ValueMember = "Id";
            cmb_Urunalkategori.DataSource= en.Kategori.ToList();


            //var dizi2 = en.Urunler.ToList();
            //foreach (var item in dizi2)
            //{
            //    cmb_UrunalUrunadi.Items.Add(item.Adi);

            //}


            //var dizi3 = en.Iliskiler.Where(t=>t.Iliski_tipi=="T").ToList();
            //foreach (var item in dizi3)
            //{
            //    cmb_UrunalTedarikci.Items.Add(item.Yetkili_kisi);

            //}
            cmb_UrunalTedarikci.DisplayMember = "Yetkili_kisi";
            cmb_UrunalTedarikci.ValueMember = "Id";
            cmb_UrunalTedarikci.DataSource=en.Iliskiler.Where(t => t.Iliski_tipi == "T").ToList();

            //var dizi4 = en.Birimtipi.ToList();
            //foreach (var item in dizi4)
            //{
            //    cmb_UrunalBirimtipi.Items.Add(item.Adi);

            //}

            cmb_UrunalBirimtipi.DisplayMember = "Adi";
            cmb_UrunalBirimtipi.ValueMember = "Id";
            cmb_UrunalBirimtipi.DataSource = en.Birimtipi.ToList();
        }

        private void tb_UrunalBirimfiyat_TextChanged(object sender, EventArgs e)
        {
            if (tb_UrunalBirimfiyat.Text !="")
            tb_UrunalToplamfiyat.Text = (Convert.ToDecimal(tb_UrunalBirimfiyat.Text) * Convert.ToDecimal(tb_UrunalMiktar.Text)).ToString();
        }

        private void cmb_UrunalBirimtipi_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cmb_UrunalBirimalttipi.Items.Clear();
            SatisProjeEntities en = new SatisProjeEntities();
            int birim_tipi_id = Convert.ToInt32(cmb_UrunalBirimtipi.SelectedValue.ToString());

            //var dizi5 = en.Birimalttipi.Where(bat=>bat.Birim_tipi_id== birim_tipi_id).ToList();
            //foreach (var item in dizi5)
            //{
            //    cmb_UrunalBirimalttipi.Items.Add(item.Adi);

            //}
            cmb_UrunalBirimalttipi.DisplayMember = "Adi";
            cmb_UrunalBirimalttipi.ValueMember = "Id";
            cmb_UrunalBirimalttipi.DataSource = en.Birimalttipi.Where(bat => bat.Birim_tipi_id == birim_tipi_id).ToList();
        }

        private void cmb_UrunalUrunadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();
            int birimtipi_id = en.Urunler.Where(a => a.Adi == cmb_UrunalUrunadi.Text).FirstOrDefault().Birim_tipi;
            //var birimtipi_adi = en.Birimtipi.Where(bat => bat.Id == birimtipi_id).FirstOrDefault().Adi;
            cmb_UrunalBirimtipi.SelectedValue = birimtipi_id;
        }

        private void cmb_Urunalkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cmb_UrunalUrunadi.Items.Clear();
            SatisProjeEntities en = new SatisProjeEntities();
            //int kategori_id = en.Kategori.Where(a => a.Adi == cmb_Urunalkategori.Text).FirstOrDefault().Id;
            if (cmb_Urunalkategori.SelectedIndex > -1)
            {
                int kategori_id = Convert.ToInt32(cmb_Urunalkategori.SelectedValue.ToString());

                //var dizi6 = en.Urunler.Where(kat => kat.Kategori_id == kategori_id).ToList();
                //foreach (var item in dizi6)
                //{
                //    cmb_UrunalUrunadi.Items.Add(item.Adi);

                //}

                cmb_UrunalUrunadi.DisplayMember = "Adi";
                cmb_UrunalUrunadi.ValueMember = "Id";
                cmb_UrunalUrunadi.DataSource = en.Urunler.Where(kat => kat.Kategori_id == kategori_id).ToList();
            }
        }

        private void btn_UrunalListele_Click(object sender, EventArgs e)
        {

            SatisProjeEntities en = new SatisProjeEntities();

            grd_Urunal.DataSource = en.Siparisler.Where(u => u.Islem_tipi == "A").Select(u => new urunallist
            {
                
                Urun_adi = en.Urunler.Where(i => i.Id == u.Urun_id).FirstOrDefault().Adi,
                Kategori = en.Kategori.Where(b => b.Id == (en.Urunler.Where(t => t.Id == u.Urun_id)).FirstOrDefault().Kategori_id).FirstOrDefault().Adi,
                Tedarikci_adi =en.Iliskiler.Where(i=>i.Id==u.Iliski_id).FirstOrDefault().Yetkili_kisi,
                Birim_tipi = en.Birimtipi.Where(b=>b.Id==(en.Birimalttipi.Where(t=>t.Id==u.Birim_alttipi_id)).FirstOrDefault().Birim_tipi_id).FirstOrDefault().Adi,
               Birim_alt_tipi=en.Birimalttipi.Where(b=>b.Id==u.Birim_alttipi_id).FirstOrDefault().Adi,
               Miktar=u.Miktar,
               Birim_fiyat=u.Birim_fiyat,
               Toplam_fiyat=u.Toplam_fiyat,
               Pesin_odenen=u.Pesin_odenen,
               Tarih=u.Tarih,
               Aciklama=u.Aciklama
               
            }).ToList();
        }

        private void cmb_UrunalTedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            int iliski_id = Convert.ToInt32(cmb_UrunalTedarikci.SelectedValue.ToString());//en.Iliskiler.Where(a => a.Yetkili_kisi == cmb_UrunalTedarikci.Text).FirstOrDefault().Id;

            decimal sum = en.Siparisler.Where(s => s.Iliski_id == iliski_id).ToList().Select(b => b.Islem_bakiye).Sum();

            decimal sum2 = en.Odemeler.Where(s => s.Iliski_id == iliski_id).ToList().Select(b => b.Islem_bakiye).Sum();

            lbl_Urunal.Text = (sum-sum2).ToString();

            
        }

        private void grd_Urunal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_Urunal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            cmb_Urunalkategori.Text = grd_Urunal.SelectedRows[0].Cells[1].Value.ToString();
            cmb_UrunalUrunadi.Text = grd_Urunal.SelectedRows[0].Cells[2].Value.ToString();
            cmb_UrunalTedarikci.Text = grd_Urunal.SelectedRows[0].Cells[0].Value.ToString();
            cmb_UrunalBirimtipi.Text = grd_Urunal.SelectedRows[0].Cells[3].Value.ToString();
            cmb_UrunalBirimalttipi.Text = grd_Urunal.SelectedRows[0].Cells[4].Value.ToString();
            tb_UrunalMiktar.Text = grd_Urunal.SelectedRows[0].Cells[5].Value.ToString();
            tb_UrunalBirimfiyat.Text = grd_Urunal.SelectedRows[0].Cells[6].Value.ToString();
            tb_UrunalToplamfiyat.Text = grd_Urunal.SelectedRows[0].Cells[7].Value.ToString();
            tb_UrunalPesinodenen.Text = grd_Urunal.SelectedRows[0].Cells[8].Value.ToString();
            dt_UrunalTarih.Value = Convert.ToDateTime(grd_Urunal.SelectedRows[0].Cells[9].Value);
            tb_UrunalAciklama.Text = grd_Urunal.SelectedRows[0].Cells[10].Value.ToString();
        }
    }
}
