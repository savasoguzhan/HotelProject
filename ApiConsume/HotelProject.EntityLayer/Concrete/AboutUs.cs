﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class AboutUs
    {
        public int AboutUsId { get; set; }

        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }

        public int RoomCount { get; set; }
        public int StaffCount { get; set; }

        public int CustomerCount { get; set; }
    }
}
