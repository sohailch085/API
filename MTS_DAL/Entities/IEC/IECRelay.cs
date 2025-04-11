using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MTS_DAL.Entities.IEC
{
    public class IECRelay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string RelayType { get; set; } = string.Empty;
    }
}
