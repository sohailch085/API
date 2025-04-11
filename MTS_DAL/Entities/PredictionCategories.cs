using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities
{
    public class PredictionCategories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TRID { get; set; }
        public string CATEGORYNAME { get; set; } = string.Empty;
        [ForeignKey("PreductionHandBook")] 
        public long BOOKID { get; set; }        
        public PredictionHandBook PreductionHandBook { get; set; }= new PredictionHandBook();
    }
}
