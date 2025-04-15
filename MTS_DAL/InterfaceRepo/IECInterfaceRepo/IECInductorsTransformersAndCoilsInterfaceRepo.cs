using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.InterfaceRepo.IECInterfaceRepo
{
    public interface IECInductorsTransformersAndCoilsInterfaceRepo
    {
        List<IECInductorsTransformersAndCoilsSubCategory> GetIECInductorsTransformersAndCoilsSubCategory();
        List<IECInductorsTransformersAndCoilsTypes> GetIECInductorsTransformersAndCoilsType(int SubCategoryId);
        Task<List<IECPredictionInductorsTransformersAndCoils>> GetIECPreductionInductorsTransformersAndCoils();

        Task<List<IECInductorsTransformersAndCoilsResponseDto>> ExecuteSPIECInductorsTransformersAndCoils
            (
                int SubCategoryId,
                int TypeId,
                double DeltaT,
                double AmbientTemperature,
                double LambdaRef
            );

        Task<bool> SaveInductorsTransformersAndCoils(IECPreductionInductorsTransformersAndCoilsDto preduction);
        Task<bool> DeleteInductorsTransformersAndCoils(int Trid);
    }
}
