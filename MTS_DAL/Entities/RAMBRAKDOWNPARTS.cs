using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.Entities
{
    public class RAMBRAKDOWNPARTS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string PWBS { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string WBS { get; set; } = string.Empty;
        [ForeignKey(nameof(PWBS)+ "," + nameof(WBS))]
        public RAMBRAKDOWN RAMBRAKDOWN { get; set; } = new RAMBRAKDOWN();
        [ForeignKey("RAMProjects")]
        public long PROJECTID { get; set; }
        public RAMProjects RAMProjects { get; set; }=new RAMProjects();
        [Column(TypeName = "varchar(19)")]
        public string? ITNAMEHA { get; set; } = string.Empty;
        [Column(TypeName = "varchar(18)")]
        public string? LSACONXB { get; set; } = string.Empty;
        [Column(TypeName = "varchar(2)")]
        public string? ALTLCNXB { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string? CAGECDXH { get; set; } = string.Empty;
        [Column(TypeName = "varchar(32)")]
        public string? REFNUMHA { get; set; } = string.Empty;
        [Column(TypeName = "varchar(4)")]
        public string? QTYASYHG { get; set; } = string.Empty;
        [Column(TypeName = "varchar(64)")]
        public string? REFDESHJ { get; set; } = string.Empty;
        public string? DESCRIPTION { get; set; } = string.Empty;
        public long? CALMETHODID { get; set; }
        public long? CATEGORYID { get; set; }
        public long? SUBCATEGORYID { get; set; }
        public long? TYPESID { get; set; }
        [Column(TypeName = "real")]
        public double? FAILURERATECALCULATED { get; set; }
        public double? FAILURERATE { get; set; }
        public double? FAILURERATEPERCENTAGE { get; set; }
        [Column(TypeName = "real")]
        public double? FRContribution { get; set; }
        public bool? FAILURERATEOVERIDE { get; set; }
        public double? MTBF { get; set; }
        public int? FLAGID { get; set; }
        public DateTime? CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime? UPDATEDATE { get; set; } = DateTime.Now;
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;

    }
}
