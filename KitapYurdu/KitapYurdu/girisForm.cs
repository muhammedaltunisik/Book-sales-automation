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
    public partial class girisForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=KitapYurdu;Integrated Security=True");  

        public girisForm()
        {
            InitializeComponent();
            Init_data();
        }


        private void Init_data()
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                if(Properties.Settings.Default.Remember==true)
                {
                    textBox_Giris_KullaniciAdi.Text = Properties.Settings.Default.UserName;
                    textBox_Giris_Sifre.Text = Properties.Settings.Default.Password;
                    checkBox_BeniHatirla.Checked = true;
                    if (Properties.Settings.Default.Remember2 == true)
                        checkBox_Yayınevi_Giris.Checked = true;
                }
                
            }
        }


        private void button_Kayıt_Ol_Click(object sender, EventArgs e)
        {
    
            

            if(textBox_Ad_Soyad.Text == "" || textBox_KullaniciAdi.Text == "" || textBox_Mail.Text == "" || textBox_Sifre.Text == "" ||
                textBox_Ad_Soyad.Text == string.Empty || textBox_KullaniciAdi.Text == string.Empty || textBox_Mail.Text == string.Empty || textBox_Sifre.Text == string.Empty)
            {
                textBox_Ad_Soyad.BackColor = Color.Yellow;
                textBox_KullaniciAdi.BackColor = Color.Yellow;
                textBox_Mail.BackColor = Color.Yellow; 
                textBox_Sifre.BackColor = Color.Yellow;

                MessageBox.Show("Sari Alanlar Bos Gecilemez");
            }

            else
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select KULLANICI_ADI from tbl_Kullanicilar where KULLANICI_ADI = @k1";
                komut.Parameters.AddWithValue("@k1", textBox_KullaniciAdi.Text);
                baglanti.Open();
                object Adi = komut.ExecuteScalar();

                if (Adi == null)
                {
                    komut = new SqlCommand("insert into tbl_Kullanicilar(KULLANICI_ADI,SIFRE,TAM_AD,MAIL,CINSIYET,KULLANICI_TIPI) " +
                    "values(@k1,@k2,@k3,@k4,@k5,@k6)", baglanti);
                    komut.Parameters.AddWithValue("@k1", textBox_KullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@k2", SHA256Hash(textBox_Sifre.Text));
                    komut.Parameters.AddWithValue("@k3", textBox_Ad_Soyad.Text);
                    komut.Parameters.AddWithValue("@k4", textBox_Mail.Text);
                    komut.Parameters.AddWithValue("@k5", comboBox_Cinsiyet.Text);
                    komut.Parameters.AddWithValue("@k6", 'M');
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayit Eklendi");

                    textBox_KullaniciAdi.Clear();
                    textBox_Sifre.Clear();
                    textBox_Mail.Clear();
                    textBox_Ad_Soyad.Clear();
                    comboBox_Cinsiyet.Text = "";
                }
                else
                {
                    MessageBox.Show("Boyle bir kullanici adi var");
                    baglanti.Close();
                }
            }
            

            
        }

        private void button_Giris_Yap_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            if(checkBox_BeniHatirla.Checked)
            {
                Properties.Settings.Default.UserName = textBox_Giris_KullaniciAdi.Text;
                Properties.Settings.Default.Password = textBox_Giris_Sifre.Text;
                Properties.Settings.Default.Remember = true;
                if(checkBox_Yayınevi_Giris.Checked)
                {
                    Properties.Settings.Default.Remember2 = true;
                }
                else
                {
                    Properties.Settings.Default.Remember2 = false;
                }
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }


            if (checkBox_Yayınevi_Giris.Checked)
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;

                komut.CommandText = "select KULLANICI_ADI from tbl_Saticilar where KULLANICI_ADI = @k1";
                komut.Parameters.AddWithValue("@k1", textBox_Giris_KullaniciAdi.Text);
                object kullaniciAdi = komut.ExecuteScalar();

                komut.CommandText = "select SIFRE from tbl_Saticilar where KULLANICI_ADI = @k1";
                object kullaniciSifresi = komut.ExecuteScalar();

                komut.CommandText = "select ID from tbl_Saticilar where KULLANICI_ADI = @k1";
                object kullaniciID = komut.ExecuteScalar();

                if (kullaniciAdi == null || kullaniciSifresi == null)
                {
                    MessageBox.Show("Kullanici adi ya da şifre hatalı.");
                }
                else if (SHA256Hash(textBox_Giris_Sifre.Text) == (kullaniciSifresi.ToString().ToUpper()) && textBox_Giris_KullaniciAdi.Text == kullaniciAdi.ToString())
                {
                    Yayınevi E1 = new Yayınevi(Convert.ToInt32(kullaniciID.ToString()));
                    this.Hide();
                    E1.Show();
                }
            }

            else
            {

                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;

                komut.CommandText = "select KULLANICI_ADI from tbl_Kullanicilar where KULLANICI_ADI = @k1";
                komut.Parameters.AddWithValue("@k1", textBox_Giris_KullaniciAdi.Text);
                object kullaniciAdi = komut.ExecuteScalar();


                komut.CommandText = "select SIFRE from tbl_Kullanicilar where KULLANICI_ADI = @k1";
                object kullaniciSifresi = komut.ExecuteScalar();


                komut.CommandText = "select KULLANICI_TIPI from tbl_Kullanicilar where KULLANICI_ADI = @k2";
                komut.Parameters.AddWithValue("@k2", textBox_Giris_KullaniciAdi.Text);
                object kullaniciTipi = komut.ExecuteScalar();

                komut.CommandText = "sp_kullaniciID @k1";
                object kullaniciID = komut.ExecuteScalar();


                if (kullaniciAdi == null || kullaniciSifresi == null)
                {
                    MessageBox.Show("Kullanici adi ya da şifre hatalı.");
                }
                else if(SHA256Hash(textBox_Giris_Sifre.Text) == (kullaniciSifresi.ToString().ToUpper()) && textBox_Giris_KullaniciAdi.Text == kullaniciAdi.ToString())
                {
                    if (kullaniciTipi.ToString() == "M")
                    {
                        this.Hide();
                        musteriForm f2 = new musteriForm();
                        f2.label_Kullanıcı_ID.Text = kullaniciID.ToString();

                        f2.Show();
                    }

                    else if (kullaniciTipi.ToString() == "A")
                    {
                        this.Hide();
                        Admin A1 = new Admin();

                        A1.Show();
                    }
                    
                    else if (kullaniciTipi.ToString() == "D")
                    {
                        MessageBox.Show("Bu hesap engellenmistir.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanici adi ya da şifre hatalı.");
                }
            }

            baglanti.Close();

        }

        private void label_Instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/muhammedaltunisik/");
        }

        private void label_twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com");
        }

        private void label_linkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/muhammed-altun%C4%B1%C5%9F%C4%B1k-582540148/");
        }

        private void label_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/muhammedaltunisik");
        }

        public string SHA256Hash(string text)
        {
            string source = text;
            using (SHA256 sha1Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return (hash);
            }
        }

        private void girisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
