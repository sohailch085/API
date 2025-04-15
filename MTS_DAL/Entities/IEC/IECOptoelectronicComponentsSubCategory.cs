using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECOptoelectronicComponentsSubCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubCategoryId { get; set; }      
        public string SubCategory { get; set; } = string.Empty;
       
        
    }

}
