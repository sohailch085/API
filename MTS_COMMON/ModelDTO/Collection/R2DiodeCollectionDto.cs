using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO.Collection
{
    public class R2DiodeCollectionDto
    {
        public int PartType { get; set; }
        public double NoOfYears { get; set; }
        public double AppliedVoltage { get; set; }
        public double RatedVoltage { get; set; }
        public double TemperatureRise { get; set; }
        public double TemperatureOverride { get; set; }
        public double AmbientTemperatureOperating { get; set; }
        public double AmbientTemperatureNonoperating { get; set; }
        public double DutyCycle { get; set; }
        public double CyclingRate { get; set; }
    }
}
