using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryWarningReasons : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual IndustryWarning IndustryWarning { get; set; }
        public int IndustryWarningId { get; set; }
        public virtual IndustryWarning PreviousIndustryWarning { get; set; }
        public int? PreviousIndustryWarningId { get; set; }
        public virtual IndustryInspection IndustryInspection { get; set; }
        public int? IndustryInspectionId { get; set; }
        public virtual IndustrialUnitsSamplingResult IndustrialUnitsSamplingResult { get; set; }
        public int? IndustrialUnitsSamplingResultId { get; set; }
        public virtual WarningReasonTypes WarningReason { get; set; }
    }
    public enum WarningReasonTypes : int
    {
        Inspections = 1,
        Warnings = 2,
        AdministratonMonitorings = 3,
        SelfDeclarationMonitorings = 4,
        EnvironmentalIncidents = 5
    }
}
