using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.Entities.IEC
{
    public class IECPredictionOptoelectronicComponent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        [Required]
        [ForeignKey("rAMProjects")]
        public long PROJECTid { get; set; }
        public RAMProjects rAMProjects { get; set; } = new RAMProjects();
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string WBS { get; set; } = string.Empty;
        [Required]
        [ForeignKey("iECOptoelectronicComponents")]
        public int OptoelectronicTypes { get; set; }
        public IECOptoelectronicComponents iECOptoelectronicComponents { get; set; } = new IECOptoelectronicComponents();
        [Required]
        [ForeignKey("iECOptoelectronicComponentsSub")]
        public int OptoelectronicComponentsSubCategory { get; set; }
        public IECOptoelectronicComponentsSubCategory iECOptoelectronicComponentsSub { get; set; } = new IECOptoelectronicComponentsSubCategory();
        [Required]
        [ForeignKey("iECConstantsForTemperatureDependence")]
        public int ConstantsTypeId { get; set; }
        public IECConstantsForTemperatureDependenceOfOptoelectronicComponents iECConstantsForTemperatureDependence { get; set; } = new IECConstantsForTemperatureDependenceOfOptoelectronicComponents();
        public double? OperatingVoltageInV { get; set; }
        public double? ReferenceVoltageInV { get; set; }
        public double? RatedVoltageInV { get; set; }
        public double? OperatingFrequencyMHz { get; set; }
        public double? MaximumOperatingFrequencyMHz { get; set; }
        public double? WorstCasePowerDissipationAtMaximumFrequencyW { get; set; }
        public double? MaximumSupplyCurrentA { get; set; }
        public double? NominalVoltage { get; set; }
        public double? ThermalResistance { get; set; }
        public double? AmbientTemperature { get; set; }
        public double? Lambda { get; set; }
        public double? LambdaRef { get; set; }
        public double? UOpDivURat { get; set; }
        public double? PieU { get; set; }
        public double? PieI { get; set; }
        public double? ThetaRef { get; set; }
        public double? ThetaOp { get; set; }
        public double? PieT { get; set; }
        public DateTime? CREATEDDATE { get; set; }
        public DateTime? UPDATEDATE { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;

    }
}
