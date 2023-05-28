using Yhiot.Application.Contract;
using Yhiot.Domain;
using Yhiot.Persistence;

namespace Yhiot.Application
{
    public class UserService : IUserService
    {
        public IAllPersist _AllPersist { get; }
        public IUserPersist _UserPersist { get; }
        public UserService(IAllPersist allPersist, IUserPersist userPersist){
                 
            _UserPersist = userPersist;
            _AllPersist = allPersist;
        }
        public async Task<User> AddUser(User model)
        {
            try
            {
                _AllPersist.Add<User>(model);
                if(await _AllPersist.SaveChangesAsync()){
                    return await _UserPersist.GetAllUsersById(model.id);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> DeleteUser(int userId)
        {
            try
            {
                var user = await _UserPersist.GetAllUsersById(userId);
                if(user == null) throw new Exception("User Not Found !");

                _AllPersist.Delete<User>(user);
                return await _AllPersist.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User[]> GetAllUsersAsync()
        {
            try
            {
                var user = await _UserPersist.GetAllUsersAsync();
                if(user == null) return null;

                return user;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> GetAllUsersById(int userId)
        {
            try
            {
                var user = await _UserPersist.GetAllUsersById(userId);
                if(user == null) return null;

                return user;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<User[]> GetAllUsersByNameAsync(string name)
        {
            try
            {
                var user = await _UserPersist.GetAllUsersByNameAsync(name);
                if(user == null) return null;

                return user;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        

        public async Task<User> UpdateUser(int userId, User model)
        {
            try
            {
                var user = await _UserPersist.GetAllUsersById(userId);
                if(user == null) return null;

                model.id = user.id;

                _AllPersist.Update(model);
                if(await _AllPersist.SaveChangesAsync()){
                    return await _UserPersist.GetAllUsersById(model.id);
                }
                return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
    }
}