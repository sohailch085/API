namespace MTS_COMMON.ModelDTO.Collection
{
   public class IECCapacitorPredictionCollectionDto
    {
        public int TypeOfCapacitor { get; set; }
        public int CapacitorType { get; set; }
        public double OperatingVoltageInV { get; set; }
        public double RatedVoltageInV { get; set; }
        public double OperatingFrequencyMHz { get; set; }
        public double MaximumOperatingFrequencyMHz { get; set; }
        public double WorstCasePowerDissipationAtMaximumFrequencyW { get; set; }
        public double MaximumSupplyCurrentA { get; set; }
        public double NominalVoltage { get; set; }
        public double ThermalResistance { get; set; }
        public double AmbientTemperature { get; set; }
        public double Lambda { get; set; }
        public double LambdaRef { get; set; }
        public double UopDivideUrat { get; set; }
        public double PieU { get; set; }
        public double ThetaRef { get; set; }
        public double ThetaOp { get; set; }
        public double PieT { get; set; }
        public long UserId { get; set; }
    }
}
