using Microsoft.EntityFrameworkCore;
using MTS_COMMON.ModelDTO.Collection;
using MTS_DAL.DBContextRepository;
using MTS_DAL.Entities;
using MTS_DAL.InterfaceRepo;

namespace MTS_DAL.RepositoryServices
{
    public class RAMProjectsServicesRepo : RAMProjectsInterfaceRepo
    {
        private readonly DbcontextRepo _dbcontextRepo;
        public RAMProjectsServicesRepo(DbcontextRepo dbcontextRepo)
        {
            _dbcontextRepo=dbcontextRepo;
        }
        public async Task<bool> DeleteRAMProjects(int Trid)
        {
            try
            {
                var result = await _dbcontextRepo.FindAsync<RAMProjects>(Trid);
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

        public async Task<IList<RAMProjects>> GetRAMProjects()
        {
            var result = await _dbcontextRepo.container.RAMProjects.ToListAsync();
            return result;
        }

        public bool SaveRAMProject(RAMProjectsCollectionDto projects)
        {
            try
            {
                RAMProjects? exists = null;

                if (projects.TRID> 0)
                {
                    exists = _dbcontextRepo.Find<RAMProjects>(projects.TRID);

                    if (exists != null)
                    {
                        exists.EIACODXA = projects.EIACODXA ?? string.Empty;
                        exists.LCNTYPXB = projects.LCNTYPXB ?? string.Empty;
                        exists.TYPEOFPRODUCTID=Convert.ToInt64(projects.TYPEOFPRODUCTID);
                        exists.LIFECYCLEPHASEID=Convert.ToInt64(projects.LIFECYCLEPHASEID);
                        exists.PROJECTNAME=projects.PROJECTNAME;
                      //  exists.OPERATIONLIFE = projects.OPERATIONLIFE;
                        exists.DESCRIPTION = projects.DESCRIPTION;
                        exists.REMARKS = projects.REMARKS;
                        exists.PROGRAMSTARTDATE =Convert.ToDateTime(projects.PROGRAMSTARTDATE);
                        exists.PROGRAMENDDATE =Convert.ToDateTime(projects.PROGRAMENDDATE);
                        exists.USERIDZU=projects.USERIDZU;
                        _dbcontextRepo.Update(exists);
                    }
                }
                else
                {
                    RAMProjects newdata = new RAMProjects
                    {
                        EIACODXA = projects.EIACODXA ?? string.Empty,
                        LCNTYPXB = projects.LCNTYPXB ?? string.Empty,
                        TYPEOFPRODUCTID =Convert.ToInt64(projects.TYPEOFPRODUCTID),
                        LIFECYCLEPHASEID =Convert.ToInt64(projects.LIFECYCLEPHASEID),
                        PROJECTNAME = projects.PROJECTNAME,
                      //  OPERATIONLIFE = projects.OPERATIONLIFE,
                        DESCRIPTION = projects.DESCRIPTION,
                        REMARKS = projects.REMARKS,
                        PROGRAMSTARTDATE =Convert.ToDateTime(projects.PROGRAMSTARTDATE),
                        PROGRAMENDDATE =Convert.ToDateTime(projects.PROGRAMENDDATE),
                        USERIDZU = projects.USERIDZU,
                    };
                    _dbcontextRepo.Add(newdata);
                }
                _dbcontextRepo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
