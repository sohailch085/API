using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.Entities.IEC
{
  public  class IECPredictionInductorsTransformersAndCoils
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        [ForeignKey("Projects")]
        public long PROJECTID { get; set; }
        public RAMProjects Projects { get; set; } = new RAMProjects();
        [Column(TypeName = "varchar(30)")]
        public string? WBS { get; set; } = string.Empty;
        [ForeignKey("iECInductorsTransformersAndCOils")]
        public int? TransformerTypeId { get; set; }
        public IECInductorsTransformersAndCoils iECInductorsTransformersAndCOils { get; set; } = new IECInductorsTransformersAndCoils();
        public double? OperatingFrequencyMHz { get; set; }
        public double? MaximumOperatingFrequencyMHz { get; set; }
        public double? WorstCasePowerDissipationAtMaximumFrequencyW { get; set; }
        public double? MaximumSupplyCurrentA { get; set; }
        public double? NominalVoltage { get; set; }
        public double? ThermalResistance { get; set; }
        public double? AmbientTemperature { get; set; }
        public double? Lambda { get; set; }
        public double? LambdaRef { get; set; }
        public double? PieT { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string USERIDZU { get; set; } = string.Empty;


    }
}
