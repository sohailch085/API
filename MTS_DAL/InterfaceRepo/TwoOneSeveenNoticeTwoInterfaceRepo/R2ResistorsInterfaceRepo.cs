using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2ResistorsInterfaceRepo
    {
        List<R2Resistors> GetR2Resistors();
        Task<List<R2ResistorsResponseDto>> ExecuteSPR2Resistors
           (
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate,
               double PowerRate
           );
    }
}
