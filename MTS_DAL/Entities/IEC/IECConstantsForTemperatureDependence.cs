using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECConstantsForTemperatureDependence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }

        public string ConstantsType { get; set; } = string.Empty;

        public double A { get; set; }

        public double Ea1 { get; set; }

        public double Ea2 { get; set; }
    }
}
