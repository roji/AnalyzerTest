namespace Core.Entities
{
    public class MonitoringPollutionDashboard
    {
        public string Province { get; set; }
        public int MonitoringYear { get; set; }
        public string PeriodTitle { get; set; }
        public int PeriodId { get; set; }
        public int AmbientAirPollution { get; set; }
        public int ChimneyPollution { get; set; }
        public int WastePollution { get; set; }
        public int WastewaterPollution { get; set; }
        public int SoundAndWavesPollution { get; set; }
        public int TotalPollution { get; set; }
    }
}
