using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2InductorsInterfaceRepo
    {
        Task<List<R2Inductors>> GetR2Inductors();
        Task<List<R2InductorsResponseDto>> ExecuteSPR2Inductors
           (
               int PartType,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
    }
}
