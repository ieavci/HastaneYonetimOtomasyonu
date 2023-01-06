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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();

        private void buttonDoktorGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", conn.connection());
            komut.Parameters.AddWithValue("@p1", maskedTextDoktorTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxDoktorSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read() == true)
            {
                frmDoktorDetay frmDoktorDetay = new frmDoktorDetay();
                frmDoktorDetay.doktorTC = maskedTextDoktorTC.Text;
                frmDoktorDetay.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("TC Kimlik Numara veya Şifre Hatalı", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {


        }

        private void frmDoktorGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            Hide();
        }
    }
}
