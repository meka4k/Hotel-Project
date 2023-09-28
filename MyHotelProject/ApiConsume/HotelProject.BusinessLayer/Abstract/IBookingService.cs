using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangedApproved(Booking booking);
        void TBookingStatusChangedApproved2(int id);
        public int TGetBookingCount();
        List<Booking> TGetLast6BookingList();

        void TBookingStatusChangedApproved3(int id);
        void TBookingStatusChangedCancel(int id);
        void TBookingStatusChangedWait(int id);
    }
}
