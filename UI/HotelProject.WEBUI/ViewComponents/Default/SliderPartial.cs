using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.ViewComponents.Default
{
    public class SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View ();
        }

    }
}
