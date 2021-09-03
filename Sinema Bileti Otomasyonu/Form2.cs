using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sinema_Bileti_Otomasyonu
{
    public partial class Form2 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");
   

        public Form2()
        {
            InitializeComponent();
        }
       
        private void btnfilmekle_Click(object sender, EventArgs e)
        {
            try
             {
                if (tbfilmadi.Text !="")
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string sec = "insert into film_bilgileri(filmadi,yonetmen,filmturu,filmsuresi,tarih,resim)values (@filmadi,@yonetmen,@filmturu,@filmsuresi,@tarih,@resim)";
                    OleDbCommand cmd = new OleDbCommand(sec, conn);
                    cmd.Parameters.AddWithValue("@filmadi", tbfilmadi.Text);
                    cmd.Parameters.AddWithValue("@yonetmen", tbyonetmen.Text);
                    cmd.Parameters.AddWithValue("@filmturu", cbfilmturu.Text);
                    cmd.Parameters.AddWithValue("@filmsuresi", tbsure.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Film bilgileri eklendi", "Kayıt");
                }
                else if(tbfilmadi.Text=="")
                {
                    MessageBox.Show("Lütfen film adı alanını boş bırakmayınız!!","Uyarı");
                } 
            }
            catch(Exception)
            {
                MessageBox.Show("Bu film daha önce eklendi!!!", "Uyarı");
            }
            tbfilmadi.Text = "";
            tbyonetmen.Text = "";
            cbfilmturu.Text = "";
            tbsure.Text = "";
            dateTimePicker1.Text="";
            pictureBox1.ImageLocation = "";
        }
        private void btnresimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resimler\\";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}

