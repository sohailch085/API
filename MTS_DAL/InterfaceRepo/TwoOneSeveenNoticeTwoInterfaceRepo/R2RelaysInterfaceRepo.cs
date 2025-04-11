using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2RelaysInterfaceRepo
    {
        List<R2Relays> GetR2Relays();
        Task<List<R2RelaysResponseDto>> ExecuteSPR2Relays
           (
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
    }
}
