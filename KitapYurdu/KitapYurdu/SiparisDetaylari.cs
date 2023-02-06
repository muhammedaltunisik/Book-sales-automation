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
    public partial class SiparisDetaylari : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=KitapYurdu;Integrated Security=True");

        public SiparisDetaylari(int kullaniciID)
        {
            InitializeComponent();
            label_Kullanıcı_ID.Text = kullaniciID.ToString();
            this.Text = "Geçmiş Siparişler";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            tumSiparisleriGetir();
            
        }

        private void button_Geri_Gel_Click(object sender, EventArgs e)
        {
            tumSiparisleriGetir();
        }

        private void tumSiparisleriGetir()
        {
            listView1.Clear();

            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("Sipariş Kodu", 100);
            listView1.Columns.Add("Durumu", 100);
            listView1.Columns.Add("Sipariş Tarihi", 100);
            listView1.Columns.Add("Ürün Adeti", 100);
            listView1.Columns.Add("Fiyat", 100);



            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;

            baglanti.Open();

            
            komut.CommandText = "SELECT SIPARIS_KODU,DURUM,TARIH,SUM(TOPLAM_FIYAT) AS FIYAT,SUM(ADET) AS ADET from tbl_Siparisler WHERE KULLANICI_ID = @k1 GROUP BY SIPARIS_KODU,DURUM,TARIH";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(label_Kullanıcı_ID.Text));
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["SIPARIS_KODU"].ToString());
                item.SubItems.Add(dr["DURUM"].ToString());
                item.SubItems.Add(dr["TARIH"].ToString());
                item.SubItems.Add(dr["ADET"].ToString());
                item.SubItems.Add(dr["FIYAT"].ToString());
                listView1.Items.Add(item);
            }

            baglanti.Close();

        }

        private void button_Sipariş_Detayi_Click(object sender, EventArgs e)
        {
            string items = "0";
            if (listView1.SelectedItems.Count == 1)
            {

                items = listView1.SelectedItems[0].Text;
            }

            listView1.Clear();

            listView1.Columns.Add("Durum", 100);
            listView1.Columns.Add("Ürün Adı", 100);
            listView1.Columns.Add("Ürün Adeti", 100);
            listView1.Columns.Add("Fiyat", 100);
            listView1.Columns.Add("Adres", 100);

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;

            baglanti.Open();


            komut.CommandText = "SELECT ITEM_ID,ADDRESS_ID,DURUM,ADET,TOPLAM_FIYAT from tbl_Siparisler where SIPARIS_KODU = @k1";
            komut.Parameters.AddWithValue("@k1", Convert.ToInt32(items));
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["DURUM"].ToString());
                item.SubItems.Add(dr["ITEM_ID"].ToString());
                item.SubItems.Add(dr["ADET"].ToString());
                item.SubItems.Add(dr["TOPLAM_FIYAT"].ToString());
                item.SubItems.Add(dr["ADDRESS_ID"].ToString());
                listView1.Items.Add(item);
            }

            dr.Close();

            komut.Parameters.Clear();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int kitapSutun = 1;
                int adresSutun = 4;

                komut.CommandText = "SELECT URUN_ADI FROM tbl_Kitaplar WHERE ID = @k1";
                komut.Parameters.AddWithValue("@k1", listView1.Items[i].SubItems[kitapSutun].Text);
                object kitapAdi = komut.ExecuteScalar();
                listView1.Items[i].SubItems[kitapSutun].Text = kitapAdi.ToString();
                kitapSutun++;


                komut.Parameters.Clear();

                komut.CommandText = "SELECT ADDRESSTEXT FROM tbl_Adress WHERE ID = @k1";
                komut.Parameters.AddWithValue("@k1", listView1.Items[i].SubItems[adresSutun].Text);
                object adresText = komut.ExecuteScalar();
                listView1.Items[i].SubItems[adresSutun].Text = adresText.ToString();
                adresSutun++;

                komut.Parameters.Clear();
            }

            baglanti.Close();
        }
    }
}
