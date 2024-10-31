
## Proje Açıklaması

Bu konsol uygulaması, kullanıcının girdiği bir sayının karesini ve karekökünü hesaplar. Kullanıcıdan alınan sayının geçerli bir formatta olup olmadığını kontrol eder. Hatalı bir giriş durumunda uygun bir hata mesajı gösterir. İşlem tamamlandığında, kullanıcıya işlem tamamlandığını belirten bir mesaj sunar.

## Özellikler

- Kullanıcıdan bir tam sayı girişi alır.
- Girişte hata olması durumunda hata mesajı gösterir.
- Geçerli bir sayı girildiğinde, sayının karesi ve karekökü hesaplanır ve ekrana yazdırılır.
- Her durumda "İşlem tamamlandı." mesajı gösterilir.

## Kullanım

1. Uygulamayı çalıştırın.
2. Konsolda "Lütfen bir sayı giriniz:" mesajını göreceksiniz.
3. Bir tam sayı girin ve Enter tuşuna basın.
4. Uygulama, girilen sayının karesini ve karekökünü hesaplayarak ekrana yazdıracaktır.
5. Eğer geçersiz bir sayı girerseniz, "Hata: Sayı formatı geçersiz. Lütfen doğru formatta bir sayı giriniz." mesajı göreceksiniz.
6. Son olarak, "İşlem tamamlandı." mesajı her zaman gösterilecektir.

## Örnek Girdi ve Çıktılar

- **Geçerli Girdi:**
  - Girdi: `4`
  - Çıktı:
    ```
    Girdiginiz sayinin karesi:16
    Girdiginiz sayinin karekoku:2
    İşlem tamamlandı.
    ```

- **Geçersiz Girdi:**
  - Girdi: `abc`
  - Çıktı:
    ```
    Hata: Sayı formatı geçersiz. Lütfen doğru formatta bir sayı giriniz.
    İşlem tamamlandı.
    ```

## Gereksinimler

- .NET Framework veya .NET Core yüklü bir ortam.
- Konsol uygulaması çalıştırmak için uygun bir IDE veya terminal.

## Geliştirici Notları

- Hatalı girişleri daha iyi yönetmek için hata ayıklama ve kullanıcı deneyimini geliştirmek adına ek kontroller eklenebilir.
- Daha fazla matematiksel işlem veya özellik eklemek istenirse, mevcut yapıya kolayca entegre edilebilir.

Bu uygulamayı kullanarak sayılarla ilgili basit matematiksel işlemleri gerçekleştirebilirsiniz!
