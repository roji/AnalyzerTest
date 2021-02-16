using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class AirQualityStationMeteorologicalSystem : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual EnumData StationMeteorologicalSystem { get; set; }
        public int StationMeteorologicalSystemId { get; set; }
        public int AirQualityMonitoringStationId { get; set; }
        public virtual AirQualityMonitoringStation AirQualityMonitoringStation { get; set; }
    }
}

