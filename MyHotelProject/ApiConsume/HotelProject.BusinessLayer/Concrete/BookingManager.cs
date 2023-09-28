using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TBookingStatusChangedApproved(Booking booking)
        {
            _bookingDal.BookingStatusChangedApproved(booking);
        }

        public void TBookingStatusChangedApproved2(int id)
        {
            _bookingDal.BookingStatusChangedApproved2(id);
        }

        public void TBookingStatusChangedApproved3(int id)
        {
            _bookingDal.BookingStatusChangedApproved3(id);
        }

        public void TBookingStatusChangedCancel(int id)
        {
            _bookingDal.BookingStatusChangedCancel(id);
        }

        public void TBookingStatusChangedWait(int id)
        {
            _bookingDal.BookingStatusChangedWait(id);
        }

        public void TDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public int TGetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public List<Booking> TGetLast6BookingList()
        {
            return _bookingDal.GetLast6BookingList();
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
