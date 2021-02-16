using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HunterNative : IAuditableEntity, IAccessControl
   {
      public HunterNative()
      {
         Descriptions = new HashSet<HunterNativeDescription>();
      }
      public int Id { get; set; }
      public virtual Hunter Hunter { get; set; }
      public int HunterId { get; set; }
      public HunterNativeStatuses Status { get; set; }
      public virtual EnumData Province { get; set; }
      public int ProvinceId { get; set; }
      public virtual Upload DocumentFileName { get; set; }

      [StringLength(38)]
      public string DocumentFileNameId { get; set; }
      public virtual ICollection<HunterNativeDescription> Descriptions { get; set; }
   }
   public enum HunterNativeStatuses : int
   {
      [Display(Name = "بررسی مجدد توسط شکارچی/صیاد")] HunterReview = -1,

      [Display(Name = "بررسی توسط کارشناس")] ExpertApprove = 1,

      [Display(Name = "تکمیل شده")] Done = 2,
   }
}
