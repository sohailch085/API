using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities;
using MTS_DAL.InterfaceRepo;

namespace MTS_DAL.RepositoryServices
{
    public class LifecyclephasesServicesRepo : LifecyclephasesInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public LifecyclephasesServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo= dbcontextRepo;
        }

        public async Task<bool> DeleteLifecyclephases(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<Lifecyclephases>(Trid);
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

        public IList<Lifecyclephases> GetLifecyclephases()
        {
            var result = _dbcontextRepo.container.Lifecyclephases.ToList();
            return result;
        }

        public bool SaveLifecyclephases(LifecyclephasesCollectionDto Lifecycle)
        {
            try
            {
                Lifecyclephases? exists = null;
                if (Lifecycle.TRID > 0)
                {
                    exists = _dbcontextRepo.Find<Lifecyclephases>(Lifecycle.TRID);

                    if (exists != null)
                    {
                        exists.LIFECYCLEPHASE = Lifecycle.LIFECYCLEPHASE;
                        exists.DESCRIPTION = Lifecycle.DESCRIPTION;
                        _dbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    Lifecyclephases newdata = new Lifecyclephases
                    {
                        LIFECYCLEPHASE = Lifecycle.LIFECYCLEPHASE,
                        DESCRIPTION = Lifecycle.DESCRIPTION
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
