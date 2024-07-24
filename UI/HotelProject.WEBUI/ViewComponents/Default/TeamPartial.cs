using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.ViewComponents.Default
{
    public class TeamPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
