using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.ViewComponents.Default
{
    public class BookingPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
