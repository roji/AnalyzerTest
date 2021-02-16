using System.Collections.Generic;

namespace Core.Entities
{
    public class MonitoringRequiredIndustryMapList
    {
        public string IndustryName { get; set; }
        public int IndustryId { get; set; }
        public int? MonitoringYear { get; set; }
        public string ProvinceTitle { get; set; }
        public string MonitoringTypeTitle { get; set; }
        public string MonitoringTypeClassification { get; set; }
        public int MonitoringTypeId { get; set; }
        public string Geo_Latitude { get; set; }
        public string Geo_Longitude { get; set; }
        public bool FirstPeriod { get; set; }
        public bool SecondPeriod { get; set; }
        public bool ThirdPeriod { get; set; }
        public bool FourthPeriod { get; set; }
        public bool MonitoringDone { get; set; }
    }
}
