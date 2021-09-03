namespace Sinema_Bileti_Otomasyonu
{
    partial class Form5
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntumseanslar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbseanskodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.koduara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // btntumseanslar
            // 
            this.btntumseanslar.Location = new System.Drawing.Point(386, 269);
            this.btntumseanslar.Name = "btntumseanslar";
            this.btntumseanslar.Size = new System.Drawing.Size(106, 42);
            this.btntumseanslar.TabIndex = 2;
            this.btntumseanslar.Text = "Tüm Seanslar";
            this.btntumseanslar.UseVisualStyleBackColor = true;
            this.btntumseanslar.Click += new System.EventHandler(this.btntumseanslar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarihe Göre Listele:";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(583, 139);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(82, 37);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seans Kodu:";
            // 
            // tbseanskodu
            // 
            this.tbseanskodu.Location = new System.Drawing.Point(572, 96);
            this.tbseanskodu.Name = "tbseanskodu";
            this.tbseanskodu.Size = new System.Drawing.Size(93, 20);
            this.tbseanskodu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seans Kodu Ara:";
            // 
            // koduara
            // 
            this.koduara.Location = new System.Drawing.Point(168, 21);
            this.koduara.Name = "koduara";
            this.koduara.Size = new System.Drawing.Size(140, 20);
            this.koduara.TabIndex = 8;
            this.koduara.TextChanged += new System.EventHandler(this.koduara_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(677, 315);
            this.Controls.Add(this.koduara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbseanskodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntumseanslar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Listeleme Silme Sayfası";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntumseanslar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbseanskodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox koduara;
    }
}