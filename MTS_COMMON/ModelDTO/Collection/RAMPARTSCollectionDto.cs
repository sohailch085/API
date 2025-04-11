using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO.Collection
{
    public class RAMPARTSCollectionDto
    {
        public string REFNUMHA { get; set; } = string.Empty;
        public string CAGECDXH { get; set; } = string.Empty;
        public string ITNAMEHA { get; set; } = string.Empty;
        public string MATERLHA { get; set; } = string.Empty;
        public DateTime CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime UPDATEDATE { get; set; } = DateTime.Now;
        public string USERIDZU { get; set; } = string.Empty;
    }
}
