using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterOnlineQualityMonitoringStationSparePart : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual EnumData StationSparePart { get; set; }
        public int StationSparePartId { get; set; }
        public int WaterOnlineQualityMonitoringStationParametersAnalyzerId { get; set; }
        public virtual WaterOnlineQualityMonitoringStationParametersAnalyzer WaterOnlineQualityMonitoringStationParametersAnalyzer { get; set; }
    }
}

