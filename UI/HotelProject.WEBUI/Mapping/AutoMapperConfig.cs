using AutoMapper;
using HotelProject.EntityLayer.Concrete;
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

        }
    }
}
