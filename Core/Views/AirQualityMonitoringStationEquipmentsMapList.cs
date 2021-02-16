namespace Core.Entities
{
    public class AirQualityMonitoringStationEquipmentsMapList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public bool IsActive { get; set; }
        public int? ProvinceId { get; set; }
        public double? NeededCostsToMeetRequirements { get; set; }
        public string Parameter { get; set; }
        public string SparePart { get; set; }
        public string Consumable { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public double? Total { get; set; }
    }
}
