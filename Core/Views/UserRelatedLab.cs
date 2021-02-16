using System;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;

namespace Core.Entities
{
   public class UserRelatedLab : IAccessControl
   {
      public int Id { get; set; }
      public string Username { get; set; }
      public string FullName { get; set; }
      public bool IsActive { get; set; }
      public DateTimeOffset? UserRegisterDate { get; set; }
      public DateTimeOffset? UserLastLoggedIn { get; set; }
      public DateTimeOffset? AssignedClaimDate { get; set; }
      public int? LabId { get; set; }
      public string LabName { get; set; }
      public string LabProvince { get; set; }
      public int? LabProvinceId { get; set; }
      public int? LabStateId { get; set; }
      public string LabState { get; set; }
      public string UserProvince { get; set; }
      public int? UserProvinceId { get; set; }
      public int? UserStateId { get; set; }
      public string UserState { get; set; }
      public LabClassifications? Classification { get; set; }

      public static Expression<Func<UserRelatedLab, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[] { "LabFull", "LabView", "UserFull", "UserView", "god" }).Any()) &&
            (
               (uai.UserDataClaims._Skip_lab ||
                  (uai.UserDataClaims.Lab_id.Contains(q.LabId)) ||
                  (uai.UserDataClaims.Lab_province.Contains(q.LabProvinceId)) ||
                  (uai.UserDataClaims.Lab_state.Contains(q.LabStateId))) ||
               (uai.UserDataClaims._Skip_user ||
                  (uai.UserDataClaims.User_id.Contains(q.Id)) ||
                  (uai.UserDataClaims.User_state.Contains(q.UserStateId)) ||
                  (uai.UserDataClaims.User_province.Contains(q.UserProvinceId)))
            );
      }
      public static Expression<Func<UserRelatedLab, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }
}
