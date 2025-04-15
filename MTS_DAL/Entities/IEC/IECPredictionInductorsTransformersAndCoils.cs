using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.Entities.IEC
{
    public class IECPredictionInductorsTransformersAndCoils
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        [ForeignKey("Projects")]
        public long PROJECTID { get; set; }
        public RAMProjects Projects { get; set; } = new RAMProjects();
        [Column(TypeName = "varchar(30)")]
        public string? WBS { get; set; } = string.Empty;
        [ForeignKey("iECInductorsTransformersAndCoilsSubCategory")]
        public int? SubCategoryId { get; set; }
        public IECInductorsTransformersAndCoilsSubCategory iECInductorsTransformersAndCoilsSubCategory = new IECInductorsTransformersAndCoilsSubCategory();
        [ForeignKey("iECInductorsTransformersAndCoilsTypes")]
        public int? TypeId { get; set; }
        public IECInductorsTransformersAndCoilsTypes iECInductorsTransformersAndCoilsTypes { get; set; } = new IECInductorsTransformersAndCoilsTypes();
        public double? DeltaT { get; set; }
        public double? AmbientTemperature { get; set; } 
        public double? Lambda { get; set; }
        public double? LambdaRef { get; set; }
        public double? ThetaOp { get; set; }
        public double? ThetaRef { get; set; }
        public double? PieT { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string USERIDZU { get; set; } = string.Empty;


    }
}
