# 💼 Kasa Hesap Programı

Kasa Hesap Programı, bir kurumun günlük para giriş-çıkış işlemlerini denetlemek, portal/banka kayıtlarıyla fiziki kasa uyumunu kontrol etmek amacıyla hazırlanmış bir ASP.NET Core MVC uygulamasıdır.

---

## 🚀 Özellikler

- Portal ve bankadaki emanet/harç verilerini girerek kasa farkını hesaplar
- Slip ve provizyon gibi verileri de dahil ederek detaylı sonuç sunar
- Sonuç farkı varsa görsel uyarı + toast bildirimi verir
- Eksik/fazla durumlarını renkli kartlarla bildirir
- Bootstrap 5 ile responsive ve modern bir arayüz
- Kod: `C#`, Arayüz: `Razor View`

---

## 🛠️ Kurulum

### 1. Gerekli Araçlar

- Visual Studio 2022 (veya VS Code)
- .NET 6/7 SDK (projenin versiyonuna göre)
- SQL Server (Express veya LocalDB)

### 2. Projeyi Klonlayın

```bash
git clone https://github.com/kullaniciadi/kasa-hesap.git
cd kasa-hesap
