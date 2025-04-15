using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.IEC;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;

namespace MTS_DAL.RepositoryServices.IECRepositoryServices
{
    public class IECInductorsTransformersAndCoilsServicesRepo : IECInductorsTransformersAndCoilsInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public IECInductorsTransformersAndCoilsServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteInductorsTransformersAndCoils(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<IECPredictionInductorsTransformersAndCoils>(Trid);
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

        public async Task<List<IECInductorsTransformersAndCoilsResponseDto>> ExecuteSPIECInductorsTransformersAndCoils(int SubCategoryId, int TypeId, double DeltaT, double AmbientTemperature, double LambdaRef)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<IECInductorsTransformersAndCoilsResponseDto>("EXEC procedure_IEC_Inductors_transformers_and_coils " + SubCategoryId + ", " + TypeId + ", " + DeltaT + ", " + AmbientTemperature + ", " + LambdaRef + "").ToListAsync();
            return result;
        }

        public List<IECInductorsTransformersAndCoilsSubCategory> GetIECInductorsTransformersAndCoilsSubCategory()
        {
            var result = _dbcontextRepo.container.IECInductorsTransformersAndCoilsSubCategory.ToList();
            return result;
            //throw new NotImplementedException();
        }

        public List<IECInductorsTransformersAndCoilsTypes> GetIECInductorsTransformersAndCoilsType(int SubCategoryId)
        {
            var result = _dbcontextRepo.container.IECInductorsTransformersAndCoilsTypes.Where(x => x.SubCategoryId == SubCategoryId).ToList();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECPredictionInductorsTransformersAndCoils>> GetIECPreductionInductorsTransformersAndCoils()
        {
            var result = await _dbcontextRepo.container.IECPredictionInductorsTransformersAndCoils.ToListAsync();
            return result;
        }

        public async Task<bool> SaveInductorsTransformersAndCoils(IECPreductionInductorsTransformersAndCoilsDto preduction)
        {
            try
            {
                IECPredictionInductorsTransformersAndCoils? exists = null;
                if (preduction.Trid != 0)
                {
                    exists = await _dbcontextRepo.FindAsync<IECPredictionInductorsTransformersAndCoils>(preduction.Trid);
                }

                if (exists != null)
                {
                    exists.PROJECTID = preduction.PROJECTID;
                    exists.WBS = preduction.WBS;
                    exists.SubCategoryId=preduction.SubCategoryId;
                    exists.TypeId=preduction.TypeId;  
                    exists.DeltaT = preduction.DeltaT;
                    exists.AmbientTemperature = preduction.AmbientTemperature;
                    exists.Lambda=preduction.Lambda;
                    exists.LambdaRef = preduction.LambdaRef;
                    exists.ThetaOp=preduction.ThetaOp;
                    exists.ThetaRef = preduction.ThetaRef;
                    exists.PieT = preduction.PieT;
                    exists.UpdateDate = DateTime.Now;
                    exists.USERIDZU = preduction.USERIDZU;
                    _dbcontextRepo.Update(exists);
                }
                else
                {
                    IECPredictionInductorsTransformersAndCoils newCapacitor = new IECPredictionInductorsTransformersAndCoils
                    {
                        PROJECTID = preduction.PROJECTID,
                        WBS = preduction.WBS,
                        SubCategoryId = preduction.SubCategoryId,
                        TypeId = preduction.TypeId,
                       DeltaT = preduction.DeltaT,
                        AmbientTemperature = preduction.AmbientTemperature,
                        Lambda = preduction.Lambda,
                        LambdaRef = preduction.LambdaRef,
                        ThetaOp = preduction.ThetaOp,
                        ThetaRef = preduction.ThetaRef,
                        PieT = preduction.PieT,
                        CreatedDate = DateTime.Now,
                        USERIDZU = preduction.USERIDZU,
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
