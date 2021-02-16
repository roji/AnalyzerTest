using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WasteExportImportCustomCargo : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public double? Quantity { get; set; }
        public int? ShipmentDate { get; set; }
        public string InternalTransitCustomNumber { get; set; }
        public int? InternalTransitCustomDate { get; set; }
        public string InternalTransitCustomStatementNumber { get; set; }
        public int? InternalTransitCustomStatementDate { get; set; }
        public virtual Upload InternalTransitCustomStatementFileName { get; set; }
        [StringLength(38)]
        public string InternalTransitCustomStatementFileNameId { get; set; }
        public int? LabId { get; set; }
        public virtual Lab Lab { get; set; }
        public int? SamplingDate { get; set; }
        public virtual Upload SamplingAnalysisFileName { get; set; }
        [StringLength(38)]
        public string SamplingAnalysisFileNameId { get; set; }
        public bool? HasAnotherCargo { get; set; }
        public bool? HasProductInspectionCertificate { get; set; }
        public string InspectionCompanyName { get; set; }
        public virtual Upload ProductInspectionCertificateFileName { get; set; }
        [StringLength(38)]
        public string ProductInspectionCertificateFileNameId { get; set; }
        public bool? ApproveWasteAnalysisByMonitoringRepresentative { get; set; }
        public string MonitoringRepresentativeWasteAnalysisDescription { get; set; }
        public int? ApproveWasteAnalysisByMonitoringRepresentativeDate { get; set; }
        public bool? ApproveCustomDocumentBySecretariatCommittee { get; set; }
        public string SecretariatCommitteeCustomDocumentDescription { get; set; }
        public int? ApproveCustomDocumentBySecretariatCommitteeDate { get; set; }
        public string OrderRegisteredApproverExpertFullName { get; set; }
        public int? OrderRegisteredApproverExpertDate { get; set; }
        public string OrderRegisteredApproverExpertHour { get; set; }
        public string OrderRegisteredApproverExpertDescription { get; set; }
        public string OrderRegisteredApproverAdminFullName { get; set; }
        public int? OrderRegisteredApproverAdminDate { get; set; }
        public string OrderRegisteredApproverAdminHour { get; set; }
        public string OrderRegisteredApproverAdminDescription { get; set; }
        public int? CargoExitFromCustomDate { get; set; }
        public int? EnteringRecycleUnitDate { get; set; }
        public int? RecycleDate { get; set; }
        public bool? ProductIsSellingInside { get; set; }
        public bool? ProductIsExporting { get; set; }
        public bool? GeneralAdministrationInspectorWasPresent { get; set; }
        public string InspectorFullName { get; set; }
        public virtual Upload InspectingDocumentFileName { get; set; }
        [StringLength(38)]
        public string InspectingDocumentFileNameId { get; set; }
        public bool? CargoObservedStandardRules { get; set; }
        public string CargoObservedStandardRulesDescription { get; set; }
        public virtual WasteExportImport WasteExportImport { get; set; }
        public int WasteExportImportId { get; set; }
        public bool? FinalApprove { get; set; }
    }
}
