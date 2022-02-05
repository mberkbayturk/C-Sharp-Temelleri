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

namespace BankaTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SQDER0I;Initial Catalog=DbBankaTest;Integrated Security=True");

        bool durum;

        void kontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblKisiler Where HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TblKisiler (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", mskTC.Text);
                komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komut.Parameters.AddWithValue("@p5", mskHesapNo.Text);
                komut.Parameters.AddWithValue("@p6", txtSifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");
            }
            else
            {
                MessageBox.Show("Başka bir hesap numarası alınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHesapNo_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000,1000000);
            mskHesapNo.Text = sayi.ToString();
        }
    }
}
