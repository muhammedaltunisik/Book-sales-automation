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

namespace KitapYurdu
{
    public partial class hesapAyarlari : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=KitapYurdu;Integrated Security=True");
        int modeBiti = 0;

        private void hesapAyarlari_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT ADRES_BASLIGI FROM tbl_Adress WHERE KULLANICI_ID = @k1";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Kullanıcı_ID.Text));

            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox_Adresler.Items.Add(dr["ADRES_BASLIGI"]);
            }

            dr.Close();
            baglanti.Close();
        }


        public hesapAyarlari()
        {
            InitializeComponent();
            gorunurlukDegistir(true,2);

        }

        private void button_Adres_Ekle_Click(object sender, EventArgs e)
        {
            adresEkle();
            MessageBox.Show("Adres Başarıyla Eklendi.");
            comboBox_Adresler.Items.Add(textBox_Adres_Basligi.Text);
        }

        private void button_Adres_Sil_Click(object sender, EventArgs e)
        {
            adresSil();
            MessageBox.Show("Adres Başarıyla Silindi.");
            comboBox_Adresler.Items.Remove(comboBox_Adresler.SelectedItem);
        }

        private void button_Adres_Guncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "UPDATE tbl_Adress SET ADDRESSTEXT = @k1 , ADRES_BASLIGI = @k2, ULKE = @k3, SEHIR = @k4, ILCE = @k5," +
                "MAHALLE = @k6 WHERE KULLANICI_ID = @k7 AND ADRES_BASLIGI = @k8";
            komut.Parameters.AddWithValue("@k1", textBox_AdresText.Text);
            komut.Parameters.AddWithValue("@k2", textBox_Adres_Basligi.Text);
            komut.Parameters.AddWithValue("@k3", textBox_Ulke.Text);
            komut.Parameters.AddWithValue("@k4", textBox_Sehir.Text);
            komut.Parameters.AddWithValue("@k5", textBox_Ilce.Text);
            komut.Parameters.AddWithValue("@k6", textBox_Mahalle.Text);
            komut.Parameters.AddWithValue("@k7", Convert.ToInt32(label_Kullanıcı_ID.Text));
            komut.Parameters.AddWithValue("@k8", textBox_Adres_Basligi.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            comboBox_Adresler.Items[comboBox_Adresler.SelectedIndex] = textBox_Adres_Basligi.Text;
            MessageBox.Show("Adres Başarıyla Güncellendi.");
        }



        private void adresEkle()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO tbl_Adress(KULLANICI_ID,ADDRESSTEXT,ADRES_BASLIGI,ULKE,SEHIR,ILCE,MAHALLE) VALUES" +
                "(@k1,@k2,@k3,@k4,@k5,@k6,@k7)";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Kullanıcı_ID.Text));
            komut.Parameters.AddWithValue("@k2", textBox_AdresText.Text);
            komut.Parameters.AddWithValue("@k3", textBox_Adres_Basligi.Text);
            komut.Parameters.AddWithValue("@k4", textBox_Ulke.Text);
            komut.Parameters.AddWithValue("@k5", textBox_Sehir.Text);
            komut.Parameters.AddWithValue("@k6", textBox_Ilce.Text);
            komut.Parameters.AddWithValue("@k7", textBox_Mahalle.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void adresSil()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM tbl_Adress WHERE KULLANICI_ID = @k1 AND ADRES_BASLIGI = @k2";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Kullanıcı_ID.Text));
            komut.Parameters.AddWithValue("@k2", comboBox_Adresler.Text);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            
            comboBox_Adresler.Text = "";
        }



        private void comboBox_Adresler_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tbl_Adress WHERE KULLANICI_ID = @k1 AND ADRES_BASLIGI = @k2";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Kullanıcı_ID.Text));
            komut.Parameters.AddWithValue("@k2", comboBox_Adresler.Text.ToString());


            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                textBox_AdresText.Text = dr["ADDRESSTEXT"].ToString();
                textBox_Ulke.Text = dr["ULKE"].ToString();
                textBox_Ilce.Text = dr["ILCE"].ToString();
                textBox_Mahalle.Text = dr["MAHALLE"].ToString();
                textBox_Sehir.Text = dr["SEHIR"].ToString();
                textBox_Adres_Basligi.Text = dr["ADRES_BASLIGI"].ToString();

            }
            dr.Close();
            baglanti.Close();
        }


        private void button_Hesap_Bilgileri_Click(object sender, EventArgs e)
        {
            modeBiti = 2;
            gorunurlukDegistir(true, 2);
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tbl_Kullanicilar WHERE ID = @k1";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Kullanıcı_ID.Text));

            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                textBox_Ad_Degistir.Text = dr["TAM_AD"].ToString();
                textBox_Kullanici_Adi.Text = dr["KULLANICI_ADI"].ToString();
                comboBox_Cinsiyet.Text = dr["CINSIYET"].ToString();
                textBox_Mail.Text = dr["MAIL"].ToString();
            }
            dr.Close();
            baglanti.Close();

        }


        private void gorunurlukDegistir(bool deger, int mode=0)
        {

            if (mode == 0)
            {
                textBox_Ad_Degistir.Visible = deger;
                textBox_Kullanici_Adi.Visible = deger;
                comboBox_Cinsiyet.Visible = deger;
                textBox_Mail.Visible = deger;
                label_Ad.Visible = deger;
                label_Kullanici_Adı.Visible = deger;
                label_Cinsiyet.Visible = deger;
                label_Mail.Visible = deger;
                button_Guncelle.Visible = deger;

            }
            else if (mode == 1)
            {
                label_Ad.Text = "Şimdiki Şifreniz:";
                label_Kullanici_Adı.Text = "Yeni Şifre:";
                textBox_Ad_Degistir.Text = "";
                textBox_Kullanici_Adi.Text = "";

                textBox_Ad_Degistir.Visible = deger;
                textBox_Kullanici_Adi.Visible = deger;
                label_Ad.Visible = deger;
                label_Kullanici_Adı.Visible = deger;
                button_Guncelle.Visible = deger;

                comboBox_Cinsiyet.Visible = false;
                textBox_Mail.Visible = false;
                label_Cinsiyet.Visible = false;
                label_Mail.Visible = false;
            }
            else if (mode == 2)
            {
                label_Ad.Text = "Ad-Soyad:";
                label_Kullanici_Adı.Text = "Kullanıcı Adı:";

                textBox_Ad_Degistir.Visible = deger;
                textBox_Kullanici_Adi.Visible = deger;
                comboBox_Cinsiyet.Visible = deger;
                textBox_Mail.Visible = deger;
                label_Ad.Visible = deger;
                label_Kullanici_Adı.Visible = deger;
                label_Cinsiyet.Visible = deger;
                label_Mail.Visible = deger;
                button_Guncelle.Visible = deger;
            }
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            

            if (modeBiti == 1)
            {
                komut.Parameters.Clear();
                komut.CommandText = "SELECT SIFRE FROM tbl_Kullanicilar WHERE ID = @k1";
                komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Kullanıcı_ID.Text));
                girisForm f = new girisForm();

                baglanti.Open();
                object sifre = komut.ExecuteScalar();
                string yeniSifre = textBox_Kullanici_Adi.Text;

                if (f.SHA256Hash(textBox_Ad_Degistir.Text) != sifre.ToString())
                {
                    MessageBox.Show("Şimdiki şifre yanlış");
                }
                else
                {
                   


                    komut.Parameters.Clear();
                    komut.CommandText = "UPDATE tbl_Kullanicilar SET SIFRE = @k1 WHERE ID = @k2";
                    komut.Parameters.AddWithValue("@k1", f.SHA256Hash(textBox_Kullanici_Adi.Text));
                    komut.Parameters.AddWithValue("@k2", Convert.ToInt32(label_Kullanıcı_ID.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz Güncellenmiştir.");
                }
                baglanti.Close();
            }

            else if(modeBiti == 2)
            {
                baglanti.Open();
                komut.CommandText = "SELECT KULLANICI_ADI FROM tbl_Kullanicilar WHERE KULLANICI_ADI=@k1";
                komut.Parameters.AddWithValue("@k1", textBox_Kullanici_Adi.Text);
                object kullaniciAdi = komut.ExecuteScalar();
                baglanti.Close();

                string kontrol = (kullaniciAdi == null ? "notEqual": textBox_Kullanici_Adi.Text );

                if (textBox_Kullanici_Adi.Text != kontrol )
                {
                    komut.Parameters.Clear();
                    komut.CommandText = "UPDATE tbl_Kullanicilar SET KULLANICI_ADI = @k1, TAM_AD=@k2, MAIL= @k3,CINSIYET = @k4 WHERE ID = @k5";
                    komut.Parameters.AddWithValue("@k1", textBox_Kullanici_Adi.Text);
                    komut.Parameters.AddWithValue("@k2", textBox_Ad_Degistir.Text);
                    komut.Parameters.AddWithValue("@k3", textBox_Mail.Text);
                    komut.Parameters.AddWithValue("@k4", comboBox_Cinsiyet.Text);
                    komut.Parameters.AddWithValue("@k5", Convert.ToInt32(label_Kullanıcı_ID.Text));

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Bilgileriniz Güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Boyle bir kullanıcı adı var.\nLutfen baska bir kullanici adi giriniz");
                }


                

            }
        }

        private void button_Sifre_Degistir_Click(object sender, EventArgs e)
        {
            modeBiti = 1;
            gorunurlukDegistir(true, 1);
            
        }

    }
}
