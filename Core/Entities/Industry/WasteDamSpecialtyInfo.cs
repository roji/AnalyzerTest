using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class WasteDamSpecialtyInfo : IAuditableEntity, IAccessControl
    {
        public WasteDamSpecialtyInfo()
        {
            Problems = new HashSet<WasteDamSpecialtyInfoProblem>();
            WaterQualityMonitoringStations = new HashSet<WasteDamSpecialtyInfoWaterQualityMonitoringStation>();
        }
        public int Id { get; set; }
        public virtual EnumData WasteDamType { get; set; }
        public int? WasteDamTypeId { get; set; }
        public virtual Industry RelatedIndustry { get; set; }
        public int? RelatedIndustryId { get; set; }
        public double? DistanceToRelatedIndustry { get; set; }
        public virtual Industry RelatedMine { get; set; }
        public int? RelatedMineId { get; set; }
        public double? DistanceToRelatedMine { get; set; }
        public double? WasteMaterialQuantity { get; set; }
        public string WasteMaterialQuality { get; set; }
        public double? WasteMaterialHumidity { get; set; }
        public bool? HasStabilitySurvey { get; set; }
        public string StabilitySurveryDescription { get; set; }
        public double? WasteDamWaterDepth { get; set; }
        public double? WasteDamStorageSize { get; set; }
        public int? WasteDamStorageSizeDuration { get; set; }
        public double? WasteDamCurrentStorageSize { get; set; }
        public int? WasteDamCurrentStorageSizeDate { get; set; }
        public bool? EarthquakeIssuesHaveBeenAddressed { get; set; }
        public string EarthquakeIssuesDescription { get; set; }
        public bool? TopPlansHaveBeenAddressed { get; set; }
        public string TopPlansDescription { get; set; }
        public bool? HasTopographicSurvey { get; set; }
        public bool? HasGeologicalSurvey { get; set; }
        public bool? HasChemicalCompositionSurvey { get; set; }
        public bool? HasHydrogeologySurvey { get; set; }
        public bool? HasSurfaceWaterSurvey { get; set; }
        public bool? HasEarthquakeRelatedDataSurvey { get; set; }
        public bool? HasDistanceToSenstiveReceiversSurvey { get; set; }
        public bool? HasDistanceToMineOperatingSurvey { get; set; }
        public bool? HasMineAdjacentInfrastructureSurvey { get; set; }
        public bool? HasTailingSurvey { get; set; }
        public bool? HasWaterManagementSurvey { get; set; }
        public bool? HasWorkEffectsSurvey { get; set; }
        public bool? HasMineralResourcesPotentialSurvey { get; set; }
        public bool? HasPlannedInnovationRevenuesSurvey { get; set; }
        public bool? hasWeatherConditionSurvey { get; set; }
        public bool? hasCurrentConditionSurvey { get; set; }
        public bool? hasCurrentAndFinalGroundSurvey { get; set; }
        public virtual ICollection<WasteDamSpecialtyInfoProblem> Problems { get; set; }
        public virtual ICollection<WasteDamSpecialtyInfoWaterQualityMonitoringStation> WaterQualityMonitoringStations { get; set; }
        public virtual Upload ChemicalAnalysisFileName { get; set; }
        [StringLength(38)]
        public string ChemicalAnalysisFileNameId { get; set; }
        public virtual Upload StabilitySurveryFileName { get; set; }
        [StringLength(38)]
        public string StabilitySurveryFileNameId { get; set; }
        public virtual Upload EnvironmentEffectsFileName { get; set; }
        [StringLength(38)]
        public string EnvironmentEffectsFileNameId { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
    }

    public class WasteDamSpecialtyInfoProblem : IAccessControl
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CheckDate { get; set; }
        public int WasteDamSpecialtyInfoId { get; set; }
        public virtual WasteDamSpecialtyInfo WasteDamSpecialtyInfo { get; set; }
    }
    public class WasteDamSpecialtyInfoWaterQualityMonitoringStation : IAccessControl
    {
        public int Id { get; set; }
        public virtual WaterQualityMonitoringStation WaterQualityMonitoringStation { get; set; }
        public int WaterQualityMonitoringStationId { get; set; }
        public int WasteDamSpecialtyInfoId { get; set; }
        public virtual WasteDamSpecialtyInfo WasteDamSpecialtyInfo { get; set; }
    }
}
