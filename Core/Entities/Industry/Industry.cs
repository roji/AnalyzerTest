using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Industry : IAuditableEntity, IAccessControl
   {
      // Public Info
      public int Id { get; set; }
      public string Name { get; set; }
      public IndustryStatuses IsActive { get; set; }
      public Int64? Serial { get; set; }
      public virtual LicenseInfo License { get; set; }
      public virtual Person Manager { get; set; }
      public virtual Address CentralOfficeAddress { get; set; }
      public virtual Address WorkshopAddress { get; set; }
      public IndustryClassifications? Classification { get; set; }
      // Relations
      public int? IsicCodeId { get; set; }
      public virtual EnumData IsicCode { get; set; }
      public int? IsicCode10Id { get; set; }
      public virtual EnumData IsicCode10 { get; set; }
      public virtual EnumData EstablishmentGrouping { get; set; }
      public int? EstablishmentGroupingId { get; set; }
      public bool? IsWasteUsedAsRawMaterial { get; set; }
      public virtual Upload OperationLicenseFileName { get; set; }

      [StringLength(38)] public string OperationLicenseFileNameId { get; set; }
      public virtual Upload LogoFileName { get; set; }

      [StringLength(38)] public string LogoFileNameId { get; set; }
      public DateTimeOffset? LastUpdateDateTime { get; set; }
      public int ValidationScore { get; set; }
      public bool IsKnowledgeBased { get; set; } // دانش بنیان
      public virtual ICollection<Waste> Wastes { get; set; }
      public virtual WasteManagementUnitsInfo WasteManagementUnit { get; set; }
      public virtual ICollection<ManufacturedProduct> ManufacturedProducts { get; set; }
      public virtual HumanResource HumanResource { get; set; }
      public virtual ICollection<WaterConsumption> WaterConsumptions { get; set; }
      public virtual ICollection<EnergyConsumption> EnergyConsumptions { get; set; }
      public virtual ICollection<RawMaterial> RawMaterials { get; set; }
      public virtual ICollection<ConsumingMaterial> ConsumingMaterials { get; set; }
      public virtual ICollection<Wastewater> Wastewaters { get; set; }
      public virtual ICollection<WastewaterDisposal> WastewaterDisposals { get; set; }
      public virtual ICollection<Repository> Repositories { get; set; }
      public virtual ICollection<IndustryInspection> IndustryInspections { get; set; }
      public virtual ICollection<IndustryPollution> IndustryPollutions { get; set; }
      public virtual ICollection<IndustryWarning> IndustryWarnings { get; set; }
      public virtual ICollection<IndustryOnlineMonitoring> OnlineMonitorings { get; set; }
      public virtual ICollection<GreenIndustry> GreenIndustries { get; set; }
      public virtual ICollection<WasteExportImport> WasteExportImports { get; set; }
      public virtual ICollection<IndustryClosure> Closures { get; set; }
      public virtual MonitoringInfo MonitoringInfo { get; set; }
      public virtual SlaughterHouseSpecialtyInfo SlaughterHouseSpecialtyInfo { get; set; }
      public virtual MedicalCenterSelfDeclarationInfo MedicalCenterSelfDeclarationInfo { get; set; }
      public virtual MedicalCenterUnitsInfo MedicalCenterUnitsInfo { get; set; }
      public virtual IndustrialTownsSpecialtyInfo IndustrialTownsSpecialtyInfo { get; set; }
      public virtual LivestockSpecialtyInfo LivestockSpecialtyInfo { get; set; }
      public virtual MineSpecialtyInfo MineSpecialtyInfo { get; set; }
      public virtual WasteDamSpecialtyInfo WasteDamSpecialtyInfo { get; set; }
      public virtual MunicipalityWasteSpecialtyInfo MunicipalityWasteSpecialtyInfo { get; set; }
      public virtual RefinerySpecialtyInfo RefinerySpecialtyInfo { get; set; }
      public virtual IndustryEvaluation Evaluation { get; set; }
      public virtual LandfillSpecialtyInfo LandfillSpecialtyInfo { get; set; }
      public virtual IndustryEstablishmentCase EstablishmentCase { get; set; }
      public virtual IndustryEstablishmentCaseAdditionalInfo EstablishmentCaseAdditionalInfo { get; set; }
      public virtual ICollection<InformationValidation> InformationValidations { get; set; }
      public virtual ICollection<IndustryEnvironmentalHealthExpertReport> EnvironmentalHealthExpertReports { get; set; }
      public virtual ICollection<UndergroundWaterQualityContinuousMonitoring> UndergroundWaterQualityContinuousMonitorings { get; set; }
      public virtual ICollection<IndustryEstablishmentRequest> EstablishmentRequests { get; set; }
      public virtual ICollection<IndustryJudicialAction> JudicialActions { get; set; }
      public virtual ICollection<IndustryMonitoringReferred> MonitoringReferreds { get; set; }
      public Industry()
      {
         Manager = new Person();
         License = new LicenseInfo();
         CentralOfficeAddress = new Address();
         WorkshopAddress = new Address();
         Wastes = new HashSet<Waste>();
         ManufacturedProducts = new HashSet<ManufacturedProduct>();
      }

      public static Expression<Func<Industry, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[] { "IndustryFull", "IndustryView", "god" })).Any() &&
            (uai.UserDataClaims._Skip_industry ||
               (uai.UserDataClaims.Industry_id.Contains(q.Id)) ||
               (uai.UserDataClaims.Industry_province.Contains(q.WorkshopAddress.ProvinceId)) ||
               (uai.UserDataClaims.Industry_state.Contains(q.WorkshopAddress.StateId)) ||
               (uai.UserDataClaims.Industry_isic2.Contains(q.IsicCode.ParentId)) ||
               (uai.UserDataClaims.Industry_isic4.Contains(q.IsicCodeId)));
      }
      public static Expression<Func<Industry, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
      public enum IndustryStatuses : int
      {
         [Display(Name = "مخالفت")] Disagreement = -2,

         [Display(Name = "نامشخص")] Undefined = -1,

         [Display(Name = "دارای مجوز و غیر فعال")] Deactive = 0,

         [Display(Name = "دارای مجوز و فعال")] Active = 1,

         [Display(Name = "درخواست مجوز استقرار")] EstablishmentRequested = 2,

         [Display(Name = "درخواست پروانه بهره برداری")] OperatingLicenseRequested = 3,

      }
      public enum IndustryClassifications : int
      {
         [Display(Name = "1")] One = 1, [Display(Name = "2")] Two = 2, [Display(Name = "3")] Three = 3, [Display(Name = "4")] Four = 4, [Display(Name = "5")] Five = 5, [Display(Name = "6")] Six = 6, [Display(Name = "7")] Seven = 7,
      }
   }
}
