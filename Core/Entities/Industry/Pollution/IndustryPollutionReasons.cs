using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryPollutionReasons
    {
        public int Id { get; set; }
        public virtual IndustryPollution IndustryPollution { get; set; }
        public int IndustryPollutionId { get; set; }
        public virtual IndustryInspection IndustryInspection { get; set; }
        public int? IndustryInspectionId { get; set; }
        public virtual IndustrialUnitsSamplingResult IndustrialUnitsSamplingResult { get; set; }
        public int? IndustrialUnitsSamplingResultId { get; set; }
        public virtual PollutionAnnouncementReasons PollutionAnnouncementReason { get; set; }
        public int? IndustryWarningId { get; set; }
        public virtual IndustryWarning IndustryWarning { get; set; }
    }
    public enum PollutionAnnouncementReasons : int
    {
        Inspections = 1,
        Warnings = 2,
        AdministratonMonitorings = 3,
        SelfDeclarationMonitorings = 4
    }
}
