using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t = new Tbl_Kategori();
            t.Ad = textBox2.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            ktgr.Ad = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
        }
    }
}
