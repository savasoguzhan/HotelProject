using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
