using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities;
using MTS_DAL.Entities.IEC;
using MTS_DAL.InterfaceRepo;
using System.Net;

namespace MTS_DAL.RepositoryServices
{
    public class PredictionHandBookServicesRepo : PredictionHandBookInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public PredictionHandBookServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo=dbcontextRepo;
        }
        
        public async Task<bool> DeleteHandBook(int BookId)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<PredictionHandBook>(BookId);
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
        public IList<PredictionHandBook> GetPredictionHandBook()
        {
            var result =_dbcontextRepo.container.PredictionHandBook.ToList();
            return result;
        }

        public IList<ProductTypes> GetProductTypes()
        {
            var result =_dbcontextRepo.container.ProductTypes.ToList();
            return result;
        }

        public bool SaveHandBook(PredictionHandBookDto handBook)
        {
            try
            {
                PredictionHandBook? exists = null;
                if (handBook.TRID > 0)
                {
                    exists =  _dbcontextRepo.Find<PredictionHandBook>(handBook.TRID);
                    if (exists != null)
                    {
                        exists.BOOKNAME = handBook.BOOKNAME;
                        _dbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    PredictionHandBook newdata = new PredictionHandBook
                    {
                        BOOKNAME = handBook.BOOKNAME
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
