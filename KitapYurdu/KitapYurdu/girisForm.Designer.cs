
namespace KitapYurdu
{
    partial class girisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_github = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label_linkedin = new System.Windows.Forms.Label();
            this.label_twitter = new System.Windows.Forms.Label();
            this.label_Instagram = new System.Windows.Forms.Label();
            this.comboBox_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.button_Kayıt_Ol = new System.Windows.Forms.Button();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Ad_Soyad = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label_Cinsiyet = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_Ad_Soyad = new System.Windows.Forms.Label();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.label_Kullanici_Adi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Giris_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Giris_Sifre = new System.Windows.Forms.TextBox();
            this.button_Giris_Yap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel_SifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.checkBox_BeniHatirla = new System.Windows.Forms.CheckBox();
            this.checkBox_Yayınevi_Giris = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::KitapYurdu.Properties.Resources.book;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_github);
            this.groupBox1.Controls.Add(this.label_linkedin);
            this.groupBox1.Controls.Add(this.label_twitter);
            this.groupBox1.Controls.Add(this.label_Instagram);
            this.groupBox1.Controls.Add(this.comboBox_Cinsiyet);
            this.groupBox1.Controls.Add(this.button_Kayıt_Ol);
            this.groupBox1.Controls.Add(this.textBox_Mail);
            this.groupBox1.Controls.Add(this.textBox_Ad_Soyad);
            this.groupBox1.Controls.Add(this.textBox_Sifre);
            this.groupBox1.Controls.Add(this.textBox_KullaniciAdi);
            this.groupBox1.Controls.Add(this.label_Cinsiyet);
            this.groupBox1.Controls.Add(this.label_Mail);
            this.groupBox1.Controls.Add(this.label_Ad_Soyad);
            this.groupBox1.Controls.Add(this.label_Sifre);
            this.groupBox1.Controls.Add(this.label_Kullanici_Adi);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label_github
            // 
            resources.ApplyResources(this.label_github, "label_github");
            this.label_github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_github.ImageList = this.ımageList1;
            this.label_github.Name = "label_github";
            this.label_github.Click += new System.EventHandler(this.label_github_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "githublogo.png");
            this.ımageList1.Images.SetKeyName(1, "instagramlogo.png");
            this.ımageList1.Images.SetKeyName(2, "linkedinlogo.png");
            this.ımageList1.Images.SetKeyName(3, "login.png");
            this.ımageList1.Images.SetKeyName(4, "twitterlogo.png");
            this.ımageList1.Images.SetKeyName(5, "book.png");
            // 
            // label_linkedin
            // 
            resources.ApplyResources(this.label_linkedin, "label_linkedin");
            this.label_linkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_linkedin.ImageList = this.ımageList1;
            this.label_linkedin.Name = "label_linkedin";
            this.label_linkedin.Click += new System.EventHandler(this.label_linkedin_Click);
            // 
            // label_twitter
            // 
            resources.ApplyResources(this.label_twitter, "label_twitter");
            this.label_twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_twitter.ImageList = this.ımageList1;
            this.label_twitter.Name = "label_twitter";
            this.label_twitter.Click += new System.EventHandler(this.label_twitter_Click);
            // 
            // label_Instagram
            // 
            resources.ApplyResources(this.label_Instagram, "label_Instagram");
            this.label_Instagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Instagram.ImageList = this.ımageList1;
            this.label_Instagram.Name = "label_Instagram";
            this.label_Instagram.Click += new System.EventHandler(this.label_Instagram_Click);
            // 
            // comboBox_Cinsiyet
            // 
            this.comboBox_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_Cinsiyet, "comboBox_Cinsiyet");
            this.comboBox_Cinsiyet.FormattingEnabled = true;
            this.comboBox_Cinsiyet.Items.AddRange(new object[] {
            resources.GetString("comboBox_Cinsiyet.Items"),
            resources.GetString("comboBox_Cinsiyet.Items1")});
            this.comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            // 
            // button_Kayıt_Ol
            // 
            resources.ApplyResources(this.button_Kayıt_Ol, "button_Kayıt_Ol");
            this.button_Kayıt_Ol.Name = "button_Kayıt_Ol";
            this.button_Kayıt_Ol.UseVisualStyleBackColor = true;
            this.button_Kayıt_Ol.Click += new System.EventHandler(this.button_Kayıt_Ol_Click);
            // 
            // textBox_Mail
            // 
            resources.ApplyResources(this.textBox_Mail, "textBox_Mail");
            this.textBox_Mail.Name = "textBox_Mail";
            // 
            // textBox_Ad_Soyad
            // 
            resources.ApplyResources(this.textBox_Ad_Soyad, "textBox_Ad_Soyad");
            this.textBox_Ad_Soyad.Name = "textBox_Ad_Soyad";
            // 
            // textBox_Sifre
            // 
            resources.ApplyResources(this.textBox_Sifre, "textBox_Sifre");
            this.textBox_Sifre.Name = "textBox_Sifre";
            // 
            // textBox_KullaniciAdi
            // 
            resources.ApplyResources(this.textBox_KullaniciAdi, "textBox_KullaniciAdi");
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            // 
            // label_Cinsiyet
            // 
            resources.ApplyResources(this.label_Cinsiyet, "label_Cinsiyet");
            this.label_Cinsiyet.Name = "label_Cinsiyet";
            // 
            // label_Mail
            // 
            resources.ApplyResources(this.label_Mail, "label_Mail");
            this.label_Mail.Name = "label_Mail";
            // 
            // label_Ad_Soyad
            // 
            resources.ApplyResources(this.label_Ad_Soyad, "label_Ad_Soyad");
            this.label_Ad_Soyad.Name = "label_Ad_Soyad";
            // 
            // label_Sifre
            // 
            resources.ApplyResources(this.label_Sifre, "label_Sifre");
            this.label_Sifre.Name = "label_Sifre";
            // 
            // label_Kullanici_Adi
            // 
            resources.ApplyResources(this.label_Kullanici_Adi, "label_Kullanici_Adi");
            this.label_Kullanici_Adi.ForeColor = System.Drawing.Color.Black;
            this.label_Kullanici_Adi.Name = "label_Kullanici_Adi";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // textBox_Giris_KullaniciAdi
            // 
            resources.ApplyResources(this.textBox_Giris_KullaniciAdi, "textBox_Giris_KullaniciAdi");
            this.textBox_Giris_KullaniciAdi.Name = "textBox_Giris_KullaniciAdi";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // textBox_Giris_Sifre
            // 
            resources.ApplyResources(this.textBox_Giris_Sifre, "textBox_Giris_Sifre");
            this.textBox_Giris_Sifre.Name = "textBox_Giris_Sifre";
            // 
            // button_Giris_Yap
            // 
            resources.ApplyResources(this.button_Giris_Yap, "button_Giris_Yap");
            this.button_Giris_Yap.Name = "button_Giris_Yap";
            this.button_Giris_Yap.UseVisualStyleBackColor = true;
            this.button_Giris_Yap.Click += new System.EventHandler(this.button_Giris_Yap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel_SifremiUnuttum);
            this.groupBox2.Controls.Add(this.checkBox_BeniHatirla);
            this.groupBox2.Controls.Add(this.checkBox_Yayınevi_Giris);
            this.groupBox2.Controls.Add(this.button_Giris_Yap);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_Giris_Sifre);
            this.groupBox2.Controls.Add(this.textBox_Giris_KullaniciAdi);
            this.groupBox2.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // linkLabel_SifremiUnuttum
            // 
            this.linkLabel_SifremiUnuttum.ActiveLinkColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.linkLabel_SifremiUnuttum, "linkLabel_SifremiUnuttum");
            this.linkLabel_SifremiUnuttum.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.linkLabel_SifremiUnuttum.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_SifremiUnuttum.Name = "linkLabel_SifremiUnuttum";
            this.linkLabel_SifremiUnuttum.TabStop = true;
            // 
            // checkBox_BeniHatirla
            // 
            resources.ApplyResources(this.checkBox_BeniHatirla, "checkBox_BeniHatirla");
            this.checkBox_BeniHatirla.ForeColor = System.Drawing.Color.Black;
            this.checkBox_BeniHatirla.Name = "checkBox_BeniHatirla";
            this.checkBox_BeniHatirla.UseVisualStyleBackColor = true;
            // 
            // checkBox_Yayınevi_Giris
            // 
            resources.ApplyResources(this.checkBox_Yayınevi_Giris, "checkBox_Yayınevi_Giris");
            this.checkBox_Yayınevi_Giris.Name = "checkBox_Yayınevi_Giris";
            this.checkBox_Yayınevi_Giris.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // girisForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "girisForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.girisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Kullanici_Adi;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.Button button_Kayıt_Ol;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Ad_Soyad;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.Label label_Cinsiyet;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_Ad_Soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Giris_KullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Giris_Sifre;
        private System.Windows.Forms.Button button_Giris_Yap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_Cinsiyet;
        private System.Windows.Forms.CheckBox checkBox_Yayınevi_Giris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel_SifremiUnuttum;
        private System.Windows.Forms.CheckBox checkBox_BeniHatirla;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_github;
        private System.Windows.Forms.Label label_linkedin;
        private System.Windows.Forms.Label label_twitter;
        private System.Windows.Forms.Label label_Instagram;
    }
}

