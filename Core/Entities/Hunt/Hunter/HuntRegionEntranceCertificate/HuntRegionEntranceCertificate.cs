using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HuntRegionEntranceCertificate : IAuditableEntity, IAccessControl
   {
      public HuntRegionEntranceCertificate()
      {
         RequestDate = DateTime.UtcNow;
         Descriptions = new HashSet<HuntRegionEntranceCertificateDescription>();
         OfferingEntranceDates = new HashSet<HuntRegionEntranceCertificateOfferingDate>();
      }
      public int Id { get; set; }
      public HuntRegionEntranceCertificateStatuses Status { get; set; }
      public DateTimeOffset RequestDate { get; set; }
      public DateTimeOffset? IssueDate { get; set; }
      public int? ApprovingDuration { get; set; }
      public virtual HuntingLicense HuntingLicense { get; set; }
      public int HuntingLicenseId { get; set; }
      public virtual HuntRegionEntranceCertificateOfferingDate EntranceDate { get; set; }
      public int? EntranceDateId { get; set; }
      public virtual ICollection<HuntRegionEntranceCertificateDescription> Descriptions { get; set; }
      public virtual ICollection<HuntRegionEntranceCertificateOfferingDate> OfferingEntranceDates { get; set; }
   }

   public enum HuntRegionEntranceCertificateStatuses : int
   {
      [Display(Name = "منقضی شده")] TimeExpired = -2,
      [Display(Name = "مخالفت پس از بررسی درخواست توسط کارشناس")] DisagreementAfterExpertDateDeterminationReview = -1,
      [Display(Name = "تکمیل مجدد درخواست توسط شکارچی")] HunterDateDeterminationReview = 1,
      [Display(Name = "بررسی درخواست توسط کارشناس تعیین وقت")] ExpertDateDeterminationReview = 2,
      [Display(Name = "تکمیل شده")] Done = 3
   }
}
