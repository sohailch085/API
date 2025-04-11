using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECChildRegion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        [Required]
        [ForeignKey("iECRegionType")]
        public int RegionSubId { get; set; }
        public IECRegionType iECRegionType { get; set; } = new IECRegionType();
        public float ResistiveLoad { get; set; }
        public float CapacitiveAndIncandescentLampLoad { get; set; }
        public float InductiveLoad { get; set; }
    }
}
