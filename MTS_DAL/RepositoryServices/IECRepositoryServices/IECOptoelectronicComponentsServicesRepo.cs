using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.IEC;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;

namespace MTS_DAL.RepositoryServices.IECRepositoryServices
{
    public class IECOptoelectronicComponentsServicesRepo : IECOptoelectronicComponentsInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public IECOptoelectronicComponentsServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteOptoelectronicComponent(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<IECPredictionOptoelectronicComponent>(Trid);
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

        public async Task<List<IECOptoelectronicComponentsResponseDto>> ExecuteIECOptoelectronicComponents(int OptoelectronicTypes, int OptoelectronicComponentsSubCategory, int ConstantsType, double OperatingVoltageInV, double ReferenceVoltageInV, double RatedVoltageInV, double OperatingFrequencyMHz, double MaximumOperatingFrequencyMHz, double WorstCasePowerDissipationAtMaximumFrequencyW, double MaximumSupplyCurrentA, double NominalVoltage, double ThermalResistance, double AmbientTemperature, double LambdaRef)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<IECOptoelectronicComponentsResponseDto>("EXEC procedure_IEC_Optoelectronic_components " + OptoelectronicTypes + "," + OptoelectronicComponentsSubCategory + "," + ConstantsType + "," + OperatingVoltageInV + "," + ReferenceVoltageInV + "," + RatedVoltageInV + "," + OperatingFrequencyMHz + "," + MaximumOperatingFrequencyMHz + "," + WorstCasePowerDissipationAtMaximumFrequencyW + "," + MaximumSupplyCurrentA + "," + NominalVoltage + "," + ThermalResistance + "," + AmbientTemperature + "," + LambdaRef + "").ToListAsync();
            return result;
        }

        public List<IECConstantsForTemperatureDependenceOfOptoelectronicComponents> GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents()
        {
            var result = _dbcontextRepo.container.IECConstantsForTemperatureDependenceOfOptoelectronicComponents.ToList();
            return result;
        }

        public List<IECOptoelectronicComponents> GetIECOptoelectronicComponents()
        {
            var result = _dbcontextRepo.container.IECOptoelectronicComponents.ToList();
            return result;
        }

        public async Task<List<IECOptoelectronicComponentsSubCategory>> GetIECOptoelectronicComponentsSubCategory(int SubCategoryId)
        {
            var result = await _dbcontextRepo.container.IECOptoelectronicComponentsSubCategory.Where(x => x.ComponentsSubCategoryId == SubCategoryId).ToListAsync();
            return result;
        }

        public List<IECPredictionOptoelectronicComponent> GetPreductionOptoelectronicComponents()
        {
            return _dbcontextRepo.container.IECPredictionOptoelectronicComponent.ToList();
        }

        public async Task<bool> SaveOptoelectronicComponent(IECPreductionOptoelectronicComponentDto OptoelectronicComponent)
        {
            try
            {
                IECPredictionOptoelectronicComponent? exists = null;

                if (OptoelectronicComponent.Trid > 0)
                {
                    exists = await _dbcontextRepo.FindAsync<IECPredictionOptoelectronicComponent>(OptoelectronicComponent.Trid);
                }

                if (exists != null)
                {
                    exists.Trid=OptoelectronicComponent.Trid;
                    exists.PROJECTid = OptoelectronicComponent .PROJECTid;
                    exists.WBS = OptoelectronicComponent .WBS;
                    exists.OptoelectronicTypes = OptoelectronicComponent .OptoelectronicTypes;
                    exists.OptoelectronicComponentsSubCategory = OptoelectronicComponent .OptoelectronicComponentsSubCategory;
                    exists.ConstantsTypeId = OptoelectronicComponent .ConstantsTypeId;
                    exists.OperatingVoltageInV = OptoelectronicComponent .OperatingVoltageInV;
                    exists.ReferenceVoltageInV = OptoelectronicComponent .ReferenceVoltageInV;
                    exists.RatedVoltageInV = OptoelectronicComponent .RatedVoltageInV;
                    exists.OperatingFrequencyMHz = OptoelectronicComponent .OperatingFrequencyMHz;
                    exists.MaximumOperatingFrequencyMHz = OptoelectronicComponent .MaximumOperatingFrequencyMHz;
                    exists.WorstCasePowerDissipationAtMaximumFrequencyW = OptoelectronicComponent .WorstCasePowerDissipationAtMaximumFrequencyW;
                    exists.MaximumSupplyCurrentA = OptoelectronicComponent .MaximumSupplyCurrentA;
                    exists.NominalVoltage = OptoelectronicComponent .NominalVoltage;
                    exists.ThermalResistance = OptoelectronicComponent .ThermalResistance;
                    exists.AmbientTemperature = OptoelectronicComponent .AmbientTemperature;
                    exists.Lambda = OptoelectronicComponent .Lambda;
                    exists.LambdaRef = OptoelectronicComponent .LambdaRef;
                    exists.UOpDivURat = OptoelectronicComponent .UOpDivURat;
                    exists.PieU = OptoelectronicComponent .PieU;
                    exists.PieI = OptoelectronicComponent .PieI;
                    exists.ThetaRef = OptoelectronicComponent .ThetaRef;
                    exists.ThetaOp = OptoelectronicComponent .ThetaOp;
                    exists.PieT = OptoelectronicComponent .PieT;
                    exists.UPDATEDATE = DateTime.Now;
                    exists.USERIDZU = OptoelectronicComponent.USERIDZU;
                    
                    _dbcontextRepo.Update(exists);
                }
                else
                {
                    IECPredictionOptoelectronicComponent Component = new IECPredictionOptoelectronicComponent
                    {
                        PROJECTid = OptoelectronicComponent.PROJECTid,
                        WBS = OptoelectronicComponent.WBS,
                        OptoelectronicTypes = OptoelectronicComponent.OptoelectronicTypes,
                        OptoelectronicComponentsSubCategory = OptoelectronicComponent.OptoelectronicComponentsSubCategory,
                        ConstantsTypeId = OptoelectronicComponent.ConstantsTypeId,
                        OperatingVoltageInV = OptoelectronicComponent.OperatingVoltageInV,
                        ReferenceVoltageInV = OptoelectronicComponent.ReferenceVoltageInV,
                        RatedVoltageInV = OptoelectronicComponent.RatedVoltageInV,
                        OperatingFrequencyMHz = OptoelectronicComponent.OperatingFrequencyMHz,
                        MaximumOperatingFrequencyMHz = OptoelectronicComponent.MaximumOperatingFrequencyMHz,
                        WorstCasePowerDissipationAtMaximumFrequencyW = OptoelectronicComponent.WorstCasePowerDissipationAtMaximumFrequencyW,
                        MaximumSupplyCurrentA = OptoelectronicComponent.MaximumSupplyCurrentA,
                        NominalVoltage = OptoelectronicComponent.NominalVoltage,
                        ThermalResistance = OptoelectronicComponent.ThermalResistance,
                        AmbientTemperature = OptoelectronicComponent.AmbientTemperature,
                        Lambda = OptoelectronicComponent.Lambda,
                        LambdaRef = OptoelectronicComponent.LambdaRef,
                        UOpDivURat = OptoelectronicComponent.UOpDivURat,
                        PieU = OptoelectronicComponent.PieU,
                        PieI = OptoelectronicComponent.PieI,
                        ThetaRef = OptoelectronicComponent.ThetaRef,
                        ThetaOp = OptoelectronicComponent.ThetaOp,
                        PieT = OptoelectronicComponent.PieT,
                        USERIDZU = OptoelectronicComponent.USERIDZU
                    };
                    Component.CREATEDDATE = DateTime.Now;
                    _dbcontextRepo.Add(Component);
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
