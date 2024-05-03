using Entities.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IAuthService{
        public IEnumerable<IdentityRole> Roles { get; }
        public IEnumerable<IdentityUser> GetAllUsers();
        public Task<IdentityResult> CreateUser(UserDtoForCreation userDto);
    }
}