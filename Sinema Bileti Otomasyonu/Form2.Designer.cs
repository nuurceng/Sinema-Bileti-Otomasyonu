namespace Sinema_Bileti_Otomasyonu
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbfilmadi = new System.Windows.Forms.TextBox();
            this.tbyonetmen = new System.Windows.Forms.TextBox();
            this.tbsure = new System.Windows.Forms.TextBox();
            this.cbfilmturu = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnfilmekle = new System.Windows.Forms.Button();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetmen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Süre:";
            // 
            // tbfilmadi
            // 
            this.tbfilmadi.Location = new System.Drawing.Point(254, 56);
            this.tbfilmadi.Name = "tbfilmadi";
            this.tbfilmadi.Size = new System.Drawing.Size(171, 20);
            this.tbfilmadi.TabIndex = 6;
            // 
            // tbyonetmen
            // 
            this.tbyonetmen.Location = new System.Drawing.Point(254, 89);
            this.tbyonetmen.Name = "tbyonetmen";
            this.tbyonetmen.Size = new System.Drawing.Size(171, 20);
            this.tbyonetmen.TabIndex = 7;
            // 
            // tbsure
            // 
            this.tbsure.Location = new System.Drawing.Point(254, 149);
            this.tbsure.Name = "tbsure";
            this.tbsure.Size = new System.Drawing.Size(171, 20);
            this.tbsure.TabIndex = 8;
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
            this.cbfilmturu.Location = new System.Drawing.Point(254, 120);
            this.cbfilmturu.Name = "cbfilmturu";
            this.cbfilmturu.Size = new System.Drawing.Size(171, 21);
            this.cbfilmturu.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 214);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnfilmekle
            // 
            this.btnfilmekle.Location = new System.Drawing.Point(342, 244);
            this.btnfilmekle.Name = "btnfilmekle";
            this.btnfilmekle.Size = new System.Drawing.Size(83, 50);
            this.btnfilmekle.TabIndex = 13;
            this.btnfilmekle.Text = "Film Ekle";
            this.btnfilmekle.UseVisualStyleBackColor = true;
            this.btnfilmekle.Click += new System.EventHandler(this.btnfilmekle_Click);
            // 
            // btnresimekle
            // 
            this.btnresimekle.Location = new System.Drawing.Point(93, 244);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(79, 50);
            this.btnresimekle.TabIndex = 14;
            this.btnresimekle.Text = "Resim Ekle";
            this.btnresimekle.UseVisualStyleBackColor = true;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tarih:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(445, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnresimekle);
            this.Controls.Add(this.btnfilmekle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbfilmturu);
            this.Controls.Add(this.tbsure);
            this.Controls.Add(this.tbyonetmen);
            this.Controls.Add(this.tbfilmadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Ekleme Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbfilmadi;
        private System.Windows.Forms.TextBox tbyonetmen;
        private System.Windows.Forms.TextBox tbsure;
        private System.Windows.Forms.ComboBox cbfilmturu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnfilmekle;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
    }
}