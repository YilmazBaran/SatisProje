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
    public partial class Parametreler : Form
    {
        static int guncellenecekid;
        public Parametreler()
        {
            InitializeComponent();
        }

        private void btn_KategoriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                en.KATEGORI_INSERT(tb_KategoriAdi.Text, "A");
                MessageBox.Show("Bu müşteri başarıyla kaydedildi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_BirimtipiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                en.BIRIMTIPI_INSERT(tb_Birimtipi.Text, "A");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_BirimalttipiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                //int birim_tipi_id = en.Birimtipi.Where(a => a.Adi == cmb_Birimtipi.Text).FirstOrDefault().Id;
                int birim_tipi_id = Convert.ToInt32(cmb_Birimtipi.SelectedValue.ToString());
                en.BIRIMALTTIPI_INSERT(tb_Birimalttipi.Text, birim_tipi_id, "A");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Parametreler_Load(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();
           

            //var dizi = en.Birimtipi.ToList();
            //foreach (var item in dizi)
            //{
            //    cmb_Birimtipi.Items.Add(item.Adi);
            //}

            cmb_Birimtipi.DisplayMember = "Adi";
            cmb_Birimtipi.ValueMember = "Id";
            cmb_Birimtipi.DataSource = en.Birimtipi.ToList();
        }

        private void btn_ParametrelerKategoriListele_Click(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            grd_Kategori.DataSource = en.Kategori.Where(u => u.Kayit_durumu == "A").Select(u => new Kategorilist
            {
                
                Kategori = u.Adi,
                Kayit_durumu = u.Kayit_durumu,
                Id=u.Id
            }).ToList();
        }

        private void btn_ParametrelerBirimtipilistele_Click(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            grd_Birimtipi.DataSource = en.Birimtipi.Where(u => u.Kayit_durumu == "A").Select(u => new Birimtipilist
            {
               
                Birim_tipi = u.Adi,
                Kayit_durumu =u.Kayit_durumu,
                Id = u.Id
            }).ToList();
        }

        private void btn_ParametrelerBirimalttipilistele_Click(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            grd_Birimalttipi.DataSource = en.Birimalttipi.Where(u => u.Kayit_durumu == "A").Select(u => new Birimalttipilist
            {
               
                Birim_alt_tipi = u.Adi,
                Kayit_durumu = u.Kayit_durumu,
                Id = u.Id
            }).ToList();
        }

        private void KategoriDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                en.KATEGORI_GUNCELLE(tb_KategoriAdi.Text, "A",guncellenecekid);
                MessageBox.Show("Bu kayıt başarıyla güncellendi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grd_Kategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guncellenecekid = Convert.ToInt32(grd_Kategori.SelectedRows[0].Cells[2].Value);
            tb_KategoriAdi.Text = grd_Kategori.SelectedRows[0].Cells[0].Value.ToString();
            cmb_ParametrelerKategoriKayitdurumu.Text = grd_Kategori.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void BirimtipiDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                en.BIRIMTIPI_GUNCELLE(tb_Birimtipi.Text, "A", guncellenecekid);
                MessageBox.Show("Bu kayıt başarıyla güncellendi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grd_Birimtipi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guncellenecekid = Convert.ToInt32(grd_Birimtipi.SelectedRows[0].Cells[2].Value);
            tb_Birimtipi.Text = grd_Birimtipi.SelectedRows[0].Cells[0].Value.ToString();
            cmb_ParametrelerBirimtipiKayitdurumu.Text = grd_Birimtipi.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BirimalttipiDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                //  int birim_tipi_id = en.Birimtipi.Where(a => a.Adi == cmb_Birimtipi.Text).FirstOrDefault().Id;
                int birim_tipi_id = Convert.ToInt32(cmb_Birimtipi.SelectedValue.ToString());
                en.BIRIMALTTIPI_GUNCELLE(tb_Birimalttipi.Text, birim_tipi_id, "A", guncellenecekid);
                MessageBox.Show("Bu kayıt başarıyla güncellendi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grd_Birimalttipi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guncellenecekid = Convert.ToInt32(grd_Birimalttipi.SelectedRows[0].Cells[2].Value);
            tb_Birimalttipi.Text = grd_Birimalttipi.SelectedRows[0].Cells[0].Value.ToString();
            cmb_ParametrelerBirimalttipiKayitdurumu.Text = grd_Birimalttipi.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
