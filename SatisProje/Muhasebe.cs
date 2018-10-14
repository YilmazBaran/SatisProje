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
    public partial class Muhasebe : Form
    {
        public Muhasebe()
        {
            InitializeComponent();
        }

        private void cmb_Muhasebeislemtipi_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  cmb_MuhasebeMusteriadi.Items.Clear();
            SatisProjeEntities en = new SatisProjeEntities();
            if (cmb_MuhasebeIslemtipi.SelectedIndex == 0)
            {
                label2.Text = "Müşteri Adı:";
                //var dizi3 = en.Iliskiler.Where(t => t.Iliski_tipi == "M").ToList();
                //foreach (var item in dizi3)
                //{
                //    cmb_MuhasebeMusteriadi.Items.Add(item.Yetkili_kisi);

                //}

                cmb_MuhasebeMusteriadi.DisplayMember = "Yetkili_kisi";
                cmb_MuhasebeMusteriadi.ValueMember = "Id";
                cmb_MuhasebeMusteriadi.DataSource = en.Iliskiler.Where(t => t.Iliski_tipi == "M").ToList();
            }
            else
            {
                label2.Text = "Tedarikçi Adı:";
                //var dizi3 = en.Iliskiler.Where(t => t.Iliski_tipi == "T").ToList();
                //foreach (var item in dizi3)
                //{
                //    cmb_MuhasebeMusteriadi.Items.Add(item.Yetkili_kisi);

                //}

                cmb_MuhasebeMusteriadi.DisplayMember = "Yetkili_kisi";
                cmb_MuhasebeMusteriadi.ValueMember = "Id";
                cmb_MuhasebeMusteriadi.DataSource = en.Iliskiler.Where(t => t.Iliski_tipi == "T").ToList();

            }
        }

        private void Muhasebe_Load(object sender, EventArgs e)
        {
            cmb_MuhasebeIslemtipi.SelectedIndex = 0;

            //SatisProjeEntities en = new SatisProjeEntities();
            //var dizi = en.Iliskiler.ToList();
            //foreach (var item in dizi)
            //{
            //    cmb_MuhasebeMusteriadi.Items.Add(item.Yetkili_kisi);
            //}
        }

        private void dt_MuhasebeTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_MuhasebeKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SatisProjeEntities en = new SatisProjeEntities();
                string islemtipi;
                if (cmb_MuhasebeIslemtipi.SelectedIndex == 0)
                {
                    islemtipi = "G";
                }
                else
                {
                    islemtipi = "Y";
                }
                if (Convert.ToDecimal(tb_MuhasebeOdemetutari.Text)>Convert.ToDecimal(lbl_bakiye.Text))
                {
                    MessageBox.Show("Max " + lbl_bakiye.Text + " şu kadar Tl ödeme yapabilirsiniz");
                 }
                // int iliski_id = en.Iliskiler.Where(a => a.Yetkili_kisi == cmb_MuhasebeMusteriadi.Text).FirstOrDefault().Id;
                int iliski_id = Convert.ToInt32(cmb_MuhasebeMusteriadi.SelectedValue.ToString());
                 en.MUHASEBE_INSERT(islemtipi, iliski_id, Convert.ToDecimal(tb_MuhasebeOdemetutari.Text), dt_MuhasebeTarih.Value, tb_MuhasebeAciklama.Text);




            }

            //   MessageBox.Show("Bu müşteri başarıyla kaydedildi");

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void cmb_MuhasebeMusteriadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SatisProjeEntities en = new SatisProjeEntities();

            int iliski_id = Convert.ToInt32(cmb_MuhasebeMusteriadi.SelectedValue.ToString());

            decimal sum = en.Siparisler.Where(s => s.Iliski_id == iliski_id).ToList().Select(b => b.Islem_bakiye).Sum();

            decimal sum2 = en.Odemeler.Where(s => s.Iliski_id == iliski_id).ToList().Select(b => b.Islem_bakiye).Sum();

            lbl_bakiye.Text = (sum - sum2).ToString();
        }
    }
}
