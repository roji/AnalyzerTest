using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryWarning : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public int? WarningDate { get; set; }
      public string Description { get; set; }
      public virtual Upload WarningDocumentFileName { get; set; }

      [StringLength(38)]
      public string WarningDocumentFileNameId { get; set; }
      public int? FaxMailDate { get; set; }
      public string IndustryCommittedActions { get; set; }
      public int? AdministrationLetterDate { get; set; }
      public string AdministrationLetterNumber { get; set; }
      public virtual Upload AdministrationLetterFileName { get; set; }

      [StringLength(38)]
      public string AdministrationLetterFileNameId { get; set; }
      public string IndustryCommittedActionsResult { get; set; }
      public int? CommittedResultPercentage { get; set; }
      public int? PercentageTillDate { get; set; }
      public string CrpDescription { get; set; }
      // Administration Announcing Comment
      public virtual EnumData GeneralAdministrationOpinion { get; set; }
      public int? GeneralAdministrationOpinionId { get; set; }
      public int? ProgressPercentage { get; set; }
      public string ProgressDescription { get; set; }
      public int? PossibleNextInspection { get; set; }
      public virtual IndustryInspection IndustryInspection { get; set; }
      public int? IndustryInspectionId { get; set; }
      public virtual IndustrialUnitsSamplingResult IndustrialUnitsSamplingResult { get; set; }
      public int? IndustrialUnitsSamplingResultId { get; set; }
      public virtual ICollection<IndustryWarningReasons> WarningReasons { get; set; }
      public virtual ICollection<IndustryWarningDescription> Descriptions { get; set; }
      public IndustryWarningStatuses Status { get; set; }
      public IndustryWarning()
      {
         WarningReasons = new HashSet<IndustryWarningReasons>();
         Descriptions = new HashSet<IndustryWarningDescription>();
      }
   }

   public enum IndustryWarningStatuses : int
   {
      [Display(Name = "در انتظار اعلام تعهدات مرکز")] IndustryCommitments = 1,

      [Display(Name = "در انتظار اعلام نتیجه اقدامات مرکز")] IndustryActions = 2,

      [Display(Name = "در انتظار بررسی اداره شهرستان")] StateOfficeReview = 3,

      [Display(Name = "در انتظار بررسی اداره کل")] GeneralAdministrationReview = 4,

      [Display(Name = "تکمیل شده")] Done = 5
   }
}
