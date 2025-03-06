namespace Booking_RapidApi.Models
{


    public class SimpleHotelSearchResultViewModel
    {

        public string? destId { get; set; }

        // Destinasyon
        public bool Status { get; set; }
   
        public long Timestamp { get; set; }
        public string city_name { get; set; } // Şehir adı
        public string Country { get; set; }  // Ülke adı

        // Otel bilgileri
        public string? HotelName { get; set; }  // Otel adı
        public float ReviewScore { get; set; }  // Otel değerlendirme puanı
        public float PriceValue { get; set; }   // Fiyat
        public string Currency { get; set; }    // Para birimi
        public string ImageUrl { get; set; }    // Otel görseli

        // Giriş ve çıkış tarihleri
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int AdultCount { get; set; }
    }
    
}



