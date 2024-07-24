﻿using HotelProject.DAL.Abstract;
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
    public class EFAboutUsDal : GenericRepository<AboutUs>, IAboutUs
    {
        public EFAboutUsDal(Context context) : base(context)
        {
        }
    }
}