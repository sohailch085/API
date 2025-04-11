using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo
    {
        Task<List<IECSwitchesAndPushButtonsForLowElectricalStress>> GetIECSwitchesAndPushButtonsForLowElectricalStress();
        Task<List<IECSwitchesAndPushButtonsForLowElectricalStressResponseDto>> ExecuteSPIECSwitchesAndPushButtonsForLowElectricalStress
           (
               int RegionType,
               int LoadType,
               double LambdaRef
           );
        Task<List<IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto>> GetIECPreductionSwitchesAndPushButtonsForLowElectricalStress();
        Task<bool> SaveSwitchesAndPushButtonsForLowElectricalStress(IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto preduction);
        Task<bool> DeleteSwitchesAndPushButtonsForLowElectricalStress(int Trid);
    }
}
