using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterOnlineQualityMonitoringStationConsumable : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual EnumData StationConsumable { get; set; }
        public int StationConsumableId { get; set; }
        public int WaterOnlineQualityMonitoringStationParametersAnalyzerId { get; set; }
        public virtual WaterOnlineQualityMonitoringStationParametersAnalyzer WaterOnlineQualityMonitoringStationParametersAnalyzer { get; set; }
    }
}

