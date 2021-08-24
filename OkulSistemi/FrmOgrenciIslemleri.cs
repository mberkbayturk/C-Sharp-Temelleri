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

namespace OkulSistemi
{
    public partial class FrmOgrenciIslemleri : Form
    {
        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.LightYellow;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SQDER0I;Initial Catalog=Okul;Integrated Security=True");

        private void FrmOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kulupler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgrenciKulubu.DisplayMember = "KULUPAD";
            cmbOgrenciKulubu.ValueMember = "KULUPID";
            cmbOgrenciKulubu.DataSource = dt;
            baglanti.Close();
        }

        string c = "";

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.OgrenciEkle(txtOgrenciAdi.Text, txtOgrenciSoyadi.Text, byte.Parse(cmbOgrenciKulubu.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Ekleme İşlemi Yapıldı");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void cmbOgrenciKulubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtOgrenciId.Text = cmbOgrenciKulubu.SelectedValue.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtOgrenciId.Text));
            MessageBox.Show("Öğrenci Silme İşlemi Yapıldı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOgrenciAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOgrenciSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbOgrenciKulubu.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            c = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (c == "Kız")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            if (c == "Erkek")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrencıGuncelle(txtOgrenciAdi.Text, txtOgrenciSoyadi.Text, byte.Parse(cmbOgrenciKulubu.SelectedValue.ToString()), c, int.Parse(txtOgrenciId.Text));
            MessageBox.Show("Öğrenci Ekleme İşlemi Yapıldı");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ds.OgrenciGetir(txtAra.Text);
        }
    }
}
