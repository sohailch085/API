using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities.TwoOneSeveenNoticeTwo
{
    public class R2IntegratedCircuitsPlasticEncapsulatedPackageType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string PackageType { get; set; } = string.Empty;

    }
}
