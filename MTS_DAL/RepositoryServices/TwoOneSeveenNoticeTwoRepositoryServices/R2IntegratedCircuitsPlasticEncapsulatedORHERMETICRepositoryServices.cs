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
    public class R2IntegratedCircuitsPlasticEncapsulatedORHERMETICRepositoryServices : R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public R2IntegratedCircuitsPlasticEncapsulatedORHERMETICRepositoryServices(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<List<R2IntegratedCircuitsPlasticEncapsulatedORHermeticResponseDto>> ExecuteSPR2EncapsulatedORHermetic(int PackageType, int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double RelativeHumidity, double DutyCycle, double CyclingRate)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<R2IntegratedCircuitsPlasticEncapsulatedORHermeticResponseDto>("EXEC procedure_R2_Integrated_Circuits_Plastic_Encapsulated_OR_HERMETIC " 
                + PackageType + "," + PartType + "," + NoOFYears + "," + TemperatureRise + "," + TemperatureOveride + "," + AmbientTemperatureOperating + "," + AmbientTemperatureNonoperating + "," + RelativeHumidity + "," + DutyCycle + "," + CyclingRate + "").ToListAsync();
            return result;
        }

        public Task<List<R2IntegratedCircuitsPlasticEncapsulatedPackageType>> GetR2IntegratedCircuitsPlasticEncapsulatedPackageType()
        {
            var result = _dbcontextRepo.container.R2IntegratedCircuitsPlasticEncapsulatedPackageType.ToList();
            return Task.FromResult(result);
        }

        public Task<List<R2IntegratedCircuitsPlasticEncapsulatedPartType>> GetR2IntegratedCircuitsPlasticEncapsulatedPartType(int PackageTypeId)
        {
            var result = _dbcontextRepo.container.R2IntegratedCircuitsPlasticEncapsulatedPartType.Where(x => x.PackageTypeId == PackageTypeId).ToList();
            return Task.FromResult(result);
        }
    }
}
