using System.Collections.Generic;

namespace Core.Entities
{
    public class MonitoringPollutionMapList
    {
        public int Id { get; set; }
        public string Industry { get; set; }
        public int IndustryId { get; set; }
        public int MonitoringYear { get; set; }
        public string Province { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string EstablishmentGrouping { get; set; }
        public string MonitoringPeriodData { get; set; }
        public string MonitoringPeriodTitle { get; set; }
        public bool HasAmbientPollution { get; set; }
        public bool HasChimneyPollution { get; set; }
        public bool HasWastePollution { get; set; }
        public bool HasWastewaterPollution { get; set; }
        public bool HasSoundAndWavePollution { get; set; }
        public string ParamTitle { get; set; }
    }
}
