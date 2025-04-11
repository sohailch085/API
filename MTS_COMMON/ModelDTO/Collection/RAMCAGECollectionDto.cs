using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO.Collection
{
    public class RAMCAGECollectionDto
    {
        public string CAGECDXH { get; set; } = string.Empty;
        public string CANAMEXH { get; set; } = string.Empty;
        public string CASTREXH { get; set; } = string.Empty;
        public string CACITYXH { get; set; } = string.Empty;
        public string CASTATXH { get; set; } = string.Empty;
        public string CANATNXH { get; set; } = string.Empty;
        public string CAPOZOXH { get; set; } = string.Empty;
        public DateTime CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime UPDATEDATE { get; set; } = DateTime.Now;
        public string USERIDZU { get; set; } = string.Empty;
    }
}
