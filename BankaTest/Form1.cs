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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SQDER0I;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblKisiler Where HESAPNO=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1",mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.hesap = mskHesapNo.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            baglanti.Close();
        }
    }
}
