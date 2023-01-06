using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yonetim_Otomasyonu
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

            
        }

        private void buttonHastaGiris_Click(object sender, EventArgs e)
        {
            frmHastaGiris frmHastaGiris = new frmHastaGiris();
            frmHastaGiris.Show();
            this.Hide();
        }

        private void buttonDoktorGiris_Click(object sender, EventArgs e)
        {
            frmDoktorGiris frmDoktorGiris = new frmDoktorGiris();
            frmDoktorGiris.Show();
            this.Hide();
        }

        private void buttonSekreterGiris_Click(object sender, EventArgs e)
        {
            frmSekreterGiris frmSekreterGiris = new frmSekreterGiris();
            frmSekreterGiris.Show();
            this.Hide();
        }
    }
}
