using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(AppDbContext context) : base(context)
        {

        }

        public int AppUserCount()
        {
            var context = new AppDbContext();
            var values = context.Users.Count();
            return values;
        }

        public List<AppUser> AppUserWithWorkLocation()
        {
            var context = new AppDbContext();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }
    }
}
