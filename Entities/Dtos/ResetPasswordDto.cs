using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ResetPasswordDto{
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string? Password { get; init; }
        
        [Required(ErrorMessage = "ConfirmPassword is required!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and ConfirmPassword must match!")]
        public string? ConfirmPassword { get; init; }
    }
}