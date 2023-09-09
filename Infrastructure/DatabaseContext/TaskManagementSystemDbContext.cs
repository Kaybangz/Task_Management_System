using DOMAIN.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace INFRASTRUCTURE.DatabaseContext
{
    public class TaskManagementSystemDbContext : IdentityDbContext<User>
    {
        public TaskManagementSystemDbContext(DbContextOptions options): base(options)
        {}

        

        public DbSet<UserTask> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Notification> Notifications { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            modelBuilder.Entity<Project>()
                .HasOne(p => p.ProjectOwner)
                .WithMany(p => p.Projects)
                .HasForeignKey(p => p.ProjectOwnerId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.User)
                .WithMany(ut => ut.Tasks)
                .HasForeignKey(ut => ut.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.Project)
                .WithMany(ut => ut.Tasks)
                .HasForeignKey(ut => ut.ProjectId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<Notification>()
                .HasOne(ut => ut.User)
                .WithMany(ut => ut.Notifications)
                .HasForeignKey(ut => ut.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();



            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
