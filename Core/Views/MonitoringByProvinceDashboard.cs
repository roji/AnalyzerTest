namespace Core.Entities
{
    public class MonitoringByProvinceDashboard
    {
        public string Province { get; set; }
        public int Total { get; set; }
        public int MonitoringYear { get; set; }
        public string MonitoringPeriodTitle { get; set; }
        public int MonitoringPeriodId { get; set; }
        public string MonitoringPeriodData { get; set; }
    }
}
