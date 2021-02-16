using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class WasteManagementUnitsInfo : IAuditableEntity, IAccessControl
   {
      public WasteManagementUnitsInfo()
      {
         SupportedIsics10 = new List<WasteManagementUnitsDetails>();
      }
      public int Id { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public int WasteManagementUnitClassificationId { get; set; }
      public virtual EnumData WasteManagementUnitClassification { get; set; }
      public int LastApprovalDate { get; set; }
      public virtual Upload LastLicenseFileName { get; set; }

      [StringLength(38)]
      public string LastLicenseFileNameId { get; set; }
      public virtual ICollection<WasteManagementUnitsDetails> SupportedIsics10 { get; set; }
   }
   public class WasteManagementUnitsDetails : IAuditableEntity, IAccessControl
   {
      public WasteManagementUnitsDetails()
      {
         OperationalProcess = new List<int>();
      }

      public int Id { get; set; }
      public int WasteManagementUnitsInfoId { get; set; }
      public virtual WasteManagementUnitsInfo WasteManagementUnitsInfo { get; set; }
      public int IsicCode10Id { get; set; }
      public virtual EnumData IsicCode10 { get; set; }
      public int HoldingCapacity { get; set; }
      public int OverallCapacityOperationLicense { get; set; }
      public WasteMeasurementUnits MeasurementUnit { get; set; }

      [NotMapped]
      public ICollection<int> OperationalProcess { get; set; }
      public string OperationalProcessIds
      {
         get { return string.Join(",", OperationalProcess); }
         set { if (!string.IsNullOrWhiteSpace(value)) { OperationalProcess = value.Split(',').Select(int.Parse).ToList(); } }
      }
      public string WorkingMethod { get; set; }
      public bool? UsingOtherMaterial { get; set; }
      public string UomDescription { get; set; }
      public string WasteResultAfterOperationalProccess { get; set; }
      public bool? WasteRemainAfterOperationalProccess { get; set; }
      public string RemainedWasteManagementMethod { get; set; }
      public string WraopDescription { get; set; }
      public string UsingEquipments { get; set; }
      public virtual Upload OperationDocumentFileName { get; set; }

      [StringLength(38)]
      public string OperationDocumentFileNameId { get; set; }
      public bool? HasBeenApprovedByGeneralAdminstration { get; set; }
      public string AdministrationDescription { get; set; }
   }
}
