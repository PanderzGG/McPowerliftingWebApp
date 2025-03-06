using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MCPowerlifting.Models.Entities
{
    public class WorkoutExercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("workout_exercise_id")]
        public int WorkoutExerciseId { get; set; }

        [Required]
        [Column("workout_id")]
        public int WorkoutId { get; set; }

        [Required]
        [Column("exercise_id")]
        public int ExerciseId { get; set; }

        [Required]
        [Column("actual_weight")]
        public float ActualWeight { get; set; }

        [Required]
        [Column("actual_sets")]
        public int ActualSets { get; set; }

        [Required]
        [Column("actual_reps")]
        public int ActualReps { get; set; }

        [Required]
        [Column("is_successful")]
        public bool IsSuccessful { get; set; }

        [Column("notes")]
        public string? Notes { get; set; }

        // Navigation
        public Workout? Workout { get; set; }
        public Exercise? Exercise { get; set; }
    }
}
