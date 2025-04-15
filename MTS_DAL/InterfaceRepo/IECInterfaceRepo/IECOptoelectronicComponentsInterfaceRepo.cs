using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECOptoelectronicComponentsInterfaceRepo
    {
        List<IECConstantsForTemperatureDependenceOfOptoelectronicComponents> GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents();
        List<IECOptoelectronicComponentsTypes> GetIECOptoelectronicComponentsTypes(int SubCategoryId);
        Task<List<IECOptoelectronicComponentsSubCategory>> GetIECOptoelectronicComponentsSubCategory();
        List<IECPredictionOptoelectronicComponent> GetPreductionOptoelectronicComponents();
        Task<List<IECOptoelectronicComponentsResponseDto>> ExecuteIECOptoelectronicComponents
           (
               int TypesId,
               int SubCategoryId,
               double OperatingVoltageInV,
               double ReferenceVoltageInV,
               double RatedVoltageInV,
               double Fop,
               double Fmax,
               double Pfwc,
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
