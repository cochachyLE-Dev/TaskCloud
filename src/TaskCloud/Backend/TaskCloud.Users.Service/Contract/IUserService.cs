using TaskCloud.Users.Domain.Entities;
using TaskCloud.Users.Domain.Models;

namespace TaskCloud.Users.Service.Contract
{
    public interface IUserService
    {
        Task<User> RegisterUserAsync(RegisterUserModel model);
        Task<User> LoginUserAsync(LoginUserModel model);
        Task<User> GetUserByIdAsync(int id);
    }
}
