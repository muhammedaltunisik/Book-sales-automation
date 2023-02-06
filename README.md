# Masaüstü Kitap Satış Uygulaması
----------------

Projede Microsoft SQL Server ve C# programlama dilini kullanarak masaüstü kitap satış uygulaması olarak geliştirildi. Uygulama *kullanıcı*, *satıcı* ve *admin* olmak üzere 3 farklı kullanıcı tipinden oluşuyor. 

***Satıcı*** tipinde tanımlanmış hesaplar sisteme kitap ekleme/silme işlemleri ve önceden kayıt ettiği kendine ait kitapları düzenleyebilir. Aynı zamanda stok kontrollü ve kendisine gelen siparişleri görebilir.

***Kullanıcı*** tipinde tanımlanmış hesaplar giriş yapıp sistemde kayıtlı bulunan kitapları *adına*, *kategorisine* veya *satıcısına* göre aratabilir. Bu kitapları alışveriş sepetlerine ekleyebilir ve kayıtlı tutukları adreslerine sipariş verebilir. Aynı zamanda bu hesaplar geçmişte ki siparişlerini kontrol edebilir ve hesap bilgilerini *(ad-soyad,kullanici adı, şifre vb.)* güncelleyebilirler.

***Admin*** tipinde tanımlanmış hesaplar sisteme kayıtlı tüm kullanıcı ve satıcılara ait bilgileri görebilirler. Sisteme yeni satıcı ekleyebilir.Kitap bilgileri silme ve kullanıcıyı engelleme işlemleri yapabilir. Kitap silme ve kullanıcı engelleme ile ilgili geçmiş verileri inceleyebilirler.

-----
#### Projeye Ait Ekran Çıktıları


1. ***Kullanıcı Modu:***
    - **Giriş Ekranı:** Kayıt ol kısmındaki tüm bilgileri girerek kayıt olabilir. Sonrasında sağ tarafta olan giriş yap kısmı ile giriş yapabilir. Eğer ki satıcı giriş yapmak isterse satıcı girişi tikini işaretlemelidir. Veri tabanına kayıtlı kullanıcı tiplerine göre giriş yapıldıktan sonra farklı arayüzler açılmaktadır
    ![Giris Ekranı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/giris.png)
    - **Müşteri Ekranı:** Kullanıcı tipi “M” olan kullanıcılar için müşteri ekranı açılır. Bu ekranda veritabanına kayıtlı olan tüm ürünler sıralanır. Aynı zamanda bu ekrandan sepete ekleme/çıkarma işlemleri, sipariş geçmişi, sipariş onaylama, urun arama, satıcı arama, tüm ürünleri görmeve hesap ayarları yapılır. Adres bilgisini seçtikten sonra sepet, onaylayabiliriz. Siparişi onayladıktan sonra veritabanına kayıtlı trigger sayesinde ürün adeti sipariş oranında azaltılır.  Ürün arama, Satıcı arama ve tüm ürünleri ekrana getirme gibi özellikler veri tabanına kayıtlı spler ile gerçekleştirilir.
    ![Musteri Ekrani](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Musteri_SepeteEkle.png)
    - **Sipariş Geçmişi:** : Seçmiş siparişler butonuna tıklarsak bu ekran açılır. Bu ekranda geçmişe dönük siparişlerimizin durumunu, sipariş kodunu, verildiği tarihi, kaç edet ürün sipariş ettiğimizi ve toplam fiyat bilgisini görürüz. Herhangi bir siparişin üzerine tıklayıp sipariş detaylarını göster dersek  onayladığımız sepetteki ürünlerin adlarını, fiyatlarını sipariş adreslerini, durumlarını sırasıyla görmüş oluruz.
    ![Gecmis Siparis](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Kullanici_GecmisSiparis1.png)
    ![Gecmis Siparis](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Kullanici_GecmisSiparis2.png)
    - **Hesap Ayarları:** Hesap Ayarları butonuna tıklarsak, yeni adres ekleyebiliceğimiz, kayıtlı adresleri silebiliceğimiz veya düzenleyebiliceğimiz bi ekran açılır. Bu ekranın sağ tarafında hesabımızla ilgili bilgileri güncelleyebilir veya şifremizi değiştirebiliriz.
    ![Hesap Ayarları](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Kullanici_Hesapbilgileri1.png)
    ![Hesap Ayarları](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Kullanici_HesapBilgileri2.png)

2. ***Admin Modu:***
Admin penceresine girmek için normal kullanıcı gibi kullanıcı adı ve şifreyi yazmak yeterlidir. Admin modunda sisteme kayıtlı tüm ürün,satıcı ve kullanıcılara ait bilgiler görüntülenebilir aynı zamanda ada göre arama yapabilir, arama yaparken ismi tam yazmasına gerek yok. Kullanıcı ve kitaplara ait bilgileri silebiliriz, silinen bilgiler veri tabanından tamamen silinmezler sadece sorgularda görünmez olurlar aynı zamanda tbl_silinenler_xxx tablolarına eklenirler. Sadece admin penceresinden yeni satıcı ekleyebiliriz. Aynı zamanda admin penceresinden silinmiş olan tüm tablo kayıtlarını görebiliriz. 
![Admin Penceresi](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Admin_Kitaplar1.png)
![Admin Penceresi](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Admin_YayineviEkle.png)
![Admin Penceresi](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Admin_Yayinevleri.png)

3. ***Satıcı Modu:***
Admin tarafından verişmiş kullanıcı adı ve şifre giriş yapıldığında satıcı ekranı açılır. Bu ekranda kendisinin satışa koyduğu ürünleri görebilir. Ürünlerin stok miktarlarını takip edebilir. Yeni ürün ekleyebilir yada eklediği ürün üzerinde düzeltmeler yapabilir. Aynı zamanda satıcıya gelmiş olan siparişlerle ilgili bilgi alıp kendisine ait kitapları silebilir.
![Satıcı Penceresi](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Satici_giris.png)
![Satıcı Penceresi](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Satici_Anasayfa.png)
![Satıcı Penceresi](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Satici_GecmisSiparis.png)
![Satıcı Penceresi](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Satici_KitapDuzenle.png)


--------
#### ER Diyagramı

1. ***tbl_Adress:*** Bu tabloda kullanıcıların ID değerleri ile tbl_Adress tablosuna kayıtlı KULLANICI_ID sütunu ilişkilendirilmiş şekilde kullanıcılara ait adres bilgileri tutulmaktadır. ID sütunu primary keydir. Tablonun içerisinde kullanıcıların açık adreslerini, adres baslıklarını, ülke, şehir, ilçe ve mahalle değerlerini tutulur.
![Adres Diyagramı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Diagram_Adress.PNG)

2. ***tbl_Kitaplar:*** Bu tablo kitaplara ait bilgileri tutmaktadır, aynı zamanda ID sütunu tbl_silinen_kitaplar tablosu ve tbl_Siparisler tablosu ile ilişkilidir. ID sütunu primary keydir. Urunun satıcısı, adı, fiyatı, kategorisi, yazarı ve stok miktarı bu tabloya kaydedilir. 
![Kitap Diyagramı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Diagram_Kitaplar.PNG)

3. ***tbl_Kullanıcılar:*** ID sütunu primary keydir. ID sütunu ile tbl_Siparisler tablosu, tbl_Adress ve tbl_silinen_Kullanicilar tablosu ile ilişkilidir. Kullanıcılara ait kullanıcı adi, kullanıcı şifresi, ad, soyadı, e-posta, cinsiyet ve kullanıcı tipini tutar. Kullanıcı tipi sayesinde paneller arasında geçiş yapabilmeyi sağlar. Kullanici sifresi veri tabanı üzerinde SHA256 algoritmasina sokulduktan sonra cikan hash degerine gore tutulur. 
![Kullanici Diyagramı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Diagram_Kullanicilar.PNG)

4. ***tbl_Saticilar:*** ID sütunu primary keydir. Saticilarla ilgili bilgileri tutar. ID sütunu ile tbl_Urunler ve tbl_Siparisler tablolarıyla ilişkilidir. Ürünlereait kullanıcı adı, şifre ve mağaza adını saklar. 
![Satici Diyagramı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Diagram_Saticilar.PNG)

5. ***tbl_Siparisler:*** Sipariş ilgili verileri tutar, tbl_Kullanici, tbl_Adress, tbl_Urunler, tbl_Saticilar tablolarının ID değerleri ile ilişkilidir. ID sütunu primary keydir. Sipariş numarasını, fiyatı, tarihi vb. önemli bilgileri saklar. 
![Siparis Diyagramı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Diagram_Siparis.PNG)

6. ***tbl_Yazarlar:*** Yazarlara ait ad verileri tutar. ID sütunu primary keydir ve tbl_Kitaplar tablosu ile ilişkilidir. 
![Yazar Diyagramı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Diagram_Yazarlar.PNG)

7. ***tbl_silinen_Kitaplar:*** Silinen kitap verileri tutar. ID sütunu tbl_Kitaplar tablosu ile ilişkilidir. 
![Silinen Kitap Diyagramı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Diagram_Silinen_Kitaplar.PNG)

8. ***tbl_silinen_Kullanicilar:*** Silinen kullanıcı verileri tutar. ID sütunu tbl_kullanicilar tablosu ile ilişkilidir. 
![Silinen Kullanici Diyagramı](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/Diagram_Silinen_Kullanicilar.PNG)


#### Tam diagram gösterimi
![Tam Diagram Gösterimi](https://github.com/muhammedaltunisik/KitapYurdu/blob/master/Screenshots/databaseDiagram.PNG)
