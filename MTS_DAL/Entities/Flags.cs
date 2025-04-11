using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.Entities
{
    public class Flags
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlagID { get; set; }
        public string FlagColor { get; set; } = string.Empty;
        [Column (TypeName ="nvarchar(250)")]
        public string? Description { get; set; } = string.Empty;
        public string FlagPath { get; set; } = string.Empty; 
    }
}
