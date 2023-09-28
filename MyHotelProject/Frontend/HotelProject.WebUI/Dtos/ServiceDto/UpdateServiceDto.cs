using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet ikonunu giriniz.")]
        [StringLength(100, ErrorMessage = "Maksimum 100 karakterden oluşabilir.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet açıklamasını giriniz.")]
        [StringLength(100, ErrorMessage = "Maksimum 200 karakterden oluşabilir.")]
        public string Description { get; set; }
    }
}
