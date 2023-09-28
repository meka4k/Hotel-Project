using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class ResultServiceDto
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string ServiceIcon { get; set; }
        public string Description { get; set; }
    }
}
