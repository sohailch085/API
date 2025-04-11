using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;

namespace MTS_DAL.InterfaceRepo
{
    public interface RAMProjectsInterfaceRepo
    {
        Task<bool> DeleteRAMProjects(int Trid);
        bool SaveRAMProject(RAMProjectsCollectionDto projects);
        Task<IList<RAMProjects>> GetRAMProjects();
    }
}
