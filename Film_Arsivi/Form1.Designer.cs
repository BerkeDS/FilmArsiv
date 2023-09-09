namespace Film_Arsivi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilmListe_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ekran_webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cikis_btn = new System.Windows.Forms.Button();
            this.Renk_btn = new System.Windows.Forms.Button();
            this.Hakkımızda_btn = new System.Windows.Forms.Button();
            this.TamEkran_btn = new System.Windows.Forms.Button();
            this.Kaydet_btn = new System.Windows.Forms.Button();
            this.Link_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kategori_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FilmAd_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmListe_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 88);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arşiv Yazılım";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilmListe_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(208, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // FilmListe_dataGridView
            // 
            this.FilmListe_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmListe_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmListe_dataGridView.Location = new System.Drawing.Point(3, 22);
            this.FilmListe_dataGridView.Name = "FilmListe_dataGridView";
            this.FilmListe_dataGridView.Size = new System.Drawing.Size(221, 310);
            this.FilmListe_dataGridView.TabIndex = 0;
            this.FilmListe_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmListe_dataGridView_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Ekran_webBrowser);
            this.groupBox2.Location = new System.Drawing.Point(441, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // Ekran_webBrowser
            // 
            this.Ekran_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ekran_webBrowser.Location = new System.Drawing.Point(3, 22);
            this.Ekran_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Ekran_webBrowser.Name = "Ekran_webBrowser";
            this.Ekran_webBrowser.Size = new System.Drawing.Size(390, 310);
            this.Ekran_webBrowser.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.Kaydet_btn);
            this.groupBox3.Controls.Add(this.Link_textBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Kategori_textBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.FilmAd_textBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(0, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 335);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Film";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Cikis_btn);
            this.groupBox4.Controls.Add(this.Renk_btn);
            this.groupBox4.Controls.Add(this.Hakkımızda_btn);
            this.groupBox4.Controls.Add(this.TamEkran_btn);
            this.groupBox4.Location = new System.Drawing.Point(6, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 153);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // Cikis_btn
            // 
            this.Cikis_btn.Location = new System.Drawing.Point(6, 121);
            this.Cikis_btn.Name = "Cikis_btn";
            this.Cikis_btn.Size = new System.Drawing.Size(178, 26);
            this.Cikis_btn.TabIndex = 3;
            this.Cikis_btn.Text = "Çıkış";
            this.Cikis_btn.UseVisualStyleBackColor = true;
            this.Cikis_btn.Click += new System.EventHandler(this.Cikis_btn_Click);
            // 
            // Renk_btn
            // 
            this.Renk_btn.Location = new System.Drawing.Point(6, 89);
            this.Renk_btn.Name = "Renk_btn";
            this.Renk_btn.Size = new System.Drawing.Size(178, 26);
            this.Renk_btn.TabIndex = 2;
            this.Renk_btn.Text = "Renk Değiştir";
            this.Renk_btn.UseVisualStyleBackColor = true;
            // 
            // Hakkımızda_btn
            // 
            this.Hakkımızda_btn.Location = new System.Drawing.Point(6, 57);
            this.Hakkımızda_btn.Name = "Hakkımızda_btn";
            this.Hakkımızda_btn.Size = new System.Drawing.Size(178, 26);
            this.Hakkımızda_btn.TabIndex = 1;
            this.Hakkımızda_btn.Text = "Hakkımızda";
            this.Hakkımızda_btn.UseVisualStyleBackColor = true;
            this.Hakkımızda_btn.Click += new System.EventHandler(this.Hakkımızda_btn_Click);
            // 
            // TamEkran_btn
            // 
            this.TamEkran_btn.Location = new System.Drawing.Point(6, 25);
            this.TamEkran_btn.Name = "TamEkran_btn";
            this.TamEkran_btn.Size = new System.Drawing.Size(178, 26);
            this.TamEkran_btn.TabIndex = 0;
            this.TamEkran_btn.Text = "Tam Ekran";
            this.TamEkran_btn.UseVisualStyleBackColor = true;
            // 
            // Kaydet_btn
            // 
            this.Kaydet_btn.Location = new System.Drawing.Point(78, 129);
            this.Kaydet_btn.Name = "Kaydet_btn";
            this.Kaydet_btn.Size = new System.Drawing.Size(118, 29);
            this.Kaydet_btn.TabIndex = 6;
            this.Kaydet_btn.Text = "Kaydet";
            this.Kaydet_btn.UseVisualStyleBackColor = true;
            this.Kaydet_btn.Click += new System.EventHandler(this.Kaydet_btn_Click);
            // 
            // Link_textBox
            // 
            this.Link_textBox.Location = new System.Drawing.Point(78, 97);
            this.Link_textBox.Name = "Link_textBox";
            this.Link_textBox.Size = new System.Drawing.Size(118, 26);
            this.Link_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Link:";
            // 
            // Kategori_textBox
            // 
            this.Kategori_textBox.Location = new System.Drawing.Point(78, 65);
            this.Kategori_textBox.Name = "Kategori_textBox";
            this.Kategori_textBox.Size = new System.Drawing.Size(118, 26);
            this.Kategori_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            // 
            // FilmAd_textBox
            // 
            this.FilmAd_textBox.Location = new System.Drawing.Point(78, 33);
            this.FilmAd_textBox.Name = "FilmAd_textBox";
            this.FilmAd_textBox.Size = new System.Drawing.Size(118, 26);
            this.FilmAd_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Ad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilmListe_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView FilmListe_dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser Ekran_webBrowser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Cikis_btn;
        private System.Windows.Forms.Button Renk_btn;
        private System.Windows.Forms.Button Hakkımızda_btn;
        private System.Windows.Forms.Button TamEkran_btn;
        private System.Windows.Forms.Button Kaydet_btn;
        private System.Windows.Forms.TextBox Link_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Kategori_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FilmAd_textBox;
        private System.Windows.Forms.Label label2;
    }
}

