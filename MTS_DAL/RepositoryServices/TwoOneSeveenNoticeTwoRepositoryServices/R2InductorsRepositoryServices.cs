using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2InductorsRepositoryServices : R2InductorsInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2InductorsRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }
        public async Task<List<R2InductorsResponseDto>> ExecuteSPR2Inductors(int PartType, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<R2InductorsResponseDto>("EXEC procedure_R2_Inductors " + PartType + "," + AmbientTemperatureOperating + "," + AmbientTemperatureNonoperating + "," + DutyCycle + "," + CyclingRate + "").ToListAsync();
            return result;
        }

        public Task<List<R2Inductors>> GetR2Inductors()
        {
            var result =  _dbcontextRepo.container.R2Inductors.ToListAsync();
            return result;
        }
    }
}
