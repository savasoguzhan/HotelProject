using HotelProject.BussinessLayer.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonailDal _testimonailDal;

        public TestimonialManager(ITestimonailDal testimonailDal)
        {
            _testimonailDal = testimonailDal;
        }
        public void TDelete(Testimonial t)
        {
            _testimonailDal.Delete(t);
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonailDal.GetAll();
        }

        public Testimonial TGetById(int id)
        {
            return _testimonailDal.GetById(id);
        }

        public void TInsert(Testimonial t)
        {
            _testimonailDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonailDal.Update(t);
        }
    }
}
