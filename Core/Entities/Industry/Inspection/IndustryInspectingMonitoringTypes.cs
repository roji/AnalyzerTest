using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryInspectingMonitoringTypes : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual IndustryInspection IndustryInspection { get; set; }
        public int IndustryInspectionId { get; set; }
        public virtual EnumData MonitoringType { get; set; }
        public int MonitoringTypeId { get; set; }
        public virtual EnumData MonitoringTypeQualityStatus { get; set; }
        public int MonitoringTypeQualityStatusId { get; set; }
        public string Description { get; set; }
        public bool? IsMeasured { get; set; }
    }
}
