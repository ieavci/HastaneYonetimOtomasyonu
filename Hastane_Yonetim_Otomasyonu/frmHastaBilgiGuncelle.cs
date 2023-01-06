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
    public partial class frmHastaBilgiGuncelle : Form
    {
        public frmHastaBilgiGuncelle()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();
        public string TCno;
        private void frmHastaBilgiGuncelle_Load(object sender, EventArgs e)
        {
            maskedTextTcKayit.Text = TCno;
            SqlCommand komut = new SqlCommand("select * from tbl_Hastalar where HastaTC=@p1", conn.connection());
            komut.Parameters.AddWithValue("@p1", maskedTextTcKayit.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                maskedTextTelefon.Text = dr[4].ToString();
                textBoxSifre.Text = dr[5].ToString();
                comboBoxCinsiyet.Text = dr[6].ToString();
            }
            conn.connection().Close();
        }

        private void buttonKayitGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", conn.connection());
            komut2.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", textBoxSifre.Text);
            komut2.Parameters.AddWithValue("@p5", comboBoxCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", maskedTextTcKayit.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Hasta Bilgileri Düzenlendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.connection().Close();
        }
    }
}
