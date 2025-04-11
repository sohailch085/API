using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.Entities.TwoOneSeveenNoticeTwo
{
    public class R2Capacitor
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
        public float? EAOp { get; set; }
        public float? EANonOp { get; set; }
        public float? N { get; set; }
        public float? C1 { get; set; }
        public float? S1 { get; set; }
        public float? CE { get; set; }       
    }
}
