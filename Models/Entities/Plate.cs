using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MudCowV2.Models.Entities
{
    [Table("plates")]
    public class Plate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("plate_id")]
        public int PlateId { get; set; }

        [Required]
        [Column("equipment_id")]
        public int EquipmentId { get; set; }

        [Required]
        [Column("plate_weight")]
        public double PlateWeight { get; set; }

        [Required]
        [Column("plate_count")]
        public int PlateCount { get; set; }

        // Navigation
        public Equipment? Equipment { get; set; }
    }
}
