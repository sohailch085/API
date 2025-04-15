using MTS_BAL.InterfaceServices;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Collection;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.IEC;
using MTS_DAL.InterfaceRepo.IECInterfaceRepo;

namespace MTS_BAL.Services
{
    public class IECServices : IECInterface
    {
        private readonly IECCapacitorsInterfaceRepo _IECCapacitorsInterface;
        private readonly IECIntegratedSemiconductorCircuitsInterfaceRepo _IECIntegratedSemiconductorCircuitsInterface;
        private readonly IECDiscreteSemiconductorsInterfaceRepo _IECDiscreteSemiconductorsInterfaceRepo;
        private readonly IECOptoelectronicComponentsInterfaceRepo _IECOptoelectronicComponentsInterfaceRepo;
        private readonly IECResistorsAndResistorNetworksInterfaceRepo _IECResistorsAndResistorNetworksInterfaceRepo;
        private readonly IECInductorsTransformersAndCoilsInterfaceRepo _IECInductorsTransformersAndCoilsInterfaceRepo;
        private readonly IECRelaysInterfaceRepo _IECRelaysInterfaceRepo;
        private readonly IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo _IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo;

        public IECServices(IECCapacitorsInterfaceRepo iECCapacitorsInterface, IECIntegratedSemiconductorCircuitsInterfaceRepo iECIntegratedSemiconductorCircuitsInterface, IECDiscreteSemiconductorsInterfaceRepo iECDiscreteSemiconductorsInterfaceRepo, IECOptoelectronicComponentsInterfaceRepo iECOptoelectronicComponentsInterfaceRepo, IECResistorsAndResistorNetworksInterfaceRepo eCResistorsAndResistorNetworks, IECInductorsTransformersAndCoilsInterfaceRepo iECInductorsTransformersAndCoilsInterfaceRepo, IECRelaysInterfaceRepo relaysInterfaceRepo, IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo iECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo)
        {
            _IECCapacitorsInterface = iECCapacitorsInterface;
            _IECIntegratedSemiconductorCircuitsInterface = iECIntegratedSemiconductorCircuitsInterface;
            _IECDiscreteSemiconductorsInterfaceRepo = iECDiscreteSemiconductorsInterfaceRepo;
            _IECOptoelectronicComponentsInterfaceRepo = iECOptoelectronicComponentsInterfaceRepo;
            _IECResistorsAndResistorNetworksInterfaceRepo = eCResistorsAndResistorNetworks;
            _IECInductorsTransformersAndCoilsInterfaceRepo = iECInductorsTransformersAndCoilsInterfaceRepo;
            _IECRelaysInterfaceRepo = relaysInterfaceRepo;
            _IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo = iECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo;
        }

        public async Task<List<SemiconductorResponseDto>> ExecuteIECDiscreteSemiconductors(int SUBCATEGORYID, int TYPESID,  double RatedVoltageInV, double NominalVoltage, double ThermalResistance, double AmbientTemperature, double MaximumSupplyCurrentA, double WorstCasePowerDissipationAtMaximumFrequencyW, double OperatingFrequencyMHz, double MaximumOperatingFrequencyMHz, double OperatingVoltageInV, double LambdaRef)
        {
            var result = await _IECDiscreteSemiconductorsInterfaceRepo.ExecuteIECDiscreteSemiconductors(SUBCATEGORYID, TYPESID, RatedVoltageInV, NominalVoltage, ThermalResistance, AmbientTemperature, MaximumSupplyCurrentA, WorstCasePowerDissipationAtMaximumFrequencyW, OperatingFrequencyMHz, MaximumOperatingFrequencyMHz, OperatingVoltageInV, LambdaRef);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECOptoelectronicComponentsResponseDto>> ExecuteIECOptoelectronicComponents(int TypesId, int SubCategoryId, double OperatingVoltageInV, double ReferenceVoltageInV, double RatedVoltageInV, double Fop, double Fmax, double Pfwc, double MaximumSupplyCurrentA, double NominalVoltage, double ThermalResistance, double AmbientTemperature, double LambdaRef)
        {
            var result = await _IECOptoelectronicComponentsInterfaceRepo.ExecuteIECOptoelectronicComponents(TypesId, SubCategoryId, OperatingVoltageInV, ReferenceVoltageInV, RatedVoltageInV, Fop, Fmax, Pfwc, MaximumSupplyCurrentA, NominalVoltage, ThermalResistance, AmbientTemperature, LambdaRef);
            return result;
        }

        public async Task<List<IECResistorsAndResistorNetworksResponseDto>> ExecuteIECResistorsAndResistorNetworks(int ResistorType, int InputType, double OperatingTemperature, double ThetaMax, double AmbiantTemperature, double LambdaRef)
        {
            var result = await _IECResistorsAndResistorNetworksInterfaceRepo.ExecuteIECResistorsAndResistorNetworks(ResistorType, InputType, OperatingTemperature, ThetaMax, AmbiantTemperature, LambdaRef);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECInductorsTransformersAndCoilsResponseDto>> ExecuteSPIECInductorsTransformersAndCoils(int SubCategoryId, int TypeId, double DeltaT, double AmbientTemperature, double LambdaRef)
        {
            var final = await _IECInductorsTransformersAndCoilsInterfaceRepo.ExecuteSPIECInductorsTransformersAndCoils(SubCategoryId, TypeId, DeltaT, AmbientTemperature, LambdaRef);
            return final;
            //throw new NotImplementedException();
        }

        public async Task<List<IECIntegratedSemiconductorCircuitsResponseDto>> ExecuteSpIECIntegratedSemiconductorCircuits(int CircuitType, int SubComponent, int ConstantsType, double OperatingVoltageInV, double RatedVoltageInV, double OperatingFrequencyMHz, double MaximumOperatingFrequencyMHz, double WorstCasePowerDissipationAtTheMaximumFrequencyW, double MaximumSupplyCurrentA, double NominalVoltage, double ThermalResistance, double AmbientTemperature, double LambdaRef)
        {
            var result = await _IECIntegratedSemiconductorCircuitsInterface.ExecuteSpIECIntegratedSemiconductorCircuits(CircuitType, SubComponent, ConstantsType, OperatingVoltageInV, RatedVoltageInV, OperatingFrequencyMHz, MaximumOperatingFrequencyMHz, WorstCasePowerDissipationAtTheMaximumFrequencyW, MaximumSupplyCurrentA, NominalVoltage, ThermalResistance, AmbientTemperature, LambdaRef);
            return result;
            //throw new NotImplementedException();
        }

        public Task<List<IECRelaysResponseDto>> ExecuteSPIECRelays(int SupportingConstructionType, int LoadType, int RegionType, double NumberOfOperatingCyclesPerHour, double ReferenceNumberOperatingCyclesPerHour, double AmbientTemperature, double LambdaRef)
        {
            var result = _IECRelaysInterfaceRepo.ExecuteSPIECRelays(SupportingConstructionType, LoadType, RegionType, NumberOfOperatingCyclesPerHour, ReferenceNumberOperatingCyclesPerHour, AmbientTemperature, LambdaRef);
            return result;
            //throw new NotImplementedException();
        }

        public Task<List<IECSwitchesAndPushButtonsForLowElectricalStressResponseDto>> ExecuteSPIECSwitchesAndPushButtonsForLowElectricalStress(int RegionType, int LoadType, double LambdaRef)
        {
            var result = _IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo.ExecuteSPIECSwitchesAndPushButtonsForLowElectricalStress(RegionType, LoadType, LambdaRef);
            return result;
            // throw new NotImplementedException();
        }

        public async Task<List<IECCapacitorResponseDto>> ExecuteStoredProcedure(int SUBCATEGORYID, int TYPEID, double OPERATINGVOLTAGEINV, double RATEDVOLTAGEINV, double AVERAGEACTUALTEMPERATURE, double LAMBDAREF)
        {
            var result = await _IECCapacitorsInterface.ExecuteStoredProcedure
                (
                    SUBCATEGORYID,
                    TYPEID,
                    OPERATINGVOLTAGEINV,
                    RATEDVOLTAGEINV,
                    AVERAGEACTUALTEMPERATURE,
                    LAMBDAREF
                );
            return result;
        }

        public async Task<List<IECCapacitorsDto>> GetIECCapacitors()
        {
            var result = await _IECCapacitorsInterface.GetIECCapacitors();
            var Final = result.Select(c => new IECCapacitorsDto
            {
                Trid = c.Trid,
                SUBCATEGORY = c.SUBCATEGORY
            }).ToList();
            return Final;
        }
        public async Task<List<IECCapacitorsTypesDto>> GetIECCapacitorsTypes(int CATEGORYID)
        {
            var result = await _IECCapacitorsInterface.GetIECCapacitorsTypes(CATEGORYID);
            var Final = result.Select(c => new IECCapacitorsTypesDto
            {
                Trid = c.Trid,
                TYPES = c.TYPES,
                CATEGORYID =Convert.ToInt32(c.CATEGORYID)
            }).ToList();
            return Final;
        }

        public async Task<List<IECConstantForVoltageDependenceDto>> GetIECConstantForVoltageDependence()
        {
            var result = await _IECIntegratedSemiconductorCircuitsInterface.GetIECConstantForVoltageDependence();
            var final = result.Select(c => new IECConstantForVoltageDependenceDto
            {
                Trid = c.Trid,
                IntegratedCircuit = c.IntegratedCircuit
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public async Task<List<IECConstantsForTemperatureDependenceDto>> GetIECConstantsForTemperatureDependence()
        {
            var result = await _IECIntegratedSemiconductorCircuitsInterface.GetIECConstantsForTemperatureDependence();
            var final = result.Select(c => new IECConstantsForTemperatureDependenceDto
            {
                Trid = (int)c.Trid,
                ConstantsType = c.ConstantsType
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public List<IECConstantsForTemperatureDependenceOfOptoelectronicComponentsDto> GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents()
        {
            var result = _IECOptoelectronicComponentsInterfaceRepo.GetIECConstantsForTemperatureDependenceOfOptoelectronicComponents();
            var final = result.Select(c => new IECConstantsForTemperatureDependenceOfOptoelectronicComponentsDto
            {
                Trid = c.Trid,
                ConstantsType = c.ConstantsType
            }).ToList();
            return final;
            // throw new NotImplementedException();
        }

        public async Task<List<IECConstantsForTemperatureDependenceOfRelaysDto>> GetIECConstantsForTemperatureDependenceOfRelays()
        {
            var result = await _IECRelaysInterfaceRepo.GetIECConstantsForTemperatureDependenceOfRelays();
            var final = result.Select(c => new IECConstantsForTemperatureDependenceOfRelaysDto
            {
                Trid = c.Trid,
                SupportingConstruction = c.SupportingConstruction
            }).ToList();
            return final;
            // throw new NotImplementedException();
        }

        public List<IECDiscreteSemiconductors> GetIECDiscreteSemiconductors()
        {
            var result = _IECDiscreteSemiconductorsInterfaceRepo.GetIECDiscreteSemiconductors();
            return result;
        }

        public async Task<List<IECDiscreteSemiconductorsSubcategoryDto>> GetIECDiscreteSemiconductorsSubcategory(int SubComponentId)
        {
            var result = await _IECDiscreteSemiconductorsInterfaceRepo.GetIECDiscreteSemiconductorsSubcategory(SubComponentId);
            var final = result.Select(c => new IECDiscreteSemiconductorsSubcategoryDto
            {
                Trid = c.Trid,
                TYPES = c.TYPES,
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public List<IECOptoelectronicComponentsTypesDto> GetIECOptoelectronicComponentsTypes(int SubCategoryId)
        {
            var result = _IECOptoelectronicComponentsInterfaceRepo.GetIECOptoelectronicComponentsTypes(SubCategoryId);
            var final = result.Select(c => new IECOptoelectronicComponentsTypesDto
            {
                TypeId = c.TypeId,
                TypeName = c.TypeName,
            }).ToList();
            return final;
            // throw new NotImplementedException();
        }

        public async Task<List<IECOptoelectronicComponentsSubCategoryDto>> GetIECOptoelectronicComponentsSubCategory()
        {
            var result = await _IECOptoelectronicComponentsInterfaceRepo.GetIECOptoelectronicComponentsSubCategory();
            var final = result.Select(c => new IECOptoelectronicComponentsSubCategoryDto
            {
                SubCategoryId = c.SubCategoryId,
                SubCategory = c.SubCategory,
            }).ToList();
            return final;

            //throw new NotImplementedException();
        }

        public async Task<List<IECRegionTypeDto>> GetIECRegionType(int RegionId)
        {
            var result = await _IECRelaysInterfaceRepo.GetIECRegionType(RegionId);
            var final = result.Select(c => new IECRegionTypeDto
            {
                Trid = c.Trid,
                RegionTypeName = c.RegionTypeName,
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public async Task<List<IECRelay>> GetIECRelay()
        {
            var result = await _IECRelaysInterfaceRepo.GetIECRelay();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECRelayLoadCategoryDto>> GetIECRelayLoadCategory()
        {
            var result = await _IECRelaysInterfaceRepo.GetIECRelayLoadCategory();
            var final = result.Select(c => new IECRelayLoadCategoryDto
            {
                LoadIndex = c.LoadIndex,
                LoadType = c.LoadType
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public async Task<List<IECRelayLoadTypeDto>> GetIECRelayLoadType()
        {
            var result = await _IECRelaysInterfaceRepo.GetIECRelayLoadType();
            var final = result.Select(c => new IECRelayLoadTypeDto
            {
                LoadIndex = c.LoadIndex,
                LoadType = c.LoadType
            }).ToList();
            return final;
            //  throw new NotImplementedException();
        }

        public async Task<List<IECResistorsAndResistorNetworksDto>> GetIECResistorsAndResistorNetworks()
        {
            var result = await _IECResistorsAndResistorNetworksInterfaceRepo.GetIECResistorsAndResistorNetworks();
            var final = result.Select(c => new IECResistorsAndResistorNetworksDto
            {
                Trid = c.Trid,
                ResistorType = c.ResistorType,
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public async Task<List<IECResistorsAndResistorNetworksInputTypeDto>> GetIECResistorsAndResistorNetworksInputType()
        {
            var result = await _IECResistorsAndResistorNetworksInterfaceRepo.GetIECResistorsAndResistorNetworksInputType();
            var final = result.Select(c => new IECResistorsAndResistorNetworksInputTypeDto
            {
                Trid = c.Trid,
                InputType = c.InputType,
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public async Task<List<IECSwitchesAndPushButtonsForLowElectricalStress>> GetIECSwitchesAndPushButtonsForLowElectricalStress()
        {
            var result = await _IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo.GetIECSwitchesAndPushButtonsForLowElectricalStress();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECTypeComponent>> GetIECTypeComponent()
        {
            var result = await _IECIntegratedSemiconductorCircuitsInterface.GetIECTypeComponent();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECTypeComponentSubCategoryDto>> GetIECTypeComponentSubCategory(int SubComponentId)
        {
            var result = await _IECIntegratedSemiconductorCircuitsInterface.GetIECTypeComponentSubCategory(SubComponentId);
            var final = result.Select(c => new IECTypeComponentSubCategoryDto
            {
                Trid = c.Trid,
                SubCategory = c.SubCategory
            }).ToList();
            return final;

            //throw new NotImplementedException();
        }

        public async Task<bool> SaveCapacitor(IECPreductionCapacitorCollectionDto preductionCapacitors)
        {
            var result = await _IECCapacitorsInterface.SaveCapacitor(preductionCapacitors);
            return result;
        }
        public Task<bool> DeleteCapacitor(long Trid)
        {
            var result = _IECCapacitorsInterface.DeleteCapacitor(Trid);
            return result;
        }

        public async Task<List<IECPreductionCapacitorCollectionDto>> GetIECPreductionCapacitor()
        {
            var result = await _IECCapacitorsInterface.GetIECPreductionCapacitor();
            return result;
        }

        public async Task<bool> SaveDiscreteSemiconductors(IECDiscreteSemiconductorsCollectionDto preductionsemiconductors)
        {
            var result = await _IECDiscreteSemiconductorsInterfaceRepo.SaveDiscreteSemiconductors(preductionsemiconductors);
            return result;
        }

        public async Task<List<IECDiscreteSemiconductorsCollectionDto>> GetPreductionDiscreteSemiconductors()
        {
            var result = await _IECDiscreteSemiconductorsInterfaceRepo.GetPreductionDiscreteSemiconductors();
            return result;
        }

        public async Task<bool> DeleteDiscreteSemiconductors(int Trid)
        {
            var result = await _IECDiscreteSemiconductorsInterfaceRepo.DeleteDiscreteSemiconductors(Trid);
            return result;
        }

        public List<IECPreductionOptoelectronicComponentDto> GetPreductionOptoelectronicComponents()
        {
            var result = _IECOptoelectronicComponentsInterfaceRepo.GetPreductionOptoelectronicComponents();
            //var final = result.Select(x => new IECPreductionOptoelectronicComponentDto
            //{
            //    Trid = x.Trid,
            //    PROJECTid = x.PROJECTid,
            //    WBS = x.WBS,
            //    OptoelectronicTypes = x.OptoelectronicTypes,
            //    OptoelectronicComponentsSubCategory = x.OptoelectronicComponentsSubCategory,
            //    ConstantsTypeId = x.ConstantsTypeId,
            //    OperatingVoltageInV = x.OperatingVoltageInV,
            //    ReferenceVoltageInV = x.ReferenceVoltageInV,
            //    RatedVoltageInV = x.RatedVoltageInV,
            //    OperatingFrequencyMHz = x.OperatingFrequencyMHz,
            //    MaximumOperatingFrequencyMHz = x.MaximumOperatingFrequencyMHz,
            //    WorstCasePowerDissipationAtMaximumFrequencyW = x.WorstCasePowerDissipationAtMaximumFrequencyW,
            //    MaximumSupplyCurrentA = x.MaximumSupplyCurrentA,
            //    NominalVoltage = x.NominalVoltage,
            //    ThermalResistance = x.ThermalResistance,
            //    AmbientTemperature = x.AmbientTemperature,
            //    Lambda = x.Lambda,
            //    LambdaRef = x.LambdaRef,
            //    UOpDivURat = x.UOpDivURat,
            //    PieU = x.PieU,
            //    PieI = x.PieI,
            //    ThetaRef = x.ThetaRef,
            //    ThetaOp = x.ThetaOp,
            //    PieT = x.PieT
            //}).ToList();
            return null; //final;
        }

        public async Task<bool> SaveOptoelectronicComponent(IECPreductionOptoelectronicComponentDto OptoelectronicComponent)
        {
            var result =await _IECOptoelectronicComponentsInterfaceRepo.SaveOptoelectronicComponent(OptoelectronicComponent);
            return result;
        }

        public async Task<bool> DeleteOptoelectronicComponent(int Trid)
        {
            var result =await _IECOptoelectronicComponentsInterfaceRepo.DeleteOptoelectronicComponent(Trid);
            return result;
        }

        public async Task<List<IECPreductionInductorsTransformersAndCoilsDto>> GetIECPreductionInductorsTransformersAndCoils()
        {
            var result =await _IECInductorsTransformersAndCoilsInterfaceRepo.GetIECPreductionInductorsTransformersAndCoils();
            var final = result.Select(x => new IECPreductionInductorsTransformersAndCoilsDto
            {
                Trid = x.Trid,
                PROJECTID= x.PROJECTID,
                WBS=x.WBS ?? string.Empty,
                SubCategoryId=Convert.ToInt32(x.SubCategoryId),
                TypeId=Convert.ToInt32(x.TypeId),
                DeltaT =Convert.ToDouble(x.DeltaT),
                AmbientTemperature = Convert.ToDouble(x.AmbientTemperature),
                Lambda= Convert.ToDouble(x.Lambda),
                LambdaRef = Convert.ToDouble(x.LambdaRef),
                ThetaOp = Convert.ToDouble(x.ThetaOp),
                ThetaRef = Convert.ToDouble(x.ThetaRef),
                PieT = Convert.ToDouble(x.PieT),
                CreatedDate=Convert.ToDateTime(x.CreatedDate),
                UpdateDate=Convert.ToDateTime(x.UpdateDate),
                USERIDZU=x.USERIDZU
            }).ToList();
            return final;
        }

        public async Task<bool> SaveInductorsTransformersAndCoils(IECPreductionInductorsTransformersAndCoilsDto preduction)
        {
            var result =await _IECInductorsTransformersAndCoilsInterfaceRepo.SaveInductorsTransformersAndCoils(preduction);
            return result;
        }

        public async Task<bool> DeleteInductorsTransformersAndCoils(int Trid)
        {
            var result =await _IECInductorsTransformersAndCoilsInterfaceRepo.DeleteInductorsTransformersAndCoils(Trid);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECPreductionIntegratedSemiconductorCircuitsDto>> GetPreductionIntegratedSemiconductorCircuits()
        {
            var result =await _IECIntegratedSemiconductorCircuitsInterface.GetPreductionIntegratedSemiconductorCircuits();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<bool> SaveIntegratedSemiconductorCircuits(IECPreductionIntegratedSemiconductorCircuitsDto preduction)
        {
            var result =await _IECIntegratedSemiconductorCircuitsInterface.SaveIntegratedSemiconductorCircuits(preduction);
            return result;
           // throw new NotImplementedException();
        }

        public async Task<bool> DeleteIntegratedSemiconductorCircuits(int Trid)
        {
            var result = await _IECIntegratedSemiconductorCircuitsInterface.DeleteIntegratedSemiconductorCircuits(Trid);
            return result;
           // throw new NotImplementedException();
        }

        public async Task<List<IECPreductionRelaysDto>> GetIECPreductionRelays()
        {
            var result =await _IECRelaysInterfaceRepo.GetIECPreductionRelays();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<bool> SaveRelays(IECPreductionRelaysDto preduction)
        {
            var result = await _IECRelaysInterfaceRepo.SaveRelays(preduction);
            return result;
        }

        public async Task<bool> DeleteRelays(int Trid)
        {
            var result = await _IECRelaysInterfaceRepo.DeleteRelays(Trid);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECPreductionResistorsAndResistorNetworksDto>> GetResistorsAndResistorNetworks()
        {
            var result =await _IECResistorsAndResistorNetworksInterfaceRepo .GetResistorsAndResistorNetworks();
            return result;
           // throw new NotImplementedException();
        }

        public Task<bool> SaveResistorsAndResistorNetworks(IECPreductionResistorsAndResistorNetworksDto preduction)
        {
            var result = _IECResistorsAndResistorNetworksInterfaceRepo.SaveResistorsAndResistorNetworks(preduction);
            return result;
           // throw new NotImplementedException();
        }

        public async Task<bool> DeleteResistorsAndResistorNetworks(int Trid)
        {
            var result = await _IECResistorsAndResistorNetworksInterfaceRepo.DeleteResistorsAndResistorNetworks(Trid);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto>> GetIECPreductionSwitchesAndPushButtonsForLowElectricalStress()
        {
            var result = await _IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo.GetIECPreductionSwitchesAndPushButtonsForLowElectricalStress();    
            return result;
           // throw new NotImplementedException();
        }

        public async Task<bool> SaveSwitchesAndPushButtonsForLowElectricalStress(IECPreductionSwitchesAndPushButtonsForLowElectricalStressDto preduction)
        {
            var result = await _IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo.SaveSwitchesAndPushButtonsForLowElectricalStress(preduction);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<bool> DeleteSwitchesAndPushButtonsForLowElectricalStress(int Trid)
        {
            var result = await _IECSwitchesAndPushButtonsForLowElectricalStressInterfaceRepo.DeleteSwitchesAndPushButtonsForLowElectricalStress(Trid);
            return result;
            //throw new NotImplementedException();
        }

        public List<IECInductorsTransformersAndCoilsSubCategoryDto> GetIECInductorsTransformersAndCoilsSubCategory()
        {
            var result = _IECInductorsTransformersAndCoilsInterfaceRepo.GetIECInductorsTransformersAndCoilsSubCategory();
            var final = result.Select(c => new IECInductorsTransformersAndCoilsSubCategoryDto
            {
                SubCategoryId = c.SubCategoryId,
                SubCategoryName = c.SubCategoryName
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }

        public List<IECInductorsTransformersAndCoilsTypesDto> GetIECInductorsTransformersAndCoilsType(int SubCategoryId)
        {
            var result = _IECInductorsTransformersAndCoilsInterfaceRepo.GetIECInductorsTransformersAndCoilsType(SubCategoryId);
            var final = result.Select(c => new IECInductorsTransformersAndCoilsTypesDto
            {
                TypeId = c.TypeId,
                TypeName = c.TypeName
            }).ToList();
            return final;
            //throw new NotImplementedException();
        }
    }
}
