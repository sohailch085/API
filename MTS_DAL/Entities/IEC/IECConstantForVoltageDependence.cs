using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECConstantForVoltageDependence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string IntegratedCircuit { get; set; } = string.Empty;
        public float URefDivideURat { get; set; }
        public float URef { get; set; }
        public float C1 { get; set; }
        public float C2 { get; set; }
        public float C3 { get; set; }
    }
}
