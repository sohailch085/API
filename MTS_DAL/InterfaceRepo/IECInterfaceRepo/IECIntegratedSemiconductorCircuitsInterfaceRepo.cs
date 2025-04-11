using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECIntegratedSemiconductorCircuitsInterfaceRepo
    {
        Task<List<IECTypeComponent>> GetIECTypeComponent();
        Task<List<IECTypeComponentSubCategory>> GetIECTypeComponentSubCategory(int SubCategoryId);
        Task<List<IECConstantForVoltageDependence>> GetIECConstantForVoltageDependence();
        Task<List<IECConstantsForTemperatureDependence>> GetIECConstantsForTemperatureDependence();
        Task<List<IECIntegratedSemiconductorCircuitsResponseDto>> ExecuteSpIECIntegratedSemiconductorCircuits(
            int CircuitType,
            int SubComponent,
            int ConstantsType,
            double OperatingVoltageInV,
            double RatedVoltageInV,
            double OperatingFrequencyMHz,
            double MaximumOperatingFrequencyMHz,
            double WorstCasePowerDissipationAtTheMaximumFrequencyW,
            double MaximumSupplyCurrentA,
            double NominalVoltage,
            double ThermalResistance,
            double AmbientTemperature,
            double LambdaRef);
        Task<List<IECPreductionIntegratedSemiconductorCircuitsDto>> GetPreductionIntegratedSemiconductorCircuits();
        Task<bool> SaveIntegratedSemiconductorCircuits(IECPreductionIntegratedSemiconductorCircuitsDto preduction);
        Task<bool> DeleteIntegratedSemiconductorCircuits(int Trid);
        //  Task SaveDiscreteSemiconductors(IECDiscreteSemiconductorsCollectionDto preductionsemiconductors);
    }
}
