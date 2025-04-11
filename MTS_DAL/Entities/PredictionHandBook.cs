using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities
{
    public class PredictionHandBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TRID { get; set; }
        public string BOOKNAME { get; set; } = string.Empty;
    }
}
