using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterQualityMonitoringStationClosedYear : IAuditableEntity
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public virtual WaterQualityMonitoringStation WaterQualityMonitoringStation { get; set; }
        public int WaterQualityMonitoringStationId { get; set; }
    }
}

