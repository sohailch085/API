using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.IEC;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;

namespace MTS_DAL.RepositoryServices.IECRepositoryServices
{
    public class IECDiscreteSemiconductorsServicesRepo : IECDiscreteSemiconductorsInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;

        public IECDiscreteSemiconductorsServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<List<SemiconductorResponseDto>> ExecuteIECDiscreteSemiconductors(int SUBCATEGORYID, int TYPESID,  double RatedVoltageInV, double NominalVoltage, double ThermalResistance, double AmbientTemperature, double MaximumSupplyCurrentA, double WorstCasePowerDissipationAtMaximumFrequencyW, double OperatingFrequencyMHz, double MaximumOperatingFrequencyMHz, double OperatingVoltageInV, double LambdaRef)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<SemiconductorResponseDto>("EXEC procedure_IEC_Discrete_semiconductors " + SUBCATEGORYID + "," + TYPESID + "," + RatedVoltageInV + "," + NominalVoltage + "," + ThermalResistance + "," + AmbientTemperature + "," + MaximumSupplyCurrentA + "," + WorstCasePowerDissipationAtMaximumFrequencyW + "," + OperatingFrequencyMHz + "," + MaximumOperatingFrequencyMHz + "," + OperatingVoltageInV + "," + LambdaRef + "").ToListAsync();
            var final = result.Select(c => new SemiconductorResponseDto
            {
                Lambda = c.Lambda,
                LambdaRef = c.LambdaRef,
                UopDivideUrat = c.UopDivideUrat,
                PieU = c.PieU,
                ThetaRef = c.ThetaRef,
                ThetaOp = c.ThetaOp,
                PieT = c.PieT
            }).ToList();
            return final;
        }
        //public List<IECConstantsForTemperatureDependenceOfDiscreteSemiconductors> GetIECConstantsForTemperatureDependenceOfDiscreteSemiconductors()
        //{
        //    var result =_dbcontextRepo.container.IECConstantsForTemperatureDependenceOfDiscreteSemiconductors.ToList();
        //    return result;
        //}
        public List<IECDiscreteSemiconductors> GetIECDiscreteSemiconductors()
        {
            var result =  _dbcontextRepo.container.IECDiscreteSemiconductors.ToList();
            return result;
        }
        public Task<List<IECDiscreteSemiconductorsSubcategory>> GetIECDiscreteSemiconductorsSubcategory(int SUBCATEGORYID)
        {
            var result = _dbcontextRepo.container.IECDiscreteSemiconductorsSubcategory.Where(x => x.SUBCATEGORYID == SUBCATEGORYID).ToListAsync();
            return result;
        }

        public async Task<bool> SaveDiscreteSemiconductors(IECDiscreteSemiconductorsCollectionDto preductionsemiconductors)
        {
            try
            {
                IECPredictionDiscreteSemiconductors? exists = null;
                if (preductionsemiconductors.Trid > 0)
                {
                    exists = await _dbcontextRepo.FindAsync<IECPredictionDiscreteSemiconductors>(preductionsemiconductors.Trid);

                    if (exists != null)
                    {
                        exists.ProjectID = preductionsemiconductors.ProjectID;
                        exists.WBS = preductionsemiconductors.WBS;
                        exists.SUBCATEGORYID = preductionsemiconductors.SUBCATEGORYID;
                        exists.TYPESID = preductionsemiconductors.TYPESID;
                        exists.RatedVoltage = preductionsemiconductors.RatedVoltageInV;
                        exists.NominalVoltage = preductionsemiconductors.NominalVoltage;
                        exists.ThermalResistance = preductionsemiconductors.ThermalResistance;
                        exists.AmbientTemperature = preductionsemiconductors.AmbientTemperature;
                        exists.MaxSupplyCurrent = preductionsemiconductors.MaximumSupplyCurrentA;
                        exists.Pfwc = preductionsemiconductors.WorstCasePowerDissipationAtMaximumFrequencyW;
                        exists.Fop = preductionsemiconductors.OperatingFrequencyMHz;
                        exists.Fmax = preductionsemiconductors.MaximumOperatingFrequencyMHz;
                        exists.Lambda = preductionsemiconductors.Lambda;
                        exists.LambdaRef = preductionsemiconductors.LambdaRef;
                        exists.UopDivideUrat = preductionsemiconductors.UopDivideUrat;
                        exists.PieU = preductionsemiconductors.PieU;
                        exists.ThetaRef = preductionsemiconductors.ThetaRef;
                        exists.ThetaOp = preductionsemiconductors.ThetaOp;
                        exists.PieT = preductionsemiconductors.PieT;
                        exists.USERIDZU = preductionsemiconductors.USERIDZU;
                        preductionsemiconductors.UpdateDate = DateTime.Now;
                        exists.UpdateDate = preductionsemiconductors.UpdateDate;
                        _dbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    IECPredictionDiscreteSemiconductors data = new IECPredictionDiscreteSemiconductors
                    {
                        ProjectID = preductionsemiconductors.ProjectID,
                        WBS = preductionsemiconductors.WBS,
                        SUBCATEGORYID = preductionsemiconductors.SUBCATEGORYID,
                        TYPESID = preductionsemiconductors.TYPESID,
                        RatedVoltage = preductionsemiconductors.RatedVoltageInV,
                        NominalVoltage = preductionsemiconductors.NominalVoltage,
                        ThermalResistance = preductionsemiconductors.ThermalResistance,
                        AmbientTemperature = preductionsemiconductors.AmbientTemperature,
                        MaxSupplyCurrent = preductionsemiconductors.MaximumSupplyCurrentA,
                        Pfwc = preductionsemiconductors.WorstCasePowerDissipationAtMaximumFrequencyW,
                        Fop = preductionsemiconductors.OperatingFrequencyMHz,
                        Fmax = preductionsemiconductors.MaximumOperatingFrequencyMHz,
                        OperatingVoltage = preductionsemiconductors.OperatingVoltageInV,
                        Lambda = preductionsemiconductors.Lambda,
                        LambdaRef = preductionsemiconductors.LambdaRef,
                        UopDivideUrat = preductionsemiconductors.UopDivideUrat,
                        PieU = preductionsemiconductors.PieU,
                        ThetaRef = preductionsemiconductors.ThetaRef,
                        ThetaOp = preductionsemiconductors.ThetaOp,
                        PieT = preductionsemiconductors.PieT,
                        USERIDZU = preductionsemiconductors.USERIDZU,
                        CreatedDate = DateTime.Now,
                        UpdateDate = preductionsemiconductors.UpdateDate
                    };
                    await _dbcontextRepo.AddAsync(data);
                }
                await _dbcontextRepo.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<IECDiscreteSemiconductorsCollectionDto>> GetPreductionDiscreteSemiconductors()
        {
            var restult = await _dbcontextRepo.container.IECPredictionDiscreteSemiconductors.ToListAsync();
            //var final = restult.Select(x => new IECDiscreteSemiconductorsCollectionDto
            //{
            //    Trid = x.Trid,
            //    ProjectID =Convert.ToInt32(x.ProjectID),
            //    WBS = x.WBS ?? string.Empty,
            //    SubCategoryID =Convert.ToInt32(x.SubCategoryID),
            //    ComponentTypeID =Convert.ToInt32(x.ComponentTypeID),
            //    ConstantsTypeID =Convert.ToInt32(x.ConstantsTypeID),
            //    RatedVoltageInV = x.RatedVoltageInV,
            //    NominalVoltage = x.NominalVoltage,
            //    ThermalResistance = x.ThermalResistance,
            //    AmbientTemperature = x.AmbientTemperature,
            //    MaximumSupplyCurrentA = x.MaxSupplyCurrent,
            //    WorstCasePowerDissipationAtMaximumFrequencyW = x.WorstCasePowerDissipationAtMaximumFrequencyW,
            //    OperatingFrequencyMHz = x.OperatingFrequencyMHz,
            //    MaximumOperatingFrequencyMHz = x.MaximumOperatingFrequencyMHz,
            //    OperatingVoltageInV = x.OperatingVoltageInV,
            //    Lambda = x.Lambda,
            //    LambdaRef = x.LambdaRef,
            //    UopDivideUrat = x.UopDivideUrat,
            //    PieU = x.PieU,
            //    ThetaRef = x.ThetaRef,
            //    ThetaOp = x.ThetaOp,
            //    PieT = x.PieT,
            //    USERIDZU = x.USERIDZU,
            //    CreatedDate = x.CreatedDate,
            //    UpdateDate = x.UpdateDate
            //}).ToList();
            return null; //restult;
        }

        public async Task<bool> DeleteDiscreteSemiconductors(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<IECPredictionDiscreteSemiconductors>(Trid);
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
    }
}
