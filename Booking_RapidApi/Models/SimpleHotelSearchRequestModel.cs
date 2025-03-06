namespace Booking_RapidApi.Models
{
    namespace Booking_RapidApi.Models
    {
        public class SimpleHotelSearchRequestModel
        {
            public string? destId { get; set; }   // Destinasyon ID'si
            public string Address { get; set; }    // Adres bilgisi
            public string? city_name { get; set; } // Şehir adı
            public string Country { get; set; }    // Ülke adı

            // Giriş ve çıkış tarihleri
            public DateTime ArrivalDate { get; set; }
            public DateTime DepartureDate { get; set; }

            // Yetişkin sayısı
            public int AdultCount { get; set; }
            public string Currency { get; set; }
        }
    }




}



