using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concreate
{
    public class Portföy
    {
        public int PortföyID { get; set; }
        public string PortföyNumber { get; set; }
        public string PortföyCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string RoomCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
