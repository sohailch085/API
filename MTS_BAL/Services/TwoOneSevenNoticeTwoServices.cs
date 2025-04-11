using MTS_BAL.InterfaceServices;
using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;
using MTS_DAL.InterfaceRepo.TwoOneSeveenNoticeTwoInterfaceRepo;

namespace MTS_BAL.Services
{
    public class TwoOneSevenNoticeTwoServices : TwoOneSeveenNoticeTwoInterface
    {
        private readonly R2CapacitorInterfaceRepo _R2CapacitorInterfaceRepo;
        private readonly R2DiodeInterfaceRepo _R2DiodeInterfaceRepo;
        private readonly R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo _R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo;
        private readonly R2InductorsInterfaceRepo _R2InductorsInterfaceRepo;
        private readonly R2TransformersInterfaceRepo _R2TransformersInterfaceRepo;
        private readonly R2OptoelectronicDevicesInterfaceRepo _R2OptoelectronicDevicesInterfaceRepo;
        private readonly R2SwitchesInterfaceRepo _R2SwitchesInterfaceRepo;
        private readonly R2RelaysInterfaceRepo _R2RelaysInterfaceRepo;
        private readonly R2ConnectorsInterfaceRepo _R2ConnectorsInterfaceRepo;
        private readonly R2ResistorsInterfaceRepo _R2ResistorsInterfaceRepo;
        private readonly R2ThyristorInterfaceRepo _R2ThyristorInterfaceRepo;
        public TwoOneSevenNoticeTwoServices(R2CapacitorInterfaceRepo R2CapacitorInterfaceRepo, R2DiodeInterfaceRepo r2DiodeInterfaceRepo, R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo r2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo, R2InductorsInterfaceRepo r2InductorsInterfaceRepo, R2TransformersInterfaceRepo r2TransformersInterfaceRepo, R2OptoelectronicDevicesInterfaceRepo r2OptoelectronicDevicesInterfaceRepo, R2SwitchesInterfaceRepo r2SwitchesInterfaceRepo, R2RelaysInterfaceRepo r2RelaysInterfaceRepo, R2ConnectorsInterfaceRepo r2ConnectorsInterfaceRepo, R2ResistorsInterfaceRepo r2ResistorsInterfaceRepo, R2ThyristorInterfaceRepo r2ThyristorInterfaceRepo)
        {
            _R2CapacitorInterfaceRepo = R2CapacitorInterfaceRepo;
            _R2DiodeInterfaceRepo = r2DiodeInterfaceRepo;
            _R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo = r2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo;
            _R2InductorsInterfaceRepo = r2InductorsInterfaceRepo;
            _R2TransformersInterfaceRepo = r2TransformersInterfaceRepo;
            _R2OptoelectronicDevicesInterfaceRepo = r2OptoelectronicDevicesInterfaceRepo;
            _R2SwitchesInterfaceRepo = r2SwitchesInterfaceRepo;
            _R2RelaysInterfaceRepo = r2RelaysInterfaceRepo;
            _R2ConnectorsInterfaceRepo = r2ConnectorsInterfaceRepo;
            _R2ResistorsInterfaceRepo = r2ResistorsInterfaceRepo;
            _R2ThyristorInterfaceRepo = r2ThyristorInterfaceRepo;
        }

        public async Task<List<R2CapacitorResponseDto>> ExecuteSPR2Capacitor(int PartType, double Capacitance, double NoOFYears, double AppliedVoltage, double RatedVoltage, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = await _R2CapacitorInterfaceRepo.ExecuteSPR2Capacitor(PartType, Capacitance, NoOFYears, AppliedVoltage, RatedVoltage, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate);
            return result;
        }
        public async Task<List<R2CapacitorDto>> GetR2Capacitors()
        {
            var result = await _R2CapacitorInterfaceRepo.GetR2Capacitors();
            var final = result.Select(x => new R2CapacitorDto
            {
                Trid = x.Trid,
                PartType = x.PartType,
            }).ToList();
            return final;
        }

        public async Task<List<R2DiodeResponseDto>> ExecuteSPR2Diode(int PartType, double NoOFYears, double AppliedVoltage, double RatedVoltage, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = await _R2DiodeInterfaceRepo.ExecuteSPR2Diode(PartType, NoOFYears, AppliedVoltage, RatedVoltage, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<R2DiodeDto>> GetR2Diode()
        {
            var result = await _R2DiodeInterfaceRepo.GetR2Diode();
            return result;
            //throw new NotImplementedException();
        }

        public Task<List<R2IntegratedCircuitsPlasticEncapsulatedPackageType>> GetR2IntegratedCircuitsPlasticEncapsulatedPackageType()
        {
            var result = _R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo.GetR2IntegratedCircuitsPlasticEncapsulatedPackageType();
            return result;
        }

        public Task<List<R2IntegratedCircuitsPlasticEncapsulatedPartTypeDto>> GetR2IntegratedCircuitsPlasticEncapsulatedPartType(int PackageTypeId)
        {
            var result = _R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo.GetR2IntegratedCircuitsPlasticEncapsulatedPartType(PackageTypeId);
            var final = result.Result.Select(x => new R2IntegratedCircuitsPlasticEncapsulatedPartTypeDto
            {
                Trid = x.Trid,
                PartType = x.PartType
            }).ToList();
            return Task.FromResult(final);
        }

        public Task<List<R2IntegratedCircuitsPlasticEncapsulatedORHermeticResponseDto>> ExecuteSPR2EncapsulatedORHermetic(int PackageType, int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double RelativeHumidity, double DutyCycle, double CyclingRate)
        {
            var result = _R2IntegratedCircuitsPlasticEncapsulatedORHermeticInterfaceRepo.ExecuteSPR2EncapsulatedORHermetic(PackageType, PartType, NoOFYears, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, RelativeHumidity, DutyCycle, CyclingRate);
            return result;
        }

        public Task<List<R2InductorsDto>> GetR2Inductors()
        {
            var result = _R2InductorsInterfaceRepo.GetR2Inductors();
            var final = result.Result.Select(x => new R2InductorsDto
            {
                Trid = x.Trid,
                PartType = x.PartType
            }).ToList();
            return Task.FromResult(final);
        }

        public Task<List<R2InductorsResponseDto>> ExecuteSPR2Inductors(int PartType, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _R2InductorsInterfaceRepo.ExecuteSPR2Inductors(PartType, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate);
            var final = result.Result.Select(x => new R2InductorsResponseDto
            {
                LambdaEB = x.LambdaEB,
                LambdaIND = x.LambdaIND,
                LambdaOB = x.LambdaOB,
                LambdaTCB = x.LambdaTCB,
                PieCR = x.PieCR,
                PieDCN = x.PieDCN,
                PieDCO = x.PieDCO,
                PieDT = x.PieDT,
                PieG = x.PieG,
                PieTE = x.PieTE,
                PieTO = x.PieTO,
                LambdaP = x.LambdaP
            }).ToList();
            return Task.FromResult(final);
        }

        public Task<List<R2TransformersDto>> GetR2Transformers()
        {
            var result = _R2TransformersInterfaceRepo.GetR2Transformers();
            var final = result.Result.Select(x => new R2TransformersDto
            {
                Trid = x.Trid,
                PartType = x.PartType
            }).ToList();
            return Task.FromResult(final);
        }

        public Task<List<R2TransformersResponseDto>> ExecuteSPR2Transformers(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _R2TransformersInterfaceRepo.ExecuteSPR2Transformers(PartType, NoOFYears, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate);
            var final = result.Result.Select(x => new R2TransformersResponseDto
            {
                LambdaEB = x.LambdaEB,
                LambdaIND = x.LambdaIND,
                LambdaOB = x.LambdaOB,
                LambdaTCB = x.LambdaTCB,
                PieCR = x.PieCR,
                PieDCN = x.PieDCN,
                PieDCO = x.PieDCO,
                PieDT = x.PieDT,
                PieG = x.PieG,
                PieTE = x.PieTE,
                PieTO = x.PieTO,
                LambdaP = x.LambdaP
            }).ToList();
            return Task.FromResult(final);
        }

        public Task<List<R2OptoelectronicDevicesDto>> GetR2OptoelectronicDevices()
        {
            var result = _R2OptoelectronicDevicesInterfaceRepo.GetR2OptoelectronicDevices();
            var final = result.Result.Select(x => new R2OptoelectronicDevicesDto
            {
                Trid = x.Trid,
                PartType = x.PartType
            }).ToList();
            return Task.FromResult(final);
        }

        public Task<List<R2OptoelectronicDevicesResponseDto>> ExecuteSPR2OptoelectronicDevices(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _R2OptoelectronicDevicesInterfaceRepo.ExecuteSPR2OptoelectronicDevices(PartType, NoOFYears, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate);
            return result;
        }

        public Task<List<R2SwitchesDto>> GetR2Switches()
        {
            var result = _R2SwitchesInterfaceRepo.GetR2Switches();
            var final = result.Result.Select(x => new R2SwitchesDto
            {
                Trid = x.Trid,
                PartType = x.PartType
            }).ToList();
            return Task.FromResult(final);
        }

        public Task<List<R2SwitchesResponseDto>> ExecuteSPR2Switches(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _R2SwitchesInterfaceRepo.ExecuteSPR2Switches(PartType, NoOFYears, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate);
            var final = result.Result.Select(x => new R2SwitchesResponseDto
            {
                LambdaEB = x.LambdaEB,
                LambdaIND = x.LambdaIND,
                LambdaOB = x.LambdaOB,
                LambdaTCB = x.LambdaTCB,
                PieCR = x.PieCR,
                PieDCN = x.PieDCN,
                PieDCO = x.PieDCO,
                PieDT = x.PieDT,
                PieG = x.PieG,
                PieTE = x.PieTE,
                PieTO = x.PieTO,
                LambdaP = x.LambdaP
            }).ToList();
            return Task.FromResult(final);
        }

        public List<R2RelaysDto> GetR2Relays()
        {
            var result = _R2RelaysInterfaceRepo.GetR2Relays();
            var final = result.Select(x => new R2RelaysDto
            {
                Trid = x.Trid,
                PartType = x.PartType
            }).ToList();
            return final;
        }

        public Task<List<R2RelaysResponseDto>> ExecuteSPR2Relays(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _R2RelaysInterfaceRepo.ExecuteSPR2Relays(PartType, NoOFYears, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate);
            return result;
        }

        public List<R2ConnectorsDto> GetR2Connectors()
        {
            var result = _R2ConnectorsInterfaceRepo.GetR2Connectors();
            var final = result.Select(x => new R2ConnectorsDto {
                Trid = x.Trid,
                PartType = x.PartType   
            }).ToList();
            return final;
        }

        public Task<List<R2ConnectorsResponseDto>> ExecuteSPR2Connectors(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate)
        {
            var result = _R2ConnectorsInterfaceRepo.ExecuteSPR2Connectors(PartType, NoOFYears, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate);
            return result;
        }

        public List<R2ResistorsDto> GetR2Resistors()
        {
            var result = _R2ResistorsInterfaceRepo.GetR2Resistors();
            var final = result.Select(x => new R2ResistorsDto { 
            Trid= x.Trid,
            PartType= x.PartType,
            }).ToList();
            return final;
        }

        public Task<List<R2ResistorsResponseDto>> ExecuteSPR2Resistors(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate, double PowerRate)
        {
            var result = _R2ResistorsInterfaceRepo.ExecuteSPR2Resistors(PartType, NoOFYears, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate, PowerRate);
            return result;
            //throw new NotImplementedException();
        }

        public List<R2ThyristorDto> GetR2Thyristor()
        {
            var result = _R2ThyristorInterfaceRepo.GetR2Thyristor();
            var final = result.Select(x => new R2ThyristorDto {Trid=x.Trid,PartType=x.PartType }).ToList();
            return final;
        }

        public Task<List<R2ThyristorResponseDto>> ExecuteSPR2Thyristor(int PartType, double NoOFYears, double TemperatureRise, double TemperatureOveride, double AmbientTemperatureOperating, double AmbientTemperatureNonoperating, double DutyCycle, double CyclingRate, double AppliedVoltage, double RatedVoltage)
        {
            var result = _R2ThyristorInterfaceRepo.ExecuteSPR2Thyristor(PartType, NoOFYears, TemperatureRise, TemperatureOveride, AmbientTemperatureOperating, AmbientTemperatureNonoperating, DutyCycle, CyclingRate, AppliedVoltage, RatedVoltage);
            return result;
        }
    }
}
