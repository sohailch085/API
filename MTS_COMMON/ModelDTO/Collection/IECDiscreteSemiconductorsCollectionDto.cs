using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO.Collection
{
    public class IECDiscreteSemiconductorsCollectionDto
    {
        public long Trid { get; set; } = 0;

        public long ProjectID { get; set; }
        public string WBS { get; set; } = string.Empty;
        public int SUBCATEGORYID { get; set; }
        public int TYPESID { get; set; }
        public double RatedVoltageInV { get; set; }
        public double NominalVoltage { get; set; }
        public double ThermalResistance { get; set; }
        public double AmbientTemperature { get; set; }
        public double MaximumSupplyCurrentA { get; set; }
        public double WorstCasePowerDissipationAtMaximumFrequencyW { get; set; }
        public double OperatingFrequencyMHz { get; set; }
        public double MaximumOperatingFrequencyMHz { get; set; }
        public double OperatingVoltageInV { get; set; }
        public double Lambda { get; set; }
        public double LambdaRef { get; set; }
        public double UopDivideUrat { get; set; }
        public double PieU { get; set; }
        public double ThetaRef { get; set; }
        public double ThetaOp { get; set; }
        public double PieT { get; set; }
        public string USERIDZU { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
