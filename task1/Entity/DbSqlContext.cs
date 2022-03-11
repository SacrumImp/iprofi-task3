using Microsoft.EntityFrameworkCore;
using Entity.Entities;

namespace Entity
{
    public class DbSqlContext : DbContext
    {
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<Participant> Participant { get; set; }
        public DbSet<Prize> Prize { get; set; }
        public DbSet<Promo_Participant> Promo_Participant { get; set; }
        public DbSet<Promo_Prize> Promo_Prize { get; set; }

        public DbSqlContext(DbContextOptions<DbSqlContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
