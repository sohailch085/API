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

        public async Task<List<IECOptoelectronicComponentsResponseDto>> ExecuteIECOptoelectronicComponents(int TypesId, int SubCategoryId, double OperatingVoltageInV, double ReferenceVoltageInV, double RatedVoltageInV, double Fop, double Fmax, double Pfwc, double MaximumSupplyCurrentA, double NominalVoltage, double ThermalResistance, double AmbientTemperature, double LambdaRef)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<IECOptoelectronicComponentsResponseDto>("EXEC procedure_IEC_Optoelectronic_components " + TypesId + "," + SubCategoryId + "," + OperatingVoltageInV + "," + ReferenceVoltageInV + "," + RatedVoltageInV + "," + Fop + "," + Fmax + "," + Pfwc + "," + MaximumSupplyCurrentA + "," + NominalVoltage + "," + ThermalResistance + "," + AmbientTemperature + "," + LambdaRef + "").ToListAsync();
            return result;
        }

        public List<IECConstantsForTemperatureDependenceOfOptoelectronicComponents> GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents()
        {
            var result = _dbcontextRepo.container.IECConstantsForTemperatureDependenceOfOptoelectronicComponents.ToList();
            return result;
        }

        public List<IECOptoelectronicComponentsTypes> GetIECOptoelectronicComponentsTypes(int SubCategoryId)
        {
            var result = _dbcontextRepo.container.IECOptoelectronicComponentsTypes.Where(x=> x.SubCategoryId== SubCategoryId).ToList();
            return result;
        }

        public async Task<List<IECOptoelectronicComponentsSubCategory>> GetIECOptoelectronicComponentsSubCategory()
        {
            var result = await _dbcontextRepo.container.IECOptoelectronicComponentsSubCategory.ToListAsync();
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
                    exists.TypesId = OptoelectronicComponent .TypesId;
                    exists.SubCategoryId = OptoelectronicComponent .SubCategoryId;
                    exists.OperatingVoltageInV = OptoelectronicComponent .OperatingVoltageInV;
                    exists.ReferenceVoltageInV = OptoelectronicComponent .ReferenceVoltageInV;
                    exists.RatedVoltageInV = OptoelectronicComponent .RatedVoltageInV;
                    exists.Fop = OptoelectronicComponent .Fop;
                    exists.Fmax = OptoelectronicComponent .Fmax;
                    exists.Pfwc = OptoelectronicComponent .Pfwc;
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
                        TypesId = OptoelectronicComponent.TypesId,
                        SubCategoryId = OptoelectronicComponent.SubCategoryId,
                        OperatingVoltageInV = OptoelectronicComponent.OperatingVoltageInV,
                        ReferenceVoltageInV = OptoelectronicComponent.ReferenceVoltageInV,
                        RatedVoltageInV = OptoelectronicComponent.RatedVoltageInV,
                        Fop = OptoelectronicComponent.Fop,
                        Fmax = OptoelectronicComponent.Fmax,
                        Pfwc = OptoelectronicComponent.Pfwc,
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
