using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.IEC;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;

namespace MTS_DAL.RepositoryServices.IECRepositoryServices
{
    public class IECCapacitorsServicesRepo : IECCapacitorsInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public IECCapacitorsServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteCapacitor(long Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<IECPredictionCapacitor>(Trid);
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
        }

        public async Task<List<IECCapacitorResponseDto>> ExecuteStoredProcedure(int SUBCATEGORYID, int TYPEID, double OPERATINGVOLTAGEINV, double RATEDVOLTAGEINV, double AVERAGEACTUALTEMPERATURE, double LAMBDAREF)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<IECCapacitorResponseDto>("EXEC procedure_IEC_Capacitors " + SUBCATEGORYID + "," + TYPEID + "," + OPERATINGVOLTAGEINV + "," + RATEDVOLTAGEINV + "," + AVERAGEACTUALTEMPERATURE + "," + LAMBDAREF + "").ToListAsync();

            return result;
        }

        public async Task<List<IECCapacitorsSubCategory>> GetIECCapacitors()
        {
            var result = await _dbcontextRepo.container.IECCapacitorsSubCategory.ToListAsync();
            return result;
        }

        public async Task<List<IECCapacitorsTypes>> GetIECCapacitorsTypes(int CATEGORYID)
        {
            var result = await _dbcontextRepo.container.IECCapacitorsTypes.Where(x => x.CATEGORYID == CATEGORYID).ToListAsync();
            return result;
        }

        public async Task<List<IECPreductionCapacitorCollectionDto>> GetIECPreductionCapacitor()
        {
            var result =await _dbcontextRepo.container.IECPredictionCapacitor.ToListAsync();
            var final = result.Select(c => new IECPreductionCapacitorCollectionDto 
            {
                Trid = c.Trid,
                PROJECTID = c.PROJECTID,
                WBS = c.WBS ?? string.Empty,
                SUBCATEGORYID = Convert.ToInt32(c.SUBCATEGORYID),
                TYPEID = Convert.ToInt32(c.TYPEID),
                OPERATINGVOLTAGEINV = Convert.ToDouble(c.OPERATINGVOLTAGEINV),
                RATEDVOLTAGEINV = Convert.ToDouble(c.RATEDVOLTAGEINV),
                AVERAGEACTUALTEMPERATURE = Convert.ToDouble(c.AVERAGEACTUALTEMPERATURE),               
                LAMBDA = Convert.ToDouble(c.LAMBDA),
                LAMBDAREF= Convert.ToDouble(c.LAMBDAREF),
                UOPDIVEDEURATE = Convert.ToDouble(c.UOPDIVEDEURATE),
                PIEU = Convert.ToDouble(c.PIEU),
                THETAREF = Convert.ToDouble(c.THETAREF),
                THETAOP= Convert.ToDouble(c.THETAOP),
                PIET = Convert.ToDouble(c.PIET),
                CREATEDDATE = Convert.ToDateTime(c.CREATEDDATE),
                UPDATEDATE=Convert.ToDateTime(c.UPDATEDATE),
                USERIDZU = Convert.ToString(c.USERIDZU)
            }).ToList();
            return final;
        }

        public async Task<bool> SaveCapacitor(IECPreductionCapacitorCollectionDto Capacitor)
        {
            try
            {
                IECPredictionCapacitor? exists = null;
                if (Capacitor.Trid > 0)
                {
                    exists = await _dbcontextRepo.FindAsync<IECPredictionCapacitor>(Capacitor.Trid);
                }

                if (exists != null)
                {
                    exists.Trid = Capacitor.Trid;
                    exists.PROJECTID = Capacitor.PROJECTID;
                    exists.WBS = Capacitor.WBS ?? string.Empty;
                    exists.SUBCATEGORYID = Convert.ToInt32(Capacitor.SUBCATEGORYID);
                    exists.TYPEID = Convert.ToInt32(Capacitor.TYPEID);
                    exists.OPERATINGVOLTAGEINV = Convert.ToDouble(Capacitor.OPERATINGVOLTAGEINV);
                    exists.RATEDVOLTAGEINV = Convert.ToDouble(Capacitor.RATEDVOLTAGEINV);
                    exists.AVERAGEACTUALTEMPERATURE = Convert.ToDouble(Capacitor.AVERAGEACTUALTEMPERATURE);
                    exists.LAMBDA = Convert.ToDouble(Capacitor.LAMBDA);
                    exists.LAMBDAREF = Convert.ToDouble(Capacitor.LAMBDAREF);
                    exists.UOPDIVEDEURATE = Convert.ToDouble(Capacitor.UOPDIVEDEURATE);
                    exists.PIEU = Convert.ToDouble(Capacitor.PIEU);
                    exists.THETAREF = Convert.ToDouble(Capacitor.THETAREF);
                    exists.THETAOP = Convert.ToDouble(Capacitor.THETAOP);
                    exists.PIET = Convert.ToDouble(Capacitor.PIET);
                    exists.UPDATEDATE = DateTime.Now;
                    exists.USERIDZU = Convert.ToString(Capacitor.USERIDZU);
                    _dbcontextRepo.Update(exists);
                }
                else
                {
                    IECPredictionCapacitor newCapacitor = new IECPredictionCapacitor
                    {
                        PROJECTID = Capacitor.PROJECTID,
                        WBS = Capacitor.WBS ?? string.Empty,
                        SUBCATEGORYID = Convert.ToInt32(Capacitor.SUBCATEGORYID),
                        TYPEID = Convert.ToInt32(Capacitor.TYPEID),
                        OPERATINGVOLTAGEINV = Convert.ToDouble(Capacitor.OPERATINGVOLTAGEINV),
                        RATEDVOLTAGEINV = Convert.ToDouble(Capacitor.RATEDVOLTAGEINV),
                        AVERAGEACTUALTEMPERATURE = Convert.ToDouble(Capacitor.AVERAGEACTUALTEMPERATURE),
                        LAMBDA = Convert.ToDouble(Capacitor.LAMBDA),
                        LAMBDAREF = Convert.ToDouble(Capacitor.LAMBDAREF),
                        UOPDIVEDEURATE = Convert.ToDouble(Capacitor.UOPDIVEDEURATE),
                        PIEU = Convert.ToDouble(Capacitor.PIEU),
                        THETAREF = Convert.ToDouble(Capacitor.THETAREF),
                        THETAOP = Convert.ToDouble(Capacitor.THETAOP),
                        PIET = Convert.ToDouble(Capacitor.PIET),
                        CREATEDDATE = DateTime.Now,
                        USERIDZU = Convert.ToString(Capacitor.USERIDZU),
                    };
                    _dbcontextRepo.Add(newCapacitor);
                }
                await _dbcontextRepo.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
