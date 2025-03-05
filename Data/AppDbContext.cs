using MCPowerlifting.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCPowerlifting.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<WorkoutProgram> WorkoutPrograms { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Plate> Plates { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

    }
}
