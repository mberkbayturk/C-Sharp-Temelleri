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
using System.IO;

namespace EtutTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SQDER0I;Initial Catalog=EtutTest;Integrated Security=True");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblDers", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "DERSID";
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.DataSource = dt;
        }

        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Execute Etut", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From TblOgretmen where BRANSID= " + cmbDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbOgretmen.ValueMember = "OGRTID";
            cmbOgretmen.DisplayMember = "AD";
            cmbOgretmen.DataSource = dt2;
        }

        private void btnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert TblEtut (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtEtutId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TblEtut set OGRENCIID=@p1,DURUM=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrenciId.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtEtutId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnFotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TblOgrenci (ad,soyad,fotograf,sınıf,telefon,maıl) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", txtSinif.Text);
            komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
