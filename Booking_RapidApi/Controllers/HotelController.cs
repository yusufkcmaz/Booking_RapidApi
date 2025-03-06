using Booking_RapidApi.Models;
using Booking_RapidApi.Models.Booking_RapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Booking_RapidApi.Controllers
{
    public class HotelController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SimpleHotelSearchRequestModel simpleHotel)
        {

            var client = new HttpClient();

            // Destinasyon sorgusunu yapalım
            var destinationRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={simpleHotel.city_name}"),
                Headers =
        {
            { "x-rapidapi-key", "61612a3788msh4b0bdf93637d781p1ab924jsn60c8aa167719" },
            { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
        },
            };

            using (var response = await client.SendAsync(destinationRequest))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<DestinationHotelViewModel.Rootobject>(body);

                // Eğer destinasyon verisi bulunmuşsa, destId'yi al
                if (values?.data != null && values.data.Count() > 0)
                {
                    simpleHotel.destId = values.data.First().dest_id; // Alınan dest_id'yi simpleHotel'e ekliyoruz
                }
                else
                {
                    // Hata mesajı döndür
                    return BadRequest("Destinasyon bulunamadı.");
                }
            }

            // Otel sorgusunu yapalım
            var hotelRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={simpleHotel.destId}&search_type=CITY&arrival_date={simpleHotel.ArrivalDate:yyyy-MM-dd}&departure_date={simpleHotel.DepartureDate:yyyy-MM-dd}&adults={simpleHotel.AdultCount}&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code={simpleHotel.Currency}"),
                Headers =
        {
            { "x-rapidapi-key", "61612a3788msh4b0bdf93637d781p1ab924jsn60c8aa167719" },
            { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
        },
            };

            using (var response = await client.SendAsync(hotelRequest))
            {
                response.EnsureSuccessStatusCode();
                var hotelBody = await response.Content.ReadAsStringAsync();
                var hotelValues = JsonConvert.DeserializeObject<SearchHotelViewModel.Rootobject>(hotelBody);

                // View'a hotelValues gönderiyoruz
                return View(hotelValues);
            }
        }


    }
}
