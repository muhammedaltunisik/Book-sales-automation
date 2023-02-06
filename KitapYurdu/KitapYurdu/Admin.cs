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
using System.Security.Cryptography;

namespace KitapYurdu
{
    public partial class Admin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=KitapYurdu;Integrated Security=True");


        public Admin()
        {
            InitializeComponent();
            tumKitaplariGetir();
        }


        private void button_Getir_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if(radioButton_Tum_Kitaplar.Checked)
            {
                tumKitaplariGetir();
            }
            else if(radioButton_Tum_Yayin.Checked)
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM tbl_Saticilar";

                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);

                dataGridView_Kitaplari_Listele.DataSource = tablo;
            }

            else if(radioButton_Kullanici_Getir.Checked)
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM tbl_Kullanicilar WHERE KULLANICI_TIPI <> 'D' ";

                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);

                dataGridView_Kitaplari_Listele.DataSource = tablo;
            }

            else if(radioButton_Ada_Gore.Checked)
            {

                if(textBox_Yayin_Evi_Adi.Text != "")
                {
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "SELECT ID FROM tbl_Saticilar WHERE (YAYINEVI_ADI LIKE '%' + @k1 + '%') ";
                    komut.Parameters.AddWithValue("@k1", textBox_Yayin_Evi_Adi.Text);
                    object yayinEvID = komut.ExecuteScalar();
                    
                    if(yayinEvID != null)
                    {
                        komut.CommandText = "SELECT * FROM tbl_Kitaplar WHERE SATICI_ID = @k2";
                        komut.Parameters.AddWithValue("@k2", Convert.ToInt32(yayinEvID.ToString()));


                        SqlDataAdapter da = new SqlDataAdapter(komut);

                        DataTable tablo = new DataTable();
                        da.Fill(tablo);

                        dataGridView_Kitaplari_Listele.DataSource = tablo;
                    }
                    else
                    {
                        MessageBox.Show("Yayin evi bulunamadi");
                    }

                    
                }
                else
                {
                    MessageBox.Show("Yayınevi Adı Giriniz.");
                }
            }



            baglanti.Close();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            girisForm f = new girisForm();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;

            baglanti.Open();

            komut.CommandText = "SELECT KULLANICI_ADI FROM tbl_Saticilar WHERE KULLANICI_ADI = @k1";
            komut.Parameters.AddWithValue("@k1", textBox_Kullanici_Adi.Text);
            object kullaniciAdi = komut.ExecuteScalar();

            if(textBox_Kullanici_Adi.Text != string.Empty && textBox_Sifre.Text != string.Empty && textBox_YayinEvi.Text != string.Empty)
            {
                if (kullaniciAdi == null)
                {
                    komut.Parameters.Clear();
                    komut.CommandText = "INSERT INTO tbl_Saticilar(KULLANICI_ADI,SIFRE,YAYINEVI_ADI) VALUES(@k1,@k2,@k3)";
                    komut.Parameters.AddWithValue("@k1", textBox_Kullanici_Adi.Text);
                    komut.Parameters.AddWithValue("@k2", f.SHA256Hash(textBox_Sifre.Text));
                    komut.Parameters.AddWithValue("@k3", textBox_YayinEvi.Text);


                    komut.ExecuteNonQuery();


                    MessageBox.Show("Satıcı Başarıyla Eklendi.");
                }
                else
                {
                    MessageBox.Show("Boyle bir kullanıcı adı var.");
                }
            }
            else
            {
                MessageBox.Show("Yukarida ki alanlardan harhangi biri bos birakilamaz");
            }

            baglanti.Close();

        }

        

        private void button_Getir2_Click(object sender, EventArgs e)
        {
            if (radioButton_Silinen_Kitaplar.Checked)
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM tbl_silinen_Kitaplar";

                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);

                dataGridView_Kitaplari_Listele.DataSource = tablo;


            }

            else if (radioButton_Silinen_Kullanicilar.Checked)
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM tbl_silinen_Kullanicilar";

                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);

                dataGridView_Kitaplari_Listele.DataSource = tablo;
            }

        }

        private void button_CikisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            girisForm Giris = new girisForm();
            Giris.Show();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tumKitaplariGetir()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT K.ID,K.SATICI_ID,S.YAYINEVI_ADI,Y.TAM_AD AS [YAZAR ADI],K.URUN_KODU,K.URUN_ADI,K.FIYAT,K.KATEGORI_1,K.KATEGORI_2,K.URUN_ADEDI,K.SAYFA_SAYISI,K.DIL" +
                " FROM tbl_Kitaplar K JOIN tbl_Saticilar S ON S.ID = K.SATICI_ID JOIN tbl_Yazarlar Y ON Y.ID = K.YAZAR_ID " +
                "ORDER BY K.SATICI_ID";

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dataGridView_Kitaplari_Listele.DataSource = tablo;
        }


        private void button_Sil_Click(object sender, EventArgs e)
        {
            if(radioButton_KitapSil.Checked)
            {
                if(textBox_ID.Text != string.Empty)
                {
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "UPDATE tbl_Kitaplar SET DURUM = 0 WHERE ID = @k1";
                    komut.Parameters.AddWithValue("@k1", textBox_ID.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kitap basariyla silindir");
                    textBox_ID.Text = "";
                    tumKitaplariGetir();
                }
                else
                {
                    MessageBox.Show("ID alani bos birakilamaz");
                }
            }
            else if (radioButton_KullaniciSil.Checked)
            {
                if(textBox_ID.Text != string.Empty)
                {
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "UPDATE tbl_Kullanicilar SET KULLANICI_TIPI = 'D' WHERE ID = @k1";
                    komut.Parameters.AddWithValue("@k1", textBox_ID.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kullanici basariyla silindir");
                    textBox_ID.Text = "";
                }
                else
                {
                    MessageBox.Show("ID alani bos birakilamaz");
                }
            }
        }

       
    }
}
