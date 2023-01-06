namespace Hastane_Yonetim_Otomasyonu
{
    partial class frmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorDetay));
            this.buttonDrAyarlar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDrTc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDrDuyuru = new System.Windows.Forms.Button();
            this.richTextDrRanDetay = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridRanListesi = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRanListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrAyarlar
            // 
            this.buttonDrAyarlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDrAyarlar.BackgroundImage")));
            this.buttonDrAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDrAyarlar.Location = new System.Drawing.Point(233, 83);
            this.buttonDrAyarlar.Name = "buttonDrAyarlar";
            this.buttonDrAyarlar.Size = new System.Drawing.Size(49, 49);
            this.buttonDrAyarlar.TabIndex = 30;
            this.buttonDrAyarlar.UseVisualStyleBackColor = true;
            this.buttonDrAyarlar.Click += new System.EventHandler(this.buttonDrAyarlar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(193, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Bilgilerini Düzenle";
            // 
            // labelDrTc
            // 
            this.labelDrTc.AutoSize = true;
            this.labelDrTc.BackColor = System.Drawing.Color.Transparent;
            this.labelDrTc.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDrTc.Location = new System.Drawing.Point(33, 95);
            this.labelDrTc.Name = "labelDrTc";
            this.labelDrTc.Size = new System.Drawing.Size(128, 23);
            this.labelDrTc.TabIndex = 28;
            this.labelDrTc.Text = "Null Null Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(43, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Doktor Bilgi";
            // 
            // buttonDrDuyuru
            // 
            this.buttonDrDuyuru.AutoSize = true;
            this.buttonDrDuyuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDrDuyuru.Location = new System.Drawing.Point(197, 138);
            this.buttonDrDuyuru.Name = "buttonDrDuyuru";
            this.buttonDrDuyuru.Size = new System.Drawing.Size(128, 30);
            this.buttonDrDuyuru.TabIndex = 26;
            this.buttonDrDuyuru.Text = "Duyurular";
            this.buttonDrDuyuru.UseVisualStyleBackColor = true;
            this.buttonDrDuyuru.Click += new System.EventHandler(this.buttonDrDuyuru_Click);
            // 
            // richTextDrRanDetay
            // 
            this.richTextDrRanDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextDrRanDetay.Location = new System.Drawing.Point(32, 190);
            this.richTextDrRanDetay.Name = "richTextDrRanDetay";
            this.richTextDrRanDetay.Size = new System.Drawing.Size(279, 236);
            this.richTextDrRanDetay.TabIndex = 23;
            this.richTextDrRanDetay.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Randevu Detay:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridRanListesi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(348, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 419);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Listesi";
            // 
            // dataGridRanListesi
            // 
            this.dataGridRanListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRanListesi.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRanListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRanListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRanListesi.Location = new System.Drawing.Point(3, 20);
            this.dataGridRanListesi.Name = "dataGridRanListesi";
            this.dataGridRanListesi.Size = new System.Drawing.Size(456, 396);
            this.dataGridRanListesi.TabIndex = 0;
            this.dataGridRanListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRanListesi_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDrAyarlar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDrTc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDrDuyuru);
            this.Controls.Add(this.richTextDrRanDetay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoktorDetay";
            this.Text = "Doktor Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDoktorDetay_FormClosed);
            this.Load += new System.EventHandler(this.frmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRanListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrAyarlar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDrTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDrDuyuru;
        private System.Windows.Forms.RichTextBox richTextDrRanDetay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridRanListesi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}