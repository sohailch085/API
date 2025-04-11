using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO
{
    public class IECPreductionResistorsAndResistorNetworksDto
    {
        public long Trid { get; set; } = 0;
        public long PROJECTID { get; set; }
        public string WBS { get; set; } = string.Empty;
        public int ResistorType { get; set; }
        public int InputType { get; set; }
        public double OperatingTemperature { get; set; }
        public double ThetaMax { get; set; }
        public double AmbiantTemperature { get; set; }
        public double Lambda { get; set; }
        public double LambdaRef { get; set; }
        public double ThetaRef { get; set; }
        public double ThetaOp { get; set; }
        public double PieT { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public DateTime UPDATEDATE { get; set; }
        public string USERIDZU { get; set; } = string.Empty;
    }
}
