using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECResistorsAndResistorNetworksInterfaceRepo
    {
        Task<List<IECResistorsAndResistorNetworks>> GetIECResistorsAndResistorNetworks();
        Task<List<IECResistorsAndResistorNetworksInputType>> GetIECResistorsAndResistorNetworksInputType();
        Task<List<IECResistorsAndResistorNetworksResponseDto>> ExecuteIECResistorsAndResistorNetworks
          (
              int ResistorType,
              int InputType,
              double OperatingTemperature,
              double ThetaMax,
              double AmbiantTemperature,
              double LambdaRef
          );
        Task<List<IECPreductionResistorsAndResistorNetworksDto>> GetResistorsAndResistorNetworks();
        Task<bool> SaveResistorsAndResistorNetworks(IECPreductionResistorsAndResistorNetworksDto preduction);
        Task<bool> DeleteResistorsAndResistorNetworks(int Trid);
    }
}
