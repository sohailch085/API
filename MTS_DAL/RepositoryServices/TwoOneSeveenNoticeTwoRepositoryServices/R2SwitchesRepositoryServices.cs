using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2SwitchesRepositoryServices : R2SwitchesInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2SwitchesRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public Task<List<R2SwitchesResponseDto>> ExecuteSPR2Switches(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _dbcontextRepo.Database.SqlQueryRaw<R2SwitchesResponseDto>("EXEC procedure_R2_SWITCHES " + PartType + "," + NoOFYears + "," + TemperatureRise + "," + TemperatureOveride + "," + AmbientTemperatureOperating + "," + AmbientTemperatureNonoperating + "," + DutyCycle + "," + CyclingRate + "").ToListAsync();
            return result;
        }

        public Task<List<R2Switches>> GetR2Switches()
        {
            var result = _dbcontextRepo.container.R2Switches.ToListAsync();
            return result;
        }
    }
}
