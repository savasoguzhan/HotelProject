using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.ViewComponents.Default
{
    public class NewsletterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
