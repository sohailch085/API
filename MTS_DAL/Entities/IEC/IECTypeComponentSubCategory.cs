using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECTypeComponentSubCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }

        public string SubCategory { get; set; } = string.Empty;

        public double? ThetaRef { get; set; }
        [Required]
        [ForeignKey("iECTypeComponent")]
        public int SubCategoryId { get; set; }
        public IECTypeComponent iECTypeComponent { get; set; } = new IECTypeComponent();
    }
}
