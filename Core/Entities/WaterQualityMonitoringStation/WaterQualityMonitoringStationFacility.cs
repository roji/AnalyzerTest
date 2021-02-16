using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterQualityMonitoringStationFacility : IAuditableEntity
    {
        public int Id { get; set; }
        public int StationUpstairsFacilityAndStructureId { get; set; }
        public virtual EnumData StationUpstairsFacilityAndStructure { get; set; }
        public virtual WaterQualityMonitoringStation WaterQualityMonitoringStation { get; set; }
        public int WaterQualityMonitoringStationId { get; set; }
    }
}

