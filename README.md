# PratikPolymorphism Projesi

Bu proje, C# dilinde **polimorfizm** kavramını basit geometrik şekiller üzerinden açıklamaktadır.

## Sınıflar

### BaseGeometrikSekil
- **Uzunluk** ve **Genislik** özelliklerine sahiptir.
- `Alan()` metodu sanal olarak tanımlanmıştır.

### Kare
- `Alan()` metodu, uzunluk ve genişliği çarparak karenin alanını hesaplar.

### Diktortgen
- `Alan()` metodu, uzunluk ve genişliği çarpar, ancak uzunluk ve genişliğin eşit olması gerektiğini kontrol eder.

### Ucgen
- `Alan()` metodu, uzunluk ve genişliğin çarpımını ikiye bölerek üçgenin alanını hesaplar.
