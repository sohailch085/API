using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities;
using MTS_DAL.Entities.IEC;
using MTS_DAL.InterfaceRepo;

namespace MTS_DAL.RepositoryServices
{
    public class RAMBRAKDOWNServicesRepo : RAMBRAKDOWNInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public RAMBRAKDOWNServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteRAMBRAKDOWNPARTS(string WBS)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<RAMBRAKDOWNPARTS>(WBS);
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

        public async Task<bool> DeleteRambrakdowns(string WBS)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<RAMBRAKDOWN>(WBS);
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

        public async Task<List<RAMBRAKDOWNPARTS>> GetRAMBRAKDOWNPARTS()
        {
            var result = await _dbcontextRepo.container.RAMBRAKDOWNPARTS.ToListAsync();
            return result;
        }

        public async Task<List<RAMBRAKDOWN>> GetRambrakdowns()
        {
            var result = await _dbcontextRepo.container.RAMBRAKDOWN.ToListAsync();
            return result;
        }

        public bool SaveRAMBRAKDOWNPARTS(RambrakdownPartsCollectionDto collectionDto)
        {
            try
            {
                RAMBRAKDOWNPARTS? exists = null;

                if (collectionDto.WBS != null || collectionDto.WBS != "")
                {
                    exists = _dbcontextRepo.Find<RAMBRAKDOWNPARTS>(collectionDto.WBS);

                    if (exists != null)
                    {
                        exists.PWBS = collectionDto.PWBS;
                        exists.WBS = collectionDto.WBS ?? string.Empty;
                        exists.PROJECTID = collectionDto.PROJECTID;
                        exists.ITNAMEHA = collectionDto.ITNAMEHA;
                        exists.LSACONXB = collectionDto.LSACONXB;
                        exists.CAGECDXH = collectionDto.CAGECDXH;
                        exists.REFNUMHA = collectionDto.REFNUMHA;
                        exists.QTYASYHG = collectionDto.QTYASYHG;
                        exists.REFDESHJ = collectionDto.REFDESHJ;
                        exists.DESCRIPTION = collectionDto.DESCRIPTION;
                        exists.CALMETHODID = collectionDto.CALMETHODID;
                        exists.CATEGORYID = collectionDto.CATEGORYID;
                        exists.SUBCATEGORYID = collectionDto.SUBCATEGORYID;
                        exists.TYPESID = collectionDto.TYPESID;
                        exists.FAILURERATE = collectionDto.FAILURERATE;
                        exists.FAILURERATEPERCENTAGE = collectionDto.FAILURERATEPERCENTAGE;
                        exists.FAILURERATEOVERIDE=collectionDto.FAILURERATEOVERIDE;
                        exists.UPDATEDATE=collectionDto.UPDATEDATE;
                        exists.USERIDZU=collectionDto.USERIDZU;
                        _dbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    RAMBRAKDOWNPARTS newdata = new RAMBRAKDOWNPARTS
                    {
                        PWBS = collectionDto.PWBS,
                        WBS = collectionDto.WBS,
                        PROJECTID = collectionDto.PROJECTID,
                        ITNAMEHA = collectionDto.ITNAMEHA,
                        LSACONXB = collectionDto.LSACONXB,
                        CAGECDXH = collectionDto.CAGECDXH,
                        REFNUMHA = collectionDto.REFNUMHA,
                        QTYASYHG = collectionDto.QTYASYHG,
                        REFDESHJ = collectionDto.REFDESHJ,
                        DESCRIPTION = collectionDto.DESCRIPTION,
                        CALMETHODID = collectionDto.CALMETHODID,
                        CATEGORYID = collectionDto.CATEGORYID,
                        SUBCATEGORYID = collectionDto.SUBCATEGORYID,
                        TYPESID = collectionDto.TYPESID,
                        FAILURERATE = collectionDto.FAILURERATE,
                        FAILURERATEPERCENTAGE = collectionDto.FAILURERATEPERCENTAGE,
                        FAILURERATEOVERIDE = collectionDto.FAILURERATEOVERIDE,
                        CREATEDDATE = collectionDto.CREATEDDATE,
                        USERIDZU = collectionDto.USERIDZU
                    };
                    _dbcontextRepo.Add(newdata);
                }
                _dbcontextRepo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveRambrakdowns(RamBrakdownCollectionDto collectionDto)
        {
            try
            {
                RAMBRAKDOWN? exists = null;
                if (collectionDto.WBS != null || collectionDto.WBS != "")
                {
                    exists = _dbcontextRepo.Find<RAMBRAKDOWN>(collectionDto.WBS);

                    if (exists != null)
                    {
                        exists.PWBS = collectionDto.PWBS;
                        exists.WBS = collectionDto.WBS ?? string.Empty;
                        exists.PROJECTID = collectionDto.PROJECTID;
                        exists.LCNAMEXB = collectionDto.LCNAMEXB;
                        exists.LSACONXB = collectionDto.LSACONXB;
                        exists.ALTLCNXB = collectionDto.ALTLCNXB;
                        exists.CAGECDXH = collectionDto.CAGECDXH;
                        exists.REFNUMHA = collectionDto.REFNUMHA;
                        exists.QTYASYHG = collectionDto.QTYASYHG;
                        exists.REFDESHJ = collectionDto.REFDESHJ;
                        exists.DESCRIPTION = collectionDto.DESCRIPTION;
                        exists.FAILURERATE = collectionDto.FAILURERATE;
                        exists.FAILURERATEPERCENTAGE = collectionDto.FAILURERATEPERCENTAGE;
                        exists.FAILURERATEOVERIDE = collectionDto.FAILURERATEOVERIDE;
                        exists.MTBF = collectionDto.MTBF;
                        exists.UPDATEDATE = collectionDto.UPDATEDATE;
                        exists.USERIDZU = collectionDto.USERIDZU;
                        _dbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    RAMBRAKDOWN newdata = new RAMBRAKDOWN 
                    {
                        PWBS = collectionDto.PWBS,
                        WBS = collectionDto.WBS,
                        PROJECTID = collectionDto.PROJECTID,
                        LCNAMEXB = collectionDto.LCNAMEXB,
                        LSACONXB = collectionDto.LSACONXB,
                        ALTLCNXB = collectionDto.ALTLCNXB,
                        CAGECDXH = collectionDto.CAGECDXH,
                        REFNUMHA = collectionDto.REFNUMHA,
                        QTYASYHG = collectionDto.QTYASYHG,
                        REFDESHJ = collectionDto.REFDESHJ,
                        DESCRIPTION = collectionDto.DESCRIPTION,
                        FAILURERATE = collectionDto.FAILURERATE,
                        FAILURERATEPERCENTAGE = collectionDto.FAILURERATEPERCENTAGE,
                        FAILURERATEOVERIDE = collectionDto.FAILURERATEOVERIDE,
                        MTBF = collectionDto.MTBF,
                        CREATEDDATE = collectionDto.CREATEDDATE,
                        USERIDZU = collectionDto.USERIDZU
                    };
                    _dbcontextRepo.Add(newdata);
                }
                _dbcontextRepo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
