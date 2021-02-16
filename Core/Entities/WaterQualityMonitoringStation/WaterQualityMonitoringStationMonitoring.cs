using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterQualityMonitoringStationMonitoring : IAuditableEntity
    {
        public int Id { get; set; }
        public int MonitoringParameterId { get; set; }
        public virtual EnumData MonitoringParameter { get; set; }
        public int MonitoringFrequencyId { get; set; }
        public virtual EnumData MonitoringFrequency { get; set; }
        public virtual WaterQualityMonitoringStation WaterQualityMonitoringStation { get; set; }
        public int WaterQualityMonitoringStationId { get; set; }
    }
}

