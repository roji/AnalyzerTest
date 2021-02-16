using System;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using static Core.Entities.Industry;

namespace Core.Entities
{
   public class IndustryPhaseOneMonitoringMapList : IAccessControl
   {
      public int IndustryId { get; set; }
      public string IndustryName { get; set; }
      public IndustryStatuses IsActive { get; set; }
      public DateTimeOffset? LastUpdateDateTime { get; set; }
      public string Province { get; set; }
      public int? ProvinceId { get; set; }
      public int? StateId { get; set; }
      public string State { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
      public string IsicCode4 { get; set; }
      public int? IsicCode4Id { get; set; }
      public int? IsicCode2Id { get; set; }
      public bool HasNeedMonitoring { get; set; }
      public bool HasMonitoring { get; set; }
      public static Expression<Func<IndustryPhaseOneMonitoringMapList, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[] { "IndustryFull", "IndustryView", "god" }).Any()) &&
            (uai.UserDataClaims._Skip_industry ||
               (uai.UserDataClaims.Industry_id.Contains(q.IndustryId)) ||
               (uai.UserDataClaims.Industry_province.Contains(q.ProvinceId)) ||
               (uai.UserDataClaims.Industry_state.Contains(q.StateId)) ||
               (uai.UserDataClaims.Industry_isic2.Contains(q.IsicCode2Id)) ||
               (uai.UserDataClaims.Industry_isic4.Contains(q.IsicCode4Id)));
      }
      public static Expression<Func<IndustryPhaseOneMonitoringMapList, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }
}
