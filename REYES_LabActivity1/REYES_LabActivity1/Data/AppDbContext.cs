using Microsoft.EntityFrameworkCore;
using REYES_LabActivity1.Models;
using System.Collections.Generic;

namespace REYES_LabActivity1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student()
            );
        }
    }
}
