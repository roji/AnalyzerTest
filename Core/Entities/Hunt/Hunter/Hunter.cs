
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Hunter : IAuditableEntity, IAccessControl
   {
      public Hunter()
      {
         Information = new DetailedPerson();
         Address = new PersonAddress();
         Booklets = new HashSet<HunterBooklet>();
      }
      public int Id { get; set; }
      public HunterTypes HunterType { get; set; }
      public virtual DetailedPerson Information { get; set; }
      public virtual PersonAddress Address { get; set; }
      public string PreviousProvinceIdentityCode { get; set; }
      public string PreviousNationalIdentityCode { get; set; }
      public string AutomaticNationalIdentityCode { get; set; }
      public int? RegisterDate { get; set; }
      public bool? AcceptedCommitmentForm { get; set; }
      // Files
      public virtual Upload PhotoFileName { get; set; }

      [StringLength(38)]
      public string PhotoFileNameId { get; set; }
      public virtual Upload NationalCardFileName { get; set; }

      [StringLength(38)]
      public string NationalCardFileNameId { get; set; }
      public virtual Upload BirthCertificateFileName { get; set; }

      [StringLength(38)]
      public string BirthCertificateFileNameId { get; set; }
      public virtual Upload CommitmentFormFileName { get; set; }

      [StringLength(38)]
      public string CommitmentFormFileNameId { get; set; }
      public int ValidationScore { get; set; }
      public DateTimeOffset? LastUpdateDateTime { get; set; }
      public virtual ICollection<HunterWeaponHistory> WeaponHistories { get; set; }
      public virtual ICollection<FishermanToolsHistory> ToolsHistories { get; set; }
      public virtual ICollection<HunterViolation> Violations { get; set; }
      public virtual HunterNative Native { get; set; }
      public virtual HunterTraining Training { get; set; }
      public virtual ICollection<HunterBooklet> Booklets { get; set; }
      public virtual ICollection<HuntingLicense> HuntingLicenses { get; set; }
      public virtual ICollection<InformationValidation> InformationValidations { get; set; }

      public static Expression<Func<Hunter, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[] { "HunterFull", "HunterView", "god" }).Any()) &&
            (uai.UserDataClaims._Skip_hunter ||
               (uai.UserDataClaims.Hunter_id.Contains(q.Id)) ||
               (uai.UserDataClaims.Hunter_province.Contains(q.Address.ProvinceId)) ||
               (uai.UserDataClaims.Hunter_state.Contains(q.Address.StateId)));
      }
      public static Expression<Func<Hunter, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }

   public class HunterInformation
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public bool? SurvivalStatus { get; set; } // False = dead , True = Alive
      public string NationalCode { get; set; }
      public string FatherName { get; set; }
      public int? DateOfBirth { get; set; }
      public virtual EnumData Religion { get; set; }
      public int? ReligionId { get; set; }
      public string Faith { get; set; }
      public virtual EnumData Grade { get; set; }
      public int? GradeId { get; set; }
      public bool? MaritalStatus { get; set; } // False = Single, True = Married
   }

   public enum HunterTypes : int
   {
      [Display(Name = "شکارچی")] Hunter = 1, [Display(Name = "صیاد")] Fisherman = 2, [Display(Name = "شکارچی و صیاد")] HunterFisherman = 3
   }
}
