using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MTS_COMMON.ModelDTO.Collection
{
    public class IECPreductionCapacitorCollectionDto
    {
        public long Trid { get; set; } = 0;
        public long PROJECTID { get; set; }
        public string WBS { get; set; } = string.Empty;
        public long SUBCATEGORYID { get; set; }
        public long TYPEID { get; set; }
        public double OPERATINGVOLTAGEINV { get; set; }
        public double RATEDVOLTAGEINV { get; set; }
        public double AVERAGEACTUALTEMPERATURE { get; set; }
        public double LAMBDA { get; set; }
        public double LAMBDAREF { get; set; }
        public double UOPDIVEDEURATE { get; set; }
        public double PIEU { get; set; }
        public double THETAREF { get; set; }
        public double THETAOP { get; set; }
        public double PIET { get; set; }
        public DateTime CREATEDDATE { get; set; } 
        public DateTime UPDATEDATE { get; set; } 
        public string USERIDZU { get; set; } = string.Empty;
    }
}
