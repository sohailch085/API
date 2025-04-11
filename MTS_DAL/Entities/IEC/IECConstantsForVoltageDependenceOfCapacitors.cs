using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECConstantsForVoltageDependenceOfCapacitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }

        public string CapacitorType { get; set; } = string.Empty;

        public double URefDivURat { get; set; }

        public double C2 { get; set; }

        public double C3 { get; set; }
        [ForeignKey("iECCapacitorsTypes")]
        public long CapacitorTypeID { get; set; }
        public IECCapacitorsTypes iECCapacitorsTypes { get; set; } = new IECCapacitorsTypes();
    }

}
