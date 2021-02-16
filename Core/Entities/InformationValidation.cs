using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;
using Core.Tools;

namespace Core.Entities
{
   public class InformationValidation : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual User User { get; set; }
      public int? UserId { get; set; }
      public string UserName { get; set; }
      public string FullName { get; set; }
      public string Description { get; set; }
      public bool Vote { get; set; }
      public InformationValidationTypes Type { get; set; }
      public IndustryValidationScores? IndustryValidationScore { get; set; }
      public LabValidationScores? LabValidationScore { get; set; }
      public HunterValidationScores? HunterValidationScore { get; set; }
      public virtual DateTimeOffset DescriptionDate { get; set; }
      public virtual Industry Industry { get; set; }
      public int? IndustryId { get; set; }
      public virtual Lab Lab { get; set; }
      public int? LabId { get; set; }
      public virtual Hunter Hunter { get; set; }
      public int? HunterId { get; set; }

      public static Expression<Func<InformationValidation, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
             (uai.UserClaims.Intersect(new string[] { "IndustryFull", "LabFull",
                 "god", "HunterInformationValidationView", "IndustryInformationValidationView",
                 "LabInformationValidationView","HunterInformationValidationHistoryList",
                 "LabInformationValidationHistoryList","IndustryInformationValidationHistoryList"}))
             .Any();
      }
      public static Expression<Func<InformationValidation, bool>> GetSmartLimitations(IUserAccessInfoService uai)
      {
         var myLimits = GetEntityLimitation(uai);
         var industryLimit = Industry.GetEntityLimitation(uai);
         var labLimit = Lab.GetEntityLimitation(uai);
         var hunterLimit = Hunter.GetEntityLimitation(uai);
         var result = (myLimits.Combine(CombineModes.And, industryLimit, q => q.Industry))
                           .Combine(CombineModes.Or,
                          myLimits.Combine(CombineModes.And, labLimit, q => q.Lab))
                            .Combine(CombineModes.Or,
                          myLimits.Combine(CombineModes.And, hunterLimit, q => q.Hunter));
         return result;
      }
   }
   public enum InformationValidationTypes : int
   {
      [Display(Name = "مرکز")] Industry = 1,
      [Display(Name = "آزمایشگاه")] Lab = 2,
      [Display(Name = "شکارچی")] Hunter = 3
   }

   [Flags]
   public enum IndustryValidationScores : int
   {
      [Display(Name = "مشخصات عمومی")] PublicInfo = 1,
      [Display(Name = "انبارش ضایعات")] Repository = 2,
      [Display(Name = "پسماند")] Waste = 4,
      [Display(Name = "پساب")] Wastewater = 8,
      [Display(Name = "تولید، مواد مصرفی و منابع انسانی")] ProductAndHumanResource = 16,
      [Display(Name = "مصارف آب و انرژی")] WaterAndEnergyConsumption = 32,
      [Display(Name = "مشخصات پایش")] MonitoringInfo = 64,
      [Display(Name = "اطلاعات زیست محیطی و فضای سبز")] Evaluation = 128,
      [Display(Name = "پایش آنلاین")] OnlineMonitoring = 256,
      [Display(Name = "بخش تخصصی")] SpecialtyInfo = 512,
   }
   [Flags]
   public enum LabValidationScores : int
   {
      [Display(Name = "مشخصات عمومی")] PublicInfo = 1,
      [Display(Name = "پرسنل")] Personnel = 2,
      [Display(Name = "تجهیزات")] Equipment = 4,
      [Display(Name = "پارامتر ها و روش اندازه گیری")] ParameterAndMeasurementMethod = 8,
      [Display(Name = "مواد مصرفی")] ConsumingMaterial = 16
   }
   [Flags]
   public enum HunterValidationScores : int
   {
      [Display(Name = "مشخصات عمومی")] PublicInfo = 1,
      [Display(Name = "سوابق اسلحه و ابزار")] WeaponAndToolsHistory = 2,
      [Display(Name = "تخلفات")] Violation = 4,
      [Display(Name = "آموزش شکارچی")] Training = 8,
   }
}
