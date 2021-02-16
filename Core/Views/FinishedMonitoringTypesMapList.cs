using System.Collections.Generic;

namespace Core.Entities
{
    public class FinishedMonitoringTypesMapList
    {
        public string IndustryName { get; set; }
        public int IndustryId { get; set; }
        public int MonitoringYear { get; set; }
        public string ProvinceTitle { get; set; }
        public string MonitoringPeriod { get; set; }
        public string MonitoringTypeTitle { get; set; }
        public string MonitoringTypeClassification { get; set; }
        public int IusrId { get; set; }
        public int MonitoringTypeId { get; set; }
        public string Geo_Latitude { get; set; }
        public string Geo_Longitude { get; set; }
        public string MonitoringPeriodData { get; set; }
    }
}
