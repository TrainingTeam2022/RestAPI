using Microsoft.EntityFrameworkCore;
using TemplateRestAPI.Entities;
using Npgsql;

namespace TemplateRestAPI.DBContext
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        static DemoDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().Property(a => a.Password).IsRequired(false);
        }
    }
}
