using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class User : IAuditableEntity, IAccessControl
   {
      public User()
      {
         UserRoles = new HashSet<UserRole>();
         UserClaims = new HashSet<UserClaim>();
         UserTokens = new HashSet<UserToken>();
         UserGroups = new HashSet<UserGroup>();
         Invoices = new HashSet<Invoice>();
         InformationValidations = new HashSet<InformationValidation>();
      }
      public int Id { get; set; }
      public string Username { get; set; }
      public string Password { get; set; }
      public string Email { get; set; }
      public string Mobile { get; set; }
      public string FullName { get; set; }
      public virtual Upload ProfileImgFileName { get; set; }

      [StringLength(38)]
      public string ProfileImgFileNameId { get; set; }
      public bool IsActive { get; set; }
      public bool EmailVerified { get; set; }
      public bool MobileVerified { get; set; }
      public string NationalCode { get; set; }
      public string Description { get; set; }
      public int? ProvinceId { get; set; }
      public virtual EnumData Province { get; set; }
      public int? StateId { get; set; }
      public virtual EnumData State { get; set; }
      public DateTimeOffset RegisterDate { get; set; }
      public DateTimeOffset? LastLoggedIn { get; set; }

      [StringLength(38)]
      public string ApiKey { get; set; }

      [StringLength(8)]
      public string SecretKeyTemplate { get; set; }
      public DateTimeOffset SecretKeyGeneratedDate { get; set; }
      public bool IsForeign { get; set; }
      /// <summary>
      /// every time the user changes his Password,
      /// or an admin changes his Roles or stat/IsActive,
      /// create a new `SerialNumber` GUID and store it in the DB.
      /// </summary>
      public string SerialNumber { get; set; }

      public virtual ICollection<UserRole> UserRoles { get; set; }
      public virtual ICollection<UserClaim> UserClaims { get; set; }
      public virtual ICollection<UserToken> UserTokens { get; set; }
      public virtual ICollection<UserGroup> UserGroups { get; set; }
      public virtual ICollection<InformationValidation> InformationValidations { get; set; }
      public virtual ICollection<Invoice> Invoices { get; set; }

      public static Expression<Func<User, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[] { "UserFull", "UserView", "god" }).Any()) &&
            (uai.UserDataClaims._Skip_user ||
               (uai.UserDataClaims.User_id.Contains(q.Id)) ||
               (uai.UserDataClaims.User_state.Contains(q.StateId)) ||
               (uai.UserDataClaims.User_province.Contains(q.ProvinceId)));
      }
      public static Expression<Func<User, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }
}
