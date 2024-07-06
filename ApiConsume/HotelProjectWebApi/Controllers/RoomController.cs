using AutoMapper;
using HotelProject.BussinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {


        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService RoomService, IMapper mapper)
        {
            _roomService = RoomService;
            _mapper = mapper;
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
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomAddDto);
            _roomService.TInsert(values);
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
