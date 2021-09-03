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
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\sinema_bileti.mdb");

        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void filmvesalongetir(ComboBox combo, string sec1, string sec2)
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
        void filmresmigoster()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from film_bilgileri where filmadi='" + cbfilmadi.SelectedItem + "'", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                pictureBox1.ImageLocation = rd["resim"].ToString();
            }
            conn.Close();
        }
        void combodolukoltuklar()
        {
            cbkoltukiptal.Items.Clear();
            cbkoltukiptal.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        cbkoltukiptal.Items.Add(item.Text);
                    }
                }
            }
        }
        void yeniden_renklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        void veritabanı_dolukoltuklar()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from satis_bilgileri where filmadi='" + cbfilmadi.SelectedItem + "'and salonadi='" + cbsalonadi.SelectedItem + "'and filmtarihi='" + cbfilmtarihi.SelectedItem + "'and filmseansi='" + cbfilmseansi.SelectedItem + "'", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (rd["koltukno"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bos_koltuklar();
            filmvesalongetir(cbfilmadi, "select*from film_bilgileri", "filmadi");
            filmvesalongetir(cbsalonadi, "select* from salon_bilgileri", "salonadi");
        }

        void Bos_koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(35, 35);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 35 + 30, i * 35 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j ==6)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += btn_click;
                }
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                tbkoltukno.Text = b.Text;
            }
        }
      
        private void cbfilmadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbfilmtarihi.Items.Clear();
            cbfilmseansi.Items.Clear();
            tbkoltukno.Text = "";
            tbadi.Text = "";
            tbsoyadi.Text = "";
            filmresmigoster();
            yeniden_renklendir();
            combodolukoltuklar();
        }

        private void btnbiletsat_Click(object sender, EventArgs e)
        {
            if (tbkoltukno.Text != "")
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string sec = "insert into satis_bilgileri(filmadi,salonadi,filmtarihi,filmseansi,koltukno,adi,soyadi,ucret,satildigitarih)values(@filmadi,@salonadi,@filmtarihi,@filmseansi,@koltukno,@adi,@soyadi,@ucret,@satildigitarih)";
                    OleDbCommand cmd = new OleDbCommand(sec, conn);
                    cmd.Parameters.AddWithValue("@filmadi", cbfilmadi.Text);
                    cmd.Parameters.AddWithValue("@salonadi",cbsalonadi.Text);
                    cmd.Parameters.AddWithValue("@filmtarihi", cbfilmtarihi.Text);
                    cmd.Parameters.AddWithValue("@filmseansi", cbfilmseansi.Text);
                    cmd.Parameters.AddWithValue("@koltukno", tbkoltukno.Text);
                    cmd.Parameters.AddWithValue("@adi", tbadi.Text);
                    cmd.Parameters.AddWithValue("@soyadi", tbsoyadi.Text);
                    cmd.Parameters.AddWithValue("@ucret", cbucret.Text);
                    cmd.Parameters.AddWithValue("@satildigitarih", dateTimePicker1.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    tbkoltukno.Text = "";
                    tbadi.Text = "";
                    tbsoyadi.Text = "";
                    yeniden_renklendir();
                    veritabanı_dolukoltuklar();
                    combodolukoltuklar();
                    MessageBox.Show("Bilet satıldı.", "Bilgi");
                    if (cbucret.Text == "")
                    {
                        MessageBox.Show("Lütfen bileti iptal ediniz!!!", "Ücret alanı boş bırakıldı...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen film bilgileri alanını boş bırakmayınız!!...", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Koltuk seçilmedi!!", "Uyarı");
            }
            
        }
        void filmtarihigetir()
        {
            cbfilmtarihi.Text = "";
            cbfilmseansi.Text = "";
            cbfilmtarihi.Items.Clear();
            cbfilmseansi.Items.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from seans_bilgileri where filmadi='" + cbfilmadi.SelectedItem + "'and salonadi='" + cbsalonadi.SelectedItem + "'", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (DateTime.Parse(rd["tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))//küçük tarih görünmemesi için...
                {
                    if (!cbfilmtarihi.Items.Contains(rd["tarih"].ToString()))//tarihte herbirinden bir tane içermesi için...
                    {
                        cbfilmtarihi.Items.Add(rd["tarih"].ToString());
                    }
                }
            }
            conn.Close();
        }

        private void cbsalonadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmtarihigetir();
        }

        void filmseansigetir()
        {
            cbfilmseansi.Text = "";
            cbfilmseansi.Items.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from seans_bilgileri where filmadi='" + cbfilmadi.SelectedItem + "'and salonadi='" + cbsalonadi.SelectedItem + "'and tarih='" + cbfilmtarihi.SelectedItem + "'", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (DateTime.Parse(rd["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))//geçmiş seansları göstermemesi için...
                {
                    if (DateTime.Parse(rd["seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        cbfilmseansi.Items.Add(rd["seans"].ToString());
                    }
                }
                else if (DateTime.Parse(rd["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    cbfilmseansi.Items.Add(rd["seans"].ToString());
                }
            }
            conn.Close();
        }

        private void cbfilmtarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmseansigetir();
        }

        private void cbfilmseansi_SelectedIndexChanged(object sender, EventArgs e)
        {
            yeniden_renklendir();
            veritabanı_dolukoltuklar();
            combodolukoltuklar();
        }

        private void btnbiletiptal_Click(object sender, EventArgs e)
        {
            if (cbkoltukiptal.Text != "")
            {
                conn.Open();
                string sec = "delete from satis_bilgileri where koltukno=@koltukno";
                OleDbCommand cmd = new OleDbCommand(sec, conn);
                cmd.Parameters.AddWithValue("@koltukno", int.Parse(cbkoltukiptal.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                yeniden_renklendir();
                veritabanı_dolukoltuklar();
                combodolukoltuklar();
                MessageBox.Show("Bilet iptal edildi.", "Bilgi");   
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!!!", "Uyarı");
            }
        }
        private void btnsalonekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Show();
        }

        private void btnfilmekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Show();
        }

        private void btnseansekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Show();
        }

        private void salonduzenlesil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
            this.Show();
        }

        private void filmduzenlesil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Show();
        }

        private void seansduzenlesil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Show();
        }

        private void btnsatislistele_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
