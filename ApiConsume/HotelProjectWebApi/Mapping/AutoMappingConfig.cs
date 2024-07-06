using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProjectWebApi.Mapping
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<RoomAddDto,Room>().ReverseMap();

            CreateMap<UpdateRoomDto,Room>().ReverseMap();
        }
    }
}
