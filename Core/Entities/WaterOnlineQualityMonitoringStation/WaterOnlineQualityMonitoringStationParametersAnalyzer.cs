using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterOnlineQualityMonitoringStationParametersAnalyzer : IAuditableEntity
    {
        public WaterOnlineQualityMonitoringStationParametersAnalyzer()
        {
            WaterOnlineQualityMonitoringStationSpareParts = new HashSet<WaterOnlineQualityMonitoringStationSparePart>();
            WaterOnlineQualityMonitoringStationConsumables = new HashSet<WaterOnlineQualityMonitoringStationConsumable>();
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public virtual EnumData StationParameter { get; set; }
        public int StationParameterId { get; set; }
        public int WaterOnlineQualityMonitoringStationId { get; set; }
        public string Description { get; set; }
        public virtual WaterOnlineQualityMonitoringStation WaterOnlineQualityMonitoringStation { get; set; }
        public virtual ICollection<WaterOnlineQualityMonitoringStationSparePart> WaterOnlineQualityMonitoringStationSpareParts { get; set; }
        public virtual ICollection<WaterOnlineQualityMonitoringStationConsumable> WaterOnlineQualityMonitoringStationConsumables { get; set; }
    }
}

