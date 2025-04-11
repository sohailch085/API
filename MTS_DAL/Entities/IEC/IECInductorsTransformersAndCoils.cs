using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECInductorsTransformersAndCoils
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string TransformerType { get; set; } = string.Empty;
        public float ThetaReference { get; set; }
    }
}
