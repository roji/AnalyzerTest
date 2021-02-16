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
   public class IndustrialUnitsSamplingResult : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public bool? OrganizationRepresentativeAttendance { get; set; }
      public int? MonitoringDate { get; set; }
      public string MonitoringHour { get; set; }
      public bool IsMonitoringDone { get; set; }
      public string Description { get; set; }
      public virtual ExperimentReasons ExperimentReason { get; set; }
      public string ExperimentSubject { get; set; }
      public string ExperimentReasonDescription { get; set; }
      public string ParametersListDescription { get; set; }
      public Int64? RialVolume { get; set; }
      public virtual Upload IndustryContractFileName { get; set; }

      [StringLength(38)]
      public string IndustryContractFileNameId { get; set; }
      public virtual Upload OrganizationRepresentativeAttendanceFileName { get; set; }

      [StringLength(38)]
      public string OrganizationRepresentativeAttendanceFileNameId { get; set; }
      public int? MonitoringYear { get; set; }
      public virtual EnumData MonitoringPeriod { get; set; }
      public int? MonitoringPeriodId { get; set; }
      //  Sampling Experts
      [NotMapped]
      public virtual ICollection<int> SamplerExperts { get; set; }
      public string SamplerExpertsIds
      {
         get { return string.Join(",", SamplerExperts); }
         set { if (!string.IsNullOrWhiteSpace(value)) { SamplerExperts = value.Split(',').Select(int.Parse).ToList(); } }
      }

      [NotMapped]
      public ICollection<int> Testers { get; set; }
      public string TestersIds
      {
         get { return string.Join(",", Testers); }
         set { if (!string.IsNullOrWhiteSpace(value)) { Testers = value.Split(',').Select(int.Parse).ToList(); } }
      }

      [NotMapped]
      public ICollection<int> TechnicalAssistantVerifiers { get; set; }
      public string TechnicalAssistantVerifiersIds
      {
         get { return string.Join(",", TechnicalAssistantVerifiers); }
         set { if (!string.IsNullOrWhiteSpace(value)) { TechnicalAssistantVerifiers = value.Split(',').Select(int.Parse).ToList(); } }
      }
      public int LabManagerVerifierId { get; set; }
      public virtual Personnel LabManagerVerifier { get; set; }
      public string SamplingExpertsDescription { get; set; }
      public bool HasLabPartner { get; set; }
      public int? LabPartnerId { get; set; }
      public virtual Lab LabPartner { get; set; }
      public virtual Upload LabPartnerContractFileName { get; set; }

      [StringLength(38)]
      public string LabPartnerContractFileNameId { get; set; }
      public virtual Upload MonitoringReferenceAgendaFileName { get; set; }

      [StringLength(38)]
      public string MonitoringReferenceAgendaFileNameId { get; set; }

      [NotMapped]
      public virtual ICollection<int> LabPartnerParameters { get; set; }
      public string LabPartnerParametersIds
      {
         get { return string.Join(",", LabPartnerParameters); }
         set { if (!string.IsNullOrWhiteSpace(value)) { LabPartnerParameters = value.Split(',').Select(int.Parse).ToList(); } }
      }
      public string LabPartnerDescription { get; set; }
      public bool FinalSave { get; set; }
      public DateTimeOffset? FinalSaveDate { get; set; }
      public DateTimeOffset? SamplingAnnounceDate { get; set; }
      // Expert Approving Sampling
      public bool? ApproveSampling { get; set; }
      public string DisapproveSamplingReason { get; set; }
      public bool? IndustryHasPollution { get; set; }
      public string IndustryPollutionReason { get; set; }
      public string ApproveSamplingDescription { get; set; }
      public DateTimeOffset? ApproveSamplingDateTime { get; set; }
      public virtual User ApproveSamplingExpert { get; set; }
      public int? ApproveSamplingExpertId { get; set; }
      public virtual ICollection<ParametersSamplingResults> ParametersSamplingResults { get; set; }
      public virtual ICollection<ExperimentParametersClassification> ExperimentParametersClassifications { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public int LabId { get; set; }
      public virtual Lab Lab { get; set; }
      public IndustrialUnitsSamplingResult()
      {
         ParametersSamplingResults = new List<ParametersSamplingResults>();
         ExperimentParametersClassifications = new List<ExperimentParametersClassification>();
         LabPartnerParameters = new List<int>();
         SamplerExperts = new List<int>();
         TechnicalAssistantVerifiers = new List<int>();
         Testers = new List<int>();
      }
      public static Expression<Func<IndustrialUnitsSamplingResult, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[]
            {
               "IndustryFull",
               "LabFull",
               "god",
               "LabIndustrialUnitsSamplingResultView",
               "IndustryMonitoringHistoryView"
            }))
            .Any();
      }
      public static Expression<Func<IndustrialUnitsSamplingResult, bool>> GetSmartLimitations(IUserAccessInfoService uai)
      {
         var myLimits = GetEntityLimitation(uai);
         var industryLimit = Industry.GetEntityLimitation(uai);
         var labLimit = Lab.GetEntityLimitation(uai);
         var result = (myLimits.Combine(CombineModes.And, industryLimit, q => q.Industry))
            .Combine(CombineModes.Or,
               myLimits.Combine(CombineModes.And, labLimit, q => q.Lab))
            .Combine(CombineModes.Or,
               myLimits.Combine(CombineModes.And, labLimit, q => q.LabPartner));
         return result;
      }
   }
   public enum ExperimentReasons : int
   {
      [Display(Name = "خوداظهاری")] SelfDeclaration = 1, [Display(Name = "گزارش مردمی")] PeopleReport = 2, [Display(Name = "اخطار صادره")] IssuedWarning = 3, [Display(Name = "اداره کل - پایش صنعت")] IndustryMonitoring = 4, [Display(Name = "اداره کل - آزمون مقایسه ای (صدور،تمدید و ارتقا آز معتمد)")] ComparingTest = 5, [Display(Name = "اداره کل - پایش همزمان")] SimultaneousMonitoring = 6, [Display(Name = "اداره کل - منابع زیستی")] BiologicalResources = 7, [Display(Name = "سایر")] Other = 8
   }
}
