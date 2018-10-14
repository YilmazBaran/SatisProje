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
    public partial class Tedarikci : Form
    {
       static int guncellenecekid;


        public Tedarikci()
        {
            InitializeComponent();
        }

        private void btn_TedarikciKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                en.ILISKI_INSERT("T", tb_TedarikciKodu.Text, tb_TedarikciYetkilikisi.Text, tb_TedarikciEmail.Text, tb_TedarikciTelefon.Text, tb_TedarikciAdres.Text, "A");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_TedarikciListele_Click(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            grd_Tedarikci.DataSource = en.Iliskiler.Where(u => u.Kayit_durumu == "A" && u.Iliski_tipi=="T").Select(u => new iliskilist
            {
                Kodu = u.Kodu,
                Yetkili_kisi = u.Yetkili_kisi,
                Email = u.Email,
                Telefon = u.Telefon,
                Adres = u.Adres,
                Kayit_durumu = u.Kayit_durumu== "A" ? "Aktif" : "Pasif",
                Id = u.Id
            }).ToList();
        }

        private void grd_Tedarikci_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grd_Tedarikci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            guncellenecekid = Convert.ToInt32(grd_Tedarikci.SelectedRows[0].Cells[0].Value);
            tb_TedarikciKodu.Text = grd_Tedarikci.SelectedRows[0].Cells[0].Value.ToString();
            tb_TedarikciYetkilikisi.Text = grd_Tedarikci.SelectedRows[0].Cells[1].Value.ToString();
            tb_TedarikciAdres.Text = grd_Tedarikci.SelectedRows[0].Cells[5].Value.ToString();
            tb_TedarikciTelefon.Text = grd_Tedarikci.SelectedRows[0].Cells[3].Value.ToString();
            tb_TedarikciEmail.Text = grd_Tedarikci.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void Tedarikci_Load(object sender, EventArgs e)
        {
            cmb_TedarikciKayitdurumu.SelectedIndex = 0;
        }

        private void btn_TedarikciDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                en.ILISKI_GUNCELLE("T", tb_TedarikciKodu.Text, tb_TedarikciYetkilikisi.Text, tb_TedarikciAdres.Text, tb_TedarikciTelefon.Text, tb_TedarikciEmail.Text, "A", guncellenecekid);
                MessageBox.Show("Bu müşteri başarıyla kaydedildi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
