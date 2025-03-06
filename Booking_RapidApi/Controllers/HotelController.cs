using Booking_RapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Booking_RapidApi.Controllers
{
    public class HotelController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SimpleHotelSearchResultViewModel simpleHotel)
        {

            var client = new HttpClient();
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
                

            }

            var hotelRequest = new HttpRequestMessage
           
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={simpleHotel.destId}&search_type=CITY&arrival_date={simpleHotel.ArrivalDate}&departure_date={simpleHotel.DepartureDate}&adults={simpleHotel.AdultCount}&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code={simpleHotel.Currency}"),
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
                Console.WriteLine(hotelBody);
                var hotelValues = JsonConvert.DeserializeObject<SearchHotelViewModel.Rootobject>(hotelBody);

                return View(hotelValues);
            }


        }


    }
}
