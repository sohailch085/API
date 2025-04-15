using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECOptoelectronicComponentsTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeId { get; set; }
        [Required]
        [ForeignKey("iECOptoelectronicComponents")]
        public int SubCategoryId { get; set; }
        public IECOptoelectronicComponentsTypes iECOptoelectronicComponents { get; set; } = new IECOptoelectronicComponentsTypes();
        public string TypeName { get; set; } = string.Empty;
        [Required]
        public int ConstantsTypeId { get; set; }
        public float ThetaRef { get; set; }

    }

}
