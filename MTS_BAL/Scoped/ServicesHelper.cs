using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MTS_BAL.InterfaceServices;
using MTS_BAL.Services;
using MTS_COMMON.Helper.Security;
using MTS_DAL.DBContextRepository;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;
using MTS_DAL.RepositoryServices.IECRepositoryServices;
using MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoInterfaceRepo;
using MTS_DAL.RepositoryServices.TwoOneSeveenNoticeTwoRepositoryServices;
using MTS_DAL.InterfaceRepo;
using MTS_DAL.RepositoryServices;

namespace MTS_BAL.Helper
{
    public static class ServicesHelper
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {           
            string? encryptConnectionStr = configuration.GetConnectionString("ConnectionStr");
            string convertstr = string.IsNullOrEmpty(encryptConnectionStr) ? string.Empty : EncryptOrDecrypt.DecryptString(encryptConnectionStr);

            services.AddDbContext<DbcontextRepo>
                (options =>
                        options.UseSqlServer(convertstr)
                       .EnableSensitiveDataLogging()
                       .LogTo(Console.WriteLine)
                );

            #region Application Scoped

            services.AddScoped<PredictionHandBookInterfaceRepo, PredictionHandBookServicesRepo>();
            services.AddScoped<PredictionCategoriesInterfaceRepo, PredictionCategoriesServicesRepo>();
            services.AddScoped<RAMCAGEInterfaceRepo, RAMCAGEServicesRepo>();
            services.AddScoped<LifecyclephasesInterfaceRepo, LifecyclephasesServicesRepo>();
            services.AddScoped<RAMBRAKDOWNInterfaceRepo, RAMBRAKDOWNServicesRepo>();
            services.AddScoped<RAMProjectsInterfaceRepo, RAMProjectsServicesRepo>();
            services.AddScoped<ApplicationScopInterface, ApplicationScopServices>();
            #endregion

            #region IEC

            services.AddScoped<IECCapacitorsInterfaceRepo, IECCapacitorsServicesRepo>();
            services.AddScoped<IECIntegratedSemiconductorCircuitsInterfaceRepo, IECIntegratedSemiconductorCircuitsServicesRepo>();
            services.AddScoped<IECDiscreteSemiconductorsInterfaceRepo, IECDiscreteSemiconductorsServicesRepo>();
            services.AddScoped<IECOptoelectronicComponentsInterfaceRepo, IECOptoelectronicComponentsServicesRepo>();
            services.AddScoped<IECResistorsAndResistorNetworksInterfaceRepo, IECResistorsAndResistorNetworksServicesRepo>();
            services.AddScoped<IECInductorsTransformersAndCoilsInterfaceRepo, IECInductorsTransformersAndCoilsServicesRepo>();
            services.AddScoped<IECRelaysInterfaceRepo, IECRelaysServicesRepo>();
            services.AddScoped<IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo, IECSwitchesAndPushButtonsForLowElectricalStressServicesRepo>();
            services.AddScoped<IECInterface, IECServices>();

            #endregion

            #region 217Plus

            services.AddScoped<R2CapacitorInterfaceRepo, R2CapacitorRepositoryServices>();
            services.AddScoped<R2DiodeInterfaceRepo, R2DiodeRepositoryServices>();
            services.AddScoped<R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo, R2IntegratedCircuitsPlasticEncapsulatedORHERMETICRepositoryServices>();
            services.AddScoped<R2InductorsInterfaceRepo, R2InductorsRepositoryServices>();
            services.AddScoped<R2TransformersInterfaceRepo, R2TransformersRepositoryServices>();
            services.AddScoped<R2OptoelectronicDevicesInterfaceRepo, R2OptoelectronicDevicesRepositoryServices>();
            services.AddScoped<R2SwitchesInterfaceRepo, R2SwitchesRepositoryServices>();
            services.AddScoped<R2RelaysInterfaceRepo, R2RelaysRepositoryServices>();
            services.AddScoped<R2ConnectorsInterfaceRepo, R2ConnectorsRepositoryServices>();
            services.AddScoped<R2ResistorsInterfaceRepo, R2ResistorsRepositoryServivces>();
            services.AddScoped<R2ThyristorInterfaceRepo, R2ThyristorRepositoryServices>();
            services.AddScoped<TwoOneSeveenNoticeTwoInterface, TwoOneSevenNoticeTwoServices>();

            #endregion


          
        }
    }
}
