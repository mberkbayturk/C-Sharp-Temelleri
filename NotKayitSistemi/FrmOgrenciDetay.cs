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

namespace NotKayitSistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SQDER0I;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            string durum="";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblDers Where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                if (dr[8].ToString() =="True")
                {
                    durum = "Geçti";
                }
                if (dr[8].ToString() =="False")
                {
                    durum = "Kaldı";
                }
                lblDurum.Text = durum;
            }
            baglanti.Close();
        }
    }
}
