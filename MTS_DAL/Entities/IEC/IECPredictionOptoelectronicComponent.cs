using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
        public int? TypesId { get; set; }
        public IECOptoelectronicComponentsTypes? iECOptoelectronicComponents { get; set; }// new IECOptoelectronicComponentsTypes();
        [Required]
        [ForeignKey("iECOptoelectronicComponentsSub")]
        public int? SubCategoryId { get; set; }
        public IECOptoelectronicComponentsSubCategory iECOptoelectronicComponentsSub { get; set; } = new IECOptoelectronicComponentsSubCategory();
        public double? OperatingVoltageInV { get; set; }
        public double? ReferenceVoltageInV { get; set; }
        public double? RatedVoltageInV { get; set; }
        public double? Fop { get; set; }
        public double? Fmax { get; set; }
        public double? Pfwc { get; set; }
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
