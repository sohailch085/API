using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2CapacitorInterfaceRepo
    {
        Task<List<R2Capacitor>> GetR2Capacitors();
        Task<List<R2CapacitorResponseDto>> ExecuteSPR2Capacitor
           (
               int PartType,
               double Capacitance,
               double NoOFYears,
               double AppliedVoltage,
               double RatedVoltage,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
    }
}
