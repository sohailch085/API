using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECCapacitorsTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        public string TYPES { get; set; } = string.Empty;
        public float ThetaRef { get; set; }
        [Required]
        [ForeignKey("iECCapacitorsSubCategory")]
        public long CATEGORYID { get; set; }
        public IECCapacitorsSubCategory iECCapacitorsSubCategory { get; set; } = new IECCapacitorsSubCategory();
    }
}
