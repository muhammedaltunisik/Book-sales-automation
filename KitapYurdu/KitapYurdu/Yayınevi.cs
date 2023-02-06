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
    public partial class Yayınevi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=KitapYurdu;Integrated Security=True");
        int durum = 0;

        public Yayınevi(int saticiID)
        {
            InitializeComponent();
            dataGridView_Kitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            label_Satici_ID.Text = saticiID.ToString();
            TumKitaplariGetir();
            
        }

        private void button_Kitaplari_Getir_Click(object sender, EventArgs e)
        {
            TumKitaplariGetir();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT ID FROM tbl_Yazarlar WHERE TAM_AD = @k1";
            komut.Parameters.AddWithValue("@k1", textBox_Yazar_Adi.Text);
            baglanti.Open();
            object yazarID = komut.ExecuteScalar();
            baglanti.Close();

            if(yazarID != null)
            {
                komut.Parameters.Clear();
                komut.CommandText = "INSERT INTO tbl_Kitaplar(SATICI_ID,YAZAR_ID,URUN_KODU,URUN_ADI,FIYAT,KATEGORI_1,KATEGORI_2,URUN_ADEDI,SAYFA_SAYISI,DIL) " +
                "VALUES(@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10)";
                komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Satici_ID.Text));
                komut.Parameters.AddWithValue("@k2", yazarID.ToString());
                komut.Parameters.AddWithValue("@k3", textBox_Kitap_Kodu.Text);
                komut.Parameters.AddWithValue("@k4", textBox_Kitap_Adi.Text);
                komut.Parameters.AddWithValue("@k5", Convert.ToDouble(textBox_Fiyat.Text));
                komut.Parameters.AddWithValue("@k6", textBox_Kategori1.Text);
                komut.Parameters.AddWithValue("@k7", textBox_Kategori2.Text);
                komut.Parameters.AddWithValue("@k8", Convert.ToInt32(textBox_Adet.Text));
                komut.Parameters.AddWithValue("@k9", Convert.ToInt32(textBox_Sayfa_Sayisi.Text));
                komut.Parameters.AddWithValue("@k10", textBox_Dili.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap Başarıyla Eklendi");
            }
            else
            {
                baglanti.Open();
                komut.Parameters.Clear();
                komut.CommandText = "INSERT INTO tbl_Yazarlar(TAM_AD) VALUES(@k1)";
                komut.Parameters.AddWithValue("@k1", textBox_Yazar_Adi.Text);
                komut.ExecuteNonQuery();

                komut.CommandText = "SELECT ID FROM tbl_Yazarlar WHERE TAM_AD = @k1";
                object yazarID2 = komut.ExecuteScalar();
                


                komut.Parameters.Clear();
                komut.CommandText = "INSERT INTO tbl_Kitaplar(SATICI_ID,YAZAR_ID,URUN_KODU,URUN_ADI,FIYAT,KATEGORI_1,KATEGORI_2,URUN_ADEDI,SAYFA_SAYISI,DIL) " +
                "VALUES(@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10)";
                komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Satici_ID.Text));
                komut.Parameters.AddWithValue("@k2", yazarID2.ToString());
                komut.Parameters.AddWithValue("@k3", textBox_Kitap_Kodu.Text);
                komut.Parameters.AddWithValue("@k4", textBox_Kitap_Adi.Text);
                komut.Parameters.AddWithValue("@k5", Convert.ToDouble(textBox_Fiyat.Text));
                komut.Parameters.AddWithValue("@k6", textBox_Kategori1.Text);
                komut.Parameters.AddWithValue("@k7", textBox_Kategori2.Text);
                komut.Parameters.AddWithValue("@k8", Convert.ToInt32(textBox_Adet.Text));
                komut.Parameters.AddWithValue("@k9", Convert.ToInt32(textBox_Sayfa_Sayisi.Text));
                komut.Parameters.AddWithValue("@k10", textBox_Dili.Text);

                
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap Başarıyla Eklendi");

            }
            TumKitaplariGetir();
        }

        private void dataGridView_Kitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (durum != 1)
            {
                int secilenHucre = dataGridView_Kitaplar.SelectedCells[0].RowIndex;

                textBox_Yazar_Adi2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[1].Value.ToString();
                textBox_Kitap_Kodu2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[2].Value.ToString();
                textBox_Kitap_Adi2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[3].Value.ToString();
                textBox_Fiyat2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[4].Value.ToString();
                textBox_Kategori1_2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[5].Value.ToString();
                textBox_Kategori2_2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[6].Value.ToString();
                textBox_Adet_2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[7].Value.ToString();
                textBox_Sayfa_Sayisi_2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[8].Value.ToString();
                textBox_Dili_2.Text = dataGridView_Kitaplar.Rows[secilenHucre].Cells[9].Value.ToString();
            }
            else { }
            
           
        }

        private void button_Duzenle_Click(object sender, EventArgs e)
        {
            int secilenHucre = dataGridView_Kitaplar.SelectedCells[0].RowIndex;

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;

            komut.CommandText = "SELECT ID FROM tbl_Yazarlar WHERE TAM_AD = @k1";
            komut.Parameters.AddWithValue("@k1", textBox_Yazar_Adi2.Text);
            baglanti.Open();
            object yazarID = komut.ExecuteScalar();
            baglanti.Close();

            komut.Parameters.Clear();
            if (yazarID != null)
            {
                
                komut.CommandText = "UPDATE tbl_Kitaplar SET SATICI_ID = @k1," +
                "YAZAR_ID = @k2," +
                "URUN_KODU = @k3," +
                "URUN_ADI = @k4," +
                "FIYAT = @k5," +
                "KATEGORI_1 = @k6," +
                "KATEGORI_2 = @k7," +
                "URUN_ADEDI = @k8," +
                "SAYFA_SAYISI = @k9," +
                "DIL = @k10 WHERE ID = @k11";
                komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Satici_ID.Text));
                komut.Parameters.AddWithValue("@k2", yazarID.ToString());
                komut.Parameters.AddWithValue("@k3", textBox_Kitap_Kodu2.Text);
                komut.Parameters.AddWithValue("@k4", textBox_Kitap_Adi2.Text);
                komut.Parameters.AddWithValue("@k5", Convert.ToDouble(textBox_Fiyat2.Text));
                komut.Parameters.AddWithValue("@k6", textBox_Kategori1_2.Text);
                komut.Parameters.AddWithValue("@k7", textBox_Kategori2_2.Text);
                komut.Parameters.AddWithValue("@k8", Convert.ToInt32(textBox_Adet_2.Text));
                komut.Parameters.AddWithValue("@k9", Convert.ToInt32(textBox_Sayfa_Sayisi_2.Text));
                komut.Parameters.AddWithValue("@k10", textBox_Dili_2.Text);
                komut.Parameters.AddWithValue("@k11", Convert.ToInt32(dataGridView_Kitaplar.Rows[secilenHucre].Cells[0].Value.ToString()));


                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap Başarıyla Güncellendi");
            }
            else
            {
                baglanti.Open();
                komut.CommandText = "INSERT INTO tbl_Yazarlar(TAM_AD) VALUES(@k1)";
                komut.Parameters.AddWithValue("@k1", textBox_Yazar_Adi2.Text);
                komut.ExecuteNonQuery();

                komut.CommandText = "SELECT ID FROM tbl_Yazarlar WHERE TAM_AD = @k1";
                object yazarID2 = komut.ExecuteScalar();


                komut.Parameters.Clear();
                komut.CommandText = "UPDATE tbl_Kitaplar SET SATICI_ID = @k1," +
                "YAZAR_ID = @k2," +
                "URUN_KODU = @k3," +
                "URUN_ADI = @k4," +
                "FIYAT = @k5," +
                "KATEGORI_1 = @k6," +
                "KATEGORI_2 = @k7," +
                "URUN_ADEDI = @k8," +
                "SAYFA_SAYISI = @k9," +
                "DIL = @k10 WHERE ID = @k11";
                komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Satici_ID.Text));
                komut.Parameters.AddWithValue("@k2", yazarID2.ToString());
                komut.Parameters.AddWithValue("@k3", textBox_Kitap_Kodu2.Text);
                komut.Parameters.AddWithValue("@k4", textBox_Kitap_Adi2.Text);
                komut.Parameters.AddWithValue("@k5", Convert.ToDouble(textBox_Fiyat2.Text));
                komut.Parameters.AddWithValue("@k6", textBox_Kategori1_2.Text);
                komut.Parameters.AddWithValue("@k7", textBox_Kategori2_2.Text);
                komut.Parameters.AddWithValue("@k8", Convert.ToInt32(textBox_Adet_2.Text));
                komut.Parameters.AddWithValue("@k9", Convert.ToInt32(textBox_Sayfa_Sayisi_2.Text));
                komut.Parameters.AddWithValue("@k10", textBox_Dili_2.Text);
                komut.Parameters.AddWithValue("@k11", Convert.ToInt32(dataGridView_Kitaplar.Rows[secilenHucre].Cells[0].Value.ToString()));

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap Başarıyla Güncellendi");
            }
            TumKitaplariGetir();
        }

        private void button_Stok_Miktari_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "sp_KitaplariGetir @k1, @k2";

            if(textBox_Stok.Text == "")
            {
                //textBox_Stok.Text = "5";
            }
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(textBox_Stok.Text));
            komut.Parameters.AddWithValue("@k2", Convert.ToInt32(label_Satici_ID.Text));

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dataGridView_Kitaplar.DataSource = tablo;
        }

        private void TumKitaplariGetir()
        {
            durum = 0;
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "sp_KitaplariGetir 1000000, @k1";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Satici_ID.Text));

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dataGridView_Kitaplar.DataSource = tablo;
        }

        private void button_Kitap_Sil_Click(object sender, EventArgs e)
        {

            if(textBox_kitapID.Text != string.Empty)
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE tbl_Kitaplar SET DURUM = 0 WHERE ID = @k1";
                komut.Parameters.AddWithValue("@k1", textBox_kitapID.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap basariyla silindir");
                TumKitaplariGetir();
                textBox_kitapID.Text = "";
            }
            else
            {
                MessageBox.Show("Kitap ID giriniz.");
            }
        }

        private void button_CikisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            girisForm Giris = new girisForm();
            Giris.Show();
        }

        private void Yayınevi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_Siparis_Gecmisi_Click(object sender, EventArgs e)
        {
            durum = 1;
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT KULLANICI_ID as [KULLANICI ID], ITEM_ID AS [ITEM ID],ADDRESS_ID AS [ADDRESS ID]," +
                " URUN_KODU AS [URUN KODU],SIPARIS_KODU AS [SIPARIS KODU], TARIH, TOPLAM_FIYAT AS [TOPLAM FIYAT],DURUM, ADET " +
                "from tbl_Siparisler WHERE SATICI_ID =  @k1";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Satici_ID.Text));

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dataGridView_Kitaplar.DataSource = tablo;
        }
    }
}
