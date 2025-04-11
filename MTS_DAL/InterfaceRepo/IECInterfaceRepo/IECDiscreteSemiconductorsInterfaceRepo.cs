using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECDiscreteSemiconductorsInterfaceRepo
    {
        Task<List<IECDiscreteSemiconductorsCollectionDto>> GetPreductionDiscreteSemiconductors();
        Task<bool> SaveDiscreteSemiconductors(IECDiscreteSemiconductorsCollectionDto preductionsemiconductors);
        Task<bool> DeleteDiscreteSemiconductors(int Trid);
      //  List<IECConstantsForTemperatureDependenceOfDiscreteSemiconductors> GetIECConstantsForTemperatureDependenceOfDiscreteSemiconductors();
        List<IECDiscreteSemiconductors> GetIECDiscreteSemiconductors();
        Task<List<IECDiscreteSemiconductorsSubcategory>> GetIECDiscreteSemiconductorsSubcategory(int SUBCATEGORYID);
        Task<List<SemiconductorResponseDto>> ExecuteIECDiscreteSemiconductors
           (
               int SUBCATEGORYID,
               int TYPESID,
               double RatedVoltageInV,
               double NominalVoltage,
               double ThermalResistance,
               double AmbientTemperature,
               double MaximumSupplyCurrentA,
               double WorstCasePowerDissipationAtMaximumFrequencyW,
               double OperatingFrequencyMHz,
               double MaximumOperatingFrequencyMHz,
               double OperatingVoltageInV,
               double LambdaRef
           );
    }
}
