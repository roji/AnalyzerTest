using System;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;

namespace Core.Entities
{
    public class UserRelatedIndustry : IAccessControl
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset? UserRegisterDate { get; set; }
        public DateTimeOffset? UserLastLoggedIn { get; set; }
        public DateTimeOffset? AssignedClaimDate { get; set; }
        public int? IndustryId { get; set; }
        public string IndustryName { get; set; }
        public string IndustryProvince { get; set; }
        public int? IndustryProvinceId { get; set; }
        public int? IndustryStateId { get; set; }
        public string IndustryState { get; set; }
        public string UserProvince { get; set; }
        public int? UserProvinceId { get; set; }
        public int? UserStateId { get; set; }
        public string UserState { get; set; }
        public string EstablishmentGrouping { get; set; }
        public int? EstablishmentGroupingId { get; set; }
        public string EstablishmentGroupingClassification { get; set; }
        public int? EstablishmentGroupingClassificationId { get; set; }
        public string IsicCode4 { get; set; }
        public int? IsicCode4Id { get; set; }
        public string IsicCode2 { get; set; }
        public int? IsicCode2Id { get; set; }

        public static Expression<Func<UserRelatedIndustry, bool>> GetEntityLimitation(IUserAccessInfoService uai)
        {
            return q =>
            (uai.UserClaims.Intersect(new string[] { "IndustryFull", "IndustryView", "UserFull", "UserView", "god" }).Any()) &&
                (
                (uai.UserDataClaims._Skip_industry ||
                (uai.UserDataClaims.Industry_id.Contains(q.IndustryId)) ||
                (uai.UserDataClaims.Industry_province.Contains(q.IndustryProvinceId)) ||
                (uai.UserDataClaims.Industry_state.Contains(q.IndustryStateId)) ||
                (uai.UserDataClaims.Industry_isic2.Contains(q.IsicCode2Id)) ||
                (uai.UserDataClaims.Industry_isic4.Contains(q.IsicCode4Id))) ||
                (uai.UserDataClaims._Skip_user ||
                (uai.UserDataClaims.User_id.Contains(q.Id)) ||
                (uai.UserDataClaims.User_state.Contains(q.UserStateId)) ||
                (uai.UserDataClaims.User_province.Contains(q.UserProvinceId)))
                );
        }
        public static Expression<Func<UserRelatedIndustry, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
    }
}
