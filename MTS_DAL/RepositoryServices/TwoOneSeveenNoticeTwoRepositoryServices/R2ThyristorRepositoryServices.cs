using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2ThyristorRepositoryServices : R2ThyristorInterfaceRepo
    {
        private readonly DbcontextRepo _dBContext;
        public R2ThyristorRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dBContext = dbcontextRepo;
        }
        public Task<List<R2ThyristorResponseDto>> ExecuteSPR2Thyristor(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate, double AppliedVoltage, double RatedVoltage)
        {
            var result = _dBContext.Database.SqlQueryRaw<R2ThyristorResponseDto>("EXEC procedure_R2_Thyristor " + PartType + "," + NoOFYears + "," + TemperatureRise + "," + TemperatureOveride + "," + AmbientTemperatureOperating + "," + AmbientTemperatureNonoperating + "," + DutyCycle + "," + CyclingRate + "," + AppliedVoltage + "," + RatedVoltage + "").ToListAsync();
            return result;
           // throw new NotImplementedException();
        }

        public List<R2Thyristor> GetR2Thyristor()
        {
            var result = _dBContext.container.R2Thyristor.ToList();
            return result;
            //throw new NotImplementedException();
        }
    }
}
