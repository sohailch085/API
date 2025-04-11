using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{

    public interface IECCapacitorsInterfaceRepo
    {
        Task<bool> SaveCapacitor(IECPreductionCapacitorCollectionDto preductionCapacitors);
        Task<bool> DeleteCapacitor(long Trid);
       Task<List<IECPreductionCapacitorCollectionDto>> GetIECPreductionCapacitor();
        Task<List<IECCapacitorsSubCategory>> GetIECCapacitors();
        Task<List<IECCapacitorsTypes>> GetIECCapacitorsTypes(int CATEGORYID);
        Task<List<IECCapacitorResponseDto>> ExecuteStoredProcedure
            (
                int SUBCATEGORYID,
                int TYPEID,
                double OPERATINGVOLTAGEINV,
                double RATEDVOLTAGEINV,
                double AVERAGEACTUALTEMPERATURE,
                double LAMBDAREF
            );
    }
}
