namespace MTS_COMMON.ModelDTO.Collection
{
    public class IECRelaysCollectionDto
    {
        public int SupportingConstructionType { get; set; }
        public int RelaysTypes { get; set; }
        public int LoadType { get; set; }
        public int RegionType { get; set; }
        public double NumberOfOperatingCyclesPerHour { get; set; }
        public double ReferenceNumberOperatingCyclesPerHour { get; set; }
        public double AmbientTemperature { get; set; }
        public double LambdaRef { get; set; }
    }
}
