using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.PortföyDto
{
   public class PortföyUpdateDto
    {
        public int PortföyID { get; set; }
        [Required(ErrorMessage = "Lütfen portföy numarası yazınız.")]
        public string PortföyNumber { get; set; }
        [Required(ErrorMessage = "Lütfen portföy resmi yazınızz.")]
        public string PortföyCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat numarası yazınız.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen portföy başlığı giriniz yazınız.")]
        [StringLength(100,ErrorMessage = "Lütfen en fazla 100 karakter giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen oda sayısını yazınız.")]
        public string RoomCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısını yazınız.")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Lütfen Wifi numarası yazınız.")]
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama yazınız.")]
        public string Description { get; set; }
    }
}
