using System.ComponentModel.DataAnnotations;

namespace HotelProject.WEBUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Mail { get; set; }

      

        [Required]
        public string Password { get; set; }


        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


    }
}
