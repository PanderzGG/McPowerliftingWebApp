using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCPowerlifting.Models.Entities
{
    [Table("programs")]
    public class WorkoutProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("program_id")]
        public int ProgramId { get; set; }

        [ForeignKey("user_id")]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [Column("description")]
        [MaxLength(1000)]
        public string? Description { get; set; }

        public User? User { get; set; }

        [Required]
        [Column("starting_weight")]
        public float StartingWeight { get; set; }
    }
}
