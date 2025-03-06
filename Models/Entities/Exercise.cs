using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCPowerlifting.Models.Entities
{
    [Table("exercises")]
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("exercise_id")]
        public int ExerciseId { get; set; }

        [Required]
        [Column("exercise_name")]
        [MaxLength(100)]
        public string? ExerciseName { get; set; }

        [Column("category")]
        [MaxLength(50)]
        public string? Category { get; set; }

        // Navigation
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }

        public ICollection<Starting_Weights> StartingWeights { get; set; }

        public Exercise()
        {
            WorkoutExercises = new List<WorkoutExercise>();
            StartingWeights = new List<Starting_Weights>();
        }
    }
}
