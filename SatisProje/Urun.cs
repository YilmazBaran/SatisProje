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
    public partial class Urun : Form
    {
        static int guncellenecekid;
        public Urun()
        {
            InitializeComponent();
        }

        private void btn_UrunKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                //   var dizi = en.Kategori.ToList();
                int kategori_id = Convert.ToInt32(cmb_UrunKategoriadi.SelectedValue.ToString());
                //foreach (var item in dizi)
                //{
                //    if (item.Adi==cmb_UrunKategoriadi.Text)
                //    {
                //        kategori_id = item.Id;
                //        break;
                //    }                 
                //}


                // MessageBox.Show("Bu müşteri başarıyla kaydedildi");



                //var dizi2 = en.Birimtipi.ToList();
               int birimtipi=Convert.ToInt32(cmb_UrunBirimTipi.SelectedValue.ToString());
                //foreach (var item in dizi2)
                //{
                //    if (item.Adi==cmb_UrunBirimTipi.Text)
                //    {
                //        birimtipi = item.Id;
                //        break;
                //    }
                //}
                en.URUN_INSERT(tb_UrunKodu.Text, tb_UrunAdi.Text, Convert.ToInt32(tb_UrunUyarilimiti.Text),kategori_id, birimtipi,"A");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();
            //var dizi = en.Kategori.ToList();
            //foreach (var item in dizi)
            //{
            //    cmb_UrunKategoriadi.Items.Add(item.Adi);
            //}

            cmb_UrunKategoriadi.DisplayMember = "Adi";
            cmb_UrunKategoriadi.ValueMember = "Id";
            cmb_UrunKategoriadi.DataSource = en.Kategori.ToList();

            //var dizi2 = en.Birimtipi.ToList();
            //foreach (var item in dizi2)
            //{
            //    cmb_UrunBirimTipi.Items.Add(item.Adi);
            //}

            cmb_UrunBirimTipi.DisplayMember = "Adi";
            cmb_UrunBirimTipi.ValueMember = "Id";
            cmb_UrunBirimTipi.DataSource = en.Birimtipi.ToList();
        }

        private void btn_UrunListele_Click(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            grd_Urun.DataSource = en.Urunler.Where(u => u.Kayit_durumu == "A").Select(u => new urunlist
            {
                UrunKodu = u.Kodu,
                UrunAdi = u.Adi,
                Kategori = en.Kategori.Where(k => k.Id == u.Kategori_id).FirstOrDefault().Adi,
                Uyari_limiti=u.Uyari_limiti.ToString(),
                Birim_tipi= en.Birimtipi.Where(k => k.Id == u.Kategori_id).FirstOrDefault().Adi,
                Kayit_durumu =u.Kayit_durumu,
                Id=u.Id
            }).ToList();
        }

        private void grd_Urun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guncellenecekid = Convert.ToInt32(grd_Urun.SelectedRows[0].Cells[6].Value);
            tb_UrunKodu.Text = grd_Urun.SelectedRows[0].Cells[0].Value.ToString();
            tb_UrunAdi.Text = grd_Urun.SelectedRows[0].Cells[1].Value.ToString();
            tb_UrunUyarilimiti.Text = grd_Urun.SelectedRows[0].Cells[3].Value.ToString();
            cmb_UrunBirimTipi.Text = grd_Urun.SelectedRows[0].Cells[4].Value.ToString();
            cmb_UrunKategoriadi.Text = grd_Urun.SelectedRows[0].Cells[2].Value.ToString();
            cmb_UrunKayitdurumu.Text = grd_Urun.SelectedRows[0].Cells[5].Value.ToString();


        }

        private void btn_UrunDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                int kategori_id = Convert.ToInt32(cmb_UrunKategoriadi.SelectedValue.ToString());
                int birimtipi = Convert.ToInt32(cmb_UrunBirimTipi.SelectedValue.ToString());
                

                en.URUN_GUNCELLE(tb_UrunKodu.Text, tb_UrunAdi.Text, kategori_id, Convert.ToInt32(tb_UrunUyarilimiti.Text),  birimtipi, "A", guncellenecekid);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
