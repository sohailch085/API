using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECRegionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string RegionTypeName { get; set; } = string.Empty;
        // public int RegionSubId { get; set; } 
        [Required]
        [ForeignKey("iECRelay")]
        public int RegionId { get; set; }
        public IECRelay iECRelay { get; set; } = new IECRelay();
    }
}
