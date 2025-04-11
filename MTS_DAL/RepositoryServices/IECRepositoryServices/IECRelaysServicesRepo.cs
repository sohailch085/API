using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.IEC;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;
using System.IO.Pipelines;

namespace MTS_DAL.RepositoryServices.IECRepositoryServices
{
    public class IECRelaysServicesRepo : IECRelaysInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public IECRelaysServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteRelays(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<IECPredictionRelays>(Trid);
                if (result == null)
                    return false;
                using (var transaction = await _dbcontextRepo.Database.BeginTransactionAsync())
                {
                    try
                    {
                        _dbcontextRepo.Remove(result);
                        await _dbcontextRepo.SaveChangesAsync();
                        await transaction.CommitAsync();
                        return true;
                    }
                    catch
                    {
                        await transaction.RollbackAsync();
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            // throw new NotImplementedException();
        }

        public async Task<List<IECRelaysResponseDto>> ExecuteSPIECRelays(int SupportingConstructionType, int LoadType, int RegionType, double NumberOfOperatingCyclesPerHour, double ReferenceNumberOperatingCyclesPerHour, double AmbientTemperature, double LambdaRef)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<IECRelaysResponseDto>("EXEC procedure_IEC_Relays " + SupportingConstructionType + "," + LoadType + "," + RegionType + "," + NumberOfOperatingCyclesPerHour + "," + ReferenceNumberOperatingCyclesPerHour + "," + AmbientTemperature + "," + LambdaRef + "").ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECConstantsForTemperatureDependenceOfRelays>> GetIECConstantsForTemperatureDependenceOfRelays()
        {
            var result = await _dbcontextRepo.container.IECConstantsForTemperatureDependenceOfRelays.ToListAsync();
            return result;
            // throw new NotImplementedException();
        }

        public async Task<List<IECPreductionRelaysDto>> GetIECPreductionRelays()
        {
            var result = await _dbcontextRepo.container.IECPredictionRelays.ToListAsync();
            var final = result.Select(x => new IECPreductionRelaysDto
            {
                Trid = x.Trid,
                PROJECTID =x.PROJECTID,
                WBS=x.WBS,
                SupportingConstructionType =Convert.ToInt32(x.SupportingConstructionType),
                LoadType=Convert.ToInt32(x.LoadType),
                RegionType =Convert.ToInt32(x.RegionType),
                NumberOfOperatingCyclesPerHour =Convert.ToDouble(x.NumberOfOperatingCyclesPerHour),
                ReferenceNumberOperatingCyclesPerHour= Convert.ToInt32(x.ReferenceNumberOperatingCyclesPerHour),
                AmbientTemperature =Convert.ToDouble(x.AmbientTemperature),
                Lambda = Convert.ToDouble(x.Lambda),
                LambdaRef = Convert.ToDouble(x.LambdaRef),
                PieEs = Convert.ToInt32(x.PieEs),
                PieS = Convert.ToDouble(x.PieS),
                ThetaRef = Convert.ToDouble(x.ThetaRef),
                ThetaOp = Convert.ToDouble(x.ThetaOp),
                PieT = Convert.ToDouble(x.PieT),
                CREATEDDATE = Convert.ToDateTime(x.CREATEDDATE),
                UPDATEDATE = Convert.ToDateTime(x.UPDATEDATE),
                USERIDZU = x.USERIDZU
            }).ToList();
            return final;
           // throw new NotImplementedException();
        }

        public async Task<List<IECRegionType>> GetIECRegionType(int RegionId)
        {
            var result = await _dbcontextRepo.container.IECRegionType.Where(x => x.RegionId == RegionId).ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECRelay>> GetIECRelay()
        {
            var result = await _dbcontextRepo.container.IECRelay.ToListAsync();
            return result;
            // throw new NotImplementedException();
        }

        public async Task<List<IECRelayLoadCategory>> GetIECRelayLoadCategory()
        {
            var result = await _dbcontextRepo.container.IECRelayLoadCategory.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECRelayLoadType>> GetIECRelayLoadType()
        {
            var result = await _dbcontextRepo.container.IECRelayLoadType.ToListAsync();
            return result;
            // throw new NotImplementedException();
        }

        public async Task<bool> SaveRelays(IECPreductionRelaysDto preduction)
        {
            try
            {
                IECPredictionRelays? exists = null;
                if (preduction.Trid != 0)
                {
                    exists = await _dbcontextRepo.FindAsync<IECPredictionRelays>(preduction.Trid);
                }

                if (exists != null)
                {
                    exists.PROJECTID = preduction.PROJECTID;
                    exists.WBS = preduction.WBS;
                    exists.SupportingConstructionType=preduction.SupportingConstructionType;
                    exists.LoadType=preduction.LoadType;
                    exists.RegionType = preduction.RegionType;
                    exists.NumberOfOperatingCyclesPerHour = preduction.NumberOfOperatingCyclesPerHour;
                    exists.ReferenceNumberOperatingCyclesPerHour = preduction.ReferenceNumberOperatingCyclesPerHour;
                    exists.AmbientTemperature = preduction.AmbientTemperature;
                    exists.Lambda = preduction.Lambda;
                    exists.LambdaRef = preduction.LambdaRef;
                    exists.PieEs = preduction.PieEs;
                    exists.PieS = preduction.PieS;
                    exists.ThetaRef = preduction.ThetaRef;
                    exists.ThetaOp = preduction.ThetaOp;
                    exists.PieT = preduction.PieT;
                    exists.USERIDZU = preduction.USERIDZU;
                    exists.UPDATEDATE = DateTime.Now;
                    _dbcontextRepo.Update(exists);
                }
                else
                {
                    IECPredictionRelays newData = new IECPredictionRelays
                    {
                        PROJECTID = preduction.PROJECTID,
                        WBS = preduction.WBS,
                        SupportingConstructionType = preduction.SupportingConstructionType,
                        LoadType = preduction.LoadType,
                        RegionType = preduction.RegionType,
                        NumberOfOperatingCyclesPerHour = preduction.NumberOfOperatingCyclesPerHour,
                        ReferenceNumberOperatingCyclesPerHour = preduction.ReferenceNumberOperatingCyclesPerHour,
                        AmbientTemperature = preduction.AmbientTemperature,
                        Lambda = preduction.Lambda,
                        LambdaRef = preduction.LambdaRef,
                        PieEs = preduction.PieEs,
                        PieS = preduction.PieS,
                        ThetaRef = preduction.ThetaRef,
                        ThetaOp = preduction.ThetaOp,
                        PieT = preduction.PieT,
                        USERIDZU = preduction.USERIDZU,
                        CREATEDDATE = DateTime.Now
                    };
                    _dbcontextRepo.Add(newData);
                }
                await _dbcontextRepo.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            //throw new NotImplementedException();
        }
    }
}
