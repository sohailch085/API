using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO
{
  public  class IECPreductionOptoelectronicComponentDto
    {
        public long Trid { get; set; } = 0;
        public long PROJECTid { get; set; }
        public string WBS { get; set; } = string.Empty;
        public int TypesId { get; set; }
        public int SubCategoryId { get; set; }
        public int ConstantsTypeId { get; set; }
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
        public double Lambda { get; set; }
        public double LambdaRef { get; set; }
        public double UOpDivURat { get; set; }
        public double PieU { get; set; }
        public double PieI { get; set; }
        public double ThetaRef { get; set; }
        public double ThetaOp { get; set; }
        public double PieT { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public DateTime UPDATEDATE { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;
    }
}
