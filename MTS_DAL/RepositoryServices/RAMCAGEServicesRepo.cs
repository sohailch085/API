using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities;
using MTS_DAL.Entities.IEC;
using MTS_DAL.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.RepositoryServices
{
    public class RAMCAGEServicesRepo : RAMCAGEInterfaceRepo
    {
        public readonly DbcontextRepo _DbcontextRepo;
        public RAMCAGEServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _DbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteRAMCAGE(string CAGECDXH)
        {
            try
            {
                var result = await _DbcontextRepo.FindAsync<RAMCAGE>(CAGECDXH);
                if (result == null)
                    return false;
                using (var transaction = await _DbcontextRepo.Database.BeginTransactionAsync())
                {
                    try
                    {
                        _DbcontextRepo.Remove(result);
                        await _DbcontextRepo.SaveChangesAsync();
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

        public async Task<bool> DeleteRAMPARTS(string REFNUMHA)
        {
            try
            {
                var result = await _DbcontextRepo.FindAsync<RAMPARTS>(REFNUMHA);
                if (result == null)
                    return false;
                using (var transaction = await _DbcontextRepo.Database.BeginTransactionAsync())
                {
                    try
                    {
                        _DbcontextRepo.Remove(result);
                        await _DbcontextRepo.SaveChangesAsync();
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

        public IList<RAMCAGE> GetRAMCAGE()
        {
            var result = _DbcontextRepo.container.RAMCAGE.ToList();
            return result;
        }

        public IList<RAMPARTS> GetRAMPARTS()
        {
            var result = _DbcontextRepo.container.RAMPARTS.ToList();
            return result;
        }

        public bool SaveRAMCAGE(RAMCAGECollectionDto ramCAGE)
        {
            try
            {
                RAMCAGE? exists = null;
                if (ramCAGE.CAGECDXH != null)
                {
                    exists = _DbcontextRepo.Find<RAMCAGE>(ramCAGE.CAGECDXH);
                    if (exists != null)
                    {
                        exists.CANAMEXH = ramCAGE.CANAMEXH;
                        exists.CASTREXH = ramCAGE.CASTREXH;
                        exists.CACITYXH = ramCAGE.CACITYXH;
                        exists.CASTATXH = ramCAGE.CASTATXH;
                        exists.CANATNXH = ramCAGE.CANATNXH;
                        exists.CAPOZOXH = ramCAGE.CAPOZOXH;
                        exists.UPDATEDATE = DateTime.Now;
                        exists.USERIDZU = ramCAGE.USERIDZU;
                        _DbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    RAMCAGE newdata = new RAMCAGE
                    {
                        CANAMEXH = ramCAGE.CANAMEXH,
                        CASTREXH = ramCAGE.CASTREXH,
                        CACITYXH = ramCAGE.CACITYXH,
                        CASTATXH = ramCAGE.CASTATXH,
                        CANATNXH = ramCAGE.CANATNXH,
                        CAPOZOXH = ramCAGE.CAPOZOXH,
                        CREATEDDATE = DateTime.Now,
                        USERIDZU = ramCAGE.USERIDZU
                    };
                    _DbcontextRepo.Add(newdata);
                }
                _DbcontextRepo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveRAMPARTS(RAMPARTSCollectionDto rampart)
        {
            try
            {
                RAMPARTS? exists = null;
                if (rampart.REFNUMHA != null)
                {
                    exists = _DbcontextRepo.Find<RAMPARTS>(rampart.REFNUMHA);
                    if (exists != null)
                    {
                        exists.CAGECDXH = rampart.CAGECDXH;
                        exists.ITNAMEHA = rampart.ITNAMEHA;
                        exists.MATERLHA = rampart.MATERLHA;
                        exists.UPDATEDATE = DateTime.Now;
                        exists.USERIDZU = rampart.USERIDZU;
                        _DbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    RAMPARTS rAMPARTS = new RAMPARTS
                    {
                        REFNUMHA = rampart.REFNUMHA,
                        CAGECDXH = rampart.CAGECDXH,
                        ITNAMEHA = rampart.ITNAMEHA,
                        MATERLHA = rampart.MATERLHA,
                        CREATEDDATE = DateTime.Now,
                        USERIDZU = rampart.USERIDZU
                    };
                    _DbcontextRepo.Add(rAMPARTS);
                }
                _DbcontextRepo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
