using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class AirQualityStationConsumable : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual EnumData StationConsumable { get; set; }
        public int StationConsumableId { get; set; }
        public int AirQualityStationParametersAnalyzerId { get; set; }
        public virtual AirQualityStationParametersAnalyzer AirQualityStationParametersAnalyzer { get; set; }
    }
}

