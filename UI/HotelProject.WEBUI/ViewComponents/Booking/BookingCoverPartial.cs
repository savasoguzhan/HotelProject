using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.ViewComponents.Booking
{
    public class BookingCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
