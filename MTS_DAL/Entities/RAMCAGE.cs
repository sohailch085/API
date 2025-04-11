using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities
{
    public class RAMCAGE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "varchar(5)")]
        public string CAGECDXH { get; set; } = string.Empty;
        [Column(TypeName = "varchar(25)")]
        public string? CANAMEXH { get; set; } = string.Empty;
        [Column(TypeName = "varchar(25)")]
        public string? CASTREXH { get; set; } = string.Empty;
        [Column(TypeName = "varchar(20)")]
        public string? CACITYXH { get; set; } = string.Empty;
        [Column(TypeName = "varchar(2)")]
        public string? CASTATXH { get; set; } = string.Empty;
        [Column(TypeName = "varchar(20)")]
        public string? CANATNXH { get; set; } = string.Empty;
        [Column(TypeName = "varchar(10)")]
        public string? CAPOZOXH { get; set; } = string.Empty;
        public DateTime? CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime? UPDATEDATE { get; set; } = DateTime.Now;
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;
    }
}
