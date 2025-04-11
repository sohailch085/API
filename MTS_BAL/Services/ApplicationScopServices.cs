using MTS_BAL.InterfaceServices;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.Entities;
using MTS_DAL.InterfaceRepo;

namespace MTS_BAL.Services
{
    public class ApplicationScopServices : ApplicationScopInterface
    {
        private readonly PredictionHandBookInterfaceRepo _PredictionHandBooksInterfaceRepo;
        private readonly PredictionCategoriesInterfaceRepo _PredictionCategoriesInterfaceRepo;
        private readonly LifecyclephasesInterfaceRepo _LifecyclephasesInterfaceRepo;
        private readonly RAMBRAKDOWNInterfaceRepo _RAMBRAKDOWNInterfaceRepo;
        public ApplicationScopServices(PredictionHandBookInterfaceRepo predictionHandBooksInterfaceRepo, PredictionCategoriesInterfaceRepo predictionCategoriesInterface, LifecyclephasesInterfaceRepo lifecyclephasesInterfaceRepo, RAMBRAKDOWNInterfaceRepo rAMBRAKDOWNInterfaceRepo)
        {
            _PredictionHandBooksInterfaceRepo = predictionHandBooksInterfaceRepo;
            _PredictionCategoriesInterfaceRepo = predictionCategoriesInterface;
            _LifecyclephasesInterfaceRepo = lifecyclephasesInterfaceRepo;
            _RAMBRAKDOWNInterfaceRepo = rAMBRAKDOWNInterfaceRepo;
        }

        public async Task<bool> DeleteHandBook(int BookId)
        {
            var result = await _PredictionHandBooksInterfaceRepo.DeleteHandBook(BookId);
            return result;
        }

        public async Task<bool> DeleteLifecyclephases(int Trid)
        {
            var result = await _LifecyclephasesInterfaceRepo.DeleteLifecyclephases(Trid);
            return result;
        }

        public async Task<bool> DeletePredictionCategories(int Trid)
        {
            var result = await _PredictionCategoriesInterfaceRepo.DeletePredictionCategories(Trid);
            return result;
        }

        public async Task<bool> DeleteRAMBRAKDOWNPARTS(string WBS)
        {
            var result =await _RAMBRAKDOWNInterfaceRepo.DeleteRAMBRAKDOWNPARTS(WBS);
            return result;
        }

        public Task<bool> DeleteRambrakdowns(string WBS)
        {
            var result = _RAMBRAKDOWNInterfaceRepo.DeleteRambrakdowns(WBS);
            return result;
        }

        public IList<LifecyclephasesDto> GetLifecyclephases()
        {
            var result = _LifecyclephasesInterfaceRepo.GetLifecyclephases();
            var final = result.Select(x => new LifecyclephasesDto
            {
                TRID = x.TRID,
                LIFECYCLEPHASE = x.LIFECYCLEPHASE
            }).ToList();
            return final;
        }

        public IList<PredictionCategoriesDto> GetPredictionCategories(int BookId)
        {
            var result = _PredictionCategoriesInterfaceRepo.GetPredictionCategories(BookId);
            var final = result.Select(x => new PredictionCategoriesDto
            {
                TRID = x.TRID,
                CATEGORYNAME = x.CATEGORYNAME
            }).ToList();
            return final;
        }

        public IList<PredictionHandBookDto> GetPredictionHandBook()
        {
            var result = _PredictionHandBooksInterfaceRepo.GetPredictionHandBook();
            var final = result.Select(x => new PredictionHandBookDto
            {
                TRID = x.TRID,
                BOOKNAME = x.BOOKNAME
            }).ToList();
            return final;
        }

        public IList<ProductTypesDto> GetProductTypes()
        {
            var result = _PredictionHandBooksInterfaceRepo.GetProductTypes();
            var final = result.Select(x => new ProductTypesDto
            {
                TRID = x.TRID,
                PRODUCTTYPE = x.PRODUCTTYPE
            }).ToList();
            return final;
        }

        public async Task<List<RAMBRAKDOWNPARTSDto>> GetRAMBRAKDOWNPARTS()
        {
            var result=await _RAMBRAKDOWNInterfaceRepo.GetRAMBRAKDOWNPARTS();
            var final= result.Select(x=> new RAMBRAKDOWNPARTSDto 
            {
                Trid=x.Trid,
                PWBS=x.PWBS,
                WBS=x.WBS,
                PROJECTID=x.PROJECTID,
                ITNAMEHA=x.ITNAMEHA ?? string.Empty,
                LASACONXB=x.LSACONXB ?? string.Empty,
                CAGECDXH = x.CAGECDXH ?? string.Empty,
                REFNUMHA = x.REFNUMHA ?? string.Empty,
                QTYASYHG = x.QTYASYHG ?? string.Empty,
                REFDESHJ = x.REFDESHJ ?? string.Empty,
                DESCRIPTION= x.DESCRIPTION ?? string.Empty,
                CALMETHOD=Convert.ToInt64(x.CALMETHODID),
                CATEGORY =Convert.ToInt64(x.CATEGORYID),
                SUBCATEGORY = Convert.ToInt64(x.SUBCATEGORYID),
                TYPES = Convert.ToInt64(x.TYPESID),
                FAILURERATE=Convert.ToDouble(x.FAILURERATE),
                FAILURERATEPERCENTAGE= Convert.ToDouble(x.FAILURERATEPERCENTAGE),
                FAILURERATEOVERIDE=Convert.ToBoolean(x.FAILURERATEOVERIDE),
                MTBF= Convert.ToDouble(x.MTBF),
                CREATEDDATE=Convert.ToDateTime(x.CREATEDDATE),
                UPDATEDATE=Convert.ToDateTime(x.UPDATEDATE),
                USERIDZU=x.USERIDZU ?? string.Empty
            }).ToList();
            return final;
        }

        public async Task<List<RAMBRAKDOWNDto>> GetRambrakdowns()
        {
            var result = await _RAMBRAKDOWNInterfaceRepo.GetRambrakdowns();
            var final = result.Select(x => new RAMBRAKDOWNDto
            {
                PWBS = x.PWBS,
                WBS = x.WBS,
                PROJECTID = x.PROJECTID,
                LCNAMEXB = x.LCNAMEXB ?? string.Empty,
                LSACONXB = x.LSACONXB ?? string.Empty,
                ALTLCNXB = x.ALTLCNXB ?? string.Empty,
                CAGECDXH = x.CAGECDXH ?? string.Empty,
                REFNUMHA = x.REFNUMHA ?? string.Empty,
                QTYASYHG = x.QTYASYHG ?? string.Empty,
                REFDESHJ = x.REFDESHJ ?? string.Empty,
                DESCRIPTION = x.DESCRIPTION ?? string.Empty,
              //  CALMETHOD = Convert.ToInt64(x.CALMETHOD),
                FAILURERATE = double.Parse(x.FAILURERATE.ToString() ?? string.Empty),
                FAILURERATEPERCENTAGE = Convert.ToDouble(x.FAILURERATEPERCENTAGE),
                FAILURERATEOVERIDE = Convert.ToBoolean(x.FAILURERATEOVERIDE),
                MTBF = Convert.ToDouble(x.MTBF),
                CREATEDDATE = Convert.ToDateTime(x.CREATEDDATE),
                UPDATEDATE = Convert.ToDateTime(x.UPDATEDATE),
                USERIDZU = x.USERIDZU ?? string.Empty,

            }).ToList();
            return final;
        }

        public bool SaveHandBook(PredictionHandBookDto handBook)
        {
            var result = _PredictionHandBooksInterfaceRepo.SaveHandBook(handBook);
            return result;
        }

        public bool SaveLifecyclephases(LifecyclephasesCollectionDto Lifecyclephases)
        {
            var result = _LifecyclephasesInterfaceRepo.SaveLifecyclephases(Lifecyclephases);
            return result;
        }

        public bool SavePredictionCategories(PredictionCategoriesCollectionDto Categories)
        {
            var result = _PredictionCategoriesInterfaceRepo.SavePredictionCategories(Categories);
            return result;
        }

        public bool SaveRAMBRAKDOWNPARTS(RambrakdownPartsCollectionDto collectionDto)
        {
            var result = _RAMBRAKDOWNInterfaceRepo.SaveRAMBRAKDOWNPARTS(collectionDto);
            return result;
        }

        public bool SaveRambrakdowns(RamBrakdownCollectionDto collectionDto)
        {
            var result = _RAMBRAKDOWNInterfaceRepo.SaveRambrakdowns(collectionDto);
            return result;
        }
    }
}
