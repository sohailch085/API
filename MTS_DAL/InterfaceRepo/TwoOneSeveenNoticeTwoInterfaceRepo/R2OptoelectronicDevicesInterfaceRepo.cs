using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2OptoelectronicDevicesInterfaceRepo
    {
        Task<List<R2OptoelectronicDevices>> GetR2OptoelectronicDevices();
        Task<List<R2OptoelectronicDevicesResponseDto>> ExecuteSPR2OptoelectronicDevices
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
