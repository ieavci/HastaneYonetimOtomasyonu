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
    public partial class frmBransBilgiGuncelle : Form
    {
        public frmBransBilgiGuncelle()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();

        private void frmBransBilgiGuncelle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.connection().Close();
        }

        private void buttonKayitEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_branslar (Bransad) values (@w2)", conn.connection());
            komut.Parameters.AddWithValue("@w2", textBoxBransAd.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Branş Kaydı Eklendi", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.connection().Close();
        }

        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_branslar where bransid=@p1", conn.connection());
            komut.Parameters.AddWithValue("@p1", textBoxBransid.Text);
            MessageBox.Show("Branş Kaydı Silindi", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            komut.ExecuteNonQuery();
            conn.connection().Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxBransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void buttonKayitGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_branslar set bransad=@p1 where bransid=@p2", conn.connection());
            komut.Parameters.AddWithValue("@p1", textBoxBransAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxBransid.Text);
            komut.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Branş Kaydı Güncellendi", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
