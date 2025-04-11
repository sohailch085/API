using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.IEC;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;

namespace MTS_DAL.RepositoryServices.IECRepositoryServices
{
    public class IECIntegratedSemiconductorCircuitsServicesRepo : IECIntegratedSemiconductorCircuitsInterfaceRepo
    {
        public readonly DbcontextRepo _dbcontextRepo;
        public IECIntegratedSemiconductorCircuitsServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteIntegratedSemiconductorCircuits(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<IECPredictionIntegratedSemiconductorCircuits>(Trid);
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

        public async Task<List<IECIntegratedSemiconductorCircuitsResponseDto>> ExecuteSpIECIntegratedSemiconductorCircuits(int CircuitType, int SubComponent, int ConstantsType, double OperatingVoltageInV, double RatedVoltageInV, double OperatingFrequencyMHz, double MaximumOperatingFrequencyMHz, double WorstCasePowerDissipationAtTheMaximumFrequencyW, double MaximumSupplyCurrentA, double NominalVoltage, double ThermalResistance, double AmbientTemperature, double LambdaRef)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<IECIntegratedSemiconductorCircuitsResponseDto>("EXEC procedure_IEC_Integrated_semiconductor_circuits " + CircuitType + "," + SubComponent + "," + ConstantsType + "," + OperatingVoltageInV + "," + RatedVoltageInV + "," + OperatingFrequencyMHz + "," + MaximumOperatingFrequencyMHz + "," + WorstCasePowerDissipationAtTheMaximumFrequencyW + "," + MaximumSupplyCurrentA + "," + NominalVoltage + "," + ThermalResistance + "," + AmbientTemperature + "," + LambdaRef + "").ToListAsync();
            return result;
        }

        public async Task<List<IECConstantForVoltageDependence>> GetIECConstantForVoltageDependence()
        {
            var result = await _dbcontextRepo.container.IECConstantForVoltageDependence.ToListAsync();
            return result;
        }

        public async Task<List<IECConstantsForTemperatureDependence>> GetIECConstantsForTemperatureDependence()
        {
            var result = await _dbcontextRepo.container.IECConstantsForTemperatureDependence.ToListAsync();
            return result;
        }

        public async Task<List<IECTypeComponent>> GetIECTypeComponent()
        {
            var result = await _dbcontextRepo.container.IECTypeComponent.ToListAsync();
            return result;
        }

        public async Task<List<IECTypeComponentSubCategory>> GetIECTypeComponentSubCategory(int SubCategoryId)
        {
            var result = await _dbcontextRepo.container.IECTypeComponentSubCategory.Where(x => x.SubCategoryId == SubCategoryId).ToListAsync();
            return result;
        }

        public async Task<List<IECPreductionIntegratedSemiconductorCircuitsDto>> GetPreductionIntegratedSemiconductorCircuits()
        {
            var result =await _dbcontextRepo.container.IECPredictionIntegratedSemiconductorCircuits.ToListAsync(); 
            var final = result.Select(x => new IECPreductionIntegratedSemiconductorCircuitsDto 
            {
                Trid =x.Trid,
                ProjectID=x.ProjectID,
                WBS=x.WBS,
                CircuitType= x.CircuitType,
                SubComponent=x.SubComponent,
                ConstantsType=x.ConstantsType,
                OperatingVoltageInV=Convert.ToDouble(x.OperatingVoltageInV),
                RatedVoltageInV=Convert.ToDouble(x.RatedVoltageInV),
                OperatingFrequencyMHz= Convert.ToDouble(x.OperatingFrequencyMHz),
                MaximumOperatingFrequencyMHz = Convert.ToDouble(x.MaximumOperatingFrequencyMHz),
                worstCasePowerDissipationAtMaximumFrequencyW=Convert.ToDouble(x.worstCasePowerDissipationAtMaximumFrequencyW),
                MaximumSupplyCurrentA=Convert.ToDouble(x.MaximumSupplyCurrentA),
                NominalVoltage = Convert.ToDouble(x.NominalVoltage),
                ThermalResistance= Convert.ToDouble(x.ThermalResistance),
                AmbientTemperature= Convert.ToDouble(x.AmbientTemperature),
                Lambda= Convert.ToDouble(x.Lambda),
                LambdaRef=Convert.ToDouble(x.LambdaRef),
                URefDivideURat = Convert.ToDouble(x.URefDivideURat),
                PieU= Convert.ToDouble(x.PieU),
                ThetaRef= Convert.ToDouble(x.ThetaRef),
                ThetaOp= Convert.ToDouble(x.ThetaOp),
                PieT=Convert.ToDouble(x.PieT),
                CREATEDDATE= Convert.ToDateTime(x.CREATEDDATE),
                UPDATEDATE=Convert.ToDateTime(x.UPDATEDATE),
                USERIDZU= Convert.ToString(x.USERIDZU)
            }).ToList();
            return final;
        }

        public async Task<bool> SaveIntegratedSemiconductorCircuits(IECPreductionIntegratedSemiconductorCircuitsDto preduction)
        {
            try
            {
                IECPredictionIntegratedSemiconductorCircuits? exists = null;
                if (preduction.Trid != 0)
                {
                    exists = await _dbcontextRepo.FindAsync<IECPredictionIntegratedSemiconductorCircuits>(preduction.Trid);
                }

                if (exists != null)
                {
                    exists.ProjectID = preduction.ProjectID;
                    exists.WBS = preduction.WBS;
                    exists.CircuitType=preduction.CircuitType;
                    exists.SubComponent=preduction.SubComponent;
                    exists.ConstantsType = preduction.ConstantsType;
                    exists.OperatingVoltageInV=preduction.OperatingVoltageInV;
                    exists.RatedVoltageInV = preduction.RatedVoltageInV;
                    exists.OperatingFrequencyMHz = preduction.OperatingFrequencyMHz;
                    exists.MaximumOperatingFrequencyMHz = preduction.MaximumOperatingFrequencyMHz;
                    exists.worstCasePowerDissipationAtMaximumFrequencyW = preduction.worstCasePowerDissipationAtMaximumFrequencyW;
                    exists.MaximumSupplyCurrentA = preduction.MaximumSupplyCurrentA;
                    exists.NominalVoltage = preduction.NominalVoltage;
                    exists.ThermalResistance = preduction.ThermalResistance;
                    exists.AmbientTemperature = preduction.AmbientTemperature;
                    exists.Lambda=preduction.Lambda;
                    exists.LambdaRef = preduction.LambdaRef;
                    exists.URefDivideURat = preduction.URefDivideURat;
                    exists.PieU = preduction.PieU;
                    exists.ThetaRef = preduction.ThetaRef;
                    exists.ThetaOp = preduction.ThetaOp;
                    exists.PieT = preduction.PieT;
                    exists.USERIDZU = preduction.USERIDZU;
                    exists.UPDATEDATE = DateTime.Now;
                    _dbcontextRepo.Update(exists);
                }
                else
                {
                    IECPredictionIntegratedSemiconductorCircuits newdata = new IECPredictionIntegratedSemiconductorCircuits
                    {
                        ProjectID = preduction.ProjectID,
                        WBS = preduction.WBS,
                        CircuitType = preduction.CircuitType,
                        SubComponent = preduction.SubComponent,
                        ConstantsType = preduction.ConstantsType,
                        OperatingVoltageInV = preduction.OperatingVoltageInV,
                        RatedVoltageInV = preduction.RatedVoltageInV,
                        OperatingFrequencyMHz = preduction.OperatingFrequencyMHz,
                        MaximumOperatingFrequencyMHz = preduction.MaximumOperatingFrequencyMHz,
                        worstCasePowerDissipationAtMaximumFrequencyW = preduction.worstCasePowerDissipationAtMaximumFrequencyW,
                        MaximumSupplyCurrentA = preduction.MaximumSupplyCurrentA,
                        NominalVoltage = preduction.NominalVoltage,
                        ThermalResistance = preduction.ThermalResistance,
                        AmbientTemperature = preduction.AmbientTemperature,
                        Lambda = preduction.Lambda,
                        LambdaRef = preduction.LambdaRef,
                        URefDivideURat = preduction.URefDivideURat,
                        PieU = preduction.PieU,
                        ThetaRef = preduction.ThetaRef,
                        ThetaOp = preduction.ThetaOp,
                        PieT = preduction.PieT,
                        USERIDZU = preduction.USERIDZU,
                        CREATEDDATE = DateTime.Now
                    };
                    _dbcontextRepo.Add(newdata);
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
