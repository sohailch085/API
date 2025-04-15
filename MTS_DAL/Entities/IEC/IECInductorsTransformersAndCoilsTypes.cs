using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.Entities.IEC
{
    public class IECInductorsTransformersAndCoilsTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public IECInductorsTransformersAndCoilsSubCategory SubCategory { get; set; } = new IECInductorsTransformersAndCoilsSubCategory();

        public float ThetaRef { get; set; }
     
    }
}
