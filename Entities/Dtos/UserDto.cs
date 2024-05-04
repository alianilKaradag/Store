using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public class UserDto
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Username is required!")]
        public string? UserName { get; init; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required!")]
        public string? Email { get; init; }

        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; init; }
        public HashSet<string> Roles { get; set; } = new HashSet<string>();
    }
}