using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{

    public class IECTypeComponent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string ComponentType { get; set; } = string.Empty;
    }
}
