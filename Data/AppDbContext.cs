using Microsoft.EntityFrameworkCore;
using MudCowV2.Models.Entities;

namespace MudCowV2.Data
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
        public DbSet<WorkoutExercise> workoutExercises { get; set; }
        public DbSet<Starting_Weights> startingWeights { get; set; }
    }
}
