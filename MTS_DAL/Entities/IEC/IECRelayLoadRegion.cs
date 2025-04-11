using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECRelayLoadRegion
    {
        [Key]
        public int Trid { get; set; }
        public float ResistiveLoadDC { get; set; }
        public float ResistiveLoadAC { get; set; }
        public float CapacitiveAndIncandescentLampLoadDC { get; set; }
        public float CapacitiveAndIncandescentLampLoadAC { get; set; }
        public float InductiveLoadDC { get; set; }
        public float InductiveLoadAC { get; set; }
        public int RegionSubId { get; set; }
    }
}
