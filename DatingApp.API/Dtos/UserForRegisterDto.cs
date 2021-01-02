using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(21, MinimumLength = 4, ErrorMessage= "Password must be between 4 and 8 characters")]
        public string Password { get; set; }

        [Required]
        [EmailAddress(ErrorMessage= "A valid Email Address is required")]
        public string EmailAddress { get; set; }
    }
}