using Entities.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IAuthService{
        public IEnumerable<IdentityRole> Roles { get; }
        public IEnumerable<IdentityUser> GetAllUsers();
        public Task<IdentityResult> CreateUser(UserDtoForCreation userDto);
        public Task<UserDtoForUpdate> GetOneUserForUpdate(string userName);
        public Task<IdentityUser> GetOneUser(string userName);
        public Task Update(UserDtoForUpdate userDto);
        public Task<IdentityResult> ResetPassword(ResetPasswordDto model);
        public Task<IdentityResult> DeleteOneUser(string userName);
    }
}