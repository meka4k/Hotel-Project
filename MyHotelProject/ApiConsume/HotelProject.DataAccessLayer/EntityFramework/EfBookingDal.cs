using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
   public class EfBookingDal: GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(AppDbContext context) : base(context)
        {

        }


        public void BookingStatusChangedApproved(Booking booking)
        {
            var context = new AppDbContext();
            var values =context.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
            values.Status = "Onaylandı!";
            context.SaveChanges();
        }

        public void BookingStatusChangedApproved2(int id)
        {
            var context = new AppDbContext();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı!";
            context.SaveChanges();
        }

        public void BookingStatusChangedApproved3(int id)
        {
            var context = new AppDbContext();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı!";
            context.SaveChanges();
        }

        public void BookingStatusChangedCancel(int id)
        {
            var context = new AppDbContext();
            var values = context.Bookings.Find(id);
            values.Status = "İptal Edildi";
            context.SaveChanges();
        }

        public void BookingStatusChangedWait(int id)
        {
            var context = new AppDbContext();
            var values = context.Bookings.Find(id);
            values.Status = "Onay Bekliyor";
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var context = new AppDbContext();
            var values = context.Bookings.Count();
            return values;
        }

        public List<Booking> GetLast6BookingList()
        {
            var context = new AppDbContext();
            var values = context.Bookings.OrderByDescending(x => x.BookingId).Take(6).ToList();
            return values;
        }
    }
}
