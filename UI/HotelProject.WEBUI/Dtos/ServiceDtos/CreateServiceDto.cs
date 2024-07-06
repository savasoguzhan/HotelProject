using System.ComponentModel.DataAnnotations;

namespace HotelProject.WEBUI.Dtos.ServiceDtos
{
    public class CreateServiceDto
    {
       

        public string ServiceIcon { get; set; }

        [Required(ErrorMessage ="Title Cannot Empty")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
