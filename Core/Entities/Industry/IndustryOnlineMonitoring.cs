using System.Collections;
using System.Collections.Generic;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryOnlineMonitoring : IAuditableEntity, IAccessControl
    {
        public IndustryOnlineMonitoring()
        {
            OnlineMonitoringParameters = new HashSet<IndustryOnlineMonitoringParameters>();
            OnlineMonitoringEquipments = new HashSet<IndustryOnlineMonitoringEquipments>();
        }

        public int Id { get; set; }
        public OnlineMonitoringTypes OnlineMonitoringType { get; set; }
        public bool NeedOnlineMonitoring { get; set; }
        public bool? MeasureAbility { get; set; }
        public string MaDescription { get; set; }
        public bool HasOnlineMonitoringEquipments { get; set; }
        public virtual ICollection<IndustryOnlineMonitoringParameters> OnlineMonitoringParameters { get; set; }
        public virtual ICollection<IndustryOnlineMonitoringEquipments> OnlineMonitoringEquipments { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
    }

    public enum OnlineMonitoringTypes : int
    {
        Chimney = 1,
        Wastewater = 2
    }
}
