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
    public partial class Form7 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        int kacincikayit;
      
        public Form7()
        {
            InitializeComponent();
        }
        void verileri_cek()
        {
            string sec = "select* from salon_bilgileri";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            ds.Clear();
            da.Fill(ds,"salon_bilgileri");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            verileri_cek();
            bs.DataSource = ds.Tables["salon_bilgileri"];
            dataGridView1.DataSource = bs;
            tbsalonadi.DataBindings.Add("Text", bs, "salonadi");
            tbsalonkodu.DataBindings.Add("Text", bs, "salonkodu");
            conn.Close();
        }

        private void btnsalonduzenle_Click(object sender, EventArgs e)
        {
            kacincikayit = bs.Position;
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sec = "update salon_bilgileri set salonadi=@salonadi where salonkodu=@salonkodu";
                OleDbCommand cmd = new OleDbCommand(sec, conn);
                cmd.Parameters.AddWithValue("@salonadi",tbsalonadi.Text);
                cmd.Parameters.AddWithValue("@salonkodu",tbsalonkodu.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salon bilgileri düzeltildi", "Bilgi");
            }
            catch (Exception)
            {
                MessageBox.Show("Aynı salon zaten bulunmaktadır!!!","Uyarı");
            }
            verileri_cek();
            bs.Position = kacincikayit;
        }

        private void btnsalonsil_Click(object sender, EventArgs e)
        {
            kacincikayit = bs.Position;
            DialogResult c = MessageBox.Show("Emin misiniz?", "Bilgi", MessageBoxButtons.YesNo);
            if (c == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sec = "delete from salon_bilgileri where salonadi=@salonadi";
                OleDbCommand cmd = new OleDbCommand(sec, conn);
                cmd.Parameters.AddWithValue("@salonadi",tbsalonadi.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydınız Silindi");
                verileri_cek();
                bs.Position = kacincikayit;
            }
        }
    }
}
