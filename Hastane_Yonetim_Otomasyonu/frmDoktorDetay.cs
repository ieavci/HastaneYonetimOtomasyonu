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
    public partial class frmDoktorDetay : Form
    {
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi conn = new sqlBaglantisi();
        public string doktorTC;

        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            labelDrTc.Text = doktorTC;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular", conn.connection());
            da.Fill(dt);
            dataGridRanListesi.DataSource = dt;
            conn.connection().Close();            
        }

        private void buttonDrAyarlar_Click(object sender, EventArgs e)
        {
            frmDrBilgiGuncelle frmDrBilgiGuncelle = new frmDrBilgiGuncelle();
            frmDrBilgiGuncelle.doktorTC = labelDrTc.Text;
            frmDrBilgiGuncelle.Show();
        }

        private void dataGridRanListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridRanListesi.SelectedCells[0].RowIndex;
            richTextDrRanDetay.Text = dataGridRanListesi.Rows[secilen].Cells[7].Value.ToString();
        }

        private void buttonDrDuyuru_Click(object sender, EventArgs e)
        {
            frmDrDuyurular frmDrDuyurular = new frmDrDuyurular();
            frmDrDuyurular.Show();
            
        }

        private void frmDoktorDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
