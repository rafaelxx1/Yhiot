using Microsoft.EntityFrameworkCore;
using Yhiot.Domain;
using Yhiot.Persistence.Context;

namespace Yhiot.Persistence
{
    public class ExamPersistence : IExamPersist
    {

        private readonly YhiotContext _context;

        public ExamPersistence(YhiotContext context)
        {
            this._context = context;
            
        }
         public async Task<Exam[]> GetAllExamByNameAsync(string name)
        {
            IQueryable<Exam> query = _context.exam.Include(e => e.Schedules);

            query = query.OrderBy(e => e.Id).Where(e => e.exName.ToLower().Contains(name.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Exam[]> GetAllExamAsync(string tema)
        {
            IQueryable<Exam> query = _context.exam.Include(e => e.Schedules);

            query = query.OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Exam> GetAllExamById(int userId)
        {
            IQueryable<Exam> query = _context.exam.Include(e => e.Schedules);

            query = query.OrderBy(e => e.Id).Where(e => e.Id == userId);

            return await query.FirstOrDefaultAsync();
        }
    }
}