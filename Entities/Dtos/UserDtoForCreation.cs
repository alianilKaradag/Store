using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public class UserDtoForCreation : UserDto
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required!")]
        public string? Password { get; init; }
    }
}