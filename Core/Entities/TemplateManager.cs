using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class TemplateManager : IAuditableEntity
   {
      public int Id { get; set; }
      public string Title { get; set; }
      public string ContentTitle { get; set; }
      public string ContentBody { get; set; }
      public string FormatedToHtmlContentBody { get; set; }
      public virtual TemplateTypes TemplateType { get; set; }
      public virtual User User { get; set; }
      public int? UserId { get; set; }
   }
   public enum TemplateTypes : int
   {
      [Display(Name = "کاربر")] User = 1,

      [Display(Name = "تایید مجوز نقل و انتقال پسماند")] ApproveWasteTransferLicense = 2,

      [Display(Name = "لغو مجوز نقل و انتقال پسماند")] DenyWasteTransferLicense = 3,

      [Display(Name = "ایمیل خوش آمدگویی")] WelcomeEmail = 4,

      [Display(Name = "ایمیل فعالسازی حساب کاربری")] ActivationEmail = 5,

      [Display(Name = "پیام خوش آمدگویی میز کار")] SystemWelcome = 6,

      [Display(Name = "اعلام آلایندگی مرکز")] IndustryPollution = 7,

      [Display(Name = "صدور اخطاریه مرکز")] IndustryWarning = 8,

      [Display(Name = "فعالسازی حساب کاربری")] UserActivation = 9,

      [Display(Name = "استفاده از کلید API")] ApiKeyUsage = 11
   }
}
