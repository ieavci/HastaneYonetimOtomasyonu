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
    public partial class frmDrBilgiGuncelle : Form
    {
        public frmDrBilgiGuncelle()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();
        public string doktorTC;

        private void buttonKayitGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5", conn.connection());
            komut.Parameters.AddWithValue("@p1",textBoxDrAd.Text);
            komut.Parameters.AddWithValue("@p2",textBoxDrSoyad.Text);
            komut.Parameters.AddWithValue("@p3",comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@p4",textBoxDrSifre.Text);
            komut.Parameters.AddWithValue("@p5",maskedTextDrTcKayit.Text);
            komut.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmDrBilgiGuncelle_Load(object sender, EventArgs e)
        {
            maskedTextDrTcKayit.Text = doktorTC;
            SqlCommand komut = new SqlCommand("Select * from tbl_doktorlar where DoktorTc=@p1", conn.connection());
            komut.Parameters.AddWithValue("@p1", maskedTextDrTcKayit.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxDrAd.Text = dr[1].ToString();
                textBoxDrSoyad.Text = dr[2].ToString();
                comboBoxBrans.Text = dr[3].ToString(); 
                textBoxDrSifre.Text = dr[5].ToString(); 
                
            }
            conn.connection().Close();
            //branşları çekme
            SqlCommand komut2 = new SqlCommand("select BransAd from tbl_branslar",conn.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            conn.connection().Close();
        }
    }
}
