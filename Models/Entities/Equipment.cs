using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MudCowV2.Models.Entities
{
    [Table("equipment")]
    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("equipment_id")]
        public int EquipmentId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("bar_weight")]
        public double BarWeight { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public User? User { get; set; }
        public ICollection<Plate> Plates { get; set; }

        public Equipment()
        {
            Plates = new List<Plate>();
        }
    }
}
