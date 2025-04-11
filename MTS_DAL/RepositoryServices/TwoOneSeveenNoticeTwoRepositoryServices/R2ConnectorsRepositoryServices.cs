using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices
{
    public class R2ConnectorsRepositoryServices : R2ConnectorsInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2ConnectorsRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }
        public List<R2Connectors> GetR2Connectors()
        {
            var result = _dbcontextRepo.container.R2Connectors.ToList();
            return result;
        }

        public Task<List<R2ConnectorsResponseDto>> ExecuteSPR2Connectors(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _dbcontextRepo.Database.SqlQueryRaw<R2ConnectorsResponseDto>("EXEC procedure_R2_CONNECTORS " + PartType + "," + NoOFYears + "," + TemperatureRise + "," + TemperatureOveride + "," + AmbientTemperatureOperating + "," + AmbientTemperatureNonoperating + "," + DutyCycle + "," + CyclingRate + "").ToList();
            return Task.FromResult(result);
        }
    }
}
