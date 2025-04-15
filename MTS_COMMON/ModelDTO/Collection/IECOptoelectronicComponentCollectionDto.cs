using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO.Collection
{
    public class IECOptoelectronicComponentCollectionDto
    {
        public int TypesId { get; set; }
        public int SubCategoryId { get; set; }
        public double OperatingVoltageInV { get; set; }
        public double ReferenceVoltageInV { get; set; }
        public double RatedVoltageInV { get; set; }
        public double Fop { get; set; }
        public double Fmax { get; set; }
        public double Pfwc { get; set; }
        public double MaximumSupplyCurrentA { get; set; }
        public double NominalVoltage { get; set; }
        public double ThermalResistance { get; set; }
        public double AmbientTemperature { get; set; }
        public double LambdaRef { get; set; }
    }
}
