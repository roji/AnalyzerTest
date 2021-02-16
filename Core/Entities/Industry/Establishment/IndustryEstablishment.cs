using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;
using static Core.Entities.Industry;

namespace Core.Entities
{
   public class IndustryEstablishment : IAuditableEntity
   {
      public IndustryEstablishment()
      {
         Descriptions = new HashSet<IndustryEstablishmentDescription>();
         DocumentFiles = new HashSet<IndustryEstablishmentDocumentFile>();
         InquiryFiles = new HashSet<IndustryEstablishmentInquiryFile>();
         InspectionDates = new HashSet<IndustryEstablishmentInspectionDate>();
         Visitors = new HashSet<IndustryEstablishmentInspectionVisitor>();
         InspectionCoordinates = new HashSet<IndustryEstablishmentInspectionCoordinate>();
         Department = IndustryEstablishmentDepartments.StateOffice;
      }
      public int Id { get; set; }
      public virtual IndustryEstablishmentRequest Request { get; set; }
      public int RequestId { get; set; }

      public IndustryEstablishmentStatuses Status { get; set; }
      public IndustryEstablishmentDepartments Department { get; set; }
      public virtual User Expert { get; set; }
      public int? ExpertId { get; set; }
      public bool? IsProfileCompleted { get; set; }
      public string ProfileCompletedDescription { get; set; }
      public virtual IndustryEstablishmentInspectionDate SelectedInspectionDate { get; set; }
      public int? SelectedInspectionDateId { get; set; }
      public int? InspectionDate { get; set; }
      public string InspectionHour { get; set; }
      public string InspectionExpertTheory { get; set; }
      public IndustryClassifications? IndustryClassification { get; set; }
      public string ClassificationReason { get; set; }
      public string SuggestIndustryCommitments { get; set; }
      public string IndustryCommitmentAndConditions { get; set; }
      public int? InspectionStageId { get; set; }
      public virtual EnumData InspectionStage { get; set; }

      public virtual Upload InspectionExpertTheoryFileName { get; set; }

      [StringLength(38)] public string InspectionExpertTheoryFileNameId { get; set; }
      public bool? ShouldUploadDocuments { get; set; }
      public bool? ShouldUploadInquiries { get; set; }
      public virtual EnumData ApplicantStatus { get; set; }
      public int? ApplicantStatusId { get; set; }
      public bool? IsCommitmentApproveByUser { get; set; }
      // step which vote in that send the establishment to current status
      public IndustryEstablishmentStatuses? StatusBeforeProvinceGeneralManagerStep { get; set; }
      // step that if province manager approve establishment should forward to.
      public IndustryEstablishmentStatuses? StatusAfterProvinceGeneralManagerStep { get; set; }
      public virtual ICollection<IndustryEstablishmentInspectionVisitor> Visitors { get; set; }
      public virtual ICollection<IndustryEstablishmentDescription> Descriptions { get; set; }
      public virtual ICollection<IndustryEstablishmentDocumentFile> DocumentFiles { get; set; }
      public virtual ICollection<IndustryEstablishmentInquiryFile> InquiryFiles { get; set; }
      public virtual ICollection<IndustryEstablishmentInspectionDate> InspectionDates { get; set; }
      public virtual ICollection<IndustryEstablishmentInspectionCoordinate> InspectionCoordinates { get; set; }
   }

   public enum IndustryEstablishmentStatuses : int
   {
      [Display(Name = "مخالفت پس از بررسی نتیجه اعتراض")] DisagreementAfterProtestReview = -7,

      [Display(Name = "عدم پیگیری متقاضی - عدم پرداخت هزینه")] UserFailedToTrackPaying = -6,

      [Display(Name = "عدم پیگیری متقاضی - تعیین وقت بازدید")] UserFailedToTrackInspection = -5,

      [Display(Name = "عدم پیگیری متقاضی - تکمیل مستندات")] UserFailedToTrackDocuments = -4,

      [Display(Name = "انتقال به دپارتمان دیگر")] ReferredToAnotherDepartment = -3,

      [Display(Name = "مخالفت پس از بازدید توسط مدیر/رئیس دپارتمان")] DisagreementAfterInspectionByDepartmentBoss = -2,

      [Display(Name = "مخالفت با مستندات توسط مدیر/رئیس دپارتمان")] DisagreementWithDocumentsByDepartmentBoss = -1,

      [Display(Name = "کمیته ماده هفت - تعیین رده")] CategoryDeterminationCommittee = 1,

      [Display(Name = "ارجاع به کارشناس")] ReferToExpert = 2,

      [Display(Name = "بررسی کارشناس - درخواست مدارک")] ExpertAskDocuments = 3,

      [Display(Name = "ارائه مستندات توسط متقاضی")] PresentingDocuments = 4,

      [Display(Name = "تکمیل مستندات توسط متقاضی")] CompletingDocuments = 5,

      [Display(Name = "بررسی مستندات توسط کارشناس")] ExpertDocumentsApprove = 6,

      [Display(Name = "بررسی مستندات توسط رئیس دپارتمان")] DepartmentBossDocumentsApprove = 7,

      [Display(Name = "تعیین وقت بازدید توسط کارشناس")] ExpertInspectionDateDetermination = 8,

      [Display(Name = "تایید وقت بازدید توسط متقاضی")] InspectionDateApprove = 9,

      [Display(Name = "انجام و نتیجه بازدید توسط کارشناس")] ExpertInspectionToBeDone = 10,

      [Display(Name = "در انتظار نتیجه استعلام توسط کارشناس")] ExpertUploadInquiryAnswer = 11,

      [Display(Name = "ارجاع بررسی مجدد به کارشناس توسط رئیس دپارتمان")] ExpertReviewInspectionInfo = 12,

      [Display(Name = "بررسی گزارش بازدید توسط رئیس دپارتمان")] DepartmentBossInspectionApprove = 13,

      [Display(Name = "پرداخت هزینه توسط متقاضی")] PayingPrice = 14,

      [Display(Name = "تکمیل شده")] Done = 15,

      [Display(Name = "کمیته ماده 11 - بررسی و نتیجه اعتراض")] ProtestReview = 16,

      [Display(Name = "بررسی درخواست توسط مدیر کل استان")] ProvinceGeneralManagerReview = 17
   }

   public enum IndustryEstablishmentDepartments : int
   {
      [Display(Name = "اداره شهرستان")] StateOffice = 1,

      [Display(Name = "اداره محیط انسانی")] HumanEnvironmentOffice = 2,

      [Display(Name = "اداره محیط طبیعی")] NaturalEnvironmentOffice = 3,

      [Display(Name = "معاونت محیط طبیعی")] NaturalEnvironmentDeputy = 4,

      [Display(Name = "اداره محیط دریایی")] SeaEnvironmentOffice = 5,

      [Display(Name = "معاونت محیط دریایی")] SeaEnvironmentDeputy = 6
   }
}
