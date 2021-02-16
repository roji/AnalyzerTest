using System;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;

namespace Core.Entities
{
   public class WasteSenderIndustryMapList : IAccessControl
   {
      public int SenderIndustryId { get; set; }
      public string SenderIndustry { get; set; }
      public int? SenderProvinceId { get; set; }
      public string SenderProvince { get; set; }
      public int? SenderStateId { get; set; }
      public string SenderState { get; set; }
      public int? EstablishmentGroupingId { get; set; }
      public string EstablishmentGrouping { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
      public string WasteNames { get; set; }
      public static Expression<Func<WasteSenderIndustryMapList, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[] { "IndustryFull", "IndustryView", "god" }).Any()) &&
            (uai.UserDataClaims._Skip_industry ||
               (uai.UserDataClaims.Industry_id.Contains(q.SenderIndustryId)) ||
               (uai.UserDataClaims.Industry_province.Contains(q.SenderProvinceId)) ||
               (uai.UserDataClaims.Industry_state.Contains(q.SenderStateId)));
      }
      public static Expression<Func<WasteSenderIndustryMapList, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }
}
