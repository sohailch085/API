using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities.IEC;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;

namespace MTS_DAL.RepositoryServices.IECRepositoryServices
{
    public class IECResistorsAndResistorNetworksServicesRepo : IECResistorsAndResistorNetworksInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public IECResistorsAndResistorNetworksServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo = dbcontextRepo;
        }

        public async Task<bool> DeleteResistorsAndResistorNetworks(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<IECPredictionResistorsAndResistorNetworks>(Trid);
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
            //throw new NotImplementedException();
        }

        public async Task<List<IECResistorsAndResistorNetworksResponseDto>> ExecuteIECResistorsAndResistorNetworks(int ResistorType, int InputType, double OperatingTemperature, double ThetaMax, double AmbiantTemperature, double LambdaRef)
        {
            var result = await _dbcontextRepo.Database.SqlQueryRaw<IECResistorsAndResistorNetworksResponseDto>("EXEC procedure_IEC_Resistors_and_resistor_networks " + ResistorType + "," + InputType + "," + OperatingTemperature + "," + ThetaMax + "," + AmbiantTemperature + "," + LambdaRef + "").ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECResistorsAndResistorNetworks>> GetIECResistorsAndResistorNetworks()
        {
            var result = await _dbcontextRepo.container.IECResistorsAndResistorNetworks.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECResistorsAndResistorNetworksInputType>> GetIECResistorsAndResistorNetworksInputType()
        {
            var result = await _dbcontextRepo.container.IECResistorsAndResistorNetworksInputType.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECPreductionResistorsAndResistorNetworksDto>> GetResistorsAndResistorNetworks()
        {
            var result =await _dbcontextRepo.container.IECPredictionResistorsAndResistorNetworks.ToListAsync();
            var final = result.Select(x => new IECPreductionResistorsAndResistorNetworksDto 
            {
                Trid = x.Trid,
                PROJECTID = x.PROJECTID,
                WBS = x.WBS,
                ResistorType =Convert.ToInt32(x.ResistorType),
                InputType=Convert.ToInt32(x.InputType),
                OperatingTemperature=Convert.ToDouble(x.OperatingTemperature),
                ThetaMax=Convert.ToDouble(x.ThetaMax),
                AmbiantTemperature=Convert.ToDouble(x.AmbiantTemperature),
                Lambda= Convert.ToDouble(x.Lambda),
                LambdaRef=Convert.ToDouble(x.LambdaRef),
                ThetaRef=Convert.ToDouble(x.ThetaRef),
                ThetaOp=Convert.ToDouble(x.ThetaOp),
                PieT=Convert.ToDouble(x.PieT),
                CREATEDDATE=Convert.ToDateTime(x.CREATEDDATE),
                UPDATEDATE= Convert.ToDateTime(x.UPDATEDATE),
                USERIDZU=x.USERIDZU
            }).ToList();
            return final;
           // throw new NotImplementedException();
        }

        public async Task<bool> SaveResistorsAndResistorNetworks(IECPreductionResistorsAndResistorNetworksDto preduction)
        {
            try
            {
                IECPredictionResistorsAndResistorNetworks? exists = null;
                if (preduction.Trid != 0)
                {
                    exists = await _dbcontextRepo.FindAsync<IECPredictionResistorsAndResistorNetworks>(preduction.Trid);
                }

                if (exists != null)
                {
                    exists.PROJECTID = preduction.PROJECTID;
                    exists.WBS = preduction.WBS;
                    exists.ResistorType=preduction.ResistorType;
                    exists.InputType = preduction.InputType;
                    exists.OperatingTemperature = preduction.OperatingTemperature;
                    exists.ThetaMax = preduction.ThetaMax;
                    exists.AmbiantTemperature = preduction.AmbiantTemperature;
                    exists.Lambda = preduction.Lambda;
                    exists.LambdaRef = preduction.LambdaRef;
                    exists.ThetaRef = preduction.ThetaRef;
                    exists.ThetaOp = preduction.ThetaOp;
                    exists.PieT = preduction.PieT;
                    exists.UPDATEDATE = DateTime.Now;
                    exists.USERIDZU = preduction.USERIDZU;
                    _dbcontextRepo.Update(exists);
                }
                else
                {
                    IECPredictionResistorsAndResistorNetworks newdata = new IECPredictionResistorsAndResistorNetworks
                    {
                        PROJECTID = preduction.PROJECTID,
                        WBS = preduction.WBS,
                        ResistorType = preduction.ResistorType,
                        InputType = preduction.InputType,
                        OperatingTemperature = preduction.OperatingTemperature,
                        ThetaMax = preduction.ThetaMax,
                        AmbiantTemperature = preduction.AmbiantTemperature,
                        Lambda = preduction.Lambda,
                        LambdaRef = preduction.LambdaRef,
                        ThetaRef = preduction.ThetaRef,
                        ThetaOp = preduction.ThetaOp,
                        PieT = preduction.PieT,
                        CREATEDDATE = DateTime.Now,
                        USERIDZU = preduction.USERIDZU,
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
