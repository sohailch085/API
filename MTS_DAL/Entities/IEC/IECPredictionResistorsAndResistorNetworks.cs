using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.Entities.IEC
{
    public class IECPredictionResistorsAndResistorNetworks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        [ForeignKey("Projects")]
        public long PROJECTID { get; set; }
        public RAMProjects Projects { get; set; } = new RAMProjects();
        [Column(TypeName = "varchar(30)")]
        public string? WBS { get; set; } = string.Empty;
        [ForeignKey ("iECResistorsAndResistor")]
        public int? ResistorType { get; set; }
        public IECResistorsAndResistorNetworks iECResistorsAndResistor { get; set; } = new IECResistorsAndResistorNetworks();
        [ForeignKey("eCResistorsAndResistorNetworksInputType")]
        public int? InputType { get; set; }
        public IECResistorsAndResistorNetworksInputType eCResistorsAndResistorNetworksInputType { get; set; } = new IECResistorsAndResistorNetworksInputType();
        public double? OperatingTemperature { get; set; }
        public double? ThetaMax { get; set; }
        public double? AmbiantTemperature { get; set; }
        public double? Lambda { get; set; }
        public double? LambdaRef { get; set; }
        public double? ThetaRef { get; set; }
        public double? ThetaOp { get; set; }
        public double? PieT { get; set; }
        public DateTime? CREATEDDATE { get; set; }
        public DateTime? UPDATEDATE { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;
    }
}
