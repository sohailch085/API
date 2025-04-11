using MTS_COMMON.ModelDTO.Response;
using MTS_COMMON.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public interface R2DiodeInterfaceRepo
    {
        Task<List<R2DiodeDto>> GetR2Diode();
        Task<List<R2DiodeResponseDto>> ExecuteSPR2Diode
           (
               int PartType,
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
