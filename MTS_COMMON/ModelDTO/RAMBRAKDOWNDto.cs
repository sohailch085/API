using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO
{
    public class RAMBRAKDOWNDto
    {
        public string PWBS { get; set; } = string.Empty;
        public string WBS { get; set; } = string.Empty;
        public long PROJECTID { get; set; }
        public string LCNAMEXB { get; set; } = string.Empty;
        public string LSACONXB { get; set; } = string.Empty;
        public string ALTLCNXB { get; set; } = string.Empty;
        public string CAGECDXH { get; set; } = string.Empty;
        public string REFNUMHA { get; set; } = string.Empty;
        public string QTYASYHG { get; set; } = string.Empty;
        public string REFDESHJ { get; set; } = string.Empty;
        public string DESCRIPTION { get; set; } = string.Empty;
        public long CALMETHOD { get; set; }
        public double FAILURERATE { get; set; }
        public double FAILURERATEPERCENTAGE { get; set; }
        public bool FAILURERATEOVERIDE { get; set; }
        public double MTBF { get; set; }
        public DateTime CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime UPDATEDATE { get; set; } = DateTime.Now;
        public string USERIDZU { get; set; } = string.Empty;
    }
}
