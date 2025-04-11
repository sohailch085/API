using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.TwoOneSeveenNoticeTwo
{
    public class R2Diode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; } 
        public string PartType { get; set; } = string.Empty;
        public float? LambdaOB { get; set; }
        public float? LambdaEB { get; set; }
        public float? LambdaTCB { get; set; }
        public float? LambdaIND { get; set; }
        public float? Betaβ { get; set; }             
    }
}
