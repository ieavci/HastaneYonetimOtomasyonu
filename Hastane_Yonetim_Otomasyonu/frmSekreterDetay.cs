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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        
        public string tcNo;
        sqlBaglantisi conn = new sqlBaglantisi();

        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {

            //ad soyad yazma
            labelSekBilgi.Text = tcNo;
            SqlCommand komut = new SqlCommand("select sekreteradsoyad from tbl_sekreterler where sekreterTc=@p1", conn.connection());
            komut.Parameters.AddWithValue("@p1", labelSekBilgi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelsekAdSoyad.Text = dr[0].ToString();
            }
            conn.connection().Close();

            //branşları datagride aktarma

            DataTable dt = new DataTable();//branşlar
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar", conn.connection());
            da.Fill(dt);
            dataGridViewBranslar.DataSource = dt;
            conn.connection().Close();

            DataTable dt2 = new DataTable();//doktorlar
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_doktorlar", conn.connection());
            da2.Fill(dt2);
            dataGridViewDoktorlar.DataSource = dt2;
            conn.connection().Close();

            //branşları ve doktorları comboboxa aktarma
            SqlCommand komut1 = new SqlCommand("select bransad from tbl_branslar", conn.connection());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                comboBoxBrans.Items.Add(dr1[0]);
            }
            conn.connection().Close();
            
        }

        private void buttonRanKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_randevular (randevutarih,randevusaat,randevubrans,randevudoktor) values (@p1,@p2,@p3,@p4)", conn.connection());
            komut.Parameters.AddWithValue("@p1", maskedTextTarih.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextSaat.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxDoktor.Text);
            komut.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Randevu Oluşturuldu");

        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
            SqlCommand komut2 = new SqlCommand("select Doktorad,Doktorsoyad from tbl_doktorlar where doktorbrans=@d1", conn.connection());
            komut2.Parameters.AddWithValue("@d1", comboBoxBrans.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) 
            {
                comboBoxDoktor.Items.Add(dr2[0]+" "+dr2[1]);
            }
            conn.connection().Close();
        }

        private void buttonSekDuyuruOlus_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru) values (@duy1)", conn.connection());
            komut.Parameters.AddWithValue("@duy1", richTextSekDuyuru.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextSekDuyuru.Clear();
            conn.connection().Close();
        }

        private void buttonDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmSekDoktorBilgiGuncelle frmDoktorBilgiGuncelle = new frmSekDoktorBilgiGuncelle();
            frmDoktorBilgiGuncelle.Show();
        }

        private void buttonBransPaneli_Click(object sender, EventArgs e)
        {
            frmBransBilgiGuncelle frmBransBilgiGuncelle = new frmBransBilgiGuncelle();
            frmBransBilgiGuncelle.Show();
        }

        private void buttonRanListesi_Click(object sender, EventArgs e)
        {
            frmRandevuListesi frmRandevular = new frmRandevuListesi();
            frmRandevular.Show();
        }

        private void buttonRanGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
