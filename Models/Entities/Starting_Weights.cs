using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MCPowerlifting.Models.Entities
{
    [Table("starting_weights")]
    public class Starting_Weights
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("weight_id")]
        public int WeightId { get; set; }

        [Required]
        [Column("exercise_id")]
        public int ExerciseId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("starting_weight")]
        public double Weight { get; set; }
    }
}
