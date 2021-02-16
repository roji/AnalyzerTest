using System;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class WastewaterDisposal : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public WastewaterDisposalMethods WastewaterDisposalMethod { get; set; }
      public int DailyQuantityMc2 { get; set; }
      public string NameAndDescription { get; set; }
      public string Description { get; set; }
      public string DepositAreaLongitude { get; set; }
      public string DepositAreaLatitude { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
   }
   public enum WastewaterDisposalMethods : int
   {
      [Display(Name = "تخلیه به چاه های زیرزمینی")] UndergroundWells = 0,

      [Display(Name = "تخلیه به آب های سطحی")] SurfaceWater = 1,

      [Display(Name = "استفاده در کشاورزی")] Agriculture = 2,

      [Display(Name = "استفاده در فضای سبز")] GreenSpace = 3,

      [Display(Name = "تخلیه به دریا")] Sea = 4,

      [Display(Name = "استفاده مجدد")] Reuse = 5,

      [Display(Name = "تخلیه به اگوی شهری/تصفیه خانه مادر")] Sewage = 6,

      [Display(Name = "تخلیه به مخزن تبخیر / سپتیک")] SepticEvaporation = 7
   }
}
