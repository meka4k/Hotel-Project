using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        void BookingStatusChangedApproved(Booking booking);
        void BookingStatusChangedApproved2(int id);

        public int GetBookingCount();
        List<Booking> GetLast6BookingList();

        void BookingStatusChangedApproved3(int id);
        void BookingStatusChangedCancel(int id);
        void BookingStatusChangedWait(int id);
    }
}
