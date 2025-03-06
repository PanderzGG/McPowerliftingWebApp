using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MCPowerlifting.Models.Entities
{
    [Table("program_exercises")]
    public class ProgramExercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("program_exercise_id")]
        public int ProgramExerciseId { get; set; }

        [Required]
        [Column("program_id")]
        public int ProgramId { get; set; }

        [Required]
        [Column("exercise_id")]
        public int ExerciseId { get; set; }

        [Required]
        [Column("starting_weight")]
        public float StartingWeight { get; set; }

        [Required]
        [Column("prescribed_sets")]
        public int PrescribedSets { get; set; }

        [Required]
        [Column("prescribed_reps")]
        public int PrescribedReps { get; set; }

        [Column("progression_notes")]
        public string? ProgressionNotes { get; set; }

        // Navigation
        public WorkoutProgram? Program { get; set; }
        public Exercise? Exercise { get; set; }
    }

}
