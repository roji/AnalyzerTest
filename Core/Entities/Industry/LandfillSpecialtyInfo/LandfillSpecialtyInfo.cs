using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class LandfillSpecialtyInfo : IAuditableEntity, IAccessControl
    {
        public LandfillSpecialtyInfo()
        {
            WasteAcceptingIndustries = new HashSet<LandfillSpecialtyInfoWasteAcceptingIndustries>();
            BurialInformation = new LandfillSpecialtyInfoBurialInformation();
            TemporaryHoldingInformation = new LandfillSpecialtyInfoTemporaryHoldingInformation();
        }
        public int Id { get; set; }
        public virtual EnumData BurialMethod { get; set; }
        public int? BurialMethodId { get; set; }
        public double? SpecialIndustrialWasteDailyCollection { get; set; }
        public double? NormalIndustrialWasteDailyCollection { get; set; }
        public double? SeperatedDryNormalWasteDailyCollection { get; set; }
        public double? SeperatedWetNormalWasteDailyCollection { get; set; }
        public double? NotSeperatedNormalWasteDailyCollection { get; set; }
        public double? RejectedDryWasteCollection { get; set; }
        public double? BurialDailyAverageQuantity { get; set; }
        public bool? HasReceiveDisinfectedMedicalWasteLicense { get; set; }
        public virtual Upload DisinfectedMedicalWasteFileName { get; set; }
        [StringLength(38)]
        public string DisinfectedMedicalWasteFileNameId { get; set; }
        public double? ReceiveMicrobialDisinfectedMedicalWasteQuantity { get; set; }
        public bool? HasReceiveNotDisinfectedMedicalWasteLicense { get; set; }
        public double? ReceiveNotDisinfectedMedicalWasteQuantity { get; set; }
        public bool? HasDailyUsageOfLimeWater { get; set; }
        public string LimeWaterUsageMethod { get; set; }
        public bool? HasDailyEmbankment { get; set; }
        public string EmbankmentUsageMethod { get; set; }
        public LandfillEmbankmentPeriods? EmbankmentPeriod { get; set; }
        public virtual Upload CommitmentFileName { get; set; }
        [StringLength(38)]
        public string CommitmentFileNameId { get; set; }
        public bool? HasReceiveConstructionWasteLicense { get; set; }
        public double? ReceiveConstructionWasteQuantity { get; set; }
        public bool? HasSandExtractionUnit { get; set; }
        public double? SandExtractionUnitStorageSize { get; set; }
        public bool? HasCompostProductionAndRefiningUnit { get; set; }
        public double? CompostProductionAndRefiningUnitSotrageSize { get; set; }
        public double? LeachateCollectionTankSize { get; set; }
        public bool? HasLeachateRefinery { get; set; }
        public double? DailyLeachateRefineryStorageSize { get; set; }
        public string LeachateUsageDescription { get; set; }
        public bool? HasGamenehPitForMethaneGasExtraction { get; set; }
        public int? PitQuantity { get; set; }
        public double? MethaneProductionQuantity { get; set; }
        public bool? HasBurningRejectionSystem { get; set; }
        public double? DailyBurningRejectionQuantity { get; set; }
        public double? BurningRejectionPowerGenerationCapacity { get; set; }
        public bool? HasAnaerobicDigesterSystem { get; set; }
        public double? DailyAnaerobicDigesterQuantity { get; set; }
        public double? AnaerobicDigesterPowerGenerationCapacity { get; set; }
        public double? RemainingSludgeInStorage { get; set; }
        public string SludgeUsageDescription { get; set; }
        public bool? HasAdvancedCompactorDevice { get; set; }
        public int? CompactDevicesQuantity { get; set; }
        public double? DailyCompactingSize { get; set; }
        public int? LandfillEstablishmentYear { get; set; }
        public int? LandfillUsefulLife { get; set; }
        public double? LandfillReceiveCapacityPerYear { get; set; }
        public bool? HasRecyclingMaterial { get; set; }
        public string RecyclingMaterialDescription { get; set; }
        public bool? HasInstantPurificationFeature { get; set; }
        public string InstantPurificationFeatureDescription { get; set; }
        public virtual Upload InstantPurificationFeatureFileName { get; set; }
        [StringLength(38)]
        public string InstantPurificationFeatureFileNameId { get; set; }
        public bool? HasEiaEvaluationSurveys { get; set; }
        public string EiaEvaluationSurveysDescription { get; set; }
        public int? PisometricPitUpstairsQuantity { get; set; }
        public int? PisometricPitDownstreamQuantity { get; set; }
        public virtual ICollection<LandfillSpecialtyInfoWasteAcceptingIndustries> WasteAcceptingIndustries { get; set; }
        public virtual LandfillSpecialtyInfoBurialInformation BurialInformation { get; set; }
        public virtual LandfillSpecialtyInfoTemporaryHoldingInformation TemporaryHoldingInformation { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
    }
    public enum LandfillEmbankmentPeriods : int
    {
        [Display(Name = "روزانه")] Daily = 1,
        [Display(Name = "چند روز یکبار")] OnesInFewDays = 2
    }
}