using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Yonetim_Otomasyonu
{
    public partial class frmHastaGiris : Form
    {
        public frmHastaGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();

        private void frmHastaGiris_Load(object sender, EventArgs e)
        {
            maskedTextHastaTC.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayit frmHastaKayit = new frmHastaKayit();
            frmHastaKayit.Show();
        }

        private void buttonHastaGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", conn.connection());
            komut.Parameters.AddWithValue("@p1", maskedTextHastaTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxHastaSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()==true)
            {
                frmHastaDetay frmHastaDetay = new frmHastaDetay();
                frmHastaDetay.tc = maskedTextHastaTC.Text;
                frmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC Kimlik Numarası veya Şifre Hatalı", "Lütfen Tekrar Deneyin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connection().Close();
        }
    }
}
