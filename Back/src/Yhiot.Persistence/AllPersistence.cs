using Microsoft.EntityFrameworkCore;
using Yhiot.Domain;
using Yhiot.Persistence.Context;

namespace Yhiot.Persistence
{
    public class AllPersistence : IAllPersist
    {
        private readonly YhiotContext _context;

        public AllPersistence(YhiotContext context)
        {
            this._context = context;
            
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}