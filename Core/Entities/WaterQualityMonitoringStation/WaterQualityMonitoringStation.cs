using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WaterQualityMonitoringStation : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Address StationAddress { get; set; }
        public string DifinitiveCode { get; set; }
        public string Code { get; set; }
        public virtual River River { get; set; }
        public int RiverId { get; set; }
        public string Zone { get; set; }
        public double? Area { get; set; }
        public int? LaunchingYear { get; set; }
        public virtual ICollection<WaterQualityMonitoringStationClosedYear> ClosedYears { get; set; }
        public virtual ICollection<WaterQualityMonitoringStationMonitoring> Monitorings { get; set; }
        public virtual ICollection<WaterQualityMonitoringStationFacility> Facilities { get; set; }
        public virtual ICollection<WaterQualityMonitoringStationRiverUsage> RiverUsages { get; set; }
        public virtual EnumData MainBasin { get; set; }
        public int MainBasinId { get; set; }
        public virtual EnumData SecondaryBasin { get; set; }
        public int SecondaryBasinId { get; set; }
        public virtual EnumData RiverRange { get; set; }
        public int? RiverRangeId { get; set; }
        public virtual EnumData WaterQualityStationType { get; set; }
        public int? WaterQualityStationTypeId { get; set; }
        public bool IsInBorder { get; set; }
        public bool IsActive { get; set; }
        public bool? IsBase { get; set; }
        public string ClassificationCode { get; set; }
        public string Section { get; set; }
        public string Village { get; set; }
        public double? RiverDepth { get; set; }
        public virtual ICollection<WaterQualityMonitoringStationSamplingResult> SamplingResults { get; set; }
        public WaterQualityMonitoringStation()
        {
            StationAddress = new Address();
            ClosedYears = new HashSet<WaterQualityMonitoringStationClosedYear>();
            Monitorings = new HashSet<WaterQualityMonitoringStationMonitoring>();
            Facilities = new HashSet<WaterQualityMonitoringStationFacility>();
            RiverUsages = new HashSet<WaterQualityMonitoringStationRiverUsage>();
        }

        public static Expression<Func<WaterQualityMonitoringStation, bool>> GetEntityLimitation(IUserAccessInfoService uai)
        {
            return q =>
            (uai.UserClaims.Intersect(new string[] { "WaterQualityMonitoringStationFull", "WaterQualityMonitoringStationView", "god" })).Any() &&
               (uai.UserDataClaims._Skip_waterqualitymonitoringstation ||
                   (uai.UserDataClaims.Waterqualitymonitoringstation_province.Contains(q.StationAddress.ProvinceId)));
        }
        public static Expression<Func<WaterQualityMonitoringStation, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
    }
}
