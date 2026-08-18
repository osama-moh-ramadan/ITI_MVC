using Day2.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Manager)
                .WithMany()
                .HasForeignKey(i => i.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
            //relation with kmvg
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructor)
                .HasForeignKey(i => i.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}