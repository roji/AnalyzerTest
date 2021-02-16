using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterQualityMonitoringStationRiverUsage : IAuditableEntity
    {
        public int Id { get; set; }
        public int RiverUsageId { get; set; }
        public virtual EnumData RiverUsage { get; set; }
        public virtual WaterQualityMonitoringStation WaterQualityMonitoringStation { get; set; }
        public int WaterQualityMonitoringStationId { get; set; }
    }
}

