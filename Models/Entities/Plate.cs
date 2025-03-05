using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCPowerlifting.Models.Entities
{
    [Table("plates")]
    public class Plate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("plate_id")]
        public int PlateId { get; set; }

        [ForeignKey("equipment_id")]
        [Column("equipment_id")]
        public int EquipmentId { get; set; }

        [Required]
        [Column("plate_weight")]
        public float PlateWeight { get; set; }

        [Required]
        [Column("plate_count")]
        public int PlateCount { get; set; }

        public Equipment? Equipment { get; set; }
    }
}
