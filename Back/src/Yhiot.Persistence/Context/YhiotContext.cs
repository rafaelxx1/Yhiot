using Microsoft.EntityFrameworkCore;
using Yhiot.Domain;

namespace Yhiot.Persistence.Context
{
    public class YhiotContext : DbContext
    {

        public YhiotContext(DbContextOptions<YhiotContext> options) : base(options){}
        public DbSet<Agendamento>? agendamentos { get; set; }
        public DbSet<User>? users {get; set;}
        public DbSet<Exam>? exam {get; set;}
        public DbSet<Schedule>? schedule {get; set;}
    }
}