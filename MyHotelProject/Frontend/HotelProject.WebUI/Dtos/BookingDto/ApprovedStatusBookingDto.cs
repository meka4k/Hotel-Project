using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class ApprovedStatusBookingDto
    {
        public int BookingId { get; set; }
        public string Status { get; set; }
    }
}
