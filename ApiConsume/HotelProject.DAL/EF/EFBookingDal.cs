using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DAL.EF
{
    public class EFBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EFBookingDal(Context context) :base(context)
        {
            
        }

        public void BookingStatusChangeAccept(Booking booking)
        {
            var context = new Context();
             var values =context.Bookings.Where(x=>x.BookingId == booking.BookingId).FirstOrDefault();
            values.Status = "Accept";
            context.SaveChanges();
        }
    }
}
