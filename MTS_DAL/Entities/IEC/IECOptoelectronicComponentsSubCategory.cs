using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECOptoelectronicComponentsSubCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        [Required]
        [ForeignKey("iECOptoelectronicComponents")]
        public int ComponentsSubCategoryId { get; set; }
        public IECOptoelectronicComponents iECOptoelectronicComponents { get; set; } = new IECOptoelectronicComponents();
        public string OptoelectronicComponentsSubCategory { get; set; } = string.Empty;
        public float ThetaRef { get; set; }
        
    }

}
