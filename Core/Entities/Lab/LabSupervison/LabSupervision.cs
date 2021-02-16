using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class LabSupervision : IAuditableEntity, IAccessControl
   {
      public LabSupervision()
      {
         SupervisingExperts = new HashSet<LabSupervisionSupervisingExpert>();
      }
      public int Id { get; set; }
      public string MonitoringInternalSection { get; set; }
      public string MonitoringExternalSection { get; set; }
      public int MonitoringDate { get; set; }
      public string MonitoringOfficeExpertsEnteringHour { get; set; }
      public string LabExpertsEnteringHour { get; set; }
      public string ExpertsCoordinationEnteringDescription { get; set; }
      public string LabExpertNamesAndAuthenticationMethod { get; set; }
      public string AnalyzerDeviceModel { get; set; }
      public string AnalyzerDeviceSerialNumber { get; set; }
      public bool? IsAnalyzerDeviceRegisteredInProfile { get; set; }
      public bool? IsAnalyzerDeviceCalibrationLicenseVerified { get; set; }
      public string AnalyzerDeviceCalibrationLicenseVerifiedDescription { get; set; }
      public bool? IsSensorAndExpirationDateVerified { get; set; }
      public string SensorAndExpirationDateVerifiedDescription { get; set; }
      public string SamplingStartingHour { get; set; }
      public string SamplingMethodDefinition { get; set; }
      public string SamplingLocation { get; set; }
      public string SamplingPointsDescription { get; set; }
      public string FetchDataRegisteringMethod { get; set; }
      public bool? DoesLabExpertHasRequiredSkills { get; set; }
      public string LabExpertHasRequiredSkillsDescription { get; set; }
      public bool? DoesSamplingFromRightPlace { get; set; }
      public string SamplingFromRightPlaceDescription { get; set; }
      public bool? DoesRealSamplingFromPlace { get; set; }
      public string RealSamplingFromPlaceDescription { get; set; }
      public bool? IsSampleTransferConditionsObserved { get; set; }
      public string SampleTransferConditionsObservedDescription { get; set; }
      public string SamplingParameters { get; set; }
      public string SamplingEndingHour { get; set; }
      public string DocumentFileDescription { get; set; }
      public string LabExpertsLeavingHour { get; set; }
      public string MonitoringOfficeExpertsLeavingHour { get; set; }
      public virtual IndustrialUnitsSamplingResult IndustrialUnitsSamplingResult { get; set; }
      public int IndustrialUnitsSamplingResultId { get; set; }
      public virtual Upload DocumentFileName { get; set; }

      [StringLength(38)]
      public string DocumentFileNameId { get; set; }
      public virtual EnumData IndustryReferralTimeActivityMethod { get; set; }
      public int? IndustryReferralTimeActivityMethodId { get; set; }
      public virtual Lab Lab { get; set; }
      public int LabId { get; set; }
      public virtual ICollection<LabSupervisionSupervisingExpert> SupervisingExperts { get; set; }
      public bool FinalSave { get; set; }
      public DateTimeOffset? FinalSaveDate { get; set; }
   }
}
