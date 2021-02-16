using System.Collections.Generic;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class MunicipalityWasteSpecialtyInfo : IAuditableEntity, IAccessControl
    {
        public MunicipalityWasteSpecialtyInfo()
        {
            RelatedIndustries = new HashSet<MunicipalityWasteSpecialtyAdditionalInfos>();
        }

        public int Id { get; set; }
        public int? SeperatedDryNormalWasteDailyCollection { get; set; }
        public int? SeperatedWetNormalWasteDailyCollection { get; set; }
        public int? NotSeperatedNormalWasteDailyCollection { get; set; }
        public int? SafeMedicalWasteDailyCollection { get; set; }
        public bool? CollectingUnsafeMedicalWaste { get; set; }
        public int? UnsafeMedicalWasteDailyCollection { get; set; }
        public int? BuildingConstructionWasteDailyCollection { get; set; }
        public int? CoveringAreasRecyclingBoothQuantity { get; set; }
        public int? CoveringAreasStationedStorage { get; set; }
        public int? IndustrialWasteDailyCollection { get; set; }
        public int? WasteTransportationMachineryQuantity { get; set; }
        public int? CityPopulation { get; set; }
        public virtual ICollection<MunicipalityWasteSpecialtyAdditionalInfos> RelatedIndustries { get; set; }
        public virtual Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
    public class MunicipalityWasteSpecialtyAdditionalInfos : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual MunicipalityWasteSpecialtyInfo MunicipalityWasteSpecialtyInfo { get; set; }
        public int MunicipalityWasteSpecialtyInfoId { get; set; }
        public virtual Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public int? DailySendingAverage { get; set; }
        public int? Distance { get; set; }
    }
}
