using Core.Contracts;
using Core.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
   public class HunterBooklet : IAuditableEntity, IAccessControl
   {
      public HunterBooklet()
      {
         Descriptions = new HashSet<HunterBookletDescription>();
         RequestDate = DateTime.UtcNow;
      }
      public int Id { get; set; }
      public DateTimeOffset RequestDate { get; set; }
      public virtual Hunter Hunter { get; set; }
      public int HunterId { get; set; }
      public HunterBookletStatuses Status { get; set; }
      public DateTimeOffset? IssueDate { get; set; }
      public virtual ICollection<HunterBookletDescription> Descriptions { get; set; }
   }
   public enum HunterBookletStatuses : int
   {
      // TODO: Add Expire status and Add background task for interval check if booklet Expired.
      [Display(Name = "مخالفت توسط اداره کل")] DisagreementAfterGeneralOfficeReview = -1,
      [Display(Name = "بررسی درخواست توسط اداره کل")] GeneralOfficeApprove = 1,
      [Display(Name = "پرداخت صورتحساب توسط شکارچی")] HunterPayBill = 2,
      [Display(Name = "تکمیل شده")] Done = 3
   }
}
