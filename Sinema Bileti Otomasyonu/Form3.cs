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
    public partial class Form3 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");

        public Form3()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbsalonadi.Text!="")
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string sec = "insert into salon_bilgileri(salonadi) values(@salonadi)";
                    OleDbCommand cmd = new OleDbCommand(sec, conn);
                    cmd.Parameters.AddWithValue("@salonadi", tbsalonadi.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Salon Eklendi", "Kayıt");
                }
                else
                {
                    MessageBox.Show("Lütfen salon adı alanını boş bırakmayınız!...", "Uyarı");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Aynı salon daha önce eklendi!!!", "Uyarı");
            }
            tbsalonadi.Text = "";
        }
    }
}
