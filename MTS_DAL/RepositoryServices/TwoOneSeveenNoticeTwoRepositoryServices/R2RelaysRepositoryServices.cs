using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2RelaysRepositoryServices : R2RelaysInterfaceRepo
    {
        private readonly DbcontextRepo _dBContext;
        public R2RelaysRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dBContext = dbcontextRepo;
        }

        public Task<List<R2RelaysResponseDto>> ExecuteSPR2Relays(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _dBContext.Database.SqlQueryRaw<R2RelaysResponseDto>("EXEC procedure_R2_RELAYS "+ PartType+","+ NoOFYears+","+ TemperatureRise+","+ TemperatureOveride+","+ AmbientTemperatureOperating+","+ AmbientTemperatureNonoperating+","+ DutyCycle+","+ CyclingRate+"").ToListAsync();
            return result;
        }

        public List<R2Relays> GetR2Relays()
        {
            var result = _dBContext.container.R2Relays.ToList();
            return result;
        }
    }
}
