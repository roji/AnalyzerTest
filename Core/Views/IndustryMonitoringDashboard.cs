namespace Core.Entities
{
    public class IndustryMonitoringDashboard
    {
        public string Province { get; set; }
        public int MonitoringCoveredIndustries { get; set; }
        public int NoNeedToBeCoveredIndustries { get; set; }
        public int TotalIndustries
        {
            get
            {
                return MonitoringCoveredIndustries + NoNeedToBeCoveredIndustries;
            }
        }
    }
}
