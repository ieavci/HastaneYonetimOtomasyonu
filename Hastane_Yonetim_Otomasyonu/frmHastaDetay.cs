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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();

        public string tc;

        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
           
            labelHastaBilgi.Text = tc;
            //SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from tbl_Hastalar where HastaTc=@p1", conn.connection());
            //komut.Parameters.AddWithValue("@p1", labelHastaBilgi.Text);

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_Randevular where HastaTc=" + tc, conn.connection());
            da.Fill(dt);
            dataGridRanGecmis.DataSource = dt;

            //branşları çekme 
            SqlCommand komut2 = new SqlCommand("select BransAd From Tbl_Branslar", conn.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            conn.connection().Close();
        }
        //branşa ait doktoru seçme
        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", conn.connection());
            komut3.Parameters.AddWithValue("@p1", comboBoxBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            conn.connection().Close();
        }
        //seçilen doktor için aktif randevuları görme
        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Randevular where RandevuBrans='" + comboBoxBrans.Text + "'and RandevuDoktor='"+comboBoxDoktor.Text+"'and RandevuDurum=0", conn.connection());
            da.Fill(dt);
            dataGridRanAktif.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHastaBilgiGuncelle frmHastaBilgiGuncelle = new frmHastaBilgiGuncelle();
            frmHastaBilgiGuncelle.TCno = labelHastaBilgi.Text;
            frmHastaBilgiGuncelle.Show();
        }

        private void dataGridRanAktif_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridRanAktif.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridRanAktif.Rows[secilen].Cells[0].Value.ToString();
        }

        private void buttonRanOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", conn.connection());
            komut.Parameters.AddWithValue("@p1", labelHastaBilgi.Text);
            komut.Parameters.AddWithValue("@p2", richTextBoxSikayet.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Randevu Başarıyla Oluşturuldu", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
