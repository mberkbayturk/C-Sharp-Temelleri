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

namespace KitaplikSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SQDER0I;Initial Catalog=Kitaplik;Integrated Security=True");

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kitaplar", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        string durum = "";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Insert into Tbl_Kitaplar (KitapAd, Yazar, Tur, Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut1.Parameters.AddWithValue("@p2", txtYazarAd.Text);
            komut1.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut1.Parameters.AddWithValue("@p4", txtSayfaSayısı.Text);
            komut1.Parameters.AddWithValue("@p5", durum);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKitapId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazarAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSayfaSayısı.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString()=="True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Kitaplar Where KitapId=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Kitaplar set KitapAd=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 Where KitapId=@p6",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazarAd.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfaSayısı.Text);
            if (radioButton1.Checked==true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if (radioButton2.Checked==true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6", txtKitapId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kitaplar Where KitapAd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapBul.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kitaplar Where KitapAd like'%"+txtKitapBul.Text+"%'", baglanti);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
