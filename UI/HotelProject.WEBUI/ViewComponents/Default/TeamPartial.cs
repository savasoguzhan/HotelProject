using HotelProject.WEBUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WEBUI.ViewComponents.Default
{
    public class TeamPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TeamPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var cleint = _httpClientFactory.CreateClient();
            var responseMessage = await cleint.GetAsync("https://localhost:7243/api/Staff");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
