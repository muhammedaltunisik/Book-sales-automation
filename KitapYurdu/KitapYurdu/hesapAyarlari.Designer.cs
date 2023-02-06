
namespace KitapYurdu
{
    partial class hesapAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesapAyarlari));
            this.comboBox_Adresler = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Adres_Basligi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Adres_Sil = new System.Windows.Forms.Button();
            this.button_Adres_Guncelle = new System.Windows.Forms.Button();
            this.button_Adres_Ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Mahalle = new System.Windows.Forms.TextBox();
            this.textBox_Ilce = new System.Windows.Forms.TextBox();
            this.textBox_Sehir = new System.Windows.Forms.TextBox();
            this.textBox_Ulke = new System.Windows.Forms.TextBox();
            this.textBox_AdresText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Kullanıcı_ID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_Cinsiyet = new System.Windows.Forms.Label();
            this.label_Kullanici_Adı = new System.Windows.Forms.Label();
            this.textBox_Ad_Degistir = new System.Windows.Forms.TextBox();
            this.label_Ad = new System.Windows.Forms.Label();
            this.button_Hesap_Bilgileri = new System.Windows.Forms.Button();
            this.button_Sifre_Degistir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Adresler
            // 
            this.comboBox_Adresler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.comboBox_Adresler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Adresler.FormattingEnabled = true;
            this.comboBox_Adresler.Location = new System.Drawing.Point(215, 373);
            this.comboBox_Adresler.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Adresler.Name = "comboBox_Adresler";
            this.comboBox_Adresler.Size = new System.Drawing.Size(263, 29);
            this.comboBox_Adresler.TabIndex = 0;
            this.comboBox_Adresler.SelectedIndexChanged += new System.EventHandler(this.comboBox_Adresler_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Adres_Basligi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_Adres_Sil);
            this.groupBox1.Controls.Add(this.button_Adres_Guncelle);
            this.groupBox1.Controls.Add(this.button_Adres_Ekle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_Adresler);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Mahalle);
            this.groupBox1.Controls.Add(this.textBox_Ilce);
            this.groupBox1.Controls.Add(this.textBox_Sehir);
            this.groupBox1.Controls.Add(this.textBox_Ulke);
            this.groupBox1.Controls.Add(this.textBox_AdresText);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(496, 524);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres Ayarları";
            // 
            // textBox_Adres_Basligi
            // 
            this.textBox_Adres_Basligi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.textBox_Adres_Basligi.Location = new System.Drawing.Point(123, 263);
            this.textBox_Adres_Basligi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Adres_Basligi.Name = "textBox_Adres_Basligi";
            this.textBox_Adres_Basligi.Size = new System.Drawing.Size(365, 28);
            this.textBox_Adres_Basligi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adres Başlığı";
            // 
            // button_Adres_Sil
            // 
            this.button_Adres_Sil.Location = new System.Drawing.Point(19, 464);
            this.button_Adres_Sil.Margin = new System.Windows.Forms.Padding(4);
            this.button_Adres_Sil.Name = "button_Adres_Sil";
            this.button_Adres_Sil.Size = new System.Drawing.Size(171, 46);
            this.button_Adres_Sil.TabIndex = 13;
            this.button_Adres_Sil.Text = "Adres Sil";
            this.button_Adres_Sil.UseVisualStyleBackColor = true;
            this.button_Adres_Sil.Click += new System.EventHandler(this.button_Adres_Sil_Click);
            // 
            // button_Adres_Guncelle
            // 
            this.button_Adres_Guncelle.Location = new System.Drawing.Point(19, 410);
            this.button_Adres_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.button_Adres_Guncelle.Name = "button_Adres_Guncelle";
            this.button_Adres_Guncelle.Size = new System.Drawing.Size(171, 46);
            this.button_Adres_Guncelle.TabIndex = 12;
            this.button_Adres_Guncelle.Text = "Adres Güncelle";
            this.button_Adres_Guncelle.UseVisualStyleBackColor = true;
            this.button_Adres_Guncelle.Click += new System.EventHandler(this.button_Adres_Guncelle_Click);
            // 
            // button_Adres_Ekle
            // 
            this.button_Adres_Ekle.Location = new System.Drawing.Point(19, 356);
            this.button_Adres_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.button_Adres_Ekle.Name = "button_Adres_Ekle";
            this.button_Adres_Ekle.Size = new System.Drawing.Size(171, 46);
            this.button_Adres_Ekle.TabIndex = 11;
            this.button_Adres_Ekle.Text = "Adres Ekle";
            this.button_Adres_Ekle.UseVisualStyleBackColor = true;
            this.button_Adres_Ekle.Click += new System.EventHandler(this.button_Adres_Ekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kayıtlı Adreslerim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mahalle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "İlçe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ülke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adres Tarifi";
            // 
            // textBox_Mahalle
            // 
            this.textBox_Mahalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.textBox_Mahalle.Location = new System.Drawing.Point(123, 232);
            this.textBox_Mahalle.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Mahalle.Name = "textBox_Mahalle";
            this.textBox_Mahalle.Size = new System.Drawing.Size(365, 28);
            this.textBox_Mahalle.TabIndex = 4;
            // 
            // textBox_Ilce
            // 
            this.textBox_Ilce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.textBox_Ilce.Location = new System.Drawing.Point(123, 200);
            this.textBox_Ilce.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ilce.Name = "textBox_Ilce";
            this.textBox_Ilce.Size = new System.Drawing.Size(365, 28);
            this.textBox_Ilce.TabIndex = 3;
            // 
            // textBox_Sehir
            // 
            this.textBox_Sehir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.textBox_Sehir.Location = new System.Drawing.Point(123, 168);
            this.textBox_Sehir.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Sehir.Name = "textBox_Sehir";
            this.textBox_Sehir.Size = new System.Drawing.Size(365, 28);
            this.textBox_Sehir.TabIndex = 2;
            // 
            // textBox_Ulke
            // 
            this.textBox_Ulke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.textBox_Ulke.Location = new System.Drawing.Point(123, 136);
            this.textBox_Ulke.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ulke.Name = "textBox_Ulke";
            this.textBox_Ulke.Size = new System.Drawing.Size(365, 28);
            this.textBox_Ulke.TabIndex = 1;
            // 
            // textBox_AdresText
            // 
            this.textBox_AdresText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.textBox_AdresText.Location = new System.Drawing.Point(123, 32);
            this.textBox_AdresText.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AdresText.Multiline = true;
            this.textBox_AdresText.Name = "textBox_AdresText";
            this.textBox_AdresText.Size = new System.Drawing.Size(365, 96);
            this.textBox_AdresText.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(-1, 545);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kullanıcı ID:";
            // 
            // label_Kullanıcı_ID
            // 
            this.label_Kullanıcı_ID.AutoSize = true;
            this.label_Kullanıcı_ID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.label_Kullanıcı_ID.Location = new System.Drawing.Point(110, 545);
            this.label_Kullanıcı_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Kullanıcı_ID.Name = "label_Kullanıcı_ID";
            this.label_Kullanıcı_ID.Size = new System.Drawing.Size(18, 21);
            this.label_Kullanıcı_ID.TabIndex = 2;
            this.label_Kullanıcı_ID.Text = "x";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Cinsiyet);
            this.groupBox2.Controls.Add(this.button_Guncelle);
            this.groupBox2.Controls.Add(this.textBox_Mail);
            this.groupBox2.Controls.Add(this.textBox_Kullanici_Adi);
            this.groupBox2.Controls.Add(this.label_Mail);
            this.groupBox2.Controls.Add(this.label_Cinsiyet);
            this.groupBox2.Controls.Add(this.label_Kullanici_Adı);
            this.groupBox2.Controls.Add(this.textBox_Ad_Degistir);
            this.groupBox2.Controls.Add(this.label_Ad);
            this.groupBox2.Controls.Add(this.button_Hesap_Bilgileri);
            this.groupBox2.Controls.Add(this.button_Sifre_Degistir);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.groupBox2.Location = new System.Drawing.Point(545, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(496, 524);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // comboBox_Cinsiyet
            // 
            this.comboBox_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cinsiyet.FormattingEnabled = true;
            this.comboBox_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox_Cinsiyet.Location = new System.Drawing.Point(198, 192);
            this.comboBox_Cinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            this.comboBox_Cinsiyet.Size = new System.Drawing.Size(232, 29);
            this.comboBox_Cinsiyet.TabIndex = 12;
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Location = new System.Drawing.Point(170, 284);
            this.button_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(171, 46);
            this.button_Guncelle.TabIndex = 11;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(198, 229);
            this.textBox_Mail.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 28);
            this.textBox_Mail.TabIndex = 10;
            // 
            // textBox_Kullanici_Adi
            // 
            this.textBox_Kullanici_Adi.Location = new System.Drawing.Point(198, 156);
            this.textBox_Kullanici_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Kullanici_Adi.Name = "textBox_Kullanici_Adi";
            this.textBox_Kullanici_Adi.Size = new System.Drawing.Size(232, 28);
            this.textBox_Kullanici_Adi.TabIndex = 8;
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.Location = new System.Drawing.Point(59, 232);
            this.label_Mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(73, 21);
            this.label_Mail.TabIndex = 7;
            this.label_Mail.Text = "E-Posta";
            // 
            // label_Cinsiyet
            // 
            this.label_Cinsiyet.AutoSize = true;
            this.label_Cinsiyet.Location = new System.Drawing.Point(57, 195);
            this.label_Cinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Cinsiyet.Name = "label_Cinsiyet";
            this.label_Cinsiyet.Size = new System.Drawing.Size(75, 21);
            this.label_Cinsiyet.TabIndex = 6;
            this.label_Cinsiyet.Text = "Cinsiyet";
            // 
            // label_Kullanici_Adı
            // 
            this.label_Kullanici_Adı.AutoSize = true;
            this.label_Kullanici_Adı.Location = new System.Drawing.Point(57, 159);
            this.label_Kullanici_Adı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Kullanici_Adı.Name = "label_Kullanici_Adı";
            this.label_Kullanici_Adı.Size = new System.Drawing.Size(109, 21);
            this.label_Kullanici_Adı.TabIndex = 5;
            this.label_Kullanici_Adı.Text = "Kullanıcı Adı";
            // 
            // textBox_Ad_Degistir
            // 
            this.textBox_Ad_Degistir.Location = new System.Drawing.Point(198, 120);
            this.textBox_Ad_Degistir.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ad_Degistir.Name = "textBox_Ad_Degistir";
            this.textBox_Ad_Degistir.Size = new System.Drawing.Size(232, 28);
            this.textBox_Ad_Degistir.TabIndex = 4;
            // 
            // label_Ad
            // 
            this.label_Ad.AutoSize = true;
            this.label_Ad.Location = new System.Drawing.Point(59, 123);
            this.label_Ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ad.Name = "label_Ad";
            this.label_Ad.Size = new System.Drawing.Size(91, 21);
            this.label_Ad.TabIndex = 3;
            this.label_Ad.Text = "Ad-Soyad";
            // 
            // button_Hesap_Bilgileri
            // 
            this.button_Hesap_Bilgileri.Location = new System.Drawing.Point(21, 50);
            this.button_Hesap_Bilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.button_Hesap_Bilgileri.Name = "button_Hesap_Bilgileri";
            this.button_Hesap_Bilgileri.Size = new System.Drawing.Size(228, 45);
            this.button_Hesap_Bilgileri.TabIndex = 1;
            this.button_Hesap_Bilgileri.Text = "Hesap Biglilerim";
            this.button_Hesap_Bilgileri.UseVisualStyleBackColor = true;
            this.button_Hesap_Bilgileri.Click += new System.EventHandler(this.button_Hesap_Bilgileri_Click);
            // 
            // button_Sifre_Degistir
            // 
            this.button_Sifre_Degistir.Location = new System.Drawing.Point(252, 50);
            this.button_Sifre_Degistir.Margin = new System.Windows.Forms.Padding(4);
            this.button_Sifre_Degistir.Name = "button_Sifre_Degistir";
            this.button_Sifre_Degistir.Size = new System.Drawing.Size(236, 45);
            this.button_Sifre_Degistir.TabIndex = 0;
            this.button_Sifre_Degistir.Text = "Şifre Değiştir";
            this.button_Sifre_Degistir.UseVisualStyleBackColor = true;
            this.button_Sifre_Degistir.Click += new System.EventHandler(this.button_Sifre_Degistir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.label_Kullanıcı_ID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 570);
            this.panel1.TabIndex = 18;
            // 
            // hesapAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1067, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hesapAyarlari";
            this.Text = "hesapAyarlari";
            this.Load += new System.EventHandler(this.hesapAyarlari_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Adresler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Sehir;
        private System.Windows.Forms.TextBox textBox_Ulke;
        private System.Windows.Forms.TextBox textBox_AdresText;
        private System.Windows.Forms.TextBox textBox_Ilce;
        private System.Windows.Forms.Button button_Adres_Sil;
        private System.Windows.Forms.Button button_Adres_Guncelle;
        private System.Windows.Forms.Button button_Adres_Ekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Mahalle;
        private System.Windows.Forms.TextBox textBox_Adres_Basligi;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label_Kullanıcı_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Sifre_Degistir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Kullanici_Adi;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_Cinsiyet;
        private System.Windows.Forms.Label label_Kullanici_Adı;
        private System.Windows.Forms.TextBox textBox_Ad_Degistir;
        private System.Windows.Forms.Label label_Ad;
        private System.Windows.Forms.Button button_Hesap_Bilgileri;
        private System.Windows.Forms.ComboBox comboBox_Cinsiyet;
        private System.Windows.Forms.Panel panel1;
    }
}