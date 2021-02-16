using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterQualityMonitoringStationSamplingExpert : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual WaterQualityMonitoringStationSamplingResult WaterQualityMonitoringStationSamplingResult { get; set; }
        public int WaterQualityMonitoringStationSamplingResultId { get; set; }
        public string FullName { get; set; }
    }
}
