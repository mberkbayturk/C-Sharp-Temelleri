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

namespace SifreliVeriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SQDER0I;Initial Catalog=Test;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblVeriler", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["AD"] = coz(row["AD"] as string);
                row["SOYAD"] = coz(row["SOYAD"] as string);
                row["MAIL"] = coz(row["MAIL"] as string);
                row["SIFRE"] = coz(row["SIFRE"] as string);
                row["HESAPNO"] = coz(row["HESAPNO"] as string);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private object coz(string v1)
        {
            byte[] cozumdizi = Convert.FromBase64String(v1);
            string adveri = ASCIIEncoding.ASCII.GetString(cozumdizi);
            return adveri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = txtSoyad.Text;
            byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = txtMail.Text;
            byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = txtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = txtHesapNo.Text;
            byte[] hesapnodizi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TblVeriler (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifresifre);
            komut.Parameters.AddWithValue("@p5", hesapnosifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Eklendi");

            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

    }
}
