using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.IEC
{
    public class IECPredictionCapacitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        [ForeignKey("Projects")]
        public long PROJECTID { get; set; }
        public RAMProjects Projects { get; set; } = new RAMProjects();
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string WBS { get; set; } = string.Empty;
        [Required]
        [ForeignKey("iECCapacitorsSubCategory")]
        public long? SUBCATEGORYID { get; set; }
        public IECCapacitorsSubCategory iECCapacitorsSubCategory { get; set; }=new IECCapacitorsSubCategory();
        [Required]
        [ForeignKey("iECCapacitorsTypes")]
        public long? TYPEID { get; set; }
        public IECCapacitorsTypes iECCapacitorsTypes { get; set; } = new IECCapacitorsTypes();
        public double? OPERATINGVOLTAGEINV { get; set; }
        public double? RATEDVOLTAGEINV { get; set; }
        public double? AVERAGEACTUALTEMPERATURE { get; set; }
        public double? LAMBDA { get; set; } 
        public double? LAMBDAREF { get; set; }
        public double? UOPDIVEDEURATE { get; set; }
        public double? PIEU { get; set; }
        public double? THETAREF { get; set; }
        public double? THETAOP { get; set; }
        public double? PIET { get; set; }
        public DateTime? CREATEDDATE { get; set; }
        public DateTime? UPDATEDATE { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;
    }
}
