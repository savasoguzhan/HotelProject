using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.ViewComponents.Default
{
    public class TestimonialPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
