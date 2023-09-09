using Microsoft.EntityFrameworkCore;
namespace INFRASTRUCTURE.DatabaseContext
{
    public class TaskManagementSystemDbContext : DbContext
    {
        public TaskManagementSystemDbContext(DbContextOptions options): base(options)
        {}



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {





            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
