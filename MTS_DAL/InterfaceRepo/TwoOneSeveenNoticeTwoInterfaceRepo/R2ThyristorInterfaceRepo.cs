using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2ThyristorInterfaceRepo
    {
        List<R2Thyristor> GetR2Thyristor();
        Task<List<R2ThyristorResponseDto>> ExecuteSPR2Thyristor
           (
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate,
               double AppliedVoltage,
               double RatedVoltage
           );
    }
}
