# 🚀 Wintask Scheduler X

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)

**Wintask Scheduler X**, hantal ve karmaşık olan orijinal Windows Görev Zamanlayıcı'ya (Task Scheduler) alternatif olarak geliştirilmiş, çok daha basit, şık ve kullanıcı dostu bir arayüze sahip görev yönetim aracıdır.

Sürekli tekrarlanan `schtasks.exe` komut satırı eziyetine son vermek ve görevleri birkaç tıkla, görsel geri bildirimlerle oluşturmak için tasarlanmıştır.

## ✨ Özellikler

* **🎨 Görsel Doğrulama:** Dosya yolu, görev adı ve açıklama gibi alanlar doldurulduğunda anlık renkli geri bildirim (Kırmızı/Yeşil/Sarı) veren reaktif arayüz.
* **🛡️ Tam Yetki Kontrolü:** Görevleri sorunsuz ekleyebilmek için otomatik UAC (Yönetici) izni talebi ve "En Yüksek Ayrıcalıklarla Çalıştır" seçeneği.
* **⚙️ Gelişmiş Tetikleyici ve Koşullar:**
    * Belirli bir gecikme (dakika) ile bilgisayar başlatıldığında tetiklenme.
    * Bilgisayarın boşta kalma süresine (dakika) göre tetiklenme.
    * Ağ bağlantısı zorunluluğu koşulu.
* **👻 Gizli Mod:** Görevlerin arka planda görünmez olarak çalıştırılabilmesi.
* **🧠 Akıllı Üzerine Yazma:** Aynı isimde bir görev zaten varsa, kullanıcıyı uyararak güvenli bir şekilde üzerine yazma veya işlemi iptal etme seçeneği.
* **🔋 Optimize Edilmiş Arka Plan Ayarları:** Pilde çalışırken durma veya boşta kalma bitince görevi sonlandırma gibi can sıkıcı varsayılan Windows kısıtlamaları arka planda otomatik olarak devre dışı bırakılır.

## 📸 Ekran Görüntüleri

<img width="504" height="381" alt="Ekran görüntüsü 2026-06-06 200818" src="https://github.com/user-attachments/assets/271f63d8-488f-4bb5-b442-06765f73ddf0" />

## 📥 Kurulum ve Kullanım

Kodu derlemekle uğraşmak istemiyorsanız, doğrudan çalıştırılabilir sürümü indirebilirsiniz:

1.  Sağ taraftaki **[Releases](#)** bölümüne gidin.
2.  En son sürüm olan `.zip` dosyasını indirin.
3.  Arşivi bir klasöre çıkartın.
4.  `wintask_scheduler_X.exe` dosyasını çalıştırın (Program, görevleri Windows'a kaydedebilmek için yönetici yetkisi isteyecektir).

## 🛠️ Geliştiriciler İçin (Kaynak Koddan Derleme)

Projeyi kendi bilgisayarınızda geliştirmek veya incelemek isterseniz:

1. Repoyu klonlayın:
   ```bash
   git clone [https://github.com/KULLANICI_ADIN/wintask_scheduler_X.git](https://github.com/KULLANICI_ADIN/wintask_scheduler_X.git)

    Projeyi Visual Studio (2022 veya daha yeni) ile açın.

    NuGet paketlerini geri yükleyin. Proje, Görev Zamanlayıcı işlemleri için TaskScheduler (David Hall) kütüphanesini kullanmaktadır.

    Configuration modunu Release veya Debug olarak ayarlayıp F5 ile çalıştırın.

📝 Bağımlılıklar

    .NET Desktop Runtime

    TaskScheduler Yönetilen Kütüphanesi

🤝 Katkıda Bulunma

Fork'layıp Pull Request göndermekten çekinmeyin! Yeni özellik fikirleri veya hata bildirimleri için Issues kısmını kullanabilirsiniz.
