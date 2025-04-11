using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.InterfaceRepo
{
    public interface LifecyclephasesInterfaceRepo
    {
        IList<Lifecyclephases> GetLifecyclephases();
        bool SaveLifecyclephases(LifecyclephasesCollectionDto Lifecyclephases);
        Task<bool> DeleteLifecyclephases(int Trid);
    }
}
