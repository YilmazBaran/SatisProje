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
    
    public partial class Musteri : Form
    {
        static int guncellenecekid;
        public Musteri()
        {
            InitializeComponent();
        }

        private void btn_MusteriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                en.ILISKI_INSERT("M", tb_MusteriKodu.Text, tb_MusteriYetkilikisi.Text, tb_MusteriEmail.Text, tb_MusteriTelefon.Text, tb_MusteriAdres.Text, "A");
                MessageBox.Show("Bu müşteri başarıyla kaydedildi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_MusteriListele_Click(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            grd_Musteri.DataSource = en.Iliskiler.Where(u => u.Kayit_durumu == "A" && u.Iliski_tipi=="M").Select(u => new iliskilist
            {
                Kodu= u.Kodu,
                Yetkili_kisi=u.Yetkili_kisi,
                Email = u.Email,
                Telefon = u.Telefon,
                Adres = u.Adres,
                Kayit_durumu = u.Kayit_durumu=="A"?"Aktif":"Pasif",
                Id=u.Id
            }).ToList();
        }

        //private void btn_MusteriSil_Click(object sender, EventArgs e)
        //{
        //   // SatisProjeEntities en = new SatisProjeEntities();
        //   // en.
        //}

        private void Musteri_Load(object sender, EventArgs e)
        {
            cmb_MusteriKayitdurumu.SelectedIndex = 0;
        }

        private void grd_Musteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_Musteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guncellenecekid = Convert.ToInt32(grd_Musteri.SelectedRows[0].Cells[6].Value);
            tb_MusteriKodu.Text = grd_Musteri.SelectedRows[0].Cells[0].Value.ToString();
            tb_MusteriYetkilikisi.Text = grd_Musteri.SelectedRows[0].Cells[1].Value.ToString();
            tb_MusteriAdres.Text = grd_Musteri.SelectedRows[0].Cells[5].Value.ToString();
            tb_MusteriTelefon.Text = grd_Musteri.SelectedRows[0].Cells[3].Value.ToString();
            tb_MusteriEmail.Text = grd_Musteri.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_MusteriDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                en.ILISKI_GUNCELLE("M", tb_MusteriKodu.Text, tb_MusteriYetkilikisi.Text, tb_MusteriAdres.Text, tb_MusteriTelefon.Text, tb_MusteriEmail.Text,"A", guncellenecekid);
                MessageBox.Show("Bu müşteri başarıyla güncellendi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
