using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities
{
    public class ProductTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TRID { get; set; }
        public string PRODUCTTYPE { get; set; } = string.Empty;
        public string? DESCRIPTION { get; set; } = string.Empty;
    }
}
