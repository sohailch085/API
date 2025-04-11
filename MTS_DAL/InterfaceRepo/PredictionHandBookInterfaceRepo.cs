using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;

namespace MTS_DAL.InterfaceRepo
{
    public interface PredictionHandBookInterfaceRepo
    {
        IList<PredictionHandBook> GetPredictionHandBook();        
        bool SaveHandBook(PredictionHandBookDto handBook);
        Task<bool> DeleteHandBook(int BookId);
        IList<ProductTypes> GetProductTypes();
     
    }
}
