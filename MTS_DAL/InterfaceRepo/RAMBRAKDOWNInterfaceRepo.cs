using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;

namespace MTS_DAL.InterfaceRepo
{
    public interface RAMBRAKDOWNInterfaceRepo
    {
       Task<List<RAMBRAKDOWN>> GetRambrakdowns();

        bool SaveRambrakdowns(RamBrakdownCollectionDto collectionDto);

        Task<bool> DeleteRambrakdowns(string WBS);

        Task<List<RAMBRAKDOWNPARTS>> GetRAMBRAKDOWNPARTS();

        bool SaveRAMBRAKDOWNPARTS(RambrakdownPartsCollectionDto collectionDto);

        Task<bool> DeleteRAMBRAKDOWNPARTS(string WBS);

    }
}
