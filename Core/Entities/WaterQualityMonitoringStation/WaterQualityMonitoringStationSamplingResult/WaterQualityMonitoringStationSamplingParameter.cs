using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterQualityMonitoringStationSamplingParameter : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual WaterQualityMonitoringStationSamplingResult WaterQualityMonitoringStationSamplingResult { get; set; }
        public int WaterQualityMonitoringStationSamplingResultId { get; set; }
        public virtual WaterQualityMonitoringStationMonitoring Monitoring { get; set; }
        public int MonitoringId { get; set; }
        public double Quantity { get; set; }
    }
}
