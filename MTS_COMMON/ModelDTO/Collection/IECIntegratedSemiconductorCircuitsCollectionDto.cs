namespace MTS_COMMON.ModelDTO.Collection
{
    public class IECIntegratedSemiconductorCircuitsCollectionDto
    {
        public int CircuitType { get; set; }
        public int SubComponent { get; set; }
        public int ConstantsType { get; set; }
        public float OperatingVoltageInV { get; set; }
        public float RatedVoltageInV { get; set; }
        public float OperatingFrequencyMHz { get; set; }
        public float MaximumOperatingFrequencyMHz { get; set; }
        public float WorstCasePowerDissipationAtMaximumFrequencyW { get; set; }
        public float MaximumSupplyCurrentA { get; set; }
        public float NominalVoltage { get; set; }
        public float ThermalResistance { get; set; }
        public float AmbientTemperature { get; set; }
        public float LambdaRef { get; set; }
    }
}
