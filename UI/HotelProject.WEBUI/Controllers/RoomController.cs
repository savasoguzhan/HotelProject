using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
