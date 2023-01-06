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
    public partial class frmSekDoktorBilgiGuncelle : Form
    {
        public frmSekDoktorBilgiGuncelle()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();

        private void frmSekDoktorBilgiGuncelle_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();//doktorlar
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_doktorlar", conn.connection());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            conn.connection().Close();

            //comboboxa branşları ekleme
            SqlCommand komut2 = new SqlCommand("select BransAd from tbl_branslar", conn.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            conn.connection().Close();
        }

        private void buttonKayitEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", conn.connection());
            komut.Parameters.AddWithValue("@p1", textBoxDrAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxDrSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextDrTcKayit.Text);
            komut.Parameters.AddWithValue("@p5", textBoxDrSifre.Text);
            
            komut.ExecuteNonQuery();
            MessageBox.Show("Doktor Kaydı Eklendi", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.connection().Close();
            


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxDrAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxDrSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextDrTcKayit.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxDrSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_doktorlar where DoktorTc=@r1", conn.connection());
            komut.Parameters.AddWithValue("@r1", maskedTextDrTcKayit.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Doktor Kaydı Silindi", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            conn.connection().Close();
        }

        private void buttonKayitGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Doktorlar set DoktorAd=@q1,DoktorSoyad=@q2,DoktorBrans=@q3,DoktorSifre=@q4 where doktorTc=@q5", conn.connection());
            komut.Parameters.AddWithValue("@q1", textBoxDrAd.Text);
            komut.Parameters.AddWithValue("@q2", textBoxDrSoyad.Text);
            komut.Parameters.AddWithValue("@q3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@q4", textBoxDrSifre.Text);
            komut.Parameters.AddWithValue("@q5", maskedTextDrTcKayit.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Doktor Kaydı Güncellendi", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.connection().Close();
        }
    }
}
