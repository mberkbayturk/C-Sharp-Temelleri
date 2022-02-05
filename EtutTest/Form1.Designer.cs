
namespace EtutTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEtutOlustur = new System.Windows.Forms.Button();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEtutId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.btnEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtDers = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFotograf = new System.Windows.Forms.Button();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbDersAdı = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnOgretmenEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtutOlustur);
            this.groupBox1.Controls.Add(this.cmbOgretmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEtutOlustur
            // 
            this.btnEtutOlustur.Location = new System.Drawing.Point(139, 224);
            this.btnEtutOlustur.Name = "btnEtutOlustur";
            this.btnEtutOlustur.Size = new System.Drawing.Size(243, 36);
            this.btnEtutOlustur.TabIndex = 9;
            this.btnEtutOlustur.Text = "Etüt Oluştur";
            this.btnEtutOlustur.UseVisualStyleBackColor = true;
            this.btnEtutOlustur.Click += new System.EventHandler(this.btnEtutOlustur_Click);
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Location = new System.Drawing.Point(139, 84);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(243, 35);
            this.cmbOgretmen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat:";
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(139, 174);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(243, 34);
            this.mskSaat.TabIndex = 6;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(139, 134);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(243, 34);
            this.mskTarih.TabIndex = 4;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ögretmen:";
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(139, 43);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(243, 35);
            this.cmbDers.TabIndex = 1;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEtutId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtOgrenciId);
            this.groupBox2.Controls.Add(this.btnEtutVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(407, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtEtutId
            // 
            this.txtEtutId.Enabled = false;
            this.txtEtutId.Location = new System.Drawing.Point(130, 25);
            this.txtEtutId.Name = "txtEtutId";
            this.txtEtutId.Size = new System.Drawing.Size(154, 34);
            this.txtEtutId.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Etüt id:";
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(130, 65);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(154, 34);
            this.txtOgrenciId.TabIndex = 11;
            // 
            // btnEtutVer
            // 
            this.btnEtutVer.Location = new System.Drawing.Point(130, 105);
            this.btnEtutVer.Name = "btnEtutVer";
            this.btnEtutVer.Size = new System.Drawing.Size(154, 36);
            this.btnEtutVer.TabIndex = 10;
            this.btnEtutVer.Text = "Etüt Ver";
            this.btnEtutVer.UseVisualStyleBackColor = true;
            this.btnEtutVer.Click += new System.EventHandler(this.btnEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 306);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDersEkle);
            this.groupBox4.Controls.Add(this.txtDers);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(407, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 147);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mskTelefon);
            this.groupBox5.Controls.Add(this.btnOgrenciEkle);
            this.groupBox5.Controls.Add(this.txtMail);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtSinif);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtSoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(712, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 300);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnFotograf);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(1026, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 300);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnOgretmenEkle);
            this.groupBox7.Controls.Add(this.cmbDersAdı);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.txtOgretmenSoyad);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.txtOgretmenAd);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(1026, 301);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(288, 300);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(111, 25);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(184, 34);
            this.txtAd.TabIndex = 15;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(111, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(184, 34);
            this.txtSoyad.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Soyad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telefon:";
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(111, 105);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(184, 34);
            this.txtSinif.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Sınıf:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(111, 185);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(184, 34);
            this.txtMail.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "Mail:";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(111, 225);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(184, 36);
            this.btnOgrenciEkle.TabIndex = 24;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(111, 148);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(184, 34);
            this.mskTelefon.TabIndex = 25;
            // 
            // txtDers
            // 
            this.txtDers.Location = new System.Drawing.Point(126, 21);
            this.txtDers.Name = "txtDers";
            this.txtDers.Size = new System.Drawing.Size(158, 34);
            this.txtDers.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ders Adı:";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(67, 72);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(154, 36);
            this.btnDersEkle.TabIndex = 18;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFotograf
            // 
            this.btnFotograf.Location = new System.Drawing.Point(52, 241);
            this.btnFotograf.Name = "btnFotograf";
            this.btnFotograf.Size = new System.Drawing.Size(184, 36);
            this.btnFotograf.TabIndex = 25;
            this.btnFotograf.Text = "Fotoğraf Yükle";
            this.btnFotograf.UseVisualStyleBackColor = true;
            this.btnFotograf.Click += new System.EventHandler(this.btnFotograf_Click);
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(95, 70);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(184, 34);
            this.txtOgretmenSoyad.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 29);
            this.label13.TabIndex = 20;
            this.label13.Text = "Soyad:";
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(95, 30);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(184, 34);
            this.txtOgretmenAd.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 29);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ad:";
            // 
            // cmbDersAdı
            // 
            this.cmbDersAdı.FormattingEnabled = true;
            this.cmbDersAdı.Location = new System.Drawing.Point(95, 110);
            this.cmbDersAdı.Name = "cmbDersAdı";
            this.cmbDersAdı.Size = new System.Drawing.Size(184, 35);
            this.cmbDersAdı.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 29);
            this.label15.TabIndex = 22;
            this.label15.Text = "Ders:";
            // 
            // btnOgretmenEkle
            // 
            this.btnOgretmenEkle.Location = new System.Drawing.Point(95, 151);
            this.btnOgretmenEkle.Name = "btnOgretmenEkle";
            this.btnOgretmenEkle.Size = new System.Drawing.Size(184, 36);
            this.btnOgretmenEkle.TabIndex = 26;
            this.btnOgretmenEkle.Text = "Öğretmen Ekle";
            this.btnOgretmenEkle.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1321, 609);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEtutOlustur;
        private System.Windows.Forms.ComboBox cmbOgretmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEtutVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.TextBox txtEtutId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TextBox txtDers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnOgretmenEkle;
        private System.Windows.Forms.ComboBox cmbDersAdı;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

