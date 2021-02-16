using System.Collections;
using System.Collections.Generic;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class MonitoringInfo : IAuditableEntity, IAccessControl
    {
        public MonitoringInfo()
        {
            NeedMonitoringTypes = new List<NeedMonitoringTypes>();
            ChimneysInfo = new List<ChimneysInfo>();
            OutletWastewaters = new List<OutletWastewaters>();
        }
        public int Id { get; set; }
        public virtual EstablishmentCode? AssessmentStatus { get; set; } // Degree 1 = 0 , Degree 2 = 1
        public virtual ICollection<NeedMonitoringTypes> NeedMonitoringTypes { get; set; }
        public virtual ICollection<ChimneysInfo> ChimneysInfo { get; set; }
        public virtual ICollection<OutletWastewaters> OutletWastewaters { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }

    }
    public class ChimneysInfo : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public int MonitoringInfoId { get; set; }
        public virtual MonitoringInfo MonitoringInfo { get; set; }
        public string Code { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public virtual EnumData ReleasePollutionSource { get; set; }
        public int ReleasePollutionSourceId { get; set; }
        public bool? HasSamplingGate { get; set; }
        public bool? IsStandardConditionsObserved { get; set; }
        public double? Diameter { get; set; }
        public double? Elevation { get; set; }
    }
    public class OutletWastewaters : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public int MonitoringInfoId { get; set; }
        public virtual MonitoringInfo MonitoringInfo { get; set; }
        public virtual Wastewater Wastewater { get; set; }
        public int WastewaterId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public virtual EnumData AcceptedResource { get; set; }
        public int AcceptedResourceId { get; set; }
        public bool? HasOutletSludge { get; set; }
        public bool? PossibleToTakeSamplingFromOutletSludge { get; set; }
        public string OutletDescription { get; set; }
    }
    public class NeedMonitoringTypes : IAuditableEntity
    {
        public int Id { get; set; }
        public int MonitoringTypeId { get; set; }
        public virtual EnumData MonitoringType { get; set; }
        public bool NeedMonitoring { get; set; }
        public int MonitoringInfoId { get; set; }
        public virtual MonitoringInfo MonitoringInfo { get; set; }
    }
}
