using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO
{
    public class IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto
    {
        public long Trid { get; set; } = 0;        
        public long PROJECTID { get; set; }
        public string WBS { get; set; } = string.Empty;
        public int RegionType { get; set; }
        public int LoadType { get; set; }
        public double Lambda { get; set; }
        public double LambdaRef { get; set; }
        public double PieEs { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public DateTime UPDATEDATE { get; set; }
        public string USERIDZU { get; set; } = string.Empty;
    }
}
