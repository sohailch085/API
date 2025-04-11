using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoInterfaceRepo
{
    public class R2CapacitorRepositoryServices : R2CapacitorInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2CapacitorRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<List<R2CapacitorResponseDto>> ExecuteSPR2Capacitor(int PartType, double Capacitance, double NoOFYears, double AppliedVoltage, double RatedVoltage, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<R2CapacitorResponseDto>("EXEC procedure_R2_CAPACITORS " + PartType + "," + Capacitance + "," + NoOFYears + "," + AppliedVoltage + "," + RatedVoltage + "," + TemperatureRise + "," + TemperatureOveride + "," + AmbientTemperatureOperating + "," + AmbientTemperatureNonoperating + "," + DutyCycle + "," + CyclingRate + "").ToListAsync();
            return result;
        }

        public async Task<List<R2Capacitor>> GetR2Capacitors()
        {
             var result = await _dbcontextRepo.container.R2Capacitor.ToListAsync();
            return result;
        }
    }
}
