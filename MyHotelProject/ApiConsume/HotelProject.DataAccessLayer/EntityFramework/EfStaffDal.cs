using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(AppDbContext context) : base(context)
        {

        }

        public List<Staff> GetListLast4Staff()
        {
            var context = new AppDbContext();
            var values = context.Staffs.OrderByDescending(x => x.StaffId).Take(4).ToList();
            return values;
        }

        public int GetStaffCount()
        {
            var context = new AppDbContext();
            var values = context.Staffs.Count();
            return values;
        }
    }
}
