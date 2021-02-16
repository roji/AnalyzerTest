using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Lab : IAuditableEntity, IAccessControl
   {
      // Public Info
      public int Id { get; set; }
      public string Name { get; set; }
      public string Code { get; set; }
      public bool IsActive { get; set; }
      public bool OtherActivity { get; set; }
      public string OtherActivityDescription { get; set; }
      public int? EstablishedYear { get; set; }
      public int? LabArea { get; set; }
      public int? LabPlatform { get; set; }
      public string ClassificationDescription { get; set; }
      public LabClassifications? Classification { get; set; }
      public virtual Upload ClassificationDocumentFileName { get; set; }

      [StringLength(38)]
      public string ClassificationDocumentFileNameId { get; set; }
      public virtual Upload OwnershipStatusDocumentFileName { get; set; }

      [StringLength(38)]
      public string OwnershipStatusDocumentFileNameId { get; set; }
      public virtual Person Manager { get; set; }
      public virtual Address LabAddress { get; set; }
      // Relations
      public int? OwnershipStatusId { get; set; }
      public virtual EnumData OwnershipStatus { get; set; }
      public DateTimeOffset? LastUpdateDateTime { get; set; }
      public int ValidationScore { get; set; }
      public virtual ICollection<LabMonitoringTypeStartedDate> MonitoringTypeStartedDates { get; set; }
      public virtual ICollection<InformationValidation> InformationValidations { get; set; }
      public virtual ICollection<Personnel> Personnels { get; set; }
      public virtual ICollection<Equipment> Equipments { get; set; }
      public virtual ICollection<ParameterAndMeasurementMethod> ParametersAndMeasurementMethods { get; set; }
      public virtual ICollection<IndustrialUnitsSamplingResult> IndustrialUnitsSamplingResults { get; set; }
      public virtual ICollection<LabConsumingMaterial> LabConsumingMaterials { get; set; }
      public virtual ICollection<HospitalSamplingResult> HospitalSamplingResults { get; set; }
      public virtual ICollection<LabInspection> Inspections { get; set; }
      public virtual ICollection<LabSupervision> Supervisions { get; set; }
      public virtual ICollection<IndustryMonitoringReferred> MonitoringReferreds { get; set; }
      public Lab()
      {
         Manager = new Person();
         LabAddress = new Address();
         MonitoringTypeStartedDates = new HashSet<LabMonitoringTypeStartedDate>();
         Inspections = new HashSet<LabInspection>();
         Supervisions = new HashSet<LabSupervision>();
      }

      public static Expression<Func<Lab, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[] { "LabFull", "LabView", "god" }).Any()) &&
            (uai.UserDataClaims._Skip_lab ||
               (uai.UserDataClaims.Lab_id.Contains(q.Id)) ||
               (uai.UserDataClaims.Lab_province.Contains(q.LabAddress.ProvinceId)) ||
               (uai.UserDataClaims.Lab_state.Contains(q.LabAddress.StateId)));
      }
      public static Expression<Func<Lab, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }
   public enum LabClassifications : int
   {
      [Display(Name = "ادارات کل استان ها (سازمان محیط زیست)")] ProvincesDepartment = 1,

      [Display(Name = "معتمد - خصوصی")] TrustedPrivate = 2,

      [Display(Name = "معتمد - مراکز آموزش عالی و دانشگاهی")] TrustedHigherEducationUniversities = 3,

      [Display(Name = "معتمد - مراکز دیگر دولتی")] TrustedOtherGovernmentCenters = 4,

      [Display(Name = "معتمد - وابسته به شهرداری ها")] TrustedAffiliatedWithMunicipalities = 5
   }
}
