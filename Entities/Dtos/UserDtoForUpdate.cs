namespace Entities.Dtos
{
    public class UserDtoForUpdate : UserDto
    {
        public HashSet<string> UserRoles { get; set; } = new HashSet<string>();
    }
}