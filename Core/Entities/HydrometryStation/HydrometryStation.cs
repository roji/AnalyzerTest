using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class HydrometryStation : IAuditableEntity
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
        public virtual ICollection<HydrometryStationClosedYear> ClosedYears { get; set; }
        public virtual ICollection<HydrometryStationMonitoring> Monitorings { get; set; }
        public virtual EnumData MainBasin { get; set; }
        public int MainBasinId { get; set; }
        public virtual EnumData SecondaryBasin { get; set; }
        public int SecondaryBasinId { get; set; }
        public virtual EnumData RiverRange { get; set; }
        public int? RiverRangeId { get; set; }
        public virtual EnumData HydrometryStationType { get; set; }
        public int? HydrometryStationTypeId { get; set; }
        public virtual EnumData HydrometryEquipmentType { get; set; }
        public int? HydrometryEquipmentTypeId { get; set; }
        public virtual EnumData GraphType { get; set; }
        public int? GraphTypeId { get; set; }
        public virtual EnumData DataLoggerCompany { get; set; }
        public int? DataLoggerCompanyId { get; set; }
        public virtual EnumData HydrometryBuilderCompany { get; set; }
        public int? HydrometryBuilderCompanyId { get; set; }
        public bool IsInBorder { get; set; }
        public bool IsActive { get; set; }
        public bool? IsBase { get; set; }
        public string ClassificationCode { get; set; }
        public string Section { get; set; }
        public string Village { get; set; }
        public bool? HasWaterSampling { get; set; }
        public bool? HasSedimentSampling { get; set; }
        public bool? HasFloorLoadSampling { get; set; }
        public bool? HasEshel { get; set; }
        public bool? HasLaminatedGraph { get; set; }
        public bool? HasTlfryk { get; set; }
        public bool? HasDataLogger { get; set; }
        public bool? HasReper { get; set; }
        public double? ReperElevation { get; set; }
        public bool? HasQualitative { get; set; }
        public bool? HasQualityPollution { get; set; }
        public bool? HasHouse { get; set; }
        public bool? HasBuildingBridge { get; set; }
        public bool? HasBuiltBed { get; set; }
        public bool? HasElectricity { get; set; }
        public bool? HasWireless { get; set; }
        public bool? HasPhone { get; set; }
        public HydrometryStation()
        {
            StationAddress = new Address();
            ClosedYears = new HashSet<HydrometryStationClosedYear>();
            Monitorings = new HashSet<HydrometryStationMonitoring>();
        }
    }
}
