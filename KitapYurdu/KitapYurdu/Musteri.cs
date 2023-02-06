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
    public partial class musteriForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=KitapYurdu;Integrated Security=True");


        public musteriForm()
        {
            InitializeComponent();
            this.Text = "Müşreti Modu";


            dataGridView_Sepet.ColumnCount = 8;
            dataGridView_Sepet.Columns[0].HeaderText = "Kitap Adi";
            dataGridView_Sepet.Columns[1].HeaderText = "Yazar Adi";
            dataGridView_Sepet.Columns[2].HeaderText = "Fiyat";
            dataGridView_Sepet.Columns[3].HeaderText = "Sayfa Sayısı";
            dataGridView_Sepet.Columns[4].HeaderText = "Dil";
            dataGridView_Sepet.Columns[5].HeaderText = "Satıcı ID:";
            dataGridView_Sepet.Columns[6].HeaderText = "Urun Kodu:";
            dataGridView_Sepet.Columns[7].HeaderText = "ID: ";


            dataGridView_Sepet.Columns[5].Visible = false;
            dataGridView_Sepet.Columns[6].Visible = false;
            dataGridView_Sepet.Columns[7].Visible = false;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapYurduDataSet.tbl_Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KitaplarTableAdapter.Fill(this.kitapYurduDataSet.tbl_Kitaplar);
            tumunuGetir();
            AdresleriGetir();
        }

        private void button_kitap_ara_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "sp_kitapAra @k1";
            komut.Parameters.AddWithValue("@k1", textBox_kitap_Adi.Text);
            

            baglanti.Open();
            da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button_Yazar_Ara_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "sp_yazarAra @k1";
            komut.Parameters.AddWithValue("@k1", textBox_kitap_Adi.Text);
            
            

            baglanti.Open();
            da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button_Kategori_Ara_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "sp_kategoriAra @k1";
            komut.Parameters.AddWithValue("@k1", textBox_kitap_Adi.Text);

            baglanti.Open();
            da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button_TumunuGetir_Click(object sender, EventArgs e)
        {
            tumunuGetir();
        }


        private void tumunuGetir()
        {
            SqlDataAdapter da;
            baglanti.Open();
            //da = new SqlDataAdapter("select URUN_ADI,Y.TAM_AD,FIYAT,KATEGORI_1,KATEGORI_2,URUN_ADEDI,SAYFA_SAYISI,DIL,SATICI_ID,URUN_KODU,K.ID " +
            //    "from tbl_Kitaplar K inner join tbl_Yazarlar Y ON Y.ID = K.YAZAR_ID WHERE URUN_ADEDI > 0", baglanti);
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "sp_tumKitaplariGetir";

            DataTable tablo = new DataTable();
            da = new SqlDataAdapter(komut);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();

            dataGridView1.Columns[0].HeaderText = "Kitap Adi";
            dataGridView1.Columns[1].HeaderText = "Yazar Adi";
            dataGridView1.Columns[2].HeaderText = "Fiyat";
            dataGridView1.Columns[3].HeaderText = "Kategori 1";
            dataGridView1.Columns[4].HeaderText = "Kategori 2";
            dataGridView1.Columns[5].HeaderText = "Urun Adeti";
            dataGridView1.Columns[6].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[7].HeaderText = "Dil";
            dataGridView1.Columns[8].HeaderText = "Satıcı ID:";
            dataGridView1.Columns[9].HeaderText = "Urun Kodu:";
            dataGridView1.Columns[10].HeaderText = "ID:";

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;


            textBox_kitap_Adi.Text = "";
        }

        private void button_Sepete_Ekle_Click(object sender, EventArgs e)
        {
            

            int secilenHucre = dataGridView1.SelectedCells[0].RowIndex;



            dataGridView_Sepet.Rows.Add(dataGridView1.Rows[secilenHucre].Cells[0].Value.ToString(),
                dataGridView1.Rows[secilenHucre].Cells[1].Value.ToString(),
                dataGridView1.Rows[secilenHucre].Cells[2].Value.ToString(),
                dataGridView1.Rows[secilenHucre].Cells[6].Value.ToString(),
                dataGridView1.Rows[secilenHucre].Cells[7].Value.ToString(),
                dataGridView1.Rows[secilenHucre].Cells[8].Value.ToString(),
                dataGridView1.Rows[secilenHucre].Cells[9].Value.ToString(),
                dataGridView1.Rows[secilenHucre].Cells[10].Value.ToString());



        }

        private void button_Sepetten_Cikar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Sepet.SelectedRows)
            {
                dataGridView_Sepet.Rows.RemoveAt(row.Index);
            }
        }

        private void button_Gecmis_Siparisler_Click(object sender, EventArgs e)
        {
            SiparisDetaylari f3 = new SiparisDetaylari(Convert.ToInt32(label_Kullanıcı_ID.Text));
            f3.ShowDialog();
        }

        private void button_Sepet_Onay_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;


            baglanti.Open();


            komut.CommandText = "SELECT TOP 1 SIPARIS_KODU FROM tbl_Siparisler order by ID DESC";
            object isNull = komut.ExecuteScalar();
            komut.Parameters.Clear();

            string secilen = comboBox_Adresler.Text;

            baglanti.Close();

            if(secilen != "")
            {
                baglanti.Open();
                komut.CommandText = "SELECT ID FROM tbl_Adress WHERE ADRES_BASLIGI = @k1";
                komut.Parameters.AddWithValue("@k1", secilen);
                object adresID = komut.ExecuteScalar();


                int siparisKodu = 0;

                if (isNull == null)
                {
                    siparisKodu = 1;
                }
                else
                {
                    siparisKodu = Convert.ToInt32(isNull.ToString());
                    siparisKodu++;
                }

                komut.Parameters.Clear();
                int sayac = 0;

                if (dataGridView_Sepet.RowCount != 0)
                {
                    foreach (DataGridViewRow row in dataGridView_Sepet.Rows)
                    {

                        komut.Parameters.Clear();
                        komut.CommandText = "SELECT URUN_ADEDI FROM tbl_Kitaplar WHERE ID = @k1";
                        komut.Parameters.AddWithValue("@k1", row.Cells[7].Value);
                        object kitapSayisi = komut.ExecuteScalar();


                        if (Convert.ToInt32(kitapSayisi.ToString()) > 0)
                        {
                            komut.CommandText = "INSERT INTO tbl_Siparisler(KULLANICI_ID,ITEM_ID,ADDRESS_ID,SATICI_ID,URUN_KODU,SIPARIS_KODU,TARIH,TOPLAM_FIYAT,DURUM,ADET)" +
                                "VALUES (@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10)";

                            komut.Parameters.Clear();
                            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Kullanıcı_ID.Text));
                            komut.Parameters.AddWithValue("@k2", row.Cells[7].Value);
                            komut.Parameters.AddWithValue("@k3", Convert.ToInt32(adresID.ToString()));
                            komut.Parameters.AddWithValue("@k4", row.Cells[5].Value);
                            komut.Parameters.AddWithValue("@k5", row.Cells[6].Value);
                            komut.Parameters.AddWithValue("@k6", siparisKodu);
                            komut.Parameters.AddWithValue("@k7", DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
                            komut.Parameters.AddWithValue("@k8", row.Cells[2].Value);
                            komut.Parameters.AddWithValue("@k9", 1);
                            komut.Parameters.AddWithValue("@k10", 1);
                            komut.ExecuteNonQuery();
                        }

                        else
                        {
                            MessageBox.Show(row.Cells[0].Value.ToString() + " adli Kitap STOK yetersizliği yüzünden sipariş alınmadı");
                        }


                    }
                    dataGridView_Sepet.Rows.Clear();
                    MessageBox.Show("Siparişiniz Alındı.");

                    baglanti.Close();
                    tumunuGetir(); //Güncel kitap stok durumunu görmek için tekrardan datagrid'i dolduruyoruz
                }
                else
                {
                    MessageBox.Show("Sepetiniz Boş.");
                }
                
            }

            else
            {
                MessageBox.Show("Adres Bilgisi Seçmeniz Gerek");
            }

            
           
            
            //tumunuGetir(); //Güncel kitap stok durumunu görmek için tekrardan datagrid'i dolduruyoruz
        }

        private void button_Hesap_Ayarlari_Click(object sender, EventArgs e)
        {
            hesapAyarlari h1 = new hesapAyarlari();
            h1.label_Kullanıcı_ID.Text = label_Kullanıcı_ID.Text;
            h1.ShowDialog();
        }


        public void AdresleriGetir()
        {
            comboBox_Adresler.Items.Clear();

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

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            AdresleriGetir();
        }

        private void button_CikisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            girisForm Giris = new girisForm();
            Giris.Show();
        }

        private void musteriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
