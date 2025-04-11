using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECChildRegionACorDC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        [Required]
        [ForeignKey("iECRegionType")]
        public int RegionSubId { get; set; }
        public IECRegionType iECRegionType { get; set; } = new IECRegionType();
        public float ResistiveLoadDC { get; set; }
        public float ResistiveLoadAC { get; set; }
        public float CapacitiveAndIncandescentLampLoadDC { get; set; }
        public float CapacitiveAndIncandescentLampLoadAC { get; set; }
        public float InductiveLoadDC { get; set; }
        public float InductiveLoadAC { get; set; }
    }
}
