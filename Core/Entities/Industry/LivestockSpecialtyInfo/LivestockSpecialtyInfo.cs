using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class LivestockSpecialtyInfo : IAuditableEntity, IAccessControl
    {
        public LivestockSpecialtyInfo()
        {
            LivestockSpecialtyDetails = new HashSet<LivestockSpecialtyDetails>();
            AdditionalInformation = new LivestockSpecialtyAdditionalInformation();
            WasteInformation = new LivestockSpecialtyWasteInformation();
        }

        public int Id { get; set; }
        public virtual EnumData LivestockClassification { get; set; }
        public int LivestockClassificationId { get; set; }
        public int AnimalWasteProductionAverage { get; set; }
        public string AnimalWasteUseageMethod { get; set; }
        public string AnimalWasteChemistryAnalyze { get; set; }
        public int AnimalWasteHoldingDuration { get; set; }
        public bool? IsInsideResidentialArea { get; set; }
        public int? DistanceToResidentialArea { get; set; }
        public int? DistanceToMainRoad { get; set; }
        public int? DistanceToNearestAgriculturalLand { get; set; }
        public int? DistanceToNearestSlaughterhouse { get; set; }
        public string SlaughterhouseName { get; set; }
        public int? DistanceToNearestForageCollection { get; set; }
        public string CollectionName { get; set; }
        public bool? HasHeatingSystem { get; set; }
        public string HeatingSystemDescription { get; set; }
        public virtual Upload BuildingMapFileName { get; set; }
        [StringLength(38)]
        public string BuildingMapFileNameId { get; set; }
        public bool? IsInSensitiveCentersWindDirection { get; set; }
        public string ScwdDescription { get; set; }
        public int? DistanceFromRiver { get; set; }
        public string SensitiveCentersAroundDescription { get; set; }
        public virtual Upload MinistryOfIndustryLicenseFileName { get; set; }
        [StringLength(38)]
        public string MinistryOfIndustryLicenseFileNameId { get; set; }
        public virtual Upload MinistryOfAgricultureLicenseFileName { get; set; }
        [StringLength(38)]
        public string MinistryOfAgricultureLicenseFileNameId { get; set; }
        public virtual ICollection<LivestockSpecialtyDetails> LivestockSpecialtyDetails { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual LivestockSpecialtyAdditionalInformation AdditionalInformation { get; set; }
        public virtual LivestockSpecialtyWasteInformation WasteInformation { get; set; }
    }
}