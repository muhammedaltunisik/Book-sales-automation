
namespace KitapYurdu
{
    partial class musteriForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kitapYurduDataSet = new KitapYurdu.KitapYurduDataSet();
            this.textBox_kitap_Adi = new System.Windows.Forms.TextBox();
            this.button_kitap_ara = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Yazar_Ara = new System.Windows.Forms.Button();
            this.button_TumunuGetir = new System.Windows.Forms.Button();
            this.button_Sepete_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Sepetten_Cikar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Sepet = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Gecmis_Siparisler = new System.Windows.Forms.Button();
            this.button_Sepet_Onay = new System.Windows.Forms.Button();
            this.label_Kullanıcı_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Hesap_Ayarlari = new System.Windows.Forms.Button();
            this.comboBox_Adresler = new System.Windows.Forms.ComboBox();
            this.label_Kayıtlı_Adresler = new System.Windows.Forms.Label();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_CikisYap = new System.Windows.Forms.Button();
            this.button_Kategori_Ara = new System.Windows.Forms.Button();
            this.tblKitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KitaplarTableAdapter = new KitapYurdu.KitapYurduDataSetTableAdapters.tbl_KitaplarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYurduDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sepet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapYurduDataSet
            // 
            this.kitapYurduDataSet.DataSetName = "KitapYurduDataSet";
            this.kitapYurduDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_kitap_Adi
            // 
            this.textBox_kitap_Adi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.textBox_kitap_Adi.Location = new System.Drawing.Point(17, 21);
            this.textBox_kitap_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_kitap_Adi.Name = "textBox_kitap_Adi";
            this.textBox_kitap_Adi.Size = new System.Drawing.Size(260, 28);
            this.textBox_kitap_Adi.TabIndex = 1;
            this.textBox_kitap_Adi.Tag = "Ara..";
            // 
            // button_kitap_ara
            // 
            this.button_kitap_ara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kitap_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kitap_ara.ImageKey = "13416400251535694869-128.png";
            this.button_kitap_ara.ImageList = this.ımageList1;
            this.button_kitap_ara.Location = new System.Drawing.Point(17, 115);
            this.button_kitap_ara.Margin = new System.Windows.Forms.Padding(4);
            this.button_kitap_ara.Name = "button_kitap_ara";
            this.button_kitap_ara.Size = new System.Drawing.Size(260, 54);
            this.button_kitap_ara.TabIndex = 2;
            this.button_kitap_ara.Text = "Kitap Ara";
            this.button_kitap_ara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kitap_ara.UseVisualStyleBackColor = true;
            this.button_kitap_ara.Click += new System.EventHandler(this.button_kitap_ara_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arrow_left.png");
            this.ımageList1.Images.SetKeyName(1, "check.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-arrow-50.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-time-machine-50.png");
            this.ımageList1.Images.SetKeyName(4, "13416400251535694869-128.png");
            this.ımageList1.Images.SetKeyName(5, "19580304091552644365-128.png");
            this.ımageList1.Images.SetKeyName(6, "8027787901556274007-128.png");
            this.ımageList1.Images.SetKeyName(7, "fountain-pen-close-up.png");
            this.ımageList1.Images.SetKeyName(8, "tag.png");
            this.ımageList1.Images.SetKeyName(9, "check-mark.png");
            this.ımageList1.Images.SetKeyName(10, "history.png");
            this.ımageList1.Images.SetKeyName(11, "tick.png");
            this.ımageList1.Images.SetKeyName(12, "gear.png");
            this.ımageList1.Images.SetKeyName(13, "login.png");
            this.ımageList1.Images.SetKeyName(14, "logout.png");
            this.ımageList1.Images.SetKeyName(15, "tag (1).png");
            // 
            // button_Yazar_Ara
            // 
            this.button_Yazar_Ara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.button_Yazar_Ara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Yazar_Ara.ImageKey = "fountain-pen-close-up.png";
            this.button_Yazar_Ara.ImageList = this.ımageList1;
            this.button_Yazar_Ara.Location = new System.Drawing.Point(17, 57);
            this.button_Yazar_Ara.Margin = new System.Windows.Forms.Padding(4);
            this.button_Yazar_Ara.Name = "button_Yazar_Ara";
            this.button_Yazar_Ara.Size = new System.Drawing.Size(260, 54);
            this.button_Yazar_Ara.TabIndex = 3;
            this.button_Yazar_Ara.Text = "Yazar Ara";
            this.button_Yazar_Ara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Yazar_Ara.UseVisualStyleBackColor = true;
            this.button_Yazar_Ara.Click += new System.EventHandler(this.button_Yazar_Ara_Click);
            // 
            // button_TumunuGetir
            // 
            this.button_TumunuGetir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.button_TumunuGetir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_TumunuGetir.ImageIndex = 6;
            this.button_TumunuGetir.ImageList = this.ımageList1;
            this.button_TumunuGetir.Location = new System.Drawing.Point(17, 173);
            this.button_TumunuGetir.Margin = new System.Windows.Forms.Padding(4);
            this.button_TumunuGetir.Name = "button_TumunuGetir";
            this.button_TumunuGetir.Size = new System.Drawing.Size(260, 54);
            this.button_TumunuGetir.TabIndex = 4;
            this.button_TumunuGetir.Text = "Tüm Kitapları Getir";
            this.button_TumunuGetir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TumunuGetir.UseVisualStyleBackColor = true;
            this.button_TumunuGetir.Click += new System.EventHandler(this.button_TumunuGetir_Click);
            // 
            // button_Sepete_Ekle
            // 
            this.button_Sepete_Ekle.ImageKey = "icons8-arrow-50.png";
            this.button_Sepete_Ekle.ImageList = this.ımageList1;
            this.button_Sepete_Ekle.Location = new System.Drawing.Point(324, 76);
            this.button_Sepete_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.button_Sepete_Ekle.Name = "button_Sepete_Ekle";
            this.button_Sepete_Ekle.Size = new System.Drawing.Size(101, 54);
            this.button_Sepete_Ekle.TabIndex = 5;
            this.button_Sepete_Ekle.UseVisualStyleBackColor = true;
            this.button_Sepete_Ekle.Click += new System.EventHandler(this.button_Sepete_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(311, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sepete Ekle";
            // 
            // button_Sepetten_Cikar
            // 
            this.button_Sepetten_Cikar.ImageKey = "arrow_left.png";
            this.button_Sepetten_Cikar.ImageList = this.ımageList1;
            this.button_Sepetten_Cikar.Location = new System.Drawing.Point(324, 192);
            this.button_Sepetten_Cikar.Margin = new System.Windows.Forms.Padding(4);
            this.button_Sepetten_Cikar.Name = "button_Sepetten_Cikar";
            this.button_Sepetten_Cikar.Size = new System.Drawing.Size(101, 54);
            this.button_Sepetten_Cikar.TabIndex = 7;
            this.button_Sepetten_Cikar.UseVisualStyleBackColor = true;
            this.button_Sepetten_Cikar.Click += new System.EventHandler(this.button_Sepetten_Cikar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(290, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sepetten Çıkar";
            // 
            // dataGridView_Sepet
            // 
            this.dataGridView_Sepet.AllowUserToAddRows = false;
            this.dataGridView_Sepet.AllowUserToDeleteRows = false;
            this.dataGridView_Sepet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sepet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Sepet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Sepet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Sepet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Sepet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Sepet.ColumnHeadersHeight = 29;
            this.dataGridView_Sepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Sepet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Sepet.Location = new System.Drawing.Point(464, 40);
            this.dataGridView_Sepet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Sepet.MultiSelect = false;
            this.dataGridView_Sepet.Name = "dataGridView_Sepet";
            this.dataGridView_Sepet.ReadOnly = true;
            this.dataGridView_Sepet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Sepet.RowHeadersWidth = 25;
            this.dataGridView_Sepet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Sepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Sepet.Size = new System.Drawing.Size(786, 325);
            this.dataGridView_Sepet.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(787, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alışveriş Sepeti";
            // 
            // button_Gecmis_Siparisler
            // 
            this.button_Gecmis_Siparisler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.button_Gecmis_Siparisler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Gecmis_Siparisler.ImageKey = "history.png";
            this.button_Gecmis_Siparisler.ImageList = this.ımageList1;
            this.button_Gecmis_Siparisler.Location = new System.Drawing.Point(465, 398);
            this.button_Gecmis_Siparisler.Margin = new System.Windows.Forms.Padding(4);
            this.button_Gecmis_Siparisler.Name = "button_Gecmis_Siparisler";
            this.button_Gecmis_Siparisler.Size = new System.Drawing.Size(260, 53);
            this.button_Gecmis_Siparisler.TabIndex = 11;
            this.button_Gecmis_Siparisler.Text = "Geçmiş Siparişler";
            this.button_Gecmis_Siparisler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Gecmis_Siparisler.UseVisualStyleBackColor = true;
            this.button_Gecmis_Siparisler.Click += new System.EventHandler(this.button_Gecmis_Siparisler_Click);
            // 
            // button_Sepet_Onay
            // 
            this.button_Sepet_Onay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.button_Sepet_Onay.ImageKey = "tick.png";
            this.button_Sepet_Onay.ImageList = this.ımageList1;
            this.button_Sepet_Onay.Location = new System.Drawing.Point(746, 397);
            this.button_Sepet_Onay.Margin = new System.Windows.Forms.Padding(4);
            this.button_Sepet_Onay.Name = "button_Sepet_Onay";
            this.button_Sepet_Onay.Size = new System.Drawing.Size(260, 54);
            this.button_Sepet_Onay.TabIndex = 12;
            this.button_Sepet_Onay.Text = "Sepeti Onayla";
            this.button_Sepet_Onay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Sepet_Onay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Sepet_Onay.UseVisualStyleBackColor = true;
            this.button_Sepet_Onay.Click += new System.EventHandler(this.button_Sepet_Onay_Click);
            // 
            // label_Kullanıcı_ID
            // 
            this.label_Kullanıcı_ID.AutoSize = true;
            this.label_Kullanıcı_ID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.label_Kullanıcı_ID.Location = new System.Drawing.Point(126, 436);
            this.label_Kullanıcı_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Kullanıcı_ID.Name = "label_Kullanıcı_ID";
            this.label_Kullanıcı_ID.Size = new System.Drawing.Size(18, 21);
            this.label_Kullanıcı_ID.TabIndex = 13;
            this.label_Kullanıcı_ID.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(13, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kullanici ID:";
            // 
            // button_Hesap_Ayarlari
            // 
            this.button_Hesap_Ayarlari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.button_Hesap_Ayarlari.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Hesap_Ayarlari.ImageKey = "19580304091552644365-128.png";
            this.button_Hesap_Ayarlari.ImageList = this.ımageList1;
            this.button_Hesap_Ayarlari.Location = new System.Drawing.Point(17, 292);
            this.button_Hesap_Ayarlari.Margin = new System.Windows.Forms.Padding(4);
            this.button_Hesap_Ayarlari.Name = "button_Hesap_Ayarlari";
            this.button_Hesap_Ayarlari.Size = new System.Drawing.Size(260, 54);
            this.button_Hesap_Ayarlari.TabIndex = 16;
            this.button_Hesap_Ayarlari.Text = "Hesap Ayarlari";
            this.button_Hesap_Ayarlari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Hesap_Ayarlari.UseVisualStyleBackColor = true;
            this.button_Hesap_Ayarlari.Click += new System.EventHandler(this.button_Hesap_Ayarlari_Click);
            // 
            // comboBox_Adresler
            // 
            this.comboBox_Adresler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Adresler.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.comboBox_Adresler.FormattingEnabled = true;
            this.comboBox_Adresler.Location = new System.Drawing.Point(1040, 398);
            this.comboBox_Adresler.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Adresler.Name = "comboBox_Adresler";
            this.comboBox_Adresler.Size = new System.Drawing.Size(197, 29);
            this.comboBox_Adresler.TabIndex = 17;
            // 
            // label_Kayıtlı_Adresler
            // 
            this.label_Kayıtlı_Adresler.AutoSize = true;
            this.label_Kayıtlı_Adresler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.label_Kayıtlı_Adresler.Location = new System.Drawing.Point(1065, 370);
            this.label_Kayıtlı_Adresler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Kayıtlı_Adresler.Name = "label_Kayıtlı_Adresler";
            this.label_Kayıtlı_Adresler.Size = new System.Drawing.Size(150, 23);
            this.label_Kayıtlı_Adresler.TabIndex = 18;
            this.label_Kayıtlı_Adresler.Text = "Kayıtlı Adresler";
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Guncelle.Location = new System.Drawing.Point(1040, 430);
            this.button_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(197, 31);
            this.button_Guncelle.TabIndex = 19;
            this.button_Guncelle.Text = "Adresleri Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.button_CikisYap);
            this.panel1.Controls.Add(this.button_Kategori_Ara);
            this.panel1.Controls.Add(this.dataGridView_Sepet);
            this.panel1.Controls.Add(this.textBox_kitap_Adi);
            this.panel1.Controls.Add(this.button_Guncelle);
            this.panel1.Controls.Add(this.button_kitap_ara);
            this.panel1.Controls.Add(this.label_Kayıtlı_Adresler);
            this.panel1.Controls.Add(this.button_Yazar_Ara);
            this.panel1.Controls.Add(this.comboBox_Adresler);
            this.panel1.Controls.Add(this.button_TumunuGetir);
            this.panel1.Controls.Add(this.button_Hesap_Ayarlari);
            this.panel1.Controls.Add(this.button_Sepete_Ekle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Kullanıcı_ID);
            this.panel1.Controls.Add(this.button_Sepetten_Cikar);
            this.panel1.Controls.Add(this.button_Sepet_Onay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_Gecmis_Siparisler);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 465);
            this.panel1.TabIndex = 20;
            // 
            // button_CikisYap
            // 
            this.button_CikisYap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.button_CikisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CikisYap.ImageKey = "login.png";
            this.button_CikisYap.ImageList = this.ımageList1;
            this.button_CikisYap.Location = new System.Drawing.Point(17, 354);
            this.button_CikisYap.Margin = new System.Windows.Forms.Padding(4);
            this.button_CikisYap.Name = "button_CikisYap";
            this.button_CikisYap.Size = new System.Drawing.Size(260, 54);
            this.button_CikisYap.TabIndex = 21;
            this.button_CikisYap.Text = "Logout";
            this.button_CikisYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CikisYap.UseVisualStyleBackColor = true;
            this.button_CikisYap.Click += new System.EventHandler(this.button_CikisYap_Click);
            // 
            // button_Kategori_Ara
            // 
            this.button_Kategori_Ara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.button_Kategori_Ara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Kategori_Ara.ImageKey = "tag (1).png";
            this.button_Kategori_Ara.ImageList = this.ımageList1;
            this.button_Kategori_Ara.Location = new System.Drawing.Point(17, 233);
            this.button_Kategori_Ara.Margin = new System.Windows.Forms.Padding(4);
            this.button_Kategori_Ara.Name = "button_Kategori_Ara";
            this.button_Kategori_Ara.Size = new System.Drawing.Size(260, 54);
            this.button_Kategori_Ara.TabIndex = 20;
            this.button_Kategori_Ara.Text = "Kategori Ara";
            this.button_Kategori_Ara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kategori_Ara.UseVisualStyleBackColor = true;
            this.button_Kategori_Ara.Click += new System.EventHandler(this.button_Kategori_Ara_Click);
            // 
            // tblKitaplarBindingSource
            // 
            this.tblKitaplarBindingSource.DataMember = "tbl_Kitaplar";
            this.tblKitaplarBindingSource.DataSource = this.kitapYurduDataSet;
            // 
            // tbl_KitaplarTableAdapter
            // 
            this.tbl_KitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1263, 380);
            this.dataGridView1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 13);
            this.panel2.TabIndex = 21;
            // 
            // musteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 845);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1281, 892);
            this.MinimumSize = new System.Drawing.Size(1281, 892);
            this.Name = "musteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.musteriForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitapYurduDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sepet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KitapYurduDataSet kitapYurduDataSet;
        private System.Windows.Forms.TextBox textBox_kitap_Adi;
        private System.Windows.Forms.Button button_kitap_ara;
        private System.Windows.Forms.Button button_Yazar_Ara;
        private System.Windows.Forms.Button button_TumunuGetir;
        private System.Windows.Forms.Button button_Sepete_Ekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Sepetten_Cikar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Sepet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Gecmis_Siparisler;
        private System.Windows.Forms.Button button_Sepet_Onay;
        public System.Windows.Forms.Label label_Kullanıcı_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Hesap_Ayarlari;
        private System.Windows.Forms.ComboBox comboBox_Adresler;
        private System.Windows.Forms.Label label_Kayıtlı_Adresler;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Kategori_Ara;
        private System.Windows.Forms.BindingSource tblKitaplarBindingSource;
        private KitapYurduDataSetTableAdapters.tbl_KitaplarTableAdapter tbl_KitaplarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_CikisYap;
    }
}