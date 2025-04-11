using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECRelaysInterfaceRepo
    {
        Task<List<IECConstantsForTemperatureDependenceOfRelays>> GetIECConstantsForTemperatureDependenceOfRelays();
        Task<List<IECRelay>> GetIECRelay();
        Task<List<IECRegionType>> GetIECRegionType(int RegionId);
        Task<List<IECRelayLoadType>> GetIECRelayLoadType();
        Task<List<IECRelayLoadCategory>> GetIECRelayLoadCategory();
        Task<List<IECRelaysResponseDto>> ExecuteSPIECRelays
            (
                int SupportingConstructionType,
                int LoadType,
                int RegionType,
                double NumberOfOperatingCyclesPerHour,
                double ReferenceNumberOperatingCyclesPerHour,
                double AmbientTemperature,
                double LambdaRef
            );
        Task<List<IECPreductionRelaysDto>> GetIECPreductionRelays();
        Task<bool> SaveRelays(IECPreductionRelaysDto preduction);
        Task<bool> DeleteRelays(int Trid);
    }
}
