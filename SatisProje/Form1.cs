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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            Musteri m1 = new Musteri();
            m1.TopLevel = false;
            pnlislem.Controls.Add(m1);
            m1.Show();
            m1.Dock = DockStyle.Fill;
        }

        private void btn_Parametreler_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            Parametreler p1 = new Parametreler();
            p1.TopLevel = false;
            pnlislem.Controls.Add(p1);
            p1.Show();
            p1.Dock = DockStyle.Fill;
        }

        private void btn_Tedarikci_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            Tedarikci m1 = new Tedarikci();
            m1.TopLevel = false;
            pnlislem.Controls.Add(m1);
            m1.Show();
            m1.Dock = DockStyle.Fill;
        }

        private void btn_Urunler_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            Urun m1 = new Urun();
            m1.TopLevel = false;
            pnlislem.Controls.Add(m1);
            m1.Show();
            m1.Dock = DockStyle.Fill;
        }

        private void btn_Urunal_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            Urunal m1 = new Urunal();
            m1.TopLevel = false;
            pnlislem.Controls.Add(m1);
            m1.Show();
            m1.Dock = DockStyle.Fill;
        }

        private void btn_Urunsat_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            Urunsat m1 = new Urunsat();
            m1.TopLevel = false;
            pnlislem.Controls.Add(m1);
            m1.Show();
            m1.Dock = DockStyle.Fill;
        }

        private void btn_Muhasebe_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            Muhasebe m1 = new Muhasebe();
            m1.TopLevel = false;
            pnlislem.Controls.Add(m1);
            m1.Show();
            m1.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            pnlislem.Controls.Clear();
            Raporlar p1 = new Raporlar();
            p1.TopLevel = false;
            pnlislem.Controls.Add(p1);
            p1.Show();
            p1.Dock = DockStyle.Fill;
        }
    }
}
