using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MCPowerlifting.Models.Entities
{
    [Table("exercises")]
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("exercise_id")]
        public int ExerciseId { get; set; }

        [ForeignKey("workout_id")]
        [Column("workout_id")]
        public int WorkoutId { get; set; }

        [Required]
        [Column("exercise_name")]
        [MaxLength(70)]
        public string? ExerciseName { get; set; }

        [Required]
        [Column("weight")]
        public float Weight { get; set; }

        [Required]
        [Column("sets")]
        public int Sets { get; set; }

        [Required]
        [Column("reps")]
        public int Reps { get; set; }

        [Required]
        [Column("is_successful")]
        public bool IsSuccessful { get; set; }
        
        [Required]
        [Column("increment")]
        public float Increment { get; set; }

        public Workout? Workout { get; set; }
    }
}
