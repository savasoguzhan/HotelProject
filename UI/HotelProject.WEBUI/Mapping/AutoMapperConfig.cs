using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WEBUI.Dtos.AboutDto;
using HotelProject.WEBUI.Dtos.RegisterDto;
using HotelProject.WEBUI.Dtos.ServiceDtos;

namespace HotelProject.WEBUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, AboutUs>().ReverseMap();
            CreateMap<UpdateAboutDto, AboutUs>().ReverseMap();



        }
    }
}
