using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;
namespace Core.Entities
{
   public class WastesShipments : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual WasteTransfer WasteTransfer { get; set; }
      public int WasteTransferId { get; set; }
      public int ShipmentDate { get; set; }
      public bool? RoadTransportRegulationsObserved { get; set; }
      public bool? RoadAccidentCommitment { get; set; }
      public string WasteTransferingCompanyName { get; set; }
      public string CarNumber { get; set; }
      public string DriverName { get; set; }
      public string DriverPhone { get; set; }
      public virtual Upload HazardousMaterialTransportingLicenseFileName { get; set; }

      [StringLength(38)]
      public string HazardousMaterialTransportingLicenseFileNameId { get; set; }
      public string CarGpsNumber { get; set; }
      public string BarSealNumber { get; set; }
      public virtual Upload WayBillFileName { get; set; }

      [StringLength(38)]
      public string WayBillFileNameId { get; set; }
      public virtual Upload LoadingSupervisionAgendaFileName { get; set; }

      [StringLength(38)]
      public string LoadingSupervisionAgendaFileNameId { get; set; }
      public double? LoadedWeight { get; set; }
      public int? WasteReceivedDate { get; set; }
      public string WasteManagementMethod { get; set; }
      public int? EliminationPossibleStartDate { get; set; }
      public virtual Upload EliminationFileName { get; set; }

      [StringLength(38)]
      public string EliminationFileNameId { get; set; }
      public virtual Upload SupervisionOverDischargeFileName { get; set; }

      [StringLength(38)]
      public string SupervisionOverDischargeFileNameId { get; set; }
      public bool? SealValidation { get; set; }
      public double? ReceivedWeight { get; set; }
   }
}
