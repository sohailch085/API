using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECConstantsForTemperatureDependenceOfCapacitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        public string CapacitorComponent { get; set; } = string.Empty;
        public float A { get; set; }
        public float Ea1 { get; set; }
        public float Ea2 { get; set; }
        [ForeignKey("iECCapacitorsTypes")]
        public long CapacitorTypeID { get; set; }
        public IECCapacitorsTypes iECCapacitorsTypes { get; set; } = new IECCapacitorsTypes();
    }


}
