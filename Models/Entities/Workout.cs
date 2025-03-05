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

        [ForeignKey("user_id")]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("date")]
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "TEXT")]
        [StringLength(1000)]
        public string? Notes { get; set; }

        [Required]
        [Column("load")]
        public LoadType Load { get; set; }

        public User? User { get; set; }

        public ICollection<Exercise> Exercises { get; set; }

        public Workout()
        {
            Exercises = new List<Exercise>();
        }

        public enum LoadType
        {
            Heavy = 1,
            Medium = 2,
            Light = 3
        }
    }
}
