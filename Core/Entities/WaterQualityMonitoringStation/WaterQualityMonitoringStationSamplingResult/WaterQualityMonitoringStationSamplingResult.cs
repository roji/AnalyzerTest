using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterQualityMonitoringStationSamplingResult : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public int WaterStationSamplingReasonId { get; set; }
        public virtual EnumData WaterStationSamplingReason { get; set; }
        public int SamplingDate { get; set; }
        public int SeasonId { get; set; }
        public virtual EnumData Season { get; set; }
        public int WaterYearId { get; set; }
        public virtual EnumData WaterYear { get; set; }
        public string SamplingHour { get; set; }
        public virtual ICollection<WaterQualityMonitoringStationSamplingExpert> SamplingExperts { get; set; }
        public virtual ICollection<WaterQualityMonitoringStationSamplingParameter> SamplingParameters { get; set; }
        public virtual EnumData AirAppearance { get; set; }
        public int? AirAppearanceId { get; set; }
        public virtual EnumData FlowAppearance { get; set; }
        public int? FlowAppearanceId { get; set; }
        public double? IrwqiVariable { get; set; }
        public bool FinalSave { get; set; }
        public DateTimeOffset? FinalSaveDate { get; set; }
        public string Description { get; set; }
        public int? MonitoringYear { get; set; }
        public string SmellDescription { get; set; }
        public string OpacityDescription { get; set; }
        public string ColorDescription { get; set; }
        public string AquaticAnimalsDescription { get; set; }
        public string PlantsDescription { get; set; }
        public string PollutionFloorDescription { get; set; }
        public string OtherWaterAppearanceDescription { get; set; }
        public int WaterQualityMonitoringStationId { get; set; }
        public virtual WaterQualityMonitoringStation WaterQualityMonitoringStation { get; set; }
        public WaterQualityMonitoringStationSamplingResult()
        {
            SamplingExperts = new HashSet<WaterQualityMonitoringStationSamplingExpert>();
            SamplingParameters = new HashSet<WaterQualityMonitoringStationSamplingParameter>();
        }
    }
}
