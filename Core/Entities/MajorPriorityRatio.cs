using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class MajorPriorityRatio : IAuditableEntity
    {
        public int MonitoringTypeId { get; set; }
        public int MajorId { get; set; }
        public double Ratio { get; set; }
        public virtual EnumData MonitoringType { get; set; }
        public virtual EnumData Major { get; set; }
    }
}
