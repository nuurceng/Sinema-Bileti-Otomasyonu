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
    public partial class Form8 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        int kacincikayit;

        public Form8()
        {
            InitializeComponent();
        }
        void verileri_cek()
        {
            string sec = "select* from film_bilgileri";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            ds.Clear();
            da.Fill(ds, "film_bilgileri");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            verileri_cek();
            bs.DataSource = ds.Tables["film_bilgileri"];
            dataGridView1.DataSource = bs;
            tbfilmadi.DataBindings.Add("Text", bs, "filmadi");
            tbyonetmen.DataBindings.Add("Text", bs, "yonetmen");
            cbfilmturu.DataBindings.Add("Text", bs, "filmturu");
            tbsure.DataBindings.Add("Text", bs, "filmsuresi");
            dateTimePicker1.DataBindings.Add("Text", bs, "tarih");
            pictureBox1.DataBindings.Add("ImageLocation", bs, "resim");
            conn.Close();
        }

        private void btnfilmduzenle_Click(object sender, EventArgs e)
        {
            kacincikayit = bs.Position;
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sec="update film_bilgileri set filmadi=@filmadi,yonetmen=@yonetmen,filmturu=@filmturu,filmsuresi=@filmsuresi, tarih=@tarih where resim=@resim";
                OleDbCommand cmd = new OleDbCommand(sec, conn);
                cmd.Parameters.AddWithValue("@filmadi", tbfilmadi.Text);
                cmd.Parameters.AddWithValue("@yonetmen", tbyonetmen.Text);
                cmd.Parameters.AddWithValue("@filmturu", cbfilmturu.Text);
                cmd.Parameters.AddWithValue("@filmsuresi", tbsure.Text);
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Film bilgileri düzeltildi", "Bilgi");
            }
            catch(Exception)
            {
                MessageBox.Show("Aynı film zaten bulunmaktadır!...", "Uyarı");
            }
            verileri_cek();
            bs.Position = kacincikayit;
        }

        private void btnfilmsil_Click(object sender, EventArgs e)
        {
            kacincikayit = bs.Position;
            DialogResult c = MessageBox.Show("Emin misiniz?", "Bilgi", MessageBoxButtons.YesNo);
            if(c==DialogResult.Yes)
            {
                conn.Open();
                string sec = "delete from film_bilgileri where filmadi=@filmadi";
                OleDbCommand cmd = new OleDbCommand(sec, conn);
                cmd.Parameters.AddWithValue("@filmadi",tbfilmadi.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydınız Silindi");
                verileri_cek();
                bs.Position = kacincikayit;
            }
        }

        private void aranan_TextChanged(object sender, EventArgs e)
        {
            string seckomutu = "select * from film_bilgileri where filmadi like '%" + aranan.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, conn);
            ds.Clear();
            da.Fill(ds, "film_bilgileri");
        }
    }
}
