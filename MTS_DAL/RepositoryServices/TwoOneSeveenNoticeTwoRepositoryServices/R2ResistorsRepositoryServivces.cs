using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2ResistorsRepositoryServivces : R2ResistorsInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2ResistorsRepositoryServivces(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo=dbcontextRepo;
        }
        public Task<List<R2ResistorsResponseDto>> ExecuteSPR2Resistors(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate, double PowerRate)
        {
            var result = _dbcontextRepo.Database.SqlQueryRaw<R2ResistorsResponseDto>("EXEC procedure_R2_RESISTORS " + PartType + "," + NoOFYears + "," + TemperatureRise + "," + TemperatureOveride + "," + AmbientTemperatureOperating + "," + AmbientTemperatureNonoperating + "," + DutyCycle + "," + CyclingRate + "," + PowerRate + "").ToList();
            return Task.FromResult(result);
        }

        public List<R2Resistors> GetR2Resistors()
        {
            var result = _dbcontextRepo.container.R2Resistors.ToList();
            return result;
        }
    }
}
