using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECConstantsForTemperatureDependenceOfRelays
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string SupportingConstruction { get; set; } = "";
        public float? A { get; set; }
        public float? Ea1 { get; set; }
        public float? Ea2 { get; set; }
    }
}
