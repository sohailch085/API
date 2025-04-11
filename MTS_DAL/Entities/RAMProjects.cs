using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTS_DAL.Entities
{
    public class RAMProjects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PROJECTID { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string? EIACODXA { get; set; } = string.Empty;
        [Column(TypeName = "char(1)")]
        public string? LCNTYPXB { get; set; } = string.Empty;
        [ForeignKey("productTypes")]
        public long? TYPEOFPRODUCTID { get; set; }
        public ProductTypes productTypes { get; set; } = new ProductTypes();
        [ForeignKey("lifecyclephases")]
        public long? LIFECYCLEPHASEID { get; set; }
        public Lifecyclephases lifecyclephases { get; set; } = new Lifecyclephases();
        [Required]
        public string PROJECTNAME { get; set; } = string.Empty;
        public float? OPRLIFXA { get; set; }
        public string? DESCRIPTION { get; set; } = string.Empty;
        public string? REMARKS { get; set; } = string.Empty;
        public DateTime? PROGRAMSTARTDATE { get; set; } = DateTime.Now;
        public DateTime? PROGRAMENDDATE { get; set; } = DateTime.Now;
        public DateTime? CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime? UPDATEDATE { get; set; } = DateTime.Now;
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;
    }
}
