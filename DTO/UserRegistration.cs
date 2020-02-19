using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class UserRegistration
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}