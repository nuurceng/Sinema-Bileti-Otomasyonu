namespace Sinema_Bileti_Otomasyonu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbkoltukno = new System.Windows.Forms.TextBox();
            this.btnbiletsat = new System.Windows.Forms.Button();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.cbucret = new System.Windows.Forms.ComboBox();
            this.cbfilmseansi = new System.Windows.Forms.ComboBox();
            this.cbfilmtarihi = new System.Windows.Forms.ComboBox();
            this.cbsalonadi = new System.Windows.Forms.ComboBox();
            this.cbfilmadi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbiletiptal = new System.Windows.Forms.Button();
            this.cbkoltukiptal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filmduzenlesil = new System.Windows.Forms.Button();
            this.salonduzenlesil = new System.Windows.Forms.Button();
            this.btnsatislistele = new System.Windows.Forms.Button();
            this.seansduzenlesil = new System.Windows.Forms.Button();
            this.btnseansekle = new System.Windows.Forms.Button();
            this.btnfilmekle = new System.Windows.Forms.Button();
            this.btnsalonekle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbdolukoltuklar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbboskoltuklar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbkoltukno);
            this.groupBox1.Controls.Add(this.btnbiletsat);
            this.groupBox1.Controls.Add(this.tbsoyadi);
            this.groupBox1.Controls.Add(this.tbadi);
            this.groupBox1.Controls.Add(this.cbucret);
            this.groupBox1.Controls.Add(this.cbfilmseansi);
            this.groupBox1.Controls.Add(this.cbfilmtarihi);
            this.groupBox1.Controls.Add(this.cbsalonadi);
            this.groupBox1.Controls.Add(this.cbfilmadi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Satış";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Satıldığı \r\nTarih:";
            // 
            // tbkoltukno
            // 
            this.tbkoltukno.Enabled = false;
            this.tbkoltukno.Location = new System.Drawing.Point(65, 122);
            this.tbkoltukno.Name = "tbkoltukno";
            this.tbkoltukno.Size = new System.Drawing.Size(134, 20);
            this.tbkoltukno.TabIndex = 17;
            // 
            // btnbiletsat
            // 
            this.btnbiletsat.Location = new System.Drawing.Point(142, 255);
            this.btnbiletsat.Name = "btnbiletsat";
            this.btnbiletsat.Size = new System.Drawing.Size(75, 23);
            this.btnbiletsat.TabIndex = 16;
            this.btnbiletsat.Text = "Bilet Sat";
            this.btnbiletsat.UseVisualStyleBackColor = true;
            this.btnbiletsat.Click += new System.EventHandler(this.btnbiletsat_Click);
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(64, 174);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(135, 20);
            this.tbsoyadi.TabIndex = 15;
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(64, 148);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(135, 20);
            this.tbadi.TabIndex = 14;
            // 
            // cbucret
            // 
            this.cbucret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbucret.FormattingEnabled = true;
            this.cbucret.Items.AddRange(new object[] {
            "15",
            "20"});
            this.cbucret.Location = new System.Drawing.Point(64, 200);
            this.cbucret.Name = "cbucret";
            this.cbucret.Size = new System.Drawing.Size(135, 21);
            this.cbucret.TabIndex = 12;
            // 
            // cbfilmseansi
            // 
            this.cbfilmseansi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilmseansi.FormattingEnabled = true;
            this.cbfilmseansi.Location = new System.Drawing.Point(64, 95);
            this.cbfilmseansi.Name = "cbfilmseansi";
            this.cbfilmseansi.Size = new System.Drawing.Size(135, 21);
            this.cbfilmseansi.Sorted = true;
            this.cbfilmseansi.TabIndex = 11;
            this.cbfilmseansi.SelectedIndexChanged += new System.EventHandler(this.cbfilmseansi_SelectedIndexChanged);
            // 
            // cbfilmtarihi
            // 
            this.cbfilmtarihi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilmtarihi.FormattingEnabled = true;
            this.cbfilmtarihi.Location = new System.Drawing.Point(64, 68);
            this.cbfilmtarihi.Name = "cbfilmtarihi";
            this.cbfilmtarihi.Size = new System.Drawing.Size(135, 21);
            this.cbfilmtarihi.Sorted = true;
            this.cbfilmtarihi.TabIndex = 10;
            this.cbfilmtarihi.SelectedIndexChanged += new System.EventHandler(this.cbfilmtarihi_SelectedIndexChanged);
            // 
            // cbsalonadi
            // 
            this.cbsalonadi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsalonadi.FormattingEnabled = true;
            this.cbsalonadi.Location = new System.Drawing.Point(64, 41);
            this.cbsalonadi.Name = "cbsalonadi";
            this.cbsalonadi.Size = new System.Drawing.Size(135, 21);
            this.cbsalonadi.TabIndex = 9;
            this.cbsalonadi.SelectedIndexChanged += new System.EventHandler(this.cbsalonadi_SelectedIndexChanged);
            // 
            // cbfilmadi
            // 
            this.cbfilmadi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilmadi.FormattingEnabled = true;
            this.cbfilmadi.Location = new System.Drawing.Point(64, 14);
            this.cbfilmadi.Name = "cbfilmadi";
            this.cbfilmadi.Size = new System.Drawing.Size(135, 21);
            this.cbfilmadi.TabIndex = 8;
            this.cbfilmadi.SelectedIndexChanged += new System.EventHandler(this.cbfilmadi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ücret:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Koltuk No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Film Seansı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.btnbiletiptal);
            this.groupBox2.Controls.Add(this.cbkoltukiptal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(230, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet İptal";
            // 
            // btnbiletiptal
            // 
            this.btnbiletiptal.Location = new System.Drawing.Point(202, 53);
            this.btnbiletiptal.Name = "btnbiletiptal";
            this.btnbiletiptal.Size = new System.Drawing.Size(75, 23);
            this.btnbiletiptal.TabIndex = 2;
            this.btnbiletiptal.Text = "Bilet İptal";
            this.btnbiletiptal.UseVisualStyleBackColor = true;
            this.btnbiletiptal.Click += new System.EventHandler(this.btnbiletiptal_Click);
            // 
            // cbkoltukiptal
            // 
            this.cbkoltukiptal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkoltukiptal.FormattingEnabled = true;
            this.cbkoltukiptal.Location = new System.Drawing.Point(91, 26);
            this.cbkoltukiptal.Name = "cbkoltukiptal";
            this.cbkoltukiptal.Size = new System.Drawing.Size(121, 21);
            this.cbkoltukiptal.Sorted = true;
            this.cbkoltukiptal.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Koltuk No:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.filmduzenlesil);
            this.groupBox3.Controls.Add(this.salonduzenlesil);
            this.groupBox3.Controls.Add(this.btnsatislistele);
            this.groupBox3.Controls.Add(this.seansduzenlesil);
            this.groupBox3.Controls.Add(this.btnseansekle);
            this.groupBox3.Controls.Add(this.btnfilmekle);
            this.groupBox3.Controls.Add(this.btnsalonekle);
            this.groupBox3.Location = new System.Drawing.Point(230, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 128);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Genel";
            // 
            // filmduzenlesil
            // 
            this.filmduzenlesil.Location = new System.Drawing.Point(164, 76);
            this.filmduzenlesil.Name = "filmduzenlesil";
            this.filmduzenlesil.Size = new System.Drawing.Size(76, 40);
            this.filmduzenlesil.TabIndex = 7;
            this.filmduzenlesil.Text = "Film Düzenle Sil";
            this.filmduzenlesil.UseVisualStyleBackColor = true;
            this.filmduzenlesil.Click += new System.EventHandler(this.filmduzenlesil_Click);
            // 
            // salonduzenlesil
            // 
            this.salonduzenlesil.Location = new System.Drawing.Point(165, 22);
            this.salonduzenlesil.Name = "salonduzenlesil";
            this.salonduzenlesil.Size = new System.Drawing.Size(75, 40);
            this.salonduzenlesil.TabIndex = 6;
            this.salonduzenlesil.Text = "Salon Düzenle Sil";
            this.salonduzenlesil.UseVisualStyleBackColor = true;
            this.salonduzenlesil.Click += new System.EventHandler(this.salonduzenlesil_Click);
            // 
            // btnsatislistele
            // 
            this.btnsatislistele.Location = new System.Drawing.Point(392, 41);
            this.btnsatislistele.Name = "btnsatislistele";
            this.btnsatislistele.Size = new System.Drawing.Size(79, 54);
            this.btnsatislistele.TabIndex = 5;
            this.btnsatislistele.Text = "Satış Listele";
            this.btnsatislistele.UseVisualStyleBackColor = true;
            this.btnsatislistele.Click += new System.EventHandler(this.btnsatislistele_Click);
            // 
            // seansduzenlesil
            // 
            this.seansduzenlesil.Location = new System.Drawing.Point(280, 41);
            this.seansduzenlesil.Name = "seansduzenlesil";
            this.seansduzenlesil.Size = new System.Drawing.Size(77, 54);
            this.seansduzenlesil.TabIndex = 3;
            this.seansduzenlesil.Text = "Seans Listele Sil";
            this.seansduzenlesil.UseVisualStyleBackColor = true;
            this.seansduzenlesil.Click += new System.EventHandler(this.seansduzenlesil_Click);
            // 
            // btnseansekle
            // 
            this.btnseansekle.Location = new System.Drawing.Point(42, 90);
            this.btnseansekle.Name = "btnseansekle";
            this.btnseansekle.Size = new System.Drawing.Size(77, 30);
            this.btnseansekle.TabIndex = 2;
            this.btnseansekle.Text = "Seans Ekle";
            this.btnseansekle.UseVisualStyleBackColor = true;
            this.btnseansekle.Click += new System.EventHandler(this.btnseansekle_Click);
            // 
            // btnfilmekle
            // 
            this.btnfilmekle.Location = new System.Drawing.Point(42, 18);
            this.btnfilmekle.Name = "btnfilmekle";
            this.btnfilmekle.Size = new System.Drawing.Size(76, 31);
            this.btnfilmekle.TabIndex = 1;
            this.btnfilmekle.Text = "Film Ekle";
            this.btnfilmekle.UseVisualStyleBackColor = true;
            this.btnfilmekle.Click += new System.EventHandler(this.btnfilmekle_Click);
            // 
            // btnsalonekle
            // 
            this.btnsalonekle.Location = new System.Drawing.Point(42, 55);
            this.btnsalonekle.Name = "btnsalonekle";
            this.btnsalonekle.Size = new System.Drawing.Size(77, 29);
            this.btnsalonekle.TabIndex = 0;
            this.btnsalonekle.Text = "Salon Ekle";
            this.btnsalonekle.UseVisualStyleBackColor = true;
            this.btnsalonekle.Click += new System.EventHandler(this.btnsalonekle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.lbdolukoltuklar);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbboskoltuklar);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(519, 467);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 82);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // lbdolukoltuklar
            // 
            this.lbdolukoltuklar.AutoSize = true;
            this.lbdolukoltuklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbdolukoltuklar.ForeColor = System.Drawing.Color.Red;
            this.lbdolukoltuklar.Location = new System.Drawing.Point(61, 53);
            this.lbdolukoltuklar.Name = "lbdolukoltuklar";
            this.lbdolukoltuklar.Size = new System.Drawing.Size(121, 20);
            this.lbdolukoltuklar.TabIndex = 3;
            this.lbdolukoltuklar.Text = "Dolu Koltuklar";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(26, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 31);
            this.label12.TabIndex = 2;
            // 
            // lbboskoltuklar
            // 
            this.lbboskoltuklar.AutoSize = true;
            this.lbboskoltuklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbboskoltuklar.ForeColor = System.Drawing.Color.White;
            this.lbboskoltuklar.Location = new System.Drawing.Point(67, 20);
            this.lbboskoltuklar.Name = "lbboskoltuklar";
            this.lbboskoltuklar.Size = new System.Drawing.Size(115, 20);
            this.lbboskoltuklar.TabIndex = 1;
            this.lbboskoltuklar.Text = "Boş Koltuklar";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 28);
            this.label10.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(43, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 214);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(230, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 327);
            this.panel1.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(51, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(409, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "                    P                    E                    R                  " +
    "  D                    E                    ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(747, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.ComboBox cbucret;
        private System.Windows.Forms.ComboBox cbfilmseansi;
        private System.Windows.Forms.ComboBox cbfilmtarihi;
        private System.Windows.Forms.ComboBox cbsalonadi;
        private System.Windows.Forms.ComboBox cbfilmadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbkoltukiptal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button seansduzenlesil;
        private System.Windows.Forms.Button btnseansekle;
        private System.Windows.Forms.Button btnfilmekle;
        private System.Windows.Forms.Button btnsalonekle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbdolukoltuklar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbboskoltuklar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnbiletiptal;
        private System.Windows.Forms.Button btnbiletsat;
        private System.Windows.Forms.Button btnsatislistele;
        private System.Windows.Forms.TextBox tbkoltukno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button filmduzenlesil;
        private System.Windows.Forms.Button salonduzenlesil;
    }
}

