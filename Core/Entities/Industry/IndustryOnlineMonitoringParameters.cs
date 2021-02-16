using System.Collections;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;
using Core.Contracts;

namespace Core.Entities
{
    public class IndustryOnlineMonitoringParameters : IAuditableEntity, IAccessControl
    {
        public IndustryOnlineMonitoringParameters()
        {
            ChimneyInfosParameters = new HashSet<OnlineMonitoringChimneyInfosParameters>();
            OutletWastewatersParameters = new HashSet<OnlineMonitoringOutletWastewatersParameters>();
        }

        public int Id { get; set; }
        public virtual IndustryOnlineMonitoring IndustryOnlineMonitoring { get; set; }
        public int IndustryOnlineMonitoringId { get; set; }
        public virtual EnumData Parameter { get; set; }
        public int ParameterId { get; set; }
        public bool? MonitoringSystemActivityStatus { get; set; }
        public string MsasDescription { get; set; }
        public bool? OnlineStatus { get; set; }
        public string OnlineStatusDescription { get; set; }
        public virtual ICollection<OnlineMonitoringChimneyInfosParameters> ChimneyInfosParameters { get; set; }
        public virtual ICollection<OnlineMonitoringOutletWastewatersParameters> OutletWastewatersParameters { get; set; }
    }
    public class OnlineMonitoringChimneyInfosParameters : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual IndustryOnlineMonitoringParameters IndustryOnlineMonitoringParameters { get; set; }
        public int IndustryOnlineMonitoringParametersId { get; set; }
        public virtual ChimneysInfo ChimneyInfo { get; set; }
        public int ChimneyInfoId { get; set; }
    }
    public class OnlineMonitoringOutletWastewatersParameters : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual IndustryOnlineMonitoringParameters IndustryOnlineMonitoringParameters { get; set; }
        public int IndustryOnlineMonitoringParametersId { get; set; }
        public virtual OutletWastewaters OutletWastewaters { get; set; }
        public int OutletWastewatersId { get; set; }
    }
}
