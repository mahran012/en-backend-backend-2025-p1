using System.ComponentModel.DataAnnotations;
using MohamedTwo.Models.Enum;

namespace MohamedTwo.Dtos.UserDto
{
    public class UpdateProfileDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateOnly BirthDate { get; set; }


        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public Gender Gender { get; set; }
    }
}
