using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2OptoelectronicDevicesRepositoryServices : R2OptoelectronicDevicesInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2OptoelectronicDevicesRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }
        public async Task<List<R2OptoelectronicDevicesResponseDto>> ExecuteSPR2OptoelectronicDevices(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result =await _dbcontextRepo.Database.SqlQueryRaw<R2OptoelectronicDevicesResponseDto>("EXEC procedure_R2_OPTOELECTRONIC_DEVICES "+ PartType+","+ NoOFYears+","+ TemperatureRise+","+ TemperatureOveride+","+ AmbientTemperatureOperating+","+ AmbientTemperatureNonoperating+","+ DutyCycle+","+ CyclingRate+"").ToListAsync();
            return result;
        }

        public Task<List<R2OptoelectronicDevices>> GetR2OptoelectronicDevices()
        {
            var result = _dbcontextRepo.container.R2OptoelectronicDevices.ToList();
            return Task.FromResult(result);
        }


    }
}
