using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECOptoelectronicComponentsInterfaceRepo
    {
        List<IECConstantsForTemperatureDependenceOfOptoelectronicComponents> GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents();
        List<IECOptoelectronicComponents> GetIECOptoelectronicComponents();
        Task<List<IECOptoelectronicComponentsSubCategory>> GetIECOptoelectronicComponentsSubCategory(int SubCategoryId);
        List<IECPredictionOptoelectronicComponent> GetPreductionOptoelectronicComponents();
        Task<List<IECOptoelectronicComponentsResponseDto>> ExecuteIECOptoelectronicComponents
           (
               int OptoelectronicTypes,
               int OptoelectronicComponentsSubCategory,
               int ConstantsType,
               double OperatingVoltageInV,
               double ReferenceVoltageInV,
               double RatedVoltageInV,
               double OperatingFrequencyMHz,
               double MaximumOperatingFrequencyMHz,
               double WorstCasePowerDissipationAtMaximumFrequencyW,
               double MaximumSupplyCurrentA,
               double NominalVoltage,
               double ThermalResistance,
               double AmbientTemperature,
               double LambdaRef
           );
        Task<bool> SaveOptoelectronicComponent(IECPreductionOptoelectronicComponentDto OptoelectronicComponent);
        Task<bool> DeleteOptoelectronicComponent(int Trid);
    }
}
