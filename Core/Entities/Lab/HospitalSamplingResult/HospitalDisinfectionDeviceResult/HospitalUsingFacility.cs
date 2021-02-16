using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HospitalUsingFacility : IAuditableEntity
   {
      public int Id { get; set; }
      public int HospitalSamplingResultId { get; set; }
      public virtual HospitalSamplingResult HospitalSamplingResult { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public HospitalUsingFacilitiesTypes UsingFacilitiesType { get; set; }
   }
   public enum HospitalUsingFacilitiesTypes : int
   {
      [Display(Name = "مراکز درمانی که از امکانات سایت مرکزی مورد پایش استفاده می کنند")] HospitalFacilities = 1,

      [Display(Name = "مراکز درمانی که از امکانات مرکز مورد پایش استفاده می کنند")] CenterSiteFacilities = 2
   }
}
