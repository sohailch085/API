using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities
{
    public class RAMBRAKDOWN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "varchar(30)")]
        public string PWBS { get; set; } = string.Empty;
        [Key]
        [Column(TypeName = "varchar(30)")]
        public string WBS { get; set; } = string.Empty;
        [ForeignKey("RAMProjects")]
        public long PROJECTID { get; set; }
        public RAMProjects RAMProjects { get; set; } = new RAMProjects();
        [Column(TypeName = "varchar(19)")]
        public string? LCNAMEXB { get; set; } = string.Empty;
        [Column(TypeName = "varchar(18)")]
        public string? LSACONXB { get; set; } = string.Empty;
        [Column(TypeName = "varchar(2)")]
        public string? ALTLCNXB { get; set; } = string.Empty;
        [Column(TypeName = "varchar(5)")]
        public string? CAGECDXH { get; set; } = string.Empty;
        [Column(TypeName = "varchar(32)")]
        public string? REFNUMHA { get; set; } = string.Empty;
        [Column(TypeName = "varchar(4)")]
        public string QTYASYHG { get; set; } = "1";
        [Column(TypeName = "varchar(64)")]
        public string? REFDESHJ { get; set; } = string.Empty;
        [Column(TypeName ="nvarchar(max)")]
        public string? DESCRIPTION { get; set; } = string.Empty;
        [Column (TypeName ="int")]
        public int? ENVIRONMENTID { get; set; }
        [Column (TypeName ="real")]
        public double? AMBIENTOPERATINGTEMPERATURE { get; set; }
        [Column (TypeName ="real")]
        public double? AMBIENTNONOPERATINGTEMPERATURE { get; set; }
        [Column(TypeName = "real")]
        public double? RELATIVEHUMIDITY { get; set; }
        [Column (TypeName ="real")]
        public double? VIBRATION { get; set; }
        [Column(TypeName = "INT")]
        public int? EQUIPMENTTYPEID { get; set; }
        [Column (TypeName ="real")]
        public double? DUTYCYCLE { get; set; }
        [Column(TypeName = "real")]
        public double? CYCLERATE { get; set; }
        [Column(TypeName = "real")]
        public double? FAILURERATE { get; set; }
        [Column(TypeName = "real")]
        public double? FAILURERATECALCULATED { get; set; }
        [Column(TypeName = "real")]
        public double? FAILURERATEPERCENTAGE { get; set; }
        [Column(TypeName = "real")]
        public double? FRContribution { get; set; } 
        [Column(TypeName = "bit")]
        public bool? FAILURERATEOVERIDE { get; set; }
        [Column(TypeName = "real")]
        public double? MTBF { get; set; }
        public int? FLAGID { get; set; }
        public DateTime? CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime? UPDATEDATE { get; set; } = DateTime.Now;
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;

        public ICollection<RAMBRAKDOWNPARTS> RAMBRAKDOWNPARTS { get; set; } = new List<RAMBRAKDOWNPARTS>();
    }
}
