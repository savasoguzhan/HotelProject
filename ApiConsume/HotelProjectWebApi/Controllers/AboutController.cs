using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutUsService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(AboutUs aboutUs)
        {
            _aboutUsService.TInsert(aboutUs);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            
            _aboutUsService.TDelete(_aboutUsService.TGetById(id));
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(AboutUs aboutUs)
        {
            _aboutUsService.TUpdate(aboutUs);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            return Ok(_aboutUsService.TGetById(id));
        }
    }
}
