using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO
{
    public class IECPreductionInductorsTransformersAndCoilsDto
    {
        public long Trid { get; set; } = 0;
        public long PROJECTID { get; set; }
        public string WBS { get; set; } = string.Empty;
        public int SubCategoryId { get; set; }
        public int TypeId { get; set; }
        public double DeltaT { get; set; }
        public double AmbientTemperature { get; set; }
        public double Lambda { get; set; }
        public double LambdaRef { get; set; }
        public double ThetaOp { get; set; }
        public double ThetaRef { get; set; }
        public double PieT { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string USERIDZU { get; set; } = string.Empty;
    }
}
