using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {


        private readonly IRoomService _roomService;

        public RoomController(IRoomService RoomService)
        {
            _roomService = RoomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetAll();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _roomService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            _roomService.TInsert(Room);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            _roomService.TUpdate(Room);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetById(id);
            _roomService.TDelete(values);
            return Ok();
        }
    }
}
