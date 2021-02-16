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
   public class WasteExportImport : IAuditableEntity, ISoftDeleteEntity, IAccessControl
   {
      public WasteExportImport()
      {
         PassingProvinces = new List<WasteExportImportPassingProvince>();
         Descriptions = new List<WasteExportImportDescription>();
         CustomCargos = new List<WasteExportImportCustomCargo>();
      }
      public int Id { get; set; }
      public virtual EnumData PermittedExportWaste { get; set; }
      public int? PermittedExportWasteId { get; set; }
      public virtual EnumData PermittedImportWaste { get; set; }
      public int? PermittedImportWasteId { get; set; }
      public virtual EnumData Country { get; set; }
      public int? CountryId { get; set; }
      public WasteExportImportTypes Type { get; set; }
      public double? Quantity { get; set; }
      public virtual EnumData MeasurementUnit { get; set; }
      public int? MeasurementUnitId { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public DateTimeOffset RequestDate { get; set; }
      public virtual EnumData WastePackagingType { get; set; }
      public int? WastePackagingTypeId { get; set; }
      public virtual WasteExportImportRepresentative Representative { get; set; }
      public virtual WasteExportImportProforma Proforma { get; set; }
      public bool HasSeveralTransportation { get; set; }
      public string SeveralTransportationDescription { get; set; }
      public bool HasStandardLabeling { get; set; }
      public string StandardLabelingDescription { get; set; }
      public int? BorderCustomId { get; set; }
      public virtual Industry BorderCustom { get; set; }
      public bool? HasInternalTransit { get; set; }
      public int? InternalTransitCustomId { get; set; }
      public virtual Industry InternalTransitCustom { get; set; }
      public virtual ICollection<WasteExportImportPassingProvince> PassingProvinces { get; set; }
      public virtual ICollection<WasteExportImportDescription> Descriptions { get; set; }
      public string TransportationVehicleToFirstCustom { get; set; }
      public int? DocumentNumber { get; set; }
      public virtual Upload WasteExportAnalysisResultFileName { get; set; }

      [StringLength(38)]
      public string WasteExportAnalysisResultFileNameId { get; set; }
      public virtual Upload BaselDocumentFileName { get; set; }

      [StringLength(38)]
      public string BaselDocumentFileNameId { get; set; }
      public WasteExportImportStatuses Status { get; set; }
      public bool? HasValidLicense { get; set; }
      public string ValidLicenseDescription { get; set; }
      public bool? ApproveProformaDocument { get; set; }
      public string ProformaDocumentDescription { get; set; }
      public bool? ViolationHistory { get; set; }
      public string ViolationHistoryDescription { get; set; }
      public double? ApprovedQuantityByGeneralAdministration { get; set; }
      public bool? ApprovedBySecretariatCommittee { get; set; }
      public string SecretariatCommitteeDescription { get; set; }
      public int? ApprovedBySecretariatCommitteeDate { get; set; }
      public bool? ApprovedByWasteRepresentative { get; set; }
      public string WasteRepresentativeDescription { get; set; }
      public int? ApprovedByWasteRepresentativeDate { get; set; }
      public bool? ApprovedBySecurityRepresentative { get; set; }
      public string SecurityRepresentativeDescription { get; set; }
      public int? ApprovedBySecurityRepresentativeDate { get; set; }
      public bool? ApprovedByInspectingRepresentative { get; set; }
      public string InspectingRepresentativeDescription { get; set; }
      public int? ApprovedByInspectingRepresentativeDate { get; set; }
      public bool? ApprovedByMonitoringRepresentative { get; set; }
      public string MonitoringRepresentativeDescription { get; set; }
      public int? ApprovedByMonitoringRepresentativeDate { get; set; }
      public double? ApprovedQuantityBySecretariat { get; set; }
      public int? LicenseExpireDate { get; set; }
      public string OrderRegisteredApproverExpertFullName { get; set; }
      public int? OrderRegisteredApproverExpertDate { get; set; }
      public string OrderRegisteredApproverExpertHour { get; set; }
      public string OrderRegisteredApproverExpertDescription { get; set; }
      public string OrderRegisteredApproverAdminFullName { get; set; }
      public int? OrderRegisteredApproverAdminDate { get; set; }
      public string OrderRegisteredApproverAdminHour { get; set; }
      public string OrderRegisteredApproverAdminDescription { get; set; }
      public virtual ICollection<WasteExportImportCustomCargo> CustomCargos { get; set; }

      public static Expression<Func<WasteExportImport, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[]
            {
               "IndustryFull",
               "IndustryWasteExportImportView",
               "god",
               "IndustryWasteExportImportGeneralAdministration",
               "IndustryWasteExportImportSecretariat",
               "IndustryWasteExportImportWasteRepresentative",
               "IndustryWasteExportImportInspectionRepresentative",
               "IndustryWasteExportImportSecurityRepresentative",
               "IndustryWasteExportImportMonitoringRepresentative"
            }).Any());
      }
      public static Expression<Func<WasteExportImport, bool>> GetSmartLimitations(IUserAccessInfoService uai)
      {
         var myLimits = GetEntityLimitation(uai);
         var industryLimit = Industry.GetEntityLimitation(uai);
         return myLimits.Combine(CombineModes.Or, industryLimit, q => q.Industry)
            .Combine(CombineModes.Or, industryLimit, q => q.BorderCustom)
            .Combine(CombineModes.Or, industryLimit, q => q.InternalTransitCustom);
      }
   }

   public enum WasteExportImportTypes : int
   {
      [Display(Name = "صادرات")] WasteExport = 1, [Display(Name = "واردات")] WasteImport = 2
   }

   public enum WasteExportImportStatuses : int
   {
      [Display(Name = "عدم تایید اداره کل")] DeniedByGeneralAdministration = -1, [Display(Name = "عدم تایید دبیرخانه")] DeniedBySecretariat = -2, [Display(Name = "اتمام مهلت مجوز")] LicenseDateExpired = -3, [Display(Name = "در انتظار بررسی اداره کل")] WaitingForGeneralAdministrationApprove = 1, [Display(Name = "در انتظار بررسی دبیر خانه")] WaitingForSecretariatApprove = 2, [Display(Name = "در انتظار دریافت اطلاعات ثبت سفارش")] WaitingForCompletingOrderInformation = 3, [Display(Name = "در انتظار بررسی ثبت سفارش")] WaitingForOrderApprove = 4, [Display(Name = "در انتظار واردات/صادرات")] WaitingForImportExport = 5, [Display(Name = "در انتظار بررسی مستندات گمرک")] WaitingForCustomDocumentApprove = 6, [Display(Name = "تکمیل مستندات توسط متقاضی")] WaitingForCompletingCustomDocument = 7, [Display(Name = "تکمیل شده")] Done = 8
   }
}
