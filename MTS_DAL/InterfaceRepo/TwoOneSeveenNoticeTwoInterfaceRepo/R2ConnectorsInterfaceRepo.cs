using MTS_COMMON.ModelDTO.Response;
using MTS_COMMON.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2ConnectorsInterfaceRepo
    {
        List<R2Connectors> GetR2Connectors();
        Task<List<R2ConnectorsResponseDto>> ExecuteSPR2Connectors
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
