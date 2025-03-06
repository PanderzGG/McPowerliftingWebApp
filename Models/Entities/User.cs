using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCPowerlifting.Models.Entities
{
    [Table("user_accounts")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("username")]
        [MaxLength(100)]
        public string? Username { get; set; }

        [Required]
        [Column("email")]
        [MaxLength(100)]
        public string? Email { get; set; }

        [Required]
        [Column("passwordhash")]
        [MaxLength(100)]
        public string? Passwordhash { get; set; }

        [Required]
        [Column("role")]
        [MaxLength(25)]
        public string? Role { get; set; }

        public ICollection<WorkoutProgram> WorkoutPrograms { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
        public ICollection<Workout> Workouts { get; set; }
        public ICollection<Starting_Weights> StartingWeights { get; set; }

        public User()
        {
            WorkoutPrograms = new List<WorkoutProgram>();
            Equipments = new List<Equipment>();
            Workouts = new List<Workout>();
            StartingWeights = new List<Starting_Weights>();
        }
    }
}
