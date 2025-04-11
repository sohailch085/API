using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO.Collection
{
    public class IECOptoelectronicComponentCollectionDto
    {
        public int OptoelectronicTypes { get; set; }
        public int OptoelectronicComponentsSubCategory { get; set; }
        public int ConstantsType { get; set; }
        public double OperatingVoltageInV { get; set; }
        public double ReferenceVoltageInV { get; set; }
        public double RatedVoltageInV { get; set; }
        public double OperatingFrequencyMHz { get; set; }
        public double MaximumOperatingFrequencyMHz { get; set; }
        public double WorstCasePowerDissipationAtMaximumFrequencyW { get; set; }
        public double MaximumSupplyCurrentA { get; set; }
        public double NominalVoltage { get; set; }
        public double ThermalResistance { get; set; }
        public double AmbientTemperature { get; set; }
        public double LambdaRef { get; set; }
    }
}
