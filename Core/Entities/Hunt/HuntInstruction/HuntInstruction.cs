using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HuntInstruction : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public HuntInstructionTypes Type { get; set; }
      public HuntInstructionStatuses Status { get; set; }
      public HuntInstructionRequestClassifications RequestClassification { get; set; }
      public int AnnouncedDate { get; set; }
      public string InstructionNumber { get; set; }
      public int HuntingTypeId { get; set; }
      public virtual EnumData HuntingType { get; set; }
      public int AnimalTypeId { get; set; }
      public virtual EnumData AnimalType { get; set; }
      public int FromDate { get; set; }
      public int ToDate { get; set; }
      public string FromHour { get; set; }
      public string ToHour { get; set; }
      public int HuntQuantity { get; set; }
      public int NativeLicenseAllowedQuantity { get; set; }
      public int NonNativeLicenseAllowedQuantity { get; set; }
      public int ForeignLicenseAllowedQuantity { get; set; }
      public double NativeLicenseFee { get; set; }
      public double NonNativeLicenseFee { get; set; }
      public double ForeignLicenseFee { get; set; }
      public int IssuedNativeLicenseQuantity { get; set; }
      public int IssuedNonNativeLicenseQuantity { get; set; }
      public int IssuedForeignLicenseQuantity { get; set; }
      public virtual Upload InstructionFileName { get; set; }

      [StringLength(38)]
      public string InstructionFileNameId { get; set; }
      public virtual EnumData Province { get; set; }
      public int ProvinceId { get; set; }
      public virtual ICollection<HuntInstructionProvinceRegionsLimitation> HuntInstructionProvinceRegionsLimitations { get; set; }
      public virtual ICollection<HuntInstructionWeekLimitation> HuntInstructionWeekLimitations { get; set; }
      public virtual ICollection<HuntInstructionDescription> Descriptions { get; set; }
      public virtual ICollection<HuntingLicense> HuntingLicenses { get; set; }
      public HuntInstruction()
      {
         HuntInstructionProvinceRegionsLimitations = new HashSet<HuntInstructionProvinceRegionsLimitation>();
         HuntInstructionWeekLimitations = new HashSet<HuntInstructionWeekLimitation>();
         Descriptions = new HashSet<HuntInstructionDescription>();
      }
      public static Expression<Func<HuntInstruction, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[] { "HuntInstructionFull", "HuntInstructionView", "god" })).Any() &&
            (uai.UserDataClaims._Skip_HuntInstruction ||
               (uai.UserDataClaims.HuntInstruction_province.Contains(q.ProvinceId)));
      }
      public static Expression<Func<HuntInstruction, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }

   public enum HuntInstructionTypes : int
   {
      [Display(Name = "عادی")] Normal = 1,

      [Display(Name = "غیر انتفاعی")] NonProfit = 2,

      [Display(Name = "ویژه")] Special = 3,
   }

   public enum HuntInstructionRequestClassifications : int
   {
      [Display(Name = "مستقل")] Independent = 1,

      [Display(Name = "قرق شکار")] PreserveHuntingGround = 2,

      [Display(Name = "صندوق ملی محیط زیست")] NationalEnvironmentalFund = 3,

      [Display(Name = "شرکت گردشگری")] TourismCompany = 4
   }

   public enum HuntInstructionStatuses : int
   {
      [Display(Name = "انقضای تعداد پروانه صادر شده")] ReachedMaximum = -3,

      [Display(Name = "انقضای تاریخ")] TimeExpired = -2,

      [Display(Name = "بررسی مجدد درخواست توسط اداره کل")] GeneralAdministrationReview = -1,

      [Display(Name = "در انتظار تایید دفتر حیات وحش")] WildLifeOfficeApprove = 1,

      [Display(Name = "در انتظار تایید معاون طبیعی و تنوع زیستی سازمان")] NaturalAndBiodiversityDeputyApprove = 2,

      [Display(Name = "تکمیل شده")] Done = 3
   }
}
