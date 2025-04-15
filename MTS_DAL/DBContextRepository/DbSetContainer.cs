using Microsoft.EntityFrameworkCore;
using MTS_DAL.Entities.IEC;
using MTS_DAL.Entities;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_DAL.DBContextRepository
{
    public class DbSetContainer : IDisposable
    {
        private readonly DbContext _context;

        #region Application Scoped

        public DbSet<PredictionHandBook> PredictionHandBook { get; set; }
        public DbSet<PredictionCategories> PredictionCategories { get; set; }
        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<Lifecyclephases> Lifecyclephases { get; set; }
        public DbSet<RAMProjects> RAMProjects { get; set; }
        public DbSet<RAMCAGE> RAMCAGE { get; set; }
        public DbSet<RAMPARTS> RAMPARTS { get; set; }
        public DbSet<RAMBRAKDOWN> RAMBRAKDOWN { get; set; }
        public DbSet<RAMBRAKDOWNPARTS> RAMBRAKDOWNPARTS { get; set; }

        #endregion

        #region IEC

        public DbSet<IECPredictionCapacitor> IECPredictionCapacitor { get; set; }
        public DbSet<IECCapacitorsSubCategory> IECCapacitorsSubCategory { get; set; }
        public DbSet<IECCapacitorsTypes> IECCapacitorsTypes { get; set; }
        public DbSet<IECConstantsForVoltageDependenceOfCapacitor> IECConstantsForVoltageDependenceOfCapacitors { get; set; }
        public DbSet<IECConstantsForTemperatureDependenceOfCapacitor> IECConstantsForTemperatureDependenceOfCapacitors { get; set; }
        public DbSet<IECDiscreteSemiconductors> IECDiscreteSemiconductors { get; set; }
        public DbSet<IECDiscreteSemiconductorsSubcategory> IECDiscreteSemiconductorsSubcategory { get; set; }
        public DbSet<IECConstantsForTemperatureDependenceOfDiscreteSemiconductors> IECConstantsForTemperatureDependenceOfDiscreteSemiconductors { get; set; }
        public DbSet<IECPredictionDiscreteSemiconductors> IECPredictionDiscreteSemiconductors { get; set; }
        public DbSet<IECOptoelectronicComponentsTypes> IECOptoelectronicComponentsTypes { get; set; }
        public DbSet<IECOptoelectronicComponentsSubCategory> IECOptoelectronicComponentsSubCategory { get; set; }
        public DbSet<IECConstantsForTemperatureDependenceOfOptoelectronicComponents> IECConstantsForTemperatureDependenceOfOptoelectronicComponents { get; set; }
        public DbSet<IECPredictionOptoelectronicComponent> IECPredictionOptoelectronicComponent { get; set; }
        public DbSet<IECPredictionInductorsTransformersAndCoils> IECPredictionInductorsTransformersAndCoils { get; set; }
        public DbSet<IECTypeComponent> IECTypeComponent { get; set; }
        public DbSet<IECTypeComponentSubCategory> IECTypeComponentSubCategory { get; set; }
        public DbSet<IECConstantForVoltageDependence> IECConstantForVoltageDependence { get; set; }
        public DbSet<IECConstantsForTemperatureDependence> IECConstantsForTemperatureDependence { get; set; }
        public DbSet<IECPredictionIntegratedSemiconductorCircuits> IECPredictionIntegratedSemiconductorCircuits { get; set; }
        public DbSet<IECResistorsAndResistorNetworks> IECResistorsAndResistorNetworks { get; set; }
        public DbSet<IECResistorsAndResistorNetworksInputType> IECResistorsAndResistorNetworksInputType { get; set; }
        public DbSet<IECConstantsForTemperatureDependenceOfRelays> IECConstantsForTemperatureDependenceOfRelays { get; set; }
        public DbSet<IECPredictionResistorsAndResistorNetworks> IECPredictionResistorsAndResistorNetworks { get; set; }
        public DbSet<IECRelay> IECRelay { get; set; }
        public DbSet<IECRegionType> IECRegionType { get; set; }
        public DbSet<IECChildRegion> IECChildRegion { get; set; }
        public DbSet<IECChildRegionACorDC> IECChildRegionACorDC { get; set; }
        public DbSet<IECRelayLoadType> IECRelayLoadType { get; set; }
        public DbSet<IECRelayLoadCategory> IECRelayLoadCategory { get; set; }
        public DbSet<IECPredictionRelays> IECPredictionRelays { get; set; }
        public DbSet<IECSwitchesAndPushButtonsForLowElectricalStress> IECSwitchesAndPushButtonsForLowElectricalStress { get; set; }
        public DbSet<IECPredictionSwitchesAndPushButtonsForLowElectricalStress> IECPredictionSwitchesAndPushButtonsForLowElectricalStress { get; set; }
        public DbSet<IECInductorsTransformersAndCoilsSubCategory> IECInductorsTransformersAndCoilsSubCategory { get; set; }
        public DbSet<IECInductorsTransformersAndCoilsTypes> IECInductorsTransformersAndCoilsTypes { get; set; }

        #endregion
        //starting pint
        #region 217Plus

        public DbSet<R2Capacitor> R2Capacitor { get; set; }
        public DbSet<R2Diode> R2Diode { get; set; }
        public DbSet<R2IntegratedCircuitsPlasticEncapsulatedPackageType> R2IntegratedCircuitsPlasticEncapsulatedPackageType { get; set; }
        public DbSet<R2IntegratedCircuitsPlasticEncapsulatedPartType> R2IntegratedCircuitsPlasticEncapsulatedPartType { get; set; }
        public DbSet<R2Inductors> R2Inductors { get; set; }
        public DbSet<R2Transformers> R2Transformers { get; set; }
        public DbSet<R2OptoelectronicDevices> R2OptoelectronicDevices { get; set; }
        public DbSet<R2Switches> R2Switches { get; set; }
        public DbSet<R2Relays> R2Relays { get; set; }
        public DbSet<R2Connectors> R2Connectors { get; set; }
        public DbSet<R2Resistors> R2Resistors { get; set; }
        public DbSet<R2Thyristor> R2Thyristor { get; set; }
        public DbSet<R2PhotonicsDevices> R2PhotonicsDevices { get; set; }
        public DbSet<R2Transistor> R2Transistor { get; set; }

        #endregion       

        public DbSetContainer(DbContext context)
        {
            _context = context;

            PredictionHandBook = _context.Set<PredictionHandBook>();
            PredictionCategories = _context.Set<PredictionCategories>();
            ProductTypes = _context.Set<ProductTypes>();
            Lifecyclephases = _context.Set<Lifecyclephases>();
            RAMProjects = _context.Set<RAMProjects>();
            RAMCAGE = _context.Set<RAMCAGE>();
            RAMPARTS = _context.Set<RAMPARTS>();
            RAMBRAKDOWN = _context.Set<RAMBRAKDOWN>();
            RAMBRAKDOWNPARTS = _context.Set<RAMBRAKDOWNPARTS>();
            IECCapacitorsSubCategory = _context.Set<IECCapacitorsSubCategory>();
            IECPredictionCapacitor = _context.Set<IECPredictionCapacitor>();
            IECCapacitorsTypes = _context.Set<IECCapacitorsTypes>();
            IECConstantsForVoltageDependenceOfCapacitors = _context.Set<IECConstantsForVoltageDependenceOfCapacitor>();
            IECConstantsForTemperatureDependenceOfCapacitors = _context.Set<IECConstantsForTemperatureDependenceOfCapacitor>();
            IECPredictionDiscreteSemiconductors = _context.Set<IECPredictionDiscreteSemiconductors>();
            IECOptoelectronicComponentsTypes = _context.Set<IECOptoelectronicComponentsTypes>();
            IECOptoelectronicComponentsSubCategory = _context.Set<IECOptoelectronicComponentsSubCategory>();
            IECConstantsForTemperatureDependenceOfOptoelectronicComponents = _context.Set<IECConstantsForTemperatureDependenceOfOptoelectronicComponents>();
            IECDiscreteSemiconductors = _context.Set<IECDiscreteSemiconductors>();
            IECDiscreteSemiconductorsSubcategory = _context.Set<IECDiscreteSemiconductorsSubcategory>();
            IECConstantsForTemperatureDependenceOfDiscreteSemiconductors = _context.Set<IECConstantsForTemperatureDependenceOfDiscreteSemiconductors>();
            IECPredictionOptoelectronicComponent = _context.Set<IECPredictionOptoelectronicComponent>();
            IECPredictionInductorsTransformersAndCoils = _context.Set<IECPredictionInductorsTransformersAndCoils>();
            IECTypeComponent =_context.Set<IECTypeComponent>();
            IECTypeComponentSubCategory = _context.Set<IECTypeComponentSubCategory>();
            IECConstantForVoltageDependence = _context.Set<IECConstantForVoltageDependence>();
            IECConstantsForTemperatureDependence = _context.Set<IECConstantsForTemperatureDependence>();
            IECPredictionIntegratedSemiconductorCircuits = _context.Set<IECPredictionIntegratedSemiconductorCircuits>();
            IECResistorsAndResistorNetworks = _context.Set<IECResistorsAndResistorNetworks>();
            IECResistorsAndResistorNetworksInputType = _context.Set<IECResistorsAndResistorNetworksInputType>();
            IECConstantsForTemperatureDependenceOfRelays = _context.Set<IECConstantsForTemperatureDependenceOfRelays>();
            IECPredictionRelays = _context.Set<IECPredictionRelays>();
            IECPredictionResistorsAndResistorNetworks = _context.Set<IECPredictionResistorsAndResistorNetworks>();
            IECRelay=_context.Set<IECRelay>();
            IECRegionType=_context.Set<IECRegionType>();
            IECChildRegion=_context.Set<IECChildRegion>();
            IECChildRegionACorDC= _context.Set<IECChildRegionACorDC>();
            IECRelayLoadType = _context.Set<IECRelayLoadType>();
            IECRelayLoadCategory = _context.Set<IECRelayLoadCategory>();
            IECPredictionRelays = _context.Set<IECPredictionRelays>();
            IECSwitchesAndPushButtonsForLowElectricalStress = _context.Set<IECSwitchesAndPushButtonsForLowElectricalStress>();
            IECPredictionSwitchesAndPushButtonsForLowElectricalStress = _context.Set<IECPredictionSwitchesAndPushButtonsForLowElectricalStress>();
            IECInductorsTransformersAndCoilsSubCategory = _context.Set<IECInductorsTransformersAndCoilsSubCategory>();
            IECInductorsTransformersAndCoilsTypes = _context.Set<IECInductorsTransformersAndCoilsTypes>();

            R2Capacitor =_context.Set<R2Capacitor>();
            R2Diode = _context.Set<R2Diode>();
            R2IntegratedCircuitsPlasticEncapsulatedPackageType = _context.Set<R2IntegratedCircuitsPlasticEncapsulatedPackageType>();
            R2IntegratedCircuitsPlasticEncapsulatedPartType = _context.Set<R2IntegratedCircuitsPlasticEncapsulatedPartType>();
            R2Inductors = _context.Set<R2Inductors>();
            R2Transformers = _context.Set<R2Transformers>();
            R2OptoelectronicDevices = _context.Set<R2OptoelectronicDevices>();
            R2Switches = _context.Set<R2Switches>();
            R2Relays = _context.Set<R2Relays>();
            R2Connectors = _context.Set<R2Connectors>();
            R2Resistors = _context.Set<R2Resistors>();
            R2Thyristor = _context.Set<R2Thyristor>();
            R2PhotonicsDevices = _context.Set<R2PhotonicsDevices>();
            R2Transistor = _context.Set<R2Transistor>();   

        }

        public void Dispose()
        {
            _context?.Dispose();
        }

    }
}
