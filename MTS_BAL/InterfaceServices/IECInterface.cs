using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;

namespace MTS_BAL.InterfaceServices
{
    public interface IECInterface
    {
        Task<List<IECCapacitorsDto>> GetIECCapacitors();
        Task<List<IECCapacitorsTypesDto>> GetIECCapacitorsTypes(int CATEGORYID);
        Task<List<IECCapacitorResponseDto>> ExecuteStoredProcedure
            (
                int SUBCATEGORYID,
                int TYPEID,
                double OPERATINGVOLTAGEINV,
                double RATEDVOLTAGEINV,
                double AVERAGEACTUALTEMPERATURE,
                double LAMBDAREF
            );

        Task<bool> SaveCapacitor(IECPreductionCapacitorCollectionDto preductionCapacitors);
        Task<bool> DeleteCapacitor(long Trid);
        Task<List<IECPreductionCapacitorCollectionDto>> GetIECPreductionCapacitor();

        Task<List<IECTypeComponent>> GetIECTypeComponent();
        Task<List<IECTypeComponentSubCategoryDto>> GetIECTypeComponentSubCategory(int SubComponentId);
        Task<List<IECConstantForVoltageDependenceDto>> GetIECConstantForVoltageDependence();
        Task<List<IECConstantsForTemperatureDependenceDto>> GetIECConstantsForTemperatureDependence();
        Task<List<IECIntegratedSemiconductorCircuitsResponseDto>> ExecuteSpIECIntegratedSemiconductorCircuits
            (
                int CircuitType,
                int SubComponent,
                int ConstantsType,
                double OperatingVoltageInV,
                double RatedVoltageInV,
                double OperatingFrequencyMHz,
                double MaximumOperatingFrequencyMHz,
                double WorstCasePowerDissipationAtTheMaximumFrequencyW,
                double MaximumSupplyCurrentA,
                double NominalVoltage,
                double ThermalResistance,
                double AmbientTemperature,
                double LambdaRef
            );
        Task<List<IECPreductionIntegratedSemiconductorCircuitsDto>> GetPreductionIntegratedSemiconductorCircuits();
        Task<bool> SaveIntegratedSemiconductorCircuits(IECPreductionIntegratedSemiconductorCircuitsDto preduction);
        Task<bool> DeleteIntegratedSemiconductorCircuits(int Trid);
        //SOHAIL
     //   List<IECConstantsForTemperatureDependenceOfDiscreteSemiconductorsDto> GetIECConstantsForTemperatureDependenceOfDiscreteSemiconductors();
        List<IECDiscreteSemiconductors> GetIECDiscreteSemiconductors();
        Task<List<IECDiscreteSemiconductorsSubcategoryDto>> GetIECDiscreteSemiconductorsSubcategory(int SubComponentId);
        Task<List<SemiconductorResponseDto>> ExecuteIECDiscreteSemiconductors
          (
              int SUBCATEGORYID,
              int TYPESID,
              double RatedVoltageInV,
              double NominalVoltage,
              double ThermalResistance,
              double AmbientTemperature,
              double MaximumSupplyCurrentA,
              double WorstCasePowerDissipationAtMaximumFrequencyW,
              double OperatingFrequencyMHz,
              double MaximumOperatingFrequencyMHz,
              double OperatingVoltageInV,
              double LambdaRef
          );
        Task<bool> SaveDiscreteSemiconductors(IECDiscreteSemiconductorsCollectionDto preductionsemiconductors);
        Task<List<IECDiscreteSemiconductorsCollectionDto>> GetPreductionDiscreteSemiconductors();
        Task<bool> DeleteDiscreteSemiconductors(int Trid);

        List<IECConstantsForTemperatureDependenceOfOptoelectronicComponentsDto> GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents();
        List<IECOptoelectronicComponents> GetIECOptoelectronicComponents();
        Task<List<IECOptoelectronicComponentsSubCategoryDto>> GetIECOptoelectronicComponentsSubCategory(int SubCategoryId);
        List<IECPreductionOptoelectronicComponentDto> GetPreductionOptoelectronicComponents();
        Task<List<IECOptoelectronicComponentsResponseDto>> ExecuteIECOptoelectronicComponents
         (
             int OptoelectronicTypes,
             int OptoelectronicComponentsSubCategory,
             int ConstantsType,
             double OperatingVoltageInV,
             double ReferenceVoltageInV,
             double RatedVoltageInV,
             double OperatingFrequencyMHz,
             double MaximumOperatingFrequencyMHz,
             double WorstCasePowerDissipationAtMaximumFrequencyW,
             double MaximumSupplyCurrentA,
             double NominalVoltage,
             double ThermalResistance,
             double AmbientTemperature,
             double LambdaRef
         );
        Task<bool> SaveOptoelectronicComponent(IECPreductionOptoelectronicComponentDto OptoelectronicComponent);
        Task<bool> DeleteOptoelectronicComponent(int Trid);

        Task<List<IECResistorsAndResistorNetworksDto>> GetIECResistorsAndResistorNetworks();
       Task<List<IECResistorsAndResistorNetworksInputTypeDto>> GetIECResistorsAndResistorNetworksInputType();
        Task<List<IECResistorsAndResistorNetworksResponseDto>> ExecuteIECResistorsAndResistorNetworks
          (
              int ResistorType,
              int InputType,
              double OperatingTemperature,
              double ThetaMax,
              double AmbiantTemperature,
              double LambdaRef
          );
        Task<List<IECPreductionResistorsAndResistorNetworksDto>> GetResistorsAndResistorNetworks();
        Task<bool> SaveResistorsAndResistorNetworks(IECPreductionResistorsAndResistorNetworksDto preduction);
        Task<bool> DeleteResistorsAndResistorNetworks(int Trid);


        List<IECInductorsTransformersAndCoilsDto> GetIECInductorsTransformersAndCoils();
        Task<List<IECInductorsTransformersAndCoilsResponseDto>> ExecuteSPIECInductorsTransformersAndCoils
            (
                int TransformersType,
                double OperatingFrequencyMHz,
                double MaximumOperatingFrequencyMHz,
                double WorstCasePowerDissipationAtMaximumFrequencyW,
                double MaximumSupplyCurrentA,
                double NominalVoltage,
                double ThermalResistance,
                double AmbientTemperature,
                double LambdaRef
            );
        Task<List<IECPreductionInductorsTransformersAndCoilsDto>> GetIECPreductionInductorsTransformersAndCoils();
        Task<bool> SaveInductorsTransformersAndCoils(IECPreductionInductorsTransformersAndCoilsDto preduction);
        Task<bool> DeleteInductorsTransformersAndCoils(int Trid);

        Task<List<IECConstantsForTemperatureDependenceOfRelaysDto>> GetIECConstantsForTemperatureDependenceOfRelays();
        Task<List<IECRelay>> GetIECRelay();
        Task<List<IECRegionTypeDto>> GetIECRegionType(int RegionId);
        Task<List<IECRelayLoadTypeDto>> GetIECRelayLoadType();
        Task<List<IECRelayLoadCategoryDto>> GetIECRelayLoadCategory();
        Task<List<IECRelaysResponseDto>> ExecuteSPIECRelays
            (
                int SupportingConstructionType,
                int LoadType,
                int RegionType,
                double NumberOfOperatingCyclesPerHour,
                double ReferenceNumberOperatingCyclesPerHour,
                double AmbientTemperature,
                double LambdaRef
            );
        Task<List<IECPreductionRelaysDto>> GetIECPreductionRelays();
        Task<bool> SaveRelays(IECPreductionRelaysDto preduction);
        Task<bool> DeleteRelays(int Trid);

        Task<List<IECSwitchesAndPushButtonsForLowElectricalStress>> GetIECSwitchesAndPushButtonsForLowElectricalStress();
        Task<List<IECSwitchesAndPushButtonsForLowElectricalStressResponseDto>> ExecuteSPIECSwitchesAndPushButtonsForLowElectricalStress
          (
              int RegionType,
              int LoadType,
              double LambdaRef
          );

        Task<List<IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto>> GetIECPreductionSwitchesAndPushButtonsForLowElectricalStress();
        Task<bool> SaveSwitchesAndPushButtonsForLowElectricalStress(IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto preduction);
        Task<bool> DeleteSwitchesAndPushButtonsForLowElectricalStress(int Trid);
    }
}
