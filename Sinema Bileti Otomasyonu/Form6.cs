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
    public partial class Form6 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");
        public static DataSet ds = new DataSet();//raporla var...

        public Form6()
        {
            InitializeComponent();
        }

        private void satis_listesi(string sec)
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            ds.Clear();
            da.Fill(ds,"satis_bilgileri");
            dataGridView1.DataSource =ds.Tables["satis_bilgileri"];
            conn.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            satis_listesi("select * from satis_bilgileri where satildigitarih like'" + dateTimePicker1.Text + "'");
            toplamucrethesapla();
        }
        private void toplamucrethesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami +=Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
            }
            label1.Text = "Toplam satış=" + ucrettoplami + "TL";
        }

        private void btntumsatislar_Click(object sender, EventArgs e)
        {
            satis_listesi("select * from satis_bilgileri ");
            toplamucrethesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            satis_listesi("select * from satis_bilgileri where satildigitarih like'" + dateTimePicker1.Text + "'");
            toplamucrethesapla();
        }

        private void raporla_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
