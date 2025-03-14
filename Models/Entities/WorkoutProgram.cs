using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MudCowV2.Models.Entities
{
    [Table("programs")]
    public class WorkoutProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("program_id")]
        public int ProgramId { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        // Navigation
        public User? User { get; set; }

        public WorkoutProgram()
        {
        }
    }
}
