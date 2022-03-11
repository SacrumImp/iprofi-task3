using Microsoft.EntityFrameworkCore;
using Entity.Entities;

namespace Entity
{
    public class DbSqlContext : DbContext
    {
        public DbSet<Promotion> Promotion { get; set; }

        public DbSqlContext(DbContextOptions<DbSqlContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
