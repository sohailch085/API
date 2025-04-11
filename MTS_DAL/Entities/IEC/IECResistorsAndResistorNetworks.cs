using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECResistorsAndResistorNetworks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }

        public string ResistorType { get; set; } = string.Empty;
        public float ThetaRef { get; set; }
    }
}
