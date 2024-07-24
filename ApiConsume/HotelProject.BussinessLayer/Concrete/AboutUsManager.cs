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
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUs _aboutUsDal;

        public AboutUsManager(IAboutUs aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void TDelete(AboutUs t)
        {
            _aboutUsDal.Delete(t);
        }

        public List<AboutUs> TGetAll()
        {
            return _aboutUsDal.GetAll();
        }

        public AboutUs TGetById(int id)
        {
           return _aboutUsDal.GetById(id);
        }

        public void TInsert(AboutUs t)
        {
            _aboutUsDal.Insert(t);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutUsDal.Update(t);
        }
    }
}
