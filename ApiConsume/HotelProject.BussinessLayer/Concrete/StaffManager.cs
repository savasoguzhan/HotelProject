﻿using HotelProject.BussinessLayer.Abstract;
using HotelProject.DAL.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }
        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public List<Staff> TGetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff TGetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
