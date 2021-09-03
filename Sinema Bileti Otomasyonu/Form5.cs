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
    public partial class Form5 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        int kacincikayit;
      
        public Form5()
        {
            InitializeComponent();
        }

        void verileri_cek()
        {
            string sec = "select* from seans_bilgileri";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            ds.Clear();
            da.Fill(ds, "seans_bilgileri");
        }

        void seans_listesi(string sec)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            ds.Clear();
            da.Fill(ds,"seans_bilgileri");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            seans_listesi("select * from seans_bilgileri where tarih like'" + dateTimePicker1.Text + "'");
            bs.DataSource = ds.Tables["seans_bilgileri"];
            dataGridView1.DataSource = bs;
            tbseanskodu.DataBindings.Add("Text", bs, "seanskodu");
            conn.Close();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            seans_listesi("select * from seans_bilgileri where tarih like'" + dateTimePicker1.Text + "'");
            
        }

        private void btntumseanslar_Click(object sender, EventArgs e)
        {
            seans_listesi("select * from seans_bilgileri");
       
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            kacincikayit = bs.Position;
            DialogResult c = MessageBox.Show("Emin misiniz?", "Bilgi", MessageBoxButtons.YesNo);
            if (c == DialogResult.Yes)
            {
                conn.Open();
                string sec = "delete from seans_bilgileri where seanskodu=@seanskodu";
                OleDbCommand cmd = new OleDbCommand(sec, conn);
                cmd.Parameters.AddWithValue("@seanskodu",int.Parse(tbseanskodu.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydınız Silindi");
                verileri_cek();
                bs.Position = kacincikayit;
            }
        }

        private void koduara_TextChanged(object sender, EventArgs e)
        {
            string seckomutu = "select * from seans_bilgileri where seanskodu like '%" + koduara.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, conn);
            ds.Clear();
            da.Fill(ds, "seans_bilgileri");
        }
    }
}
       