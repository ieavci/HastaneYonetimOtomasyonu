namespace Hastane_Yonetim_Otomasyonu
{
    partial class frmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterDetay));
            this.labelSekBilgi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSekDuyuruOlus = new System.Windows.Forms.Button();
            this.richTextSekDuyuru = new System.Windows.Forms.RichTextBox();
            this.Re = new System.Windows.Forms.GroupBox();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.maskedTextTc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextTarih = new System.Windows.Forms.MaskedTextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxDurum = new System.Windows.Forms.CheckBox();
            this.buttonRanGuncelle = new System.Windows.Forms.Button();
            this.buttonRanKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBranslar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDoktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonRanListesi = new System.Windows.Forms.Button();
            this.buttonBransPaneli = new System.Windows.Forms.Button();
            this.buttonDoktorPaneli = new System.Windows.Forms.Button();
            this.labelsekAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Re.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranslar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorlar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSekBilgi
            // 
            this.labelSekBilgi.AutoSize = true;
            this.labelSekBilgi.BackColor = System.Drawing.Color.Transparent;
            this.labelSekBilgi.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSekBilgi.Location = new System.Drawing.Point(21, 58);
            this.labelSekBilgi.Name = "labelSekBilgi";
            this.labelSekBilgi.Size = new System.Drawing.Size(128, 23);
            this.labelSekBilgi.TabIndex = 30;
            this.labelSekBilgi.Text = "Null Null Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sekreter Bilgi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonSekDuyuruOlus);
            this.groupBox1.Controls.Add(this.richTextSekDuyuru);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 228);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duyuru Oluştur";
            // 
            // buttonSekDuyuruOlus
            // 
            this.buttonSekDuyuruOlus.Location = new System.Drawing.Point(82, 190);
            this.buttonSekDuyuruOlus.Name = "buttonSekDuyuruOlus";
            this.buttonSekDuyuruOlus.Size = new System.Drawing.Size(79, 32);
            this.buttonSekDuyuruOlus.TabIndex = 1;
            this.buttonSekDuyuruOlus.Text = "Oluştur";
            this.buttonSekDuyuruOlus.UseVisualStyleBackColor = true;
            this.buttonSekDuyuruOlus.Click += new System.EventHandler(this.buttonSekDuyuruOlus_Click);
            // 
            // richTextSekDuyuru
            // 
            this.richTextSekDuyuru.Location = new System.Drawing.Point(3, 22);
            this.richTextSekDuyuru.Name = "richTextSekDuyuru";
            this.richTextSekDuyuru.Size = new System.Drawing.Size(241, 162);
            this.richTextSekDuyuru.TabIndex = 0;
            this.richTextSekDuyuru.Text = "";
            // 
            // Re
            // 
            this.Re.BackColor = System.Drawing.Color.Transparent;
            this.Re.Controls.Add(this.comboBoxDoktor);
            this.Re.Controls.Add(this.comboBoxBrans);
            this.Re.Controls.Add(this.maskedTextTc);
            this.Re.Controls.Add(this.maskedTextSaat);
            this.Re.Controls.Add(this.maskedTextTarih);
            this.Re.Controls.Add(this.textBoxid);
            this.Re.Controls.Add(this.label7);
            this.Re.Controls.Add(this.checkBoxDurum);
            this.Re.Controls.Add(this.buttonRanGuncelle);
            this.Re.Controls.Add(this.buttonRanKaydet);
            this.Re.Controls.Add(this.label6);
            this.Re.Controls.Add(this.label4);
            this.Re.Controls.Add(this.label3);
            this.Re.Controls.Add(this.label2);
            this.Re.Controls.Add(this.label1);
            this.Re.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Re.Location = new System.Drawing.Point(265, 12);
            this.Re.Name = "Re";
            this.Re.Size = new System.Drawing.Size(233, 329);
            this.Re.TabIndex = 32;
            this.Re.TabStop = false;
            this.Re.Text = "Randevu Paneli";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(79, 170);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(140, 28);
            this.comboBoxDoktor.TabIndex = 16;
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(80, 136);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(140, 28);
            this.comboBoxBrans.TabIndex = 15;
            this.comboBoxBrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrans_SelectedIndexChanged);
            // 
            // maskedTextTc
            // 
            this.maskedTextTc.Location = new System.Drawing.Point(80, 201);
            this.maskedTextTc.Mask = "00000000000";
            this.maskedTextTc.Name = "maskedTextTc";
            this.maskedTextTc.Size = new System.Drawing.Size(141, 26);
            this.maskedTextTc.TabIndex = 14;
            this.maskedTextTc.ValidatingType = typeof(int);
            // 
            // maskedTextSaat
            // 
            this.maskedTextSaat.Location = new System.Drawing.Point(79, 104);
            this.maskedTextSaat.Mask = "00:00";
            this.maskedTextSaat.Name = "maskedTextSaat";
            this.maskedTextSaat.Size = new System.Drawing.Size(141, 26);
            this.maskedTextSaat.TabIndex = 11;
            this.maskedTextSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextTarih
            // 
            this.maskedTextTarih.Location = new System.Drawing.Point(79, 70);
            this.maskedTextTarih.Mask = "00/00/0000";
            this.maskedTextTarih.Name = "maskedTextTarih";
            this.maskedTextTarih.Size = new System.Drawing.Size(141, 26);
            this.maskedTextTarih.TabIndex = 10;
            this.maskedTextTarih.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(80, 34);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(140, 26);
            this.textBoxid.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "TC:";
            // 
            // checkBoxDurum
            // 
            this.checkBoxDurum.AutoSize = true;
            this.checkBoxDurum.Location = new System.Drawing.Point(80, 236);
            this.checkBoxDurum.Name = "checkBoxDurum";
            this.checkBoxDurum.Size = new System.Drawing.Size(76, 24);
            this.checkBoxDurum.TabIndex = 7;
            this.checkBoxDurum.Text = "Durum";
            this.checkBoxDurum.UseVisualStyleBackColor = true;
            // 
            // buttonRanGuncelle
            // 
            this.buttonRanGuncelle.Location = new System.Drawing.Point(125, 285);
            this.buttonRanGuncelle.Name = "buttonRanGuncelle";
            this.buttonRanGuncelle.Size = new System.Drawing.Size(83, 35);
            this.buttonRanGuncelle.TabIndex = 6;
            this.buttonRanGuncelle.Text = "Güncelle";
            this.buttonRanGuncelle.UseVisualStyleBackColor = true;
            this.buttonRanGuncelle.Click += new System.EventHandler(this.buttonRanGuncelle_Click);
            // 
            // buttonRanKaydet
            // 
            this.buttonRanKaydet.Location = new System.Drawing.Point(27, 284);
            this.buttonRanKaydet.Name = "buttonRanKaydet";
            this.buttonRanKaydet.Size = new System.Drawing.Size(82, 35);
            this.buttonRanKaydet.TabIndex = 5;
            this.buttonRanKaydet.Text = "Kaydet";
            this.buttonRanKaydet.UseVisualStyleBackColor = true;
            this.buttonRanKaydet.Click += new System.EventHandler(this.buttonRanKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doktor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridViewBranslar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(526, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 194);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Branşlar";
            // 
            // dataGridViewBranslar
            // 
            this.dataGridViewBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBranslar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBranslar.GridColor = System.Drawing.Color.Black;
            this.dataGridViewBranslar.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewBranslar.Name = "dataGridViewBranslar";
            this.dataGridViewBranslar.Size = new System.Drawing.Size(302, 169);
            this.dataGridViewBranslar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridViewDoktorlar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(526, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 213);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doktorlar";
            // 
            // dataGridViewDoktorlar
            // 
            this.dataGridViewDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoktorlar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktorlar.GridColor = System.Drawing.Color.Black;
            this.dataGridViewDoktorlar.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewDoktorlar.Name = "dataGridViewDoktorlar";
            this.dataGridViewDoktorlar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewDoktorlar.Size = new System.Drawing.Size(302, 188);
            this.dataGridViewDoktorlar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.buttonRanListesi);
            this.groupBox4.Controls.Add(this.buttonBransPaneli);
            this.groupBox4.Controls.Add(this.buttonDoktorPaneli);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(15, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 82);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // buttonRanListesi
            // 
            this.buttonRanListesi.Location = new System.Drawing.Point(326, 32);
            this.buttonRanListesi.Name = "buttonRanListesi";
            this.buttonRanListesi.Size = new System.Drawing.Size(136, 35);
            this.buttonRanListesi.TabIndex = 17;
            this.buttonRanListesi.Text = "Randevu Listesi";
            this.buttonRanListesi.UseVisualStyleBackColor = true;
            this.buttonRanListesi.Click += new System.EventHandler(this.buttonRanListesi_Click);
            // 
            // buttonBransPaneli
            // 
            this.buttonBransPaneli.Location = new System.Drawing.Point(179, 32);
            this.buttonBransPaneli.Name = "buttonBransPaneli";
            this.buttonBransPaneli.Size = new System.Drawing.Size(136, 35);
            this.buttonBransPaneli.TabIndex = 16;
            this.buttonBransPaneli.Text = "Branş Paneli";
            this.buttonBransPaneli.UseVisualStyleBackColor = true;
            this.buttonBransPaneli.Click += new System.EventHandler(this.buttonBransPaneli_Click);
            // 
            // buttonDoktorPaneli
            // 
            this.buttonDoktorPaneli.Location = new System.Drawing.Point(31, 32);
            this.buttonDoktorPaneli.Name = "buttonDoktorPaneli";
            this.buttonDoktorPaneli.Size = new System.Drawing.Size(136, 35);
            this.buttonDoktorPaneli.TabIndex = 15;
            this.buttonDoktorPaneli.Text = "Doktor Paneli";
            this.buttonDoktorPaneli.UseVisualStyleBackColor = true;
            this.buttonDoktorPaneli.Click += new System.EventHandler(this.buttonDoktorPaneli_Click);
            // 
            // labelsekAdSoyad
            // 
            this.labelsekAdSoyad.AutoSize = true;
            this.labelsekAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.labelsekAdSoyad.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsekAdSoyad.Location = new System.Drawing.Point(21, 82);
            this.labelsekAdSoyad.Name = "labelsekAdSoyad";
            this.labelsekAdSoyad.Size = new System.Drawing.Size(128, 23);
            this.labelsekAdSoyad.TabIndex = 36;
            this.labelsekAdSoyad.Text = "Null Null Null";
            // 
            // frmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.labelsekAdSoyad);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Re);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSekBilgi);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSekreterDetay";
            this.Text = "Sekreter Paneli";
            this.Load += new System.EventHandler(this.frmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.Re.ResumeLayout(false);
            this.Re.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranslar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorlar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSekBilgi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSekDuyuruOlus;
        private System.Windows.Forms.RichTextBox richTextSekDuyuru;
        private System.Windows.Forms.GroupBox Re;
        private System.Windows.Forms.MaskedTextBox maskedTextTc;
        private System.Windows.Forms.MaskedTextBox maskedTextSaat;
        private System.Windows.Forms.MaskedTextBox maskedTextTarih;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxDurum;
        private System.Windows.Forms.Button buttonRanGuncelle;
        private System.Windows.Forms.Button buttonRanKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewBranslar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonRanListesi;
        private System.Windows.Forms.Button buttonBransPaneli;
        private System.Windows.Forms.Button buttonDoktorPaneli;
        private System.Windows.Forms.DataGridView dataGridViewDoktorlar;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.Label labelsekAdSoyad;
    }
}