using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_DAL.Entities.IEC
{
    public class IECDiscreteSemiconductors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }

        public string SUBCATEGORY { get; set; } = string.Empty;
    }
}
