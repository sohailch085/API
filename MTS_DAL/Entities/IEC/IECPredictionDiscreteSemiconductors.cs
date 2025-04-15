using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECPredictionDiscreteSemiconductors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        [ForeignKey("RAMProjects")]
        public long? ProjectID { get; set; }
        public RAMProjects RAMProjects { get; set; } = new RAMProjects();

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string? WBS { get; set; } = string.Empty;

        [Required]
        [ForeignKey("iECDiscreteSemiconductors")]
        public int? SUBCATEGORYID { get; set; }

        public IECDiscreteSemiconductors iECDiscreteSemiconductors { get; set; } = new IECDiscreteSemiconductors();

        [Required]
        [ForeignKey("iECDiscreteSemiconductorsSubcategory")]
        public int? TYPESID { get; set; }

        public IECDiscreteSemiconductorsSubcategory iECDiscreteSemiconductorsSubcategory { get; set; } =new IECDiscreteSemiconductorsSubcategory();

        public double? OperatingVoltage { get; set; }
        public double? RatedVoltage { get; set; }
        public double? NominalVoltage { get; set; }
        public double? ThermalResistance { get; set; }
        public double? AmbientTemperature { get; set; }
        public double? MaxSupplyCurrent { get; set; }
        public double? Pfwc { get; set; }
        public double? Fop { get; set; }
        public double? Fmax { get; set; }
        public double? Lambda { get; set; }
        public double? LambdaRef { get; set; }
        public double? UopDivideUrat { get; set; }
        public double? PieU { get; set; }
        public double? ThetaRef { get; set; }
        public double? ThetaOp { get; set; }
        public double? PieT { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string USERIDZU { get; set; } = string.Empty;
    }
}

