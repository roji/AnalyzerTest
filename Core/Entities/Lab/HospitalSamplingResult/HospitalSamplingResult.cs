using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;
using Core.Tools;

namespace Core.Entities
{
   public class HospitalSamplingResult : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public bool? OrganizationRepresentativeAttendance { get; set; }
      public int? MonitoringDate { get; set; }
      public string MonitoringHour { get; set; }
      public bool IsMonitoringDone { get; set; }
      public string Description { get; set; }
      public ExperimentReasons ExperimentReason { get; set; }
      public string ExperimentSubject { get; set; }
      public string ExperimentReasonDescription { get; set; }
      public Int64? RialVolume { get; set; }
      public virtual Upload HospitalContractFileName { get; set; }

      [StringLength(38)]
      public string HospitalContractFileNameId { get; set; }
      public virtual Upload OrganizationRepresentativeAttendanceFileName { get; set; }

      [StringLength(38)]
      public string OrganizationRepresentativeAttendanceFileNameId { get; set; }
      public virtual Upload SelfDeclarationAgendaFileName { get; set; }

      [StringLength(38)]
      public string SelfDeclarationAgendaFileNameId { get; set; }
      public int? MonitoringYear { get; set; }
      public virtual EnumData MonitoringPeriod { get; set; }
      public int? MonitoringPeriodId { get; set; }
      //  Sampling Experts
      public virtual ICollection<HospitalTesterPersonnel> Testers { get; set; }
      public int LabManagerVerifierId { get; set; }
      public virtual Personnel LabManagerVerifier { get; set; }
      public string SamplingExpertsDescription { get; set; }
      public bool? HasPollution { get; set; } // Monitoring Result
      public bool? HasWastePollution { get; set; }
      public bool? HasDisinfectionDevicePollution { get; set; }
      public string PollutionDescription { get; set; }
      public bool FinalSave { get; set; }
      public DateTimeOffset? FinalSaveDate { get; set; }
      public DateTimeOffset? SamplingAnnounceDate { get; set; }
      public virtual ICollection<HospitalDisinfectionDeviceResult> DisinfectionDeviceResults { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public int LabId { get; set; }
      public virtual Lab Lab { get; set; }
      public virtual ICollection<HospitalUsingFacility> HospitalUsingFacilities { get; set; }
      public bool? IsEliminationHappenInHospital { get; set; }
      public bool? EliminateOtherHospitalsWaste { get; set; }
      public bool? IsMonitoringCenterSite { get; set; }
      // Fill IsDeviceResultsAcceptable in Service After Add/Update For Future Performance Boost in Queries 
      public bool? IsDevicesResultsAcceptable { get; set; }
      public HospitalSamplingResult()
      {
         Testers = new HashSet<HospitalTesterPersonnel>();
         HospitalUsingFacilities = new HashSet<HospitalUsingFacility>();
         DisinfectionDeviceResults = new HashSet<HospitalDisinfectionDeviceResult>();
      }
      public static Expression<Func<HospitalSamplingResult, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[]
            {
               "IndustryFull",
               "LabFull",
               "god",
               "LabHospitalSamplingResultView",
               "IndustryMonitoringHistoryView"
            }))
            .Any();
      }
      public static Expression<Func<HospitalSamplingResult, bool>> GetSmartLimitations(IUserAccessInfoService uai)
      {
         var myLimits = GetEntityLimitation(uai);
         var industryLimit = Industry.GetEntityLimitation(uai);
         var labLimit = Lab.GetEntityLimitation(uai);
         var result = (myLimits.Combine(CombineModes.And, industryLimit, q => q.Industry))
            .Combine(CombineModes.Or,
               myLimits.Combine(CombineModes.And, labLimit, q => q.Lab));
         return result;
      }
   }
}
