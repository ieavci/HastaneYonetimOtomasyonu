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
    public partial class frmHastaKayit : Form
    {
        public frmHastaKayit()
        {
            InitializeComponent();
        }

        sqlBaglantisi conn = new sqlBaglantisi();
        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_hastalar (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn.connection());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextTcKayit.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextTelefon.Text);
            komut.Parameters.AddWithValue("@p5", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxCinsiyet.Text);
            komut.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Hasta Kaydı Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }
    }
}
