using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCPowerlifting.Models.Entities
{
    [Table("equipment")]
    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("equipmeint_id")]
        public int EquipmentId { get; set; }

        [ForeignKey("user_id")]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("bar_weight")]
        public float BarWeight { get; set; }

        [Required]
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public User? User { get; set; }

        public ICollection<Plate> Plates { get; set; }

        public Equipment()
        {
            Plates = new List<Plate>();
        }
    }
}
