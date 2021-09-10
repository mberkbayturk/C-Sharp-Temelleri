using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SQDER0I;Initial Catalog=FilmArsivim;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select AD, LINK From TblFilmler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TblFilmler (AD,KATEGORI,LINK) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Listenize Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Mehmet Berk BAYTÜRK tarafından oluştuurldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            frm.film = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.Show();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] renkler = { "Yellow", "Blue", "Purple", "Red", "Gray", "Green", "Orange" };
            int index = rnd.Next(renkler.Length);
            if (index == 0)
            {
                this.BackColor = Color.Yellow;
            }
            else if (index == 1)
            {
                this.BackColor = Color.Blue;
            }
            else if (index == 2)
            {
                this.BackColor = Color.Purple;
            }
            else if (index == 3)
            {
                this.BackColor = Color.Red;
            }
            else if (index == 4)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Orange;
            }
        }
    }
}
