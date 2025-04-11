using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.InterfaceRepo
{
    public interface PredictionCategoriesInterfaceRepo
    {
        IList<PredictionCategories> GetPredictionCategories(int BookId);
        Task<bool> DeletePredictionCategories(int Trid);
        bool SavePredictionCategories(PredictionCategoriesCollectionDto Categories);
    }
}
