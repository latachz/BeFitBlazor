using BeFitBlazor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeFitBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BeFitBlazor.Models.ExerciseType> ExerciseType { get; set; } = default!;
        public DbSet<BeFitBlazor.Models.TrainingSession> TrainingSession { get; set; } = default!;
        public DbSet<BeFitBlazor.Models.ExerciseExecution> ExerciseExecution { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Microsoft.AspNetCore.Identity.IdentityRole>().HasData(
                new Microsoft.AspNetCore.Identity.IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" }
            );
        }
    }
}

