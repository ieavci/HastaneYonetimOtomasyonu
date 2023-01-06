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
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();
        private void buttonDoktorGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_Sekreterler where SekreterTc=@p1 and SekreterSifre=@p2", conn.connection());
            komut.Parameters.AddWithValue("@p1", maskedTextSekreterTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSekreterSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()==true)
            {
                frmSekreterDetay frmSekreterDetay = new frmSekreterDetay();
                this.Hide();
                frmSekreterDetay.tcNo = maskedTextSekreterTC.Text;
                frmSekreterDetay.Show();
            }
            conn.connection().Close();
        }
    }
}
