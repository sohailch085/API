using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.IEC;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;

namespace MTS_DAL.RepositoryServices.IECRepositoryServices
{
    public class IECSwitchesAndPushButtonsForLowElectricalStressServicesRepo : IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public IECSwitchesAndPushButtonsForLowElectricalStressServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteSwitchesAndPushButtonsForLowElectricalStress(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<IECPredictionSwitchesAndPushButtonsForLowElectricalStress>(Trid);
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

        public async Task<List<IECSwitchesAndPushButtonsForLowElectricalStressResponseDto>> ExecuteSPIECSwitchesAndPushButtonsForLowElectricalStress(int RegionType, int LoadType, double LambdaRef)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<IECSwitchesAndPushButtonsForLowElectricalStressResponseDto>("EXEC procedure_IEC_Switches_and_push_buttons " + RegionType + "," + LoadType + "," + LambdaRef + "").ToListAsync();
            return result;
        }

        public async Task<List<IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto>> GetIECPreductionSwitchesAndPushButtonsForLowElectricalStress()
        {
            var result = await _dbcontextRepo.container.IECPredictionSwitchesAndPushButtonsForLowElectricalStress.ToListAsync();
            var final = result.Select(x => new IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto
            {
                Trid = x.Trid,
                PROJECTID = x.PROJECTID,
                WBS = x.WBS,
                RegionType = Convert.ToInt32(x.RegionType),
                LoadType = Convert.ToInt32(x.LoadType),
                Lambda = Convert.ToDouble(x.Lambda),
                LambdaRef = Convert.ToDouble(x.LambdaRef),
                PieEs=Convert.ToDouble(x.PieEs),
                CREATEDDATE = Convert.ToDateTime(x.CREATEDDATE),
                UPDATEDATE = Convert.ToDateTime(x.UPDATEDATE),
                USERIDZU= x.USERIDZU
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public async Task<List<IECSwitchesAndPushButtonsForLowElectricalStress>> GetIECSwitchesAndPushButtonsForLowElectricalStress()
        {
            var result = await _dbcontextRepo.container.IECSwitchesAndPushButtonsForLowElectricalStress.ToListAsync();
            return result;
        }

        public async Task<bool> SaveSwitchesAndPushButtonsForLowElectricalStress(IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto preduction)
        {
            try
            {
                IECPredictionSwitchesAndPushButtonsForLowElectricalStress? exists = null;
                if (preduction.Trid != 0)
                {
                    exists = await _dbcontextRepo.FindAsync<IECPredictionSwitchesAndPushButtonsForLowElectricalStress>(preduction.Trid);
                }

                if (exists != null)
                {
                    exists.PROJECTID = preduction.PROJECTID;
                    exists.WBS = preduction.WBS;
                    exists.RegionType = preduction.RegionType;
                    exists.LoadType = preduction.LoadType;
                    exists.Lambda = preduction.Lambda;
                    exists.LambdaRef = preduction.LambdaRef;
                    exists.PieEs = preduction.PieEs;
                    exists.UPDATEDATE = DateTime.Now;
                    exists.USERIDZU = preduction.USERIDZU;
                    _dbcontextRepo.Update(exists);
                }
                else
                {
                    IECPredictionSwitchesAndPushButtonsForLowElectricalStress newdata = new IECPredictionSwitchesAndPushButtonsForLowElectricalStress
                    {
                        PROJECTID = preduction.PROJECTID,
                        WBS = preduction.WBS,
                        RegionType = preduction.RegionType,
                        LoadType = preduction.LoadType,
                        Lambda = preduction.Lambda,
                        LambdaRef = preduction.LambdaRef,
                        PieEs = preduction.PieEs,
                        CREATEDDATE = DateTime.Now,
                        USERIDZU = preduction.USERIDZU
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
