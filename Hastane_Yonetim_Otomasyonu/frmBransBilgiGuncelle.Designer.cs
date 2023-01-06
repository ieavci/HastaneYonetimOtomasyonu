namespace Hastane_Yonetim_Otomasyonu
{
    partial class frmBransBilgiGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBransBilgiGuncelle));
            this.buttonKayitSil = new System.Windows.Forms.Button();
            this.buttonKayitGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonKayitEkle = new System.Windows.Forms.Button();
            this.textBoxBransid = new System.Windows.Forms.TextBox();
            this.textBoxBransAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKayitSil
            // 
            this.buttonKayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayitSil.Location = new System.Drawing.Point(147, 252);
            this.buttonKayitSil.Name = "buttonKayitSil";
            this.buttonKayitSil.Size = new System.Drawing.Size(85, 33);
            this.buttonKayitSil.TabIndex = 77;
            this.buttonKayitSil.Text = "Sil";
            this.buttonKayitSil.UseVisualStyleBackColor = true;
            this.buttonKayitSil.Click += new System.EventHandler(this.buttonKayitSil_Click);
            // 
            // buttonKayitGuncelle
            // 
            this.buttonKayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayitGuncelle.Location = new System.Drawing.Point(238, 252);
            this.buttonKayitGuncelle.Name = "buttonKayitGuncelle";
            this.buttonKayitGuncelle.Size = new System.Drawing.Size(85, 33);
            this.buttonKayitGuncelle.TabIndex = 76;
            this.buttonKayitGuncelle.Text = "Güncelle";
            this.buttonKayitGuncelle.UseVisualStyleBackColor = true;
            this.buttonKayitGuncelle.Click += new System.EventHandler(this.buttonKayitGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 370);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonKayitEkle
            // 
            this.buttonKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayitEkle.Location = new System.Drawing.Point(54, 252);
            this.buttonKayitEkle.Name = "buttonKayitEkle";
            this.buttonKayitEkle.Size = new System.Drawing.Size(85, 33);
            this.buttonKayitEkle.TabIndex = 72;
            this.buttonKayitEkle.Text = "Ekle";
            this.buttonKayitEkle.UseVisualStyleBackColor = true;
            this.buttonKayitEkle.Click += new System.EventHandler(this.buttonKayitEkle_Click);
            // 
            // textBoxBransid
            // 
            this.textBoxBransid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBransid.Location = new System.Drawing.Point(167, 136);
            this.textBoxBransid.Name = "textBoxBransid";
            this.textBoxBransid.Size = new System.Drawing.Size(156, 26);
            this.textBoxBransid.TabIndex = 70;
            // 
            // textBoxBransAd
            // 
            this.textBoxBransAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBransAd.Location = new System.Drawing.Point(167, 182);
            this.textBoxBransAd.Name = "textBoxBransAd";
            this.textBoxBransAd.Size = new System.Drawing.Size(156, 26);
            this.textBoxBransAd.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Branş Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Branş ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // frmBransBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonKayitSil);
            this.Controls.Add(this.buttonKayitGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonKayitEkle);
            this.Controls.Add(this.textBoxBransid);
            this.Controls.Add(this.textBoxBransAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBransBilgiGuncelle";
            this.Text = "Branş Bilgi Güncelle";
            this.Load += new System.EventHandler(this.frmBransBilgiGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKayitSil;
        private System.Windows.Forms.Button buttonKayitGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKayitEkle;
        private System.Windows.Forms.TextBox textBoxBransid;
        private System.Windows.Forms.TextBox textBoxBransAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}