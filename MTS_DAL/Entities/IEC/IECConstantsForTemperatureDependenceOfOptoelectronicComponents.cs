using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECConstantsForTemperatureDependenceOfOptoelectronicComponents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string ConstantsType { get; set; } = string.Empty;
        public float Ea { get; set; }
    }
}
