using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECConstantsForTemperatureDependenceOfDiscreteSemiconductors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string ConstantsType { get; set; } = string.Empty;

        public float A { get; set; }

        public float Ea1 { get; set; }

        public float Ea2 { get; set; }
    }
}
