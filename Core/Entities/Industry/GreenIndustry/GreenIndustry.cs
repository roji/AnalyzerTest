using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;
using Core.Tools;

namespace Core.Entities
{
   public class GreenIndustry : IAuditableEntity, IAccessControl
   {
      public GreenIndustry()
      {
         Strategies = new HashSet<GreenIndustryStrategies>();
         Descriptions = new HashSet<GreenIndustryDescriptions>();
         ShowResultForIndustry = false;
         GreenIndustryStatus = GreenIndustryStatuses.WaitingForCompletingInformations;
         RequestDate = DateTime.UtcNow;
      }
      public int Id { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public int Year { get; set; }
      public bool? HasRequestForGreenIndustry { get; set; }
      public DateTimeOffset RequestDate { get; set; }
      public virtual ICollection<GreenIndustryStrategies> Strategies { get; set; }
      public virtual ICollection<GreenIndustryDescriptions> Descriptions { get; set; }
      public bool ShowResultForIndustry { get; set; }
      public virtual GreenIndustryStatuses GreenIndustryStatus { get; set; }
      public virtual Upload PayBillFileName { get; set; }

      [StringLength(38)]
      public string PayBillFileNameId { get; set; }
      public double? TotalFinalScore { get; set; }
      public double? ProvinceTotalFinalScore { get; set; }

      public static Expression<Func<GreenIndustry, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[]
            {
               "god",
               "GreenIndustryPayConfirmationVote",
               "GreenIndustryProvinceExpertScoringVote",
               "GreenIndustryOrganizationExpertScoringVote",
               "GreenIndustryProvinceGeneralManagerVote",
               "GreenIndustryEvaluationOfficeManagerVote"
            }).Any()) &&
            (uai.UserDataClaims._Skip_greenindustry ||
               (uai.UserDataClaims.Greenindustry_province.Contains(q.Industry.WorkshopAddress.ProvinceId)));
      }
      public static Expression<Func<GreenIndustry, bool>> GetSmartLimitations(IUserAccessInfoService uai)
      {
         var myLimits = GetEntityLimitation(uai);
         var industryLimit = Industry.GetEntityLimitation(uai);
         var result = myLimits.Combine(CombineModes.Or, industryLimit, q => q.Industry);
         return result;
      }
   }
   public enum GreenIndustryStatuses : int
   {
      [Display(Name = "در انتظار تکمیل اطلاعات")] WaitingForCompletingInformations = 1,

      [Display(Name = "در انتظار بارگذاری فیش واریزی")] WaitingForUploadPayBillFile = 2,

      [Display(Name = "در انتظار تایید پرداخت")] WaitingForPayConfirmation = 3,

      [Display(Name = "در انتظار بررسی کارشناس اداره کل")] WaitingForProvinceExpertScoringVote = 4,

      [Display(Name = "در انتظار تایید مدیرکل استان")] WaitingForProvinceGeneralManagerVote = 5,

      [Display(Name = "در انتظار بررسی دبیرخانه")] WaitingForOrganizationExpertScoringVote = 6,

      [Display(Name = "در انتظار تایید مدیر کل دفتر ارزیابی")] WaitingForEvaluationOfficeManagerVote = 7,

      [Display(Name = "تکمیل شده")] Done = 8,

      [Display(Name = "لغو شده")] Canceled = 9,

      [Display(Name = "عدم موافقت")] Disapproved = 10
   }
}
