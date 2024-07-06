using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage ="Please type room Number")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage ="Please type room price ")]
        public int Price { get; set; }

        public string Title { get; set; }

        [Required(ErrorMessage = "Please type bed count ")]
        public string BedCount { get; set; }
        public string WiFi { get; set; }
        public string BathCount { get; set; }
        public string Description { get; set; }

    }
}
