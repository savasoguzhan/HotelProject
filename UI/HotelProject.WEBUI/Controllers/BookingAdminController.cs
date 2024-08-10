using HotelProject.WEBUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WEBUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7243/api/Booking");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> AcceptBooking(AcceptBookingDto acceptBookingDto)
        {
            acceptBookingDto.Status = "Accept";
            var client = _httpClientFactory.CreateClient();
            var jsonDate = JsonConvert.SerializeObject(acceptBookingDto);
            StringContent stringContent = new StringContent(jsonDate,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:7243/api/Booking/UpdateBookingStatus", stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return View("Index");
            }
            return View();
            
        }
    }
}
