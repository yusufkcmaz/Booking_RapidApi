Booking.com Hotel Search App
Bu proje, RapidAPI üzerinden Booking.com API'yi kullanarak bir şehirdeki otelleri listelemeye yönelik bir uygulamadır. Kullanıcılar, şehir adı, varış ve dönüş tarihleri, yetişkin sayısı ve para birimi gibi bilgileri girerek otel araması yapabilirler.

Özellikler
Şehir adı girerek otel araması yapın.
Varış ve dönüş tarihlerini belirleyin.
Yetişkin sayısını ve para birimini seçin.
Booking.com'dan en uygun otelleri görüntüleyin.
Kullanılan Teknolojiler
Backend: ASP.NET Core
Frontend: HTML, CSS (Bootstrap)
API: Booking.com API (RapidAPI üzerinden)
JSON: Otel verilerini almak için JSON veri formatı kullanıldı.
Proje Yapısı
HotelController: API ile iletişimi sağlayan ana controller. Şehir adı ve tarih bilgisi gönderildiğinde, API'den otel verisi alır.
Model: SimpleHotelSearchRequestModel kullanıcı girişlerini almak için kullanılır.
View: Kullanıcıya arama sonuçlarını görsel olarak sunar. Otellerin adı, fiyatı, inceleme puanı ve fotoğrafları listelenir.
