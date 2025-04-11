using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.InterfaceRepo
{
    public interface RAMCAGEInterfaceRepo
    {
        IList<RAMCAGE> GetRAMCAGE();
        bool SaveRAMCAGE(RAMCAGECollectionDto ramCAGE);
       Task<bool> DeleteRAMCAGE(string CAGECDXH);

        IList<RAMPARTS> GetRAMPARTS();
        bool SaveRAMPARTS(RAMPARTSCollectionDto rampart);
        Task<bool> DeleteRAMPARTS(string REFNUMHA);
    }
}
