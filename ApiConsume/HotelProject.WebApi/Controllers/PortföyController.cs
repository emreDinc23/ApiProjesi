using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortföyController : ControllerBase
    {
        private readonly IPortföyService _portföyService;

        public PortföyController(IPortföyService portföyService)
        {
            _portföyService = portföyService;
        }
        [HttpGet]
        public IActionResult PortföyList()
        {
            var values = _portföyService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddPortföy(Portföy portföy)
        {
            _portföyService.TInsert(portföy);


            return Ok();
        }
        [HttpDelete]
        public IActionResult DeletePortföy(int id)
        {
            var values = _portföyService.TGetByID(id);
            _portföyService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdatePortföy(Portföy portföy)
        {
            _portföyService.TUpdate(portföy);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetPortföy(int id)
        {
            var values = _portföyService.TGetByID(id);

            return Ok(values);
        }
    }
}
