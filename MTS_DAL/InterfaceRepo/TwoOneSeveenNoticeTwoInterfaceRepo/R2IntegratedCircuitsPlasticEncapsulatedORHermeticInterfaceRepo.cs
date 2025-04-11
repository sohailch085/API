using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo
    {
        Task<List<R2IntegratedCircuitsPlasticEncapsulatedPackageType>> GetR2IntegratedCircuitsPlasticEncapsulatedPackageType();
        Task<List<R2IntegratedCircuitsPlasticEncapsulatedPartType>> GetR2IntegratedCircuitsPlasticEncapsulatedPartType(int PackageTypeId);
        Task<List<R2IntegratedCircuitsPlasticEncapsulatedORHermeticResponseDto>> ExecuteSPR2EncapsulatedORHermetic
           (
               int PackageType,
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double RelativeHumidity,
               double DutyCycle,
               double CyclingRate
           );
    }
}
