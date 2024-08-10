using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WEBUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLAyout()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult PreLoader()
        {
            return PartialView();
        }

        public PartialViewResult NavHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

       

        public PartialViewResult SideBarPartial()
        {
            return PartialView();
        }
    }
}
