using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities
{
    public class Lifecyclephases
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TRID { get; set; }
        public string LIFECYCLEPHASE { get; set; } = string.Empty;
        public string? DESCRIPTION { get; set; } = string.Empty;
    }
}
