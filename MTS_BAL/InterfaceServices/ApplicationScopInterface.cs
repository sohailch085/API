

using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;

namespace MTS_BAL.InterfaceServices
{
  public interface ApplicationScopInterface
    {
        IList<PredictionHandBookDto> GetPredictionHandBook();
        IList <ProductTypesDto> GetProductTypes();
        IList<PredictionCategoriesDto> GetPredictionCategories(int BookId);
        bool SaveHandBook(PredictionHandBookDto handBook);
       Task<bool> DeleteHandBook(int BookId);
        IList<LifecyclephasesDto> GetLifecyclephases();
        bool SaveLifecyclephases(LifecyclephasesCollectionDto Lifecyclephases);
        Task<bool> DeleteLifecyclephases(int Trid);
        Task<bool> DeletePredictionCategories(int Trid);
        bool SavePredictionCategories(PredictionCategoriesCollectionDto Categories);

        Task<List<RAMBRAKDOWNDto>> GetRambrakdowns();

        bool SaveRambrakdowns(RamBrakdownCollectionDto collectionDto);

        Task<bool> DeleteRambrakdowns(string WBS);

        Task<List<RAMBRAKDOWNPARTSDto>> GetRAMBRAKDOWNPARTS();

        bool SaveRAMBRAKDOWNPARTS(RambrakdownPartsCollectionDto collectionDto);

        Task<bool> DeleteRAMBRAKDOWNPARTS(string WBS);
    }
}
