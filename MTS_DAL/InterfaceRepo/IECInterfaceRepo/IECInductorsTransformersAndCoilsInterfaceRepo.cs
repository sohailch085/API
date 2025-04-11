using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECInductorsTransformersAndCoilsInterfaceRepo
    {
        List<IECInductorsTransformersAndCoils> GetIECInductorsTransformersAndCoils();
        Task<List<IECPredictionInductorsTransformersAndCoils>> GetIECPreductionInductorsTransformersAndCoils();

        Task<List<IECInductorsTransformersAndCoilsResponseDto>> ExecuteSPIECInductorsTransformersAndCoils
            (
                int TransformersType,
                double OperatingFrequencyMHz,
                double MaximumOperatingFrequencyMHz,
                double WorstCasePowerDissipationAtMaximumFrequencyW,
                double MaximumSupplyCurrentA,
                double NominalVoltage,
                double ThermalResistance,
                double AmbientTemperature,
                double LambdaRef
            );

        Task<bool> SaveInductorsTransformersAndCoils(IECPreductionInductorsTransformersAndCoilsDto preduction);
        Task<bool> DeleteInductorsTransformersAndCoils(int Trid);
    }
}
