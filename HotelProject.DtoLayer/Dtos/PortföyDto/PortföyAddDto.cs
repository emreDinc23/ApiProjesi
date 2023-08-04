using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.PortföyDto
{
   public class PortföyAddDto
    {
       [Required(ErrorMessage = "Lütfen portföy numarası yazınız.")]
        public string PortföyNumber { get; set; }
        public string PortföyCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat numarası yazınız.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen portföy başlığı giriniz yazınız.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen oda sayısını yazınız.")]
        public string RoomCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısını yazınız.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
