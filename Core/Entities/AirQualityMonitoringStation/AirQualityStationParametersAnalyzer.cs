using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class AirQualityStationParametersAnalyzer : IAuditableEntity
    {
        public AirQualityStationParametersAnalyzer()
        {
            AirQualityStationSpareParts = new HashSet<AirQualityStationSparePart>();
            AirQualityStationConsumables = new HashSet<AirQualityStationConsumable>();
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public virtual EnumData AirQualityMonitoringStationParameter { get; set; }
        public int AirQualityMonitoringStationParameterId { get; set; }
        public int AirQualityMonitoringStationId { get; set; }
        public string Description { get; set; }
        public virtual AirQualityMonitoringStation AirQualityMonitoringStation { get; set; }
        public virtual ICollection<AirQualityStationSparePart> AirQualityStationSpareParts { get; set; }
        public virtual ICollection<AirQualityStationConsumable> AirQualityStationConsumables { get; set; }
    }
}

