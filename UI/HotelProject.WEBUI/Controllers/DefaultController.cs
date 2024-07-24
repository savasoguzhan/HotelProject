using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
