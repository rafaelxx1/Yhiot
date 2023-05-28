using Yhiot.Domain;

namespace Yhiot.Application.Contract
{
    public interface IUserService
    {
        Task<User> AddUser(User model);
        Task<User> UpdateUser(int userId, User model);
        Task<bool> DeleteUser(int userId);

        Task<User[]> GetAllUsersByNameAsync(string name);
        Task<User[]> GetAllUsersAsync();
        Task<User> GetAllUsersById(int userId);
    }
}