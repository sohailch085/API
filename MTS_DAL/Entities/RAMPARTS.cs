using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities
{
    public class RAMPARTS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "varchar(32)")]
        public string REFNUMHA { get; set; } = string.Empty;
        [ForeignKey("RAMCAGE")]
        [Column(TypeName = "varchar(5)")]
        public string? CAGECDXH { get; set; } = string.Empty;
        public RAMCAGE RAMCAGE { get; set; }=new RAMCAGE();
        [Column(TypeName = "varchar(19)")]
        public string? ITNAMEHA { get; set; } = string.Empty;
        [Column(TypeName = "varchar(240)")]
        public string? MATERLHA { get; set; } = string.Empty;
        public DateTime? CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime? UPDATEDATE { get; set; } = DateTime.Now;
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;
    }
}
