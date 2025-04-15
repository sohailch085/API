using Microsoft.EntityFrameworkCore;
using MTS_DAL.Entities;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.Entities.IEC;

namespace MTS_DAL.DBContextRepository
{
    public class DbcontextRepo : DbContext
    {
        public DbSetContainer container { get; private set; }
        public DbcontextRepo(DbContextOptions<DbcontextRepo> options) : base(options) 
        {
            container = new DbSetContainer(this);
        }               
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PredictionCategories>()
                .HasOne(p => p.PreductionHandBook)
                .WithMany()
                .HasForeignKey(p=> p.BOOKID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RAMProjects>()
                .HasOne(p=> p.productTypes)
                .WithMany()
                .HasForeignKey(p=> p.TYPEOFPRODUCTID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RAMProjects>()
                .HasOne(p => p.lifecyclephases)
                .WithMany()
                .HasForeignKey(p => p.LIFECYCLEPHASEID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RAMPARTS>()
                .HasOne(p => p.RAMCAGE)
                .WithMany()
                .HasForeignKey(p => p.CAGECDXH)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RAMBRAKDOWN>()
                .HasKey(r => new { r.PWBS, r.WBS });

            modelBuilder.Entity<RAMBRAKDOWN>()
                .HasOne(r => r.RAMProjects)
                .WithMany()
                .HasForeignKey(r => r.PROJECTID)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<RAMBRAKDOWNPARTS>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<RAMBRAKDOWNPARTS>()
                .HasOne(p => p.RAMBRAKDOWN)
                .WithMany(r => r.RAMBRAKDOWNPARTS)
                .HasForeignKey(p => new { p.PWBS, p.WBS })
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RAMBRAKDOWNPARTS>()
                .HasOne(p => p.RAMProjects)
                .WithMany()
                .HasForeignKey(p => p.PROJECTID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionCapacitor>()
                .HasOne(p => p.Projects)
                .WithMany()
                .HasForeignKey(p => p.PROJECTID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionCapacitor>()
             .HasOne(p => p.iECCapacitorsSubCategory)
             .WithMany()
             .HasForeignKey(p => p.SUBCATEGORYID)
             .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionCapacitor>()
                .HasOne(p => p.iECCapacitorsTypes)
                .WithMany()
                .HasForeignKey(p => p.TYPEID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECCapacitorsTypes>()
                .HasOne(p => p.iECCapacitorsSubCategory)
                .WithMany()
                .HasForeignKey(p => p.CATEGORYID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECConstantsForVoltageDependenceOfCapacitor>()
              .HasOne(p => p.iECCapacitorsTypes)
              .WithMany()
              .HasForeignKey(p => p.CapacitorTypeID)
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECConstantsForTemperatureDependenceOfCapacitor>()
             .HasOne(p => p.iECCapacitorsTypes)
             .WithMany()
             .HasForeignKey(p => p.CapacitorTypeID)
             .OnDelete(DeleteBehavior.NoAction);         

            modelBuilder.Entity<IECPredictionDiscreteSemiconductors>()
                .HasOne(d => d.iECDiscreteSemiconductors)
                .WithMany()
                .HasForeignKey(d => d.SUBCATEGORYID)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<IECPredictionDiscreteSemiconductors>()
                .HasOne(d => d.iECDiscreteSemiconductorsSubcategory)
                .WithMany()
                .HasForeignKey(d => d.TYPESID)
                .OnDelete(DeleteBehavior.NoAction);
           
            //modelBuilder.Entity<IECPredictionDiscreteSemiconductors>()
            //    .HasOne(d => d.iECConstantsForTemperatureDependenceOfDiscreteSemiconductors)
            //    .WithMany()
            //    .HasForeignKey(d => d.ConstantsTypeID)
            //    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionDiscreteSemiconductors>()
                .HasOne(p => p.RAMProjects)
                .WithMany()
                .HasForeignKey(p => p.ProjectID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECDiscreteSemiconductorsSubcategory>()
                .HasOne(d=> d.iECDiscreteSemiconductors)
                .WithMany()
                .HasForeignKey(d=> d.SUBCATEGORYID)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<IECDiscreteSemiconductorsSubcategory>()
                .HasOne(d => d.iECConstantsForTemperatureDependenceOfDiscreteSemiconductors)
                .WithMany()
                .HasForeignKey(d => d.CONSTANTSTYPEID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECOptoelectronicComponentsTypes>()
                .HasOne(p => p.iECOptoelectronicComponents)
                .WithMany()
                .HasForeignKey(p => p.SubCategoryId)
                .OnDelete(DeleteBehavior.NoAction);                      

            modelBuilder.Entity<IECPredictionOptoelectronicComponent>()
                .HasOne(p => p.rAMProjects)
                .WithMany()
                .HasForeignKey(d => d.PROJECTid)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionOptoelectronicComponent>()
                .HasOne(p=> p.iECOptoelectronicComponentsSub)
                .WithMany()
                .HasForeignKey(p=> p.SubCategoryId)
                .OnDelete(DeleteBehavior.NoAction);
            
            //modelBuilder.Entity<IECPredictionOptoelectronicComponent>()
            //    .HasOne(p => p.iECConstantsForTemperatureDependence)
            //    .WithMany()
            //    .HasForeignKey(p => p.ConstantsTypeId)
            //    .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<IECPredictionOptoelectronicComponent>()
                .HasOne(p => p.iECOptoelectronicComponents)
                .WithMany()
                .HasForeignKey(p => p.TypesId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionInductorsTransformersAndCoils>()
                .HasOne(p=> p.Projects)
                .WithMany()
                .HasForeignKey(p => p.PROJECTID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionInductorsTransformersAndCoils>()
              .HasOne(p => p.iECInductorsTransformersAndCoilsSubCategory)
              .WithMany()
              .HasForeignKey(p => p.SubCategoryId)
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionInductorsTransformersAndCoils>()
            .HasOne(p => p.iECInductorsTransformersAndCoilsTypes)
            .WithMany()
            .HasForeignKey(p => p.TypeId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionIntegratedSemiconductorCircuits>()
                .HasOne(p => p.RAMProject)
                .WithMany()
                .HasForeignKey(p => p.ProjectID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionRelays>()
                .HasOne(p => p.iECConstantsForTemperatureDependenceOfRelays)
                .WithMany()
                .HasForeignKey(p => p.SupportingConstructionType)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionResistorsAndResistorNetworks>()
                .HasOne(p => p.iECResistorsAndResistor)
                .WithMany()
                .HasForeignKey(p => p.ResistorType)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionResistorsAndResistorNetworks>()
                .HasOne(p => p.eCResistorsAndResistorNetworksInputType)
                .WithMany()
                .HasForeignKey(p => p.InputType)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECPredictionSwitchesAndPushButtonsForLowElectricalStress>()
                .HasOne(p => p.Projects)
                .WithMany()
                .HasForeignKey(p => p.PROJECTID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IECRelay>()
               .HasKey(p => p.Trid);

             modelBuilder.Entity<IECRegionType>()
               .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECChildRegion>()
               .HasKey(p => p.Trid); 
            
            modelBuilder.Entity<IECChildRegionACorDC>()
               .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECTypeComponent>()
               .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECTypeComponentSubCategory>()
               .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECConstantForVoltageDependence>()
               .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECConstantForVoltageDependence>()
               .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECRelayLoadCategory>()
               .HasKey(p => p.Trid); 
            
            modelBuilder.Entity<IECRelayLoadType>()
               .HasKey(p => p.Trid);
            
            
            modelBuilder.Entity<IECSwitchesAndPushButtonsForLowElectricalStress>()
               .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECInductorsTransformersAndCoilsSubCategory>()
               .HasKey(p => p.SubCategoryId);

            modelBuilder.Entity<IECConstantsForTemperatureDependenceOfOptoelectronicComponents>()
                .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECConstantsForTemperatureDependence>()
                .HasKey(p => p.Trid);
            
            modelBuilder.Entity<IECOptoelectronicComponentsTypes>()
                .HasKey(p => p.TypeId);
            
            modelBuilder.Entity<IECOptoelectronicComponentsSubCategory>()
                .HasKey(p => p.SubCategoryId);

            modelBuilder.Entity<IECInductorsTransformersAndCoilsTypes>()
                .HasOne(p => p.SubCategory)
                .WithMany()
                .HasForeignKey(p => p.SubCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<R2Capacitor>()
               .HasKey(p => p.Trid);

            modelBuilder.Entity<R2Diode>()
              .HasKey(p => p.Trid);

            modelBuilder.Entity<R2IntegratedCircuitsPlasticEncapsulatedPackageType>()
              .HasKey(p => p.Trid);

            modelBuilder.Entity<R2IntegratedCircuitsPlasticEncapsulatedPartType>()
              .HasKey(p => p.Trid);

            modelBuilder.Entity<R2IntegratedCircuitsPlasticEncapsulatedPartType>()
               .HasOne(p => p.PlasticEncapsulatedPackageType)
               .WithMany()
               .HasForeignKey(p => p.PackageTypeId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<R2Inductors>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2Transformers>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2OptoelectronicDevices>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2Switches>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2Relays>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2Connectors>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2Resistors>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2Thyristor>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2PhotonicsDevices>()
                .HasKey(p => p.Trid);

            modelBuilder.Entity<R2Transistor>()
                .HasKey(p => p.Trid);

        }
    }
}
