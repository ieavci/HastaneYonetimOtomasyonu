namespace Hastane_Yonetim_Otomasyonu
{
    partial class frmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHastaSifre = new System.Windows.Forms.TextBox();
            this.maskedTextHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.buttonHastaGiris = new System.Windows.Forms.Button();
            this.linkLabelKayit = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "TC Kimlik No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(124, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(168, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Hesabın yok mu?";
            // 
            // textBoxHastaSifre
            // 
            this.textBoxHastaSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxHastaSifre.Location = new System.Drawing.Point(182, 229);
            this.textBoxHastaSifre.Name = "textBoxHastaSifre";
            this.textBoxHastaSifre.Size = new System.Drawing.Size(156, 26);
            this.textBoxHastaSifre.TabIndex = 2;
            this.textBoxHastaSifre.UseSystemPasswordChar = true;
            // 
            // maskedTextHastaTC
            // 
            this.maskedTextHastaTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextHastaTC.Location = new System.Drawing.Point(182, 183);
            this.maskedTextHastaTC.Mask = "00000000000";
            this.maskedTextHastaTC.Name = "maskedTextHastaTC";
            this.maskedTextHastaTC.Size = new System.Drawing.Size(156, 26);
            this.maskedTextHastaTC.TabIndex = 1;
            this.maskedTextHastaTC.ValidatingType = typeof(int);
            // 
            // buttonHastaGiris
            // 
            this.buttonHastaGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHastaGiris.Location = new System.Drawing.Point(217, 273);
            this.buttonHastaGiris.Name = "buttonHastaGiris";
            this.buttonHastaGiris.Size = new System.Drawing.Size(75, 32);
            this.buttonHastaGiris.TabIndex = 3;
            this.buttonHastaGiris.Text = "Giriş";
            this.buttonHastaGiris.UseVisualStyleBackColor = true;
            this.buttonHastaGiris.Click += new System.EventHandler(this.buttonHastaGiris_Click);
            // 
            // linkLabelKayit
            // 
            this.linkLabelKayit.AutoSize = true;
            this.linkLabelKayit.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelKayit.Location = new System.Drawing.Point(279, 318);
            this.linkLabelKayit.Name = "linkLabelKayit";
            this.linkLabelKayit.Size = new System.Drawing.Size(59, 18);
            this.linkLabelKayit.TabIndex = 4;
            this.linkLabelKayit.TabStop = true;
            this.linkLabelKayit.Text = "Kayıt Ol";
            this.linkLabelKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKayit_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // frmHastaGiris
            // 
            this.AcceptButton = this.buttonHastaGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 510);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelKayit);
            this.Controls.Add(this.buttonHastaGiris);
            this.Controls.Add(this.maskedTextHastaTC);
            this.Controls.Add(this.textBoxHastaSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHastaGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmHastaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHastaSifre;
        private System.Windows.Forms.MaskedTextBox maskedTextHastaTC;
        private System.Windows.Forms.Button buttonHastaGiris;
        private System.Windows.Forms.LinkLabel linkLabelKayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}