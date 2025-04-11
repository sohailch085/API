using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECDiscreteSemiconductorsSubcategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        [Required]
        [ForeignKey("iECDiscreteSemiconductors")]
        public int SUBCATEGORYID { get; set; }
        [Required]
        [ForeignKey("iECConstantsForTemperatureDependenceOfDiscreteSemiconductors")]
        public int CONSTANTSTYPEID  { get; set; }       
        public string TYPES  { get; set; } = string.Empty;
        public float THETAREF  { get; set; }
        public IECConstantsForTemperatureDependenceOfDiscreteSemiconductors iECConstantsForTemperatureDependenceOfDiscreteSemiconductors { get; set; } = new IECConstantsForTemperatureDependenceOfDiscreteSemiconductors();
        public IECDiscreteSemiconductors iECDiscreteSemiconductors { get; set; } = new IECDiscreteSemiconductors();
    }
}
