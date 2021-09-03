namespace Sinema_Bileti_Otomasyonu
{
    partial class Form8
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
            this.btnfilmduzenle = new System.Windows.Forms.Button();
            this.btnfilmsil = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbfilmturu = new System.Windows.Forms.ComboBox();
            this.tbsure = new System.Windows.Forms.TextBox();
            this.tbyonetmen = new System.Windows.Forms.TextBox();
            this.tbfilmadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aranan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfilmduzenle
            // 
            this.btnfilmduzenle.Location = new System.Drawing.Point(167, 414);
            this.btnfilmduzenle.Name = "btnfilmduzenle";
            this.btnfilmduzenle.Size = new System.Drawing.Size(75, 52);
            this.btnfilmduzenle.TabIndex = 1;
            this.btnfilmduzenle.Text = "Film Düzenle";
            this.btnfilmduzenle.UseVisualStyleBackColor = true;
            this.btnfilmduzenle.Click += new System.EventHandler(this.btnfilmduzenle_Click);
            // 
            // btnfilmsil
            // 
            this.btnfilmsil.Location = new System.Drawing.Point(263, 414);
            this.btnfilmsil.Name = "btnfilmsil";
            this.btnfilmsil.Size = new System.Drawing.Size(75, 52);
            this.btnfilmsil.TabIndex = 2;
            this.btnfilmsil.Text = "Film Sil";
            this.btnfilmsil.UseVisualStyleBackColor = true;
            this.btnfilmsil.Click += new System.EventHandler(this.btnfilmsil_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 391);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // cbfilmturu
            // 
            this.cbfilmturu.FormattingEnabled = true;
            this.cbfilmturu.Items.AddRange(new object[] {
            "Dram",
            "Komedi",
            "Animasyon",
            "Macera",
            "Korku",
            "Aksiyon ",
            "Belgesel",
            "Bilim Kurgu",
            "Suç",
            "Gerilim"});
            this.cbfilmturu.Location = new System.Drawing.Point(167, 331);
            this.cbfilmturu.Name = "cbfilmturu";
            this.cbfilmturu.Size = new System.Drawing.Size(171, 21);
            this.cbfilmturu.TabIndex = 22;
            // 
            // tbsure
            // 
            this.tbsure.Location = new System.Drawing.Point(167, 360);
            this.tbsure.Name = "tbsure";
            this.tbsure.Size = new System.Drawing.Size(171, 20);
            this.tbsure.TabIndex = 20;
            // 
            // tbyonetmen
            // 
            this.tbyonetmen.Location = new System.Drawing.Point(167, 300);
            this.tbyonetmen.Name = "tbyonetmen";
            this.tbyonetmen.Size = new System.Drawing.Size(171, 20);
            this.tbyonetmen.TabIndex = 19;
            // 
            // tbfilmadi
            // 
            this.tbfilmadi.Location = new System.Drawing.Point(167, 267);
            this.tbfilmadi.Name = "tbfilmadi";
            this.tbfilmadi.Size = new System.Drawing.Size(171, 20);
            this.tbfilmadi.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Süre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Film Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yönetmen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Film Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.aranan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 261);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeleme Ve Arama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // aranan
            // 
            this.aranan.Location = new System.Drawing.Point(217, 27);
            this.aranan.Name = "aranan";
            this.aranan.Size = new System.Drawing.Size(207, 20);
            this.aranan.TabIndex = 2;
            this.aranan.TextChanged += new System.EventHandler(this.aranan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Film Adı Ara:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(356, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 199);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(573, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbfilmturu);
            this.Controls.Add(this.tbsure);
            this.Controls.Add(this.tbyonetmen);
            this.Controls.Add(this.tbfilmadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfilmsil);
            this.Controls.Add(this.btnfilmduzenle);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Düzenleme Silme Sayfası";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfilmduzenle;
        private System.Windows.Forms.Button btnfilmsil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbfilmturu;
        private System.Windows.Forms.TextBox tbsure;
        private System.Windows.Forms.TextBox tbyonetmen;
        private System.Windows.Forms.TextBox tbfilmadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox aranan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}