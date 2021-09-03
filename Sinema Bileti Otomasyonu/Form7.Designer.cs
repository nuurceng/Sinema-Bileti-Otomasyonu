namespace Sinema_Bileti_Otomasyonu
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsalonduzenle = new System.Windows.Forms.Button();
            this.btnsalonsil = new System.Windows.Forms.Button();
            this.tbsalonadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsalonkodu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnsalonduzenle
            // 
            this.btnsalonduzenle.Location = new System.Drawing.Point(268, 136);
            this.btnsalonduzenle.Name = "btnsalonduzenle";
            this.btnsalonduzenle.Size = new System.Drawing.Size(75, 44);
            this.btnsalonduzenle.TabIndex = 1;
            this.btnsalonduzenle.Text = "Salon Düzenle";
            this.btnsalonduzenle.UseVisualStyleBackColor = true;
            this.btnsalonduzenle.Click += new System.EventHandler(this.btnsalonduzenle_Click);
            // 
            // btnsalonsil
            // 
            this.btnsalonsil.Location = new System.Drawing.Point(351, 136);
            this.btnsalonsil.Name = "btnsalonsil";
            this.btnsalonsil.Size = new System.Drawing.Size(75, 44);
            this.btnsalonsil.TabIndex = 2;
            this.btnsalonsil.Text = "Salon Sil";
            this.btnsalonsil.UseVisualStyleBackColor = true;
            this.btnsalonsil.Click += new System.EventHandler(this.btnsalonsil_Click);
            // 
            // tbsalonadi
            // 
            this.tbsalonadi.Location = new System.Drawing.Point(326, 102);
            this.tbsalonadi.Name = "tbsalonadi";
            this.tbsalonadi.Size = new System.Drawing.Size(100, 20);
            this.tbsalonadi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salon Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salon Kodu:";
            // 
            // tbsalonkodu
            // 
            this.tbsalonkodu.Location = new System.Drawing.Point(326, 70);
            this.tbsalonkodu.Name = "tbsalonkodu";
            this.tbsalonkodu.ReadOnly = true;
            this.tbsalonkodu.Size = new System.Drawing.Size(100, 20);
            this.tbsalonkodu.TabIndex = 6;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(454, 264);
            this.Controls.Add(this.tbsalonkodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbsalonadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalonsil);
            this.Controls.Add(this.btnsalonduzenle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon Düzenleme Silme Sayfası";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsalonduzenle;
        private System.Windows.Forms.Button btnsalonsil;
        private System.Windows.Forms.TextBox tbsalonadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbsalonkodu;
    }
}