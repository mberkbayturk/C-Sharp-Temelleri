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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString();
            label3.Text = db.Tbl_Urun.Count().ToString();
            label5.Text = db.Tbl_Urun.Count(x => x.Durum == false).ToString();
            label7.Text = db.Tbl_Musteri.Count(x => x.Durum == true).ToString();
            label13.Text = db.Tbl_Urun.Sum(x => x.Stok).ToString();
            label21.Text = db.Tbl_Satıs.Sum(x => x.Fiyat).ToString() + " TL";
            label11.Text = (from x in db.Tbl_Urun orderby x.Fiyat descending select x.UrunAdı).FirstOrDefault();
            label9.Text = (from x in db.Tbl_Urun orderby x.Fiyat ascending select x.UrunAdı).FirstOrDefault();
            label15.Text = db.Tbl_Urun.Count(x => x.Kategori == 1).ToString();
            label17.Text = db.Tbl_Urun.Count(x => x.UrunAdı == "Buzdolabı").ToString();
            label23.Text = (from x in db.Tbl_Musteri select x.Sehir).Distinct().Count().ToString();
            label19.Text = db.Tbl_Urun.Count(x => x.UrunAdı == "Laptop").ToString();
        }
    }
}
