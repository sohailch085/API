using MTS_COMMON.ModelDTO;
using MTS_COMMON.ModelDTO.Response;
using MTS_DAL.Entities.TwoOneSeveenNoticeTwo;

namespace MTS_BAL.InterfaceServices
{
   public interface TwoOneSeveenNoticeTwoInterface
    {
        Task<List<R2CapacitorDto>> GetR2Capacitors();
        Task<List<R2CapacitorResponseDto>> ExecuteSPR2Capacitor
           (
               int PartType,
               double Capacitance,
               double NoOFYears,
               double AppliedVoltage,
               double RatedVoltage,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
        Task<List<R2DiodeDto>> GetR2Diode();
        Task<List<R2DiodeResponseDto>> ExecuteSPR2Diode
           (
               int PartType,
               double NoOFYears,
               double AppliedVoltage,
               double RatedVoltage,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
        Task<List<R2IntegratedCircuitsPlasticEncapsulatedPackageType>> GetR2IntegratedCircuitsPlasticEncapsulatedPackageType();
        Task<List<R2IntegratedCircuitsPlasticEncapsulatedPartTypeDto>> GetR2IntegratedCircuitsPlasticEncapsulatedPartType(int PackageTypeId);
        Task<List<R2IntegratedCircuitsPlasticEncapsulatedORHermeticResponseDto>> ExecuteSPR2EncapsulatedORHermetic
           (
               int PackageType,
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double RelativeHumidity,
               double DutyCycle,
               double CyclingRate
           );
        Task<List<R2InductorsDto>> GetR2Inductors();
        Task<List<R2InductorsResponseDto>> ExecuteSPR2Inductors
           (
               int PartType,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
        Task<List<R2TransformersDto>> GetR2Transformers();
        Task<List<R2TransformersResponseDto>> ExecuteSPR2Transformers
           (
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
        Task<List<R2OptoelectronicDevicesDto>> GetR2OptoelectronicDevices();
        Task<List<R2OptoelectronicDevicesResponseDto>> ExecuteSPR2OptoelectronicDevices
          (
              int PartType,
              double NoOFYears,
              double TemperatureRise,
              double TemperatureOveride,
              double AmbientTemperatureOperating,
              double AmbientTemperatureNonoperating,
              double DutyCycle,
              double CyclingRate
          );
        Task<List<R2SwitchesDto>> GetR2Switches();
        Task<List<R2SwitchesResponseDto>> ExecuteSPR2Switches
            (
                int PartType,
                double NoOFYears,
                double TemperatureRise,
                double TemperatureOveride,
                double AmbientTemperatureOperating,
                double AmbientTemperatureNonoperating,
                double DutyCycle,
                double CyclingRate
            );
        List<R2RelaysDto> GetR2Relays();
        Task<List<R2RelaysResponseDto>> ExecuteSPR2Relays
           (
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
        List<R2ConnectorsDto> GetR2Connectors();
        Task<List<R2ConnectorsResponseDto>> ExecuteSPR2Connectors
           (
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate
           );
        List<R2ResistorsDto> GetR2Resistors();
        Task<List<R2ResistorsResponseDto>> ExecuteSPR2Resistors
           (
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate,
               double PowerRate
           );
        List<R2ThyristorDto> GetR2Thyristor();
        Task<List<R2ThyristorResponseDto>> ExecuteSPR2Thyristor
           (
               int PartType,
               double NoOFYears,
               double TemperatureRise,
               double TemperatureOveride,
               double AmbientTemperatureOperating,
               double AmbientTemperatureNonoperating,
               double DutyCycle,
               double CyclingRate,
               double AppliedVoltage,
               double RatedVoltage
           );
    }
}
