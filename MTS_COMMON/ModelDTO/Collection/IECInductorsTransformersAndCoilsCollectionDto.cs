namespace MTS_COMMON.ModelDTO.Collection
{
    public class IECInductorsTransformersAndCoilsCollectionDto
    {
        public int TransformersType { get; set; }
        public double OperatingFrequencyMHz { get; set; }
        public double MaximumOperatingFrequencyMHz { get; set; }
        public double WorstCasePowerDissipationAtMaximumFrequencyW { get; set; }
        public double MaximumSupplyCurrentA { get; set; }
        public double NominalVoltage { get; set; }
        public double ThermalResistance { get; set; }
        public double AmbientTemperature { get; set; }
        public double LambdaRef { get; set; }
    }
}
