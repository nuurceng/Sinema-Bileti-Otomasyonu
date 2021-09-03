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
    public partial class Form4 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");

        string seans = "";

        public Form4()
        {
            InitializeComponent();
        }

        void filmvesalon_goster(ComboBox combo, string sec1, string sec2)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sec1, conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                combo.Items.Add(rd[sec2].ToString());
            }
            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            filmvesalon_goster(cbfilm, "select * from film_bilgileri", "filmadi");
            filmvesalon_goster(cbsalon, "select *from salon_bilgileri", "salonadi");
        }

        void radiobuttonseciliyse()
        {
            if (radioButton1.Checked) seans = radioButton1.Text;
            else if (radioButton2.Checked) seans = radioButton2.Text;
            else if (radioButton3.Checked) seans = radioButton3.Text;
            else if (radioButton4.Checked) seans = radioButton4.Text;
            else if (radioButton5.Checked) seans = radioButton5.Text;
            else if (radioButton6.Checked) seans = radioButton6.Text;
            else if (radioButton7.Checked) seans = radioButton7.Text;
            else if (radioButton8.Checked) seans = radioButton8.Text;
            else if (radioButton9.Checked) seans = radioButton9.Text;
            else if (radioButton10.Checked) seans = radioButton10.Text;
            else if (radioButton11.Checked) seans = radioButton11.Text;
            else if (radioButton12.Checked) seans = radioButton12.Text;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                radiobuttonseciliyse();

                if (seans != "")
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string sec = "insert into seans_bilgileri(filmadi,salonadi,tarih,seans)values(@filmadi,@salonadi,@tarih,@seans)";
                    OleDbCommand cmd = new OleDbCommand(sec, conn);
                    cmd.Parameters.AddWithValue("@filmadi", cbfilm.Text);
                    cmd.Parameters.AddWithValue("@salonadi", cbsalon.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@seans", seans);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Seans ekleme işlemi yapıldı", "Kayıt");
                }
                else if (seans == "")
                {
                    MessageBox.Show("Seans seçilmedi!!!", "Uyarı");
                }
                //cbfilm.Text = "";
                //cbsalon.Text = "";
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen boş yerleri doldurunuz!...", "Uyarı");
            }
        }

        private void cbsalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        void tarihi_karsilastir()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from seans_bilgileri where salonadi='" + cbsalon.Text + "'and tarih='" + dateTimePicker1.Text + "'", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                foreach (Control x in groupBox1.Controls)
                {
                    if (rd["seans"].ToString() == x.Text)
                    {
                        x.Enabled =false;
                    }
                }
            }
            conn.Close();
        }  
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach(Control item in groupBox1.Controls)
            {
                item.Enabled=true;
            }
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni == bugün)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                tarihi_karsilastir();
            }
            else if(yeni>bugün)
            {
                tarihi_karsilastir();
            }
            else if(yeni<bugün)
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz!!!", "Uyarı");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }
    }
}
   