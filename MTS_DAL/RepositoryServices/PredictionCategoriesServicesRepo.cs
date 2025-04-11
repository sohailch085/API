using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities;
using MTS_DAL.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.RepositoryServices
{
  public class PredictionCategoriesServicesRepo : PredictionCategoriesInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public PredictionCategoriesServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeletePredictionCategories(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<PredictionCategories>(Trid);
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

        public IList<PredictionCategories> GetPredictionCategories(int BookId)
        {
            var result = _dbcontextRepo.container.PredictionCategories.Where(x => x.BOOKID == BookId).ToList();
            return result;
        }

        public bool SavePredictionCategories(PredictionCategoriesCollectionDto Categories)
        {
            try
            {
                PredictionCategories? exists = null;
                if (Categories.Trid > 0)
                {
                    exists = _dbcontextRepo.Find<PredictionCategories>(Categories.Trid);

                    if (exists != null)
                    {
                        exists.CATEGORYNAME = Categories.CATEGORYNAME;
                        exists.BOOKID = Categories.BookID;
                        _dbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    PredictionCategories newdata = new PredictionCategories
                    {
                        CATEGORYNAME = Categories.CATEGORYNAME,
                        BOOKID = Categories.BookID
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
