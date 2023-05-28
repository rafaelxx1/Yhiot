using Microsoft.EntityFrameworkCore;
using Yhiot.Domain;
using Yhiot.Persistence.Context;

namespace Yhiot.Persistence
{
    public class UserPersistence : IUserPersist
    {

         private readonly YhiotContext _context;

        public UserPersistence(YhiotContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            
        }
         public async Task<User[]> GetAllUsersAsync()
        {
            IQueryable<User> query = _context.users.Include(e => e.Schedules);

            query = query.OrderBy(u => u.id);

            return await query.ToArrayAsync();
        }

        public async Task<User> GetAllUsersById(int userId)
        {
            IQueryable<User> query = _context.users.Include(e => e.Schedules);

            query = query.OrderBy(u => u.id).Where(e => e.id == userId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<User[]> GetAllUsersByNameAsync(string name)
        {
            IQueryable<User> query = _context.users.Include(e => e.Schedules);

            query = query.OrderBy(u => u.id).Where(u => u.userName.ToLower().Contains(name.ToLower()));

            return await query.ToArrayAsync();
        }

    }
}