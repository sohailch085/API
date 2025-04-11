using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2SwitchesInterfaceRepo
    {
        Task<List<R2Switches>> GetR2Switches();
        Task<List<R2SwitchesResponseDto>> ExecuteSPR2Switches
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
