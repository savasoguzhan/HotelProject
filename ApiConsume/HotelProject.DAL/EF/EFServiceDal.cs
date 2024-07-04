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
    public class EFServiceDal : GenericRepository<Service> , IServicesDal
    {
        public EFServiceDal(Context context) : base(context)
        {
            
        }
    }
}
