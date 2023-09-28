using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class AddServiceDto
    {
        [Required(ErrorMessage ="Hizmet başlığı giriniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet ikonunu giriniz.")]
        [StringLength(100,ErrorMessage ="Maksimum 100 karakterden oluşabilir.")]
        public string ServiceIcon { get; set; }
        public string Description { get; set; }
    }
}
