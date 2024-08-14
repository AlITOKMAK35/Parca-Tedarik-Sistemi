Proje Açıklaması
Bu proje, bir parça tedarik zincirinin takibi için geliştirilmiş bir Windows Forms uygulamasıdır. Uygulama, birden fazla ürünün fiyatını, adetini ve toplam maliyetlerini hesaplayarak KDV dâhil toplam tutarları kullanıcıya sunar. Aynı zamanda bu verileri SQL Server veritabanına kaydedebilir ve sipariş detaylarını görüntüleyebilirsiniz.

Özellikler

Ürün Girişi: Ürünlerin fiyat ve adet bilgilerini girebilirsiniz.

KDV Hesaplama: Ürünler için KDV hesaplamalarını otomatik olarak gerçekleştirir.

Toplam Tutar Hesaplama: Ürünlerin toplam tutarlarını ve KDV ile genel toplamlarını hesaplar.

Veri Kaydı: Sipariş bilgilerini SQL Server veritabanına kaydeder.

Sipariş Görüntüleme: Sipariş detaylarını kullanıcıya gösterir.

Gereksinimler

.NET Framework 4.8

SQL Server 2019 (veya daha güncel bir sürüm)

Kurulum

Proje Dosyalarını İndirin: Bu projeyi GitHub üzerinden klonlayabilir veya ZIP olarak indirebilirsiniz.

https://github.com/AlITOKMAK35/Parca-Tedarik-Sistemi

SQL Server Kurulumu: Veritabanını oluşturmak için parca.sql dosyasını SQL Server Management Studio (SSMS) kullanarak çalıştırın.

Bağlantı Dizisi: Form1.cs dosyasındaki SqlConnection nesnesinde yer alan bağlantı dizisini kendi SQL Server bilgilerinizle güncelleyin.

SqlConnection baglanti = new SqlConnection("Data Source=YOUR_SERVER_NAME;Initial Catalog=parca;Integrated Security=True");

Uygulamayı Çalıştırın: Visual Studio'da projeyi açarak F5 tuşuna basarak uygulamayı çalıştırabilirsiniz.

Kullanım

Ürün Bilgilerini Girin: Fiyat ve adet bilgilerini girerek Topla ve Gönder butonuna basın.

Sipariş Bilgilerini Girin: Sipariş veren firmanın adı, telefonu, tarihi gibi bilgileri girin ve Verileri Kaydet butonuna basın.

Verileri Kaydedin: Kaydetme işlemi sonrası veritabanında sipariş bilgilerini tutabilirsiniz.

Sipariş Detaylarını Görüntüleyin: Sipariş Detaylarını Göster butonuna tıklayarak siparişin özetini görüntüleyebilirsiniz.

İletişim

Sorularınız veya geri bildirimleriniz için benimle iletişime geçebilirsiniz:

E-posta: alitokmak3535@gmail.com

GitHub: AlITOKMAK35 - https://github.com/AlITOKMAK35 -
