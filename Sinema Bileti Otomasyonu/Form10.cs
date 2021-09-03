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
    public partial class Form10 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");

        public Form10()
        {
            InitializeComponent();
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbkullaniciadi.Text != "")
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string sec = "insert into kullanici_bilgileri(kullaniciadi,sifre)values (@kullaniciadi,@sifre)";
                    OleDbCommand cmd = new OleDbCommand(sec, conn);
                    cmd.Parameters.AddWithValue("@kullaniciadi",tbkullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@sifre", tbsifre.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Yeni kayıt eklendi", "Kayıt");
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adı alanını boş bırakmayınız!!", "Uyarı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu kullanıcı adı zaten var!!!", "Uyarı");
            }
            tbkullaniciadi.Text = "";
            tbsifre.Text = "";
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbCommand cmd = new OleDbCommand("select* from kullanici_bilgileri where kullaniciadi='" + tbkullaniciadi.Text + "'", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                if (tbkullaniciadi.Text == rd["kullaniciadi"].ToString() && tbsifre.Text == rd["sifre"].ToString())
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifre hatalı kontrol ediniz..","Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı hatalı kontrol ediniz..!", "Uyarı");
            }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                tbsifre.PasswordChar = '\0';
            }
            else
            {
                tbsifre.PasswordChar = '*';
            }
        }

        private void tbsifre_TextChanged(object sender, EventArgs e)
        {
            tbsifre.PasswordChar = '*';
        }
    }
}
