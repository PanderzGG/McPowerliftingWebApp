using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCPowerlifting.Models.Entities
{
    [Table("workouts")]
    public class Workout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("workout_id")]
        public int WorkoutId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("date")]
        public DateTime Date { get; set; }

        [Column("notes")]
        public string? Notes { get; set; }

        [Column("load")]
        public string Load { get; set; }

        // Navigation
        public User? User { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }

        public Workout()
        {
            WorkoutExercises = new List<WorkoutExercise>();
        }

    }
}
