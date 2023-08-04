using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelProject.DtoLayer.Dtos.PortföyDto;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<PortföyAddDto,Portföy>();
            CreateMap<Portföy,PortföyAddDto>();
           
            CreateMap<PortföyUpdateDto,Portföy>().ReverseMap();
        }
    }
}
