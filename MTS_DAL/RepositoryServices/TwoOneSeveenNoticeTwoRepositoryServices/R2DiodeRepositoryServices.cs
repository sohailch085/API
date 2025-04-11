using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2DiodeRepositoryServices : R2DiodeInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2DiodeRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }
        public async Task<List<R2DiodeResponseDto>> ExecuteSPR2Diode(int PartType, double NoOFYears, double AppliedVoltage, double RatedVoltage, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<R2DiodeResponseDto>("EXEC procedure_R2_DIODE " + PartType + "," + NoOFYears + "," + AppliedVoltage + "," + RatedVoltage + "," + TemperatureRise + "," + TemperatureOveride + "," + AmbientTemperatureOperating + "," + AmbientTemperatureNonoperating + "," + DutyCycle + "," + CyclingRate + "").ToListAsync();
            return result;
        }

        public async Task<List<R2DiodeDto>> GetR2Diode()
        {
            var result = await _dbcontextRepo.container.R2Diode.ToListAsync();
            var final = result.Select(x=> new R2DiodeDto { Trid=x.Trid,PartType=x.PartType }).ToList();
            return final;
        }
    }
}
