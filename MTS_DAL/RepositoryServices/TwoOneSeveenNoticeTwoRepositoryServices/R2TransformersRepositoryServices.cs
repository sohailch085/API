using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2TransformersRepositoryServices : R2TransformersInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2TransformersRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }
        public Task<List<R2TransformersResponseDto>> ExecuteSPR2Transformers(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result =  _dbcontextRepo.Database.SqlQueryRaw<R2TransformersResponseDto>("EXEC procedure_R2_TRANSFORMERS " + PartType+","+ NoOFYears+","+ TemperatureRise+","+ TemperatureOveride+","+ AmbientTemperatureOperating+","+ AmbientTemperatureNonoperating+","+ DutyCycle+","+ CyclingRate+"").ToListAsync();
            return result;
        }

        public Task<List<R2Transformers>> GetR2Transformers()
        {
            var result = _dbcontextRepo.container.R2Transformers.ToListAsync();
            return result;
        }
    }
}
