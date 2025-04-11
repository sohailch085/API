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

        public async Task<List<IECInductorsTransformersAndCoilsResponseDto>> ExecuteSPIECInductorsTransformersAndCoils(int TransformersType, double OperatingFrequencyMHz, double MaximumOperatingFrequencyMHz, double WorstCasePowerDissipationAtMaximumFrequencyW, double MaximumSupplyCurrentA, double NominalVoltage, double ThermalResistance, double AmbientTemperature, double LambdaRef)
        {
            var resulta = await _dbcontextRepo.Database.SqlQueryRaw<IECInductorsTransformersAndCoilsResponseDto>("EXEC procedure_IEC_Inductors_transformers_and_coils " + TransformersType + ", " + OperatingFrequencyMHz + ", " + MaximumOperatingFrequencyMHz + ", " + WorstCasePowerDissipationAtMaximumFrequencyW + ", " + MaximumSupplyCurrentA + ", " + NominalVoltage + ", " + ThermalResistance + ", " + AmbientTemperature + ", " + LambdaRef + "").ToListAsync();
            return resulta;
        }

        public List<IECInductorsTransformersAndCoils> GetIECInductorsTransformersAndCoils()
        {
            var result =  _dbcontextRepo.container.IECInductorsTransformersAndCoils.ToList();
            return result;
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
                    exists.TransformerTypeId=preduction.TransformerTypeId;
                    exists.OperatingFrequencyMHz=preduction.OperatingFrequencyMHz;
                    exists.MaximumOperatingFrequencyMHz = preduction.MaximumOperatingFrequencyMHz;
                    exists.WorstCasePowerDissipationAtMaximumFrequencyW = preduction.WorstCasePowerDissipationAtMaximumFrequencyW;
                    exists.MaximumSupplyCurrentA = preduction.MaximumSupplyCurrentA;
                    exists.NominalVoltage = preduction.NominalVoltage;
                    exists.ThermalResistance = preduction.ThermalResistance;
                    exists.AmbientTemperature = preduction.AmbientTemperature;
                    exists.Lambda=preduction.Lambda;
                    exists.LambdaRef = preduction.LambdaRef;
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
                        TransformerTypeId = preduction.TransformerTypeId,
                        OperatingFrequencyMHz = preduction.OperatingFrequencyMHz,
                        MaximumOperatingFrequencyMHz = preduction.MaximumOperatingFrequencyMHz,
                        WorstCasePowerDissipationAtMaximumFrequencyW = preduction.WorstCasePowerDissipationAtMaximumFrequencyW,
                        MaximumSupplyCurrentA = preduction.MaximumSupplyCurrentA,
                        NominalVoltage = preduction.NominalVoltage,
                        ThermalResistance = preduction.ThermalResistance,
                        AmbientTemperature = preduction.AmbientTemperature,
                        Lambda = preduction.Lambda,
                        LambdaRef = preduction.LambdaRef,
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
