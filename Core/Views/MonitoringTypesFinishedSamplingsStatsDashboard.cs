namespace Core.Entities
{
    public class MonitoringTypesFinishedSamplingsStatsDashboard
    {
        public string Province { get; set; }
        public string MonitoringTypeTitle { get; set; }
        public int Count { get; set; }
        public int? MonitoringTypeId { get; set; }
        public string Color { get; set; }
        public int MonitoringYear { get; set; }
    }
}
