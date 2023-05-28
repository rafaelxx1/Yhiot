using Yhiot.Domain;

namespace Yhiot.Persistence
{
    public interface IUserPersist
    {

        //User
        Task<User[]> GetAllUsersByNameAsync(string name);
        Task<User[]> GetAllUsersAsync();
        Task<User> GetAllUsersById(int userId);
    }
}