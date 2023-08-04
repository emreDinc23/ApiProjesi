using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.PortföyDto;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Portföy2Controller : ControllerBase
    {


        private readonly IPortföyService _portföyService;
        private readonly IMapper _mapper;

        public Portföy2Controller(IPortföyService portföyService, IMapper mapper)
        {
            _portföyService = portföyService;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _portföyService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddPortföy(PortföyAddDto portföyAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Portföy>(portföyAddDto);
            _portföyService.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdatePortföy(PortföyUpdateDto portföyUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Portföy>(portföyUpdateDto);
            _portföyService.TUpdate(values);
            return Ok("Başarılı");
        }
    }
    
}
