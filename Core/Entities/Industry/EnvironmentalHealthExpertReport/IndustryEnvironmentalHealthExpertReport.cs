using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryEnvironmentalHealthExpertReport : MedicalWasteMonitoringQuestions, IAuditableEntity, IAccessControl
    {
        public IndustryEnvironmentalHealthExpertReport()
        {
            UsingOtherIndustryDisinfectionDevices = new HashSet<IndustryUsingOtherIndustryDisinfectionDevice>();
        }
        public int Id { get; set; }
        public string HealthExpertFullName { get; set; }
        public int ReportDate { get; set; }
        public virtual ICollection<IndustryUsingOtherIndustryDisinfectionDevice> UsingOtherIndustryDisinfectionDevices { get; set; }
        public int IndustryId { get; set; }
        public virtual Industry Industry { get; set; }
    }
    public class MedicalWasteMonitoringQuestions
    {
        public bool HasWasteManagementOperationProgram { get; set; }
        public bool IsProducedWasteIdentify { get; set; }
        public bool DoesCollectingInfectiousWaste { get; set; }
        public bool DoesKeepingChemicalMedicineWastes { get; set; }
        public bool DoesPlasticBagsFilledThreeQuarters { get; set; }
        public bool DoesCollectingInSafetyBox { get; set; }
        public bool DoesMercuryWasteSepration { get; set; }
        public bool DoesWashingWasteBuckets { get; set; }
        public bool DoesLabelingWastes { get; set; }
        public bool DoesCollectingRadioActiveWastes { get; set; }
        public bool DoesDisposingBodyParts { get; set; }
        public bool HasWasteTemporarySavingLocation { get; set; }
        public bool IsSavingLocationAwayOfAtmosphericFactors { get; set; }
        public bool IsSavingLocationIsMoistureImpermeable { get; set; }
        public bool IsSavingLocationCorruptionResistance { get; set; }
        public bool IsSavingLocationBagsShred { get; set; }
        public bool IsSavingLocationCleanable { get; set; }
        public bool IsSavingLocationHasEnoughSpace { get; set; }
        public bool IsSavingLocationHasProperSewageSystem { get; set; }
        public bool HasEnoughSpaceIfDisinfectionHappen { get; set; }
        public bool DoesRulesApplyToTemporaryKeepingWastes { get; set; }
        public bool HasEnoughSpaceAccordingToActiveBeds { get; set; }
        public bool IsDisinfectionHappenToAllKindOfWaste { get; set; }
        public bool IsDisinfectionMethodHasHealthMinisteryConfirmation { get; set; }
        public bool HasUserToWorkWithDevice { get; set; }
        public bool IsUserEducatedToWorkWithDevice { get; set; }
        public bool HasDeviceMonitoringWasteDocuments { get; set; }
        public bool DoesSavingDocumentsForAtLeastOneYear { get; set; }
        public bool HasDeviceCalibrationDocuments { get; set; }
        public bool UsingBiologicalIndexOnesPerMonth { get; set; }
        public bool IsValidationCheckingHappenWithPreVacuumAutoClave { get; set; }
        public bool DoesSendingSelfDeclarationForm { get; set; }
        public virtual EnumData DisinfectionDeviceStatus { get; set; }
        public int DisinfectionDeviceStatusId { get; set; }
        public string DisinfectionDeviceModel { get; set; }
        public string DisinfectionDeviceCompany { get; set; }
        public int DisinfectionDeviceLunchingDate { get; set; }
        public bool DeviceShredderStatus { get; set; }
        public virtual EnumData ShredderType { get; set; }
        public int ShredderTypeId { get; set; }
        public bool DoesShreddingSafetyBox { get; set; }
        public double DisinfectionNonBurningDeviceSize { get; set; }
        public double DevicePressure { get; set; }
        public double DeviceTemperature { get; set; }
        public string SterileRetentionTime { get; set; }
        public string ChemicalIndexType { get; set; }
        public int CalibrationDate { get; set; }
        public virtual Upload CalibrationDocumentFileName { get; set; }
        [StringLength(38)]
        public string CalibrationDocumentFileNameId { get; set; }
        public string UsingDisinfectantType { get; set; }
        public string DisinfectantConcentration { get; set; }
        public string UsingDisinfectantQuantity { get; set; }
        public bool IsDirtWasteShreddingDuringDisinfectant { get; set; }
        public bool IsSharpWasteShreddingDuringDisinfectant { get; set; }
        public string PathologicalWastesManagementMethod { get; set; }
        public string ChemicalWastesManagementMethod { get; set; }
        public string MedicineWastesManagementMethod { get; set; }
        public string GenotoxicWastesManagementMethod { get; set; }
        public string HeavyMetalsWastesManagementMethod { get; set; }
        public string RadiatorWastesManagementMethod { get; set; }
        public string PressureVesselsWastesManagementMethod { get; set; }
        public string NormalWastesManagementMethod { get; set; }
    }
}
