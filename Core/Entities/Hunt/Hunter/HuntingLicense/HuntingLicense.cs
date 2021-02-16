using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HuntingLicense : IAuditableEntity, IAccessControl
   {
      public HuntingLicense()
      {
         RequestDate = DateTime.UtcNow;
         Descriptions = new HashSet<HuntingLicenseDescription>();
      }
      public int Id { get; set; }
      public HuntingLicenseStatuses Status { get; set; }
      public DateTimeOffset RequestDate { get; set; }
      public DateTimeOffset? IssueDate { get; set; }
      public int? ApprovingDuration { get; set; }
      public virtual HuntInstruction HuntInstruction { get; set; }
      public int HuntInstructionId { get; set; }
      public virtual Hunter Hunter { get; set; }
      public int HunterId { get; set; }
      public virtual ICollection<HuntingLicenseDescription> Descriptions { get; set; }
      public virtual ICollection<HuntRegionEntranceCertificate> HuntRegionEntranceCertificates { get; set; }
   }

   public enum HuntingLicenseStatuses : int
   {
      [Display(Name = "منقضی شده")] TimeExpired = -2,
      [Display(Name = "مخالفت پس از بررسی درخواست توسط اداره کل")] DisagreementAfterGeneralAdministrationReview = -1,
      [Display(Name = "بررسی درخواست توسط اداره کل")] GeneralAdministrationReview = 1,
      [Display(Name = "پرداخت هزینه پروانه")] Pay = 2,
      [Display(Name = "تکمیل شده")] Done = 3
   }
}
