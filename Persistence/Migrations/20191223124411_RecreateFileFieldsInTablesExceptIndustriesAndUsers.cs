using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RecreateFileFieldsInTablesExceptIndustriesAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanSiteFileName",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropColumn(
                name: "RefineryHydraulicPlanFileName",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropColumn(
                name: "DesAdminAgreementFileName",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "EliminationFormFileName",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "LoadingSupervisionAgendaFileName",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "SaleInvoiceFileName",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "SupervisionOverDischargeFileName",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "WasteAnalysisFileName",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "WaybillFileName",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "WasteAnalysisFileName",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "WasteAnalysisResultFileName",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "EliminationFileName",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "HazardousMaterialTransportingLicenseFileName",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "LoadingSupervisionAgendaFileName",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "SupervisionOverDischargeFileName",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "WayBillFileName",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "LastLicensePhotoName",
                table: "WasteManagementUnitsInfos");

            migrationBuilder.DropColumn(
                name: "ProfileImgFileName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MinistryOfAgricultureLicenseFileName",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "MinistryOfIndustryLicenseFileName",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "DegreeOfEducationFileName",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "NationalCardPhotoFileName",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "PersonnelHistoryFileName",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "DocumentsFileName",
                table: "ParametersSamplingResults");

            migrationBuilder.DropColumn(
                name: "ContractFileName",
                table: "NormalWasteInformations");

            migrationBuilder.DropColumn(
                name: "ScannerBlockDiagramFileName",
                table: "ManufacturedProducts");

            migrationBuilder.DropColumn(
                name: "BuildingMapFileName",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "MinistryOfAgricultureLicenseFileName",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "MinistryOfIndustryLicenseFileName",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "ClassificationDocumentFileName",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "OwnershipStatusDocumentFileName",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "AdministrationLetterFileName",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "WarningDocumentFileName",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "DocumentFileName",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "PollutionDetectionCommitteeFileName",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "InspectDocumentFileName",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "InspectingAgendaFileName",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "InspectingExpertReportFileName",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "MonitoringTypesDocumentFileName",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "IndustryContractFileName",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "LabPartnerContractFileName",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "OrganizationRepresentativeAttendanceFileName",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "CommitmentsFileName",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "EstablishedIndustryMapFileName",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "EstablishmentZoningFileName",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "LicenseFileName",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "DocumentFileName",
                table: "GreenIndustryStrategies");

            migrationBuilder.DropColumn(
                name: "PayBillFileName",
                table: "GreenIndustries");

            migrationBuilder.DropColumn(
                name: "CalibrationLicensePhotoFileName",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "EquipmentPhotoFileName",
                table: "Equipments");

            migrationBuilder.AddColumn<string>(
                name: "PlanSiteFileNameId",
                table: "WwHasPurificationSystems",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefineryHydraulicPlanFileNameId",
                table: "WwHasPurificationSystems",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesAdminAgreementFileNameId",
                table: "WasteTransportation",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EliminationFormFileNameId",
                table: "WasteTransportation",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoadingSupervisionAgendaFileNameId",
                table: "WasteTransportation",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleInvoiceFileNameId",
                table: "WasteTransportation",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisionOverDischargeFileNameId",
                table: "WasteTransportation",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WasteAnalysisFileNameId",
                table: "WasteTransportation",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WaybillFileNameId",
                table: "WasteTransportation",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WasteAnalysisFileNameId",
                table: "WasteTransfers",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WasteAnalysisResultFileNameId",
                table: "WasteTransfers",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EliminationFileNameId",
                table: "WastesShipments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HazardousMaterialTransportingLicenseFileNameId",
                table: "WastesShipments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoadingSupervisionAgendaFileNameId",
                table: "WastesShipments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisionOverDischargeFileNameId",
                table: "WastesShipments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WayBillFileNameId",
                table: "WastesShipments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastLicenseFileNameId",
                table: "WasteManagementUnitsInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinistryOfAgricultureLicenseFileNameId",
                table: "SlaughterHouseSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinistryOfIndustryLicenseFileNameId",
                table: "SlaughterHouseSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeOfEducationFileNameId",
                table: "Personnels",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalCardPhotoFileNameId",
                table: "Personnels",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonnelHistoryFileNameId",
                table: "Personnels",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentsFileNameId",
                table: "ParametersSamplingResults",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContractFileNameId",
                table: "NormalWasteInformations",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScannerBlockDiagramFileNameId",
                table: "ManufacturedProducts",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuildingMapFileNameId",
                table: "LivestockSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinistryOfAgricultureLicenseFileNameId",
                table: "LivestockSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinistryOfIndustryLicenseFileNameId",
                table: "LivestockSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassificationDocumentFileNameId",
                table: "Labs",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnershipStatusDocumentFileNameId",
                table: "Labs",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdministrationLetterFileNameId",
                table: "IndustryWarnings",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarningDocumentFileNameId",
                table: "IndustryWarnings",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentFileNameId",
                table: "IndustryPollutions",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PollutionDetectionCommitteeFileNameId",
                table: "IndustryPollutions",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectDocumentFileNameId",
                table: "IndustryInspections",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectingAgendaFileNameId",
                table: "IndustryInspections",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectingExpertReportFileNameId",
                table: "IndustryInspections",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonitoringTypesDocumentFileNameId",
                table: "IndustryInspections",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustryContractFileNameId",
                table: "IndustrialUnitsSamplingResults",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabPartnerContractFileNameId",
                table: "IndustrialUnitsSamplingResults",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganizationRepresentativeAttendanceFileNameId",
                table: "IndustrialUnitsSamplingResults",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommitmentsFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstablishedIndustryMapFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentZoningFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LicenseFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentFileNameId",
                table: "GreenIndustryStrategies",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayBillFileNameId",
                table: "GreenIndustries",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CalibrationLicensePhotoFileNameId",
                table: "Equipments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentPhotoFileNameId",
                table: "Equipments",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WwHasPurificationSystems_PlanSiteFileNameId",
                table: "WwHasPurificationSystems",
                column: "PlanSiteFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WwHasPurificationSystems_RefineryHydraulicPlanFileNameId",
                table: "WwHasPurificationSystems",
                column: "RefineryHydraulicPlanFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_DesAdminAgreementFileNameId",
                table: "WasteTransportation",
                column: "DesAdminAgreementFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_EliminationFormFileNameId",
                table: "WasteTransportation",
                column: "EliminationFormFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_LoadingSupervisionAgendaFileNameId",
                table: "WasteTransportation",
                column: "LoadingSupervisionAgendaFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_SaleInvoiceFileNameId",
                table: "WasteTransportation",
                column: "SaleInvoiceFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_SupervisionOverDischargeFileNameId",
                table: "WasteTransportation",
                column: "SupervisionOverDischargeFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_WasteAnalysisFileNameId",
                table: "WasteTransportation",
                column: "WasteAnalysisFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_WaybillFileNameId",
                table: "WasteTransportation",
                column: "WaybillFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfers_WasteAnalysisFileNameId",
                table: "WasteTransfers",
                column: "WasteAnalysisFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfers_WasteAnalysisResultFileNameId",
                table: "WasteTransfers",
                column: "WasteAnalysisResultFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WastesShipments_EliminationFileNameId",
                table: "WastesShipments",
                column: "EliminationFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WastesShipments_HazardousMaterialTransportingLicenseFileName~",
                table: "WastesShipments",
                column: "HazardousMaterialTransportingLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WastesShipments_LoadingSupervisionAgendaFileNameId",
                table: "WastesShipments",
                column: "LoadingSupervisionAgendaFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WastesShipments_SupervisionOverDischargeFileNameId",
                table: "WastesShipments",
                column: "SupervisionOverDischargeFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WastesShipments_WayBillFileNameId",
                table: "WastesShipments",
                column: "WayBillFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagementUnitsInfos_LastLicenseFileNameId",
                table: "WasteManagementUnitsInfos",
                column: "LastLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_SlaughterHouseSpecialtyInfos_MinistryOfAgricultureLicenseFil~",
                table: "SlaughterHouseSpecialtyInfos",
                column: "MinistryOfAgricultureLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_SlaughterHouseSpecialtyInfos_MinistryOfIndustryLicenseFileNa~",
                table: "SlaughterHouseSpecialtyInfos",
                column: "MinistryOfIndustryLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_DegreeOfEducationFileNameId",
                table: "Personnels",
                column: "DegreeOfEducationFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_NationalCardPhotoFileNameId",
                table: "Personnels",
                column: "NationalCardPhotoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_PersonnelHistoryFileNameId",
                table: "Personnels",
                column: "PersonnelHistoryFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_DocumentsFileNameId",
                table: "ParametersSamplingResults",
                column: "DocumentsFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_NormalWasteInformations_ContractFileNameId",
                table: "NormalWasteInformations",
                column: "ContractFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturedProducts_ScannerBlockDiagramFileNameId",
                table: "ManufacturedProducts",
                column: "ScannerBlockDiagramFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyInfos_BuildingMapFileNameId",
                table: "LivestockSpecialtyInfos",
                column: "BuildingMapFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyInfos_MinistryOfAgricultureLicenseFileName~",
                table: "LivestockSpecialtyInfos",
                column: "MinistryOfAgricultureLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyInfos_MinistryOfIndustryLicenseFileNameId",
                table: "LivestockSpecialtyInfos",
                column: "MinistryOfIndustryLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_ClassificationDocumentFileNameId",
                table: "Labs",
                column: "ClassificationDocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_OwnershipStatusDocumentFileNameId",
                table: "Labs",
                column: "OwnershipStatusDocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarnings_AdministrationLetterFileNameId",
                table: "IndustryWarnings",
                column: "AdministrationLetterFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryWarnings_WarningDocumentFileNameId",
                table: "IndustryWarnings",
                column: "WarningDocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutions_DocumentFileNameId",
                table: "IndustryPollutions",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutions_PollutionDetectionCommitteeFileNameId",
                table: "IndustryPollutions",
                column: "PollutionDetectionCommitteeFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspections_InspectDocumentFileNameId",
                table: "IndustryInspections",
                column: "InspectDocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspections_InspectingAgendaFileNameId",
                table: "IndustryInspections",
                column: "InspectingAgendaFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspections_InspectingExpertReportFileNameId",
                table: "IndustryInspections",
                column: "InspectingExpertReportFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspections_MonitoringTypesDocumentFileNameId",
                table: "IndustryInspections",
                column: "MonitoringTypesDocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_IndustryContractFileNameId",
                table: "IndustrialUnitsSamplingResults",
                column: "IndustryContractFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_LabPartnerContractFileNameId",
                table: "IndustrialUnitsSamplingResults",
                column: "LabPartnerContractFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_OrganizationRepresentativeAtt~",
                table: "IndustrialUnitsSamplingResults",
                column: "OrganizationRepresentativeAttendanceFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_CommitmentsFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                column: "CommitmentsFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_EstablishedIndustryMapFileName~",
                table: "IndustrialTownsSpecialtyInfos",
                column: "EstablishedIndustryMapFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_EstablishmentZoningFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                column: "EstablishmentZoningFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_LicenseFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                column: "LicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryStrategies_DocumentFileNameId",
                table: "GreenIndustryStrategies",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustries_PayBillFileNameId",
                table: "GreenIndustries",
                column: "PayBillFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_CalibrationLicensePhotoFileNameId",
                table: "Equipments",
                column: "CalibrationLicensePhotoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_EquipmentPhotoFileNameId",
                table: "Equipments",
                column: "EquipmentPhotoFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Uploads_CalibrationLicensePhotoFileNameId",
                table: "Equipments",
                column: "CalibrationLicensePhotoFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Uploads_EquipmentPhotoFileNameId",
                table: "Equipments",
                column: "EquipmentPhotoFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GreenIndustries_Uploads_PayBillFileNameId",
                table: "GreenIndustries",
                column: "PayBillFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GreenIndustryStrategies_Uploads_DocumentFileNameId",
                table: "GreenIndustryStrategies",
                column: "DocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialTownsSpecialtyInfos_Uploads_CommitmentsFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                column: "CommitmentsFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialTownsSpecialtyInfos_Uploads_EstablishedIndustryMap~",
                table: "IndustrialTownsSpecialtyInfos",
                column: "EstablishedIndustryMapFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialTownsSpecialtyInfos_Uploads_EstablishmentZoningFil~",
                table: "IndustrialTownsSpecialtyInfos",
                column: "EstablishmentZoningFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialTownsSpecialtyInfos_Uploads_LicenseFileNameId",
                table: "IndustrialTownsSpecialtyInfos",
                column: "LicenseFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Uploads_IndustryContractFileN~",
                table: "IndustrialUnitsSamplingResults",
                column: "IndustryContractFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Uploads_LabPartnerContractFil~",
                table: "IndustrialUnitsSamplingResults",
                column: "LabPartnerContractFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Uploads_OrganizationRepresent~",
                table: "IndustrialUnitsSamplingResults",
                column: "OrganizationRepresentativeAttendanceFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryInspections_Uploads_InspectDocumentFileNameId",
                table: "IndustryInspections",
                column: "InspectDocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryInspections_Uploads_InspectingAgendaFileNameId",
                table: "IndustryInspections",
                column: "InspectingAgendaFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryInspections_Uploads_InspectingExpertReportFileNameId",
                table: "IndustryInspections",
                column: "InspectingExpertReportFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryInspections_Uploads_MonitoringTypesDocumentFileNameId",
                table: "IndustryInspections",
                column: "MonitoringTypesDocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryPollutions_Uploads_DocumentFileNameId",
                table: "IndustryPollutions",
                column: "DocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryPollutions_Uploads_PollutionDetectionCommitteeFileNa~",
                table: "IndustryPollutions",
                column: "PollutionDetectionCommitteeFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryWarnings_Uploads_AdministrationLetterFileNameId",
                table: "IndustryWarnings",
                column: "AdministrationLetterFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryWarnings_Uploads_WarningDocumentFileNameId",
                table: "IndustryWarnings",
                column: "WarningDocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_Uploads_ClassificationDocumentFileNameId",
                table: "Labs",
                column: "ClassificationDocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_Uploads_OwnershipStatusDocumentFileNameId",
                table: "Labs",
                column: "OwnershipStatusDocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LivestockSpecialtyInfos_Uploads_BuildingMapFileNameId",
                table: "LivestockSpecialtyInfos",
                column: "BuildingMapFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LivestockSpecialtyInfos_Uploads_MinistryOfAgricultureLicense~",
                table: "LivestockSpecialtyInfos",
                column: "MinistryOfAgricultureLicenseFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LivestockSpecialtyInfos_Uploads_MinistryOfIndustryLicenseFil~",
                table: "LivestockSpecialtyInfos",
                column: "MinistryOfIndustryLicenseFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturedProducts_Uploads_ScannerBlockDiagramFileNameId",
                table: "ManufacturedProducts",
                column: "ScannerBlockDiagramFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NormalWasteInformations_Uploads_ContractFileNameId",
                table: "NormalWasteInformations",
                column: "ContractFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersSamplingResults_Uploads_DocumentsFileNameId",
                table: "ParametersSamplingResults",
                column: "DocumentsFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Uploads_DegreeOfEducationFileNameId",
                table: "Personnels",
                column: "DegreeOfEducationFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Uploads_NationalCardPhotoFileNameId",
                table: "Personnels",
                column: "NationalCardPhotoFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Uploads_PersonnelHistoryFileNameId",
                table: "Personnels",
                column: "PersonnelHistoryFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_Uploads_MinistryOfAgricultureLi~",
                table: "SlaughterHouseSpecialtyInfos",
                column: "MinistryOfAgricultureLicenseFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_Uploads_MinistryOfIndustryLicen~",
                table: "SlaughterHouseSpecialtyInfos",
                column: "MinistryOfIndustryLicenseFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsInfos_Uploads_LastLicenseFileNameId",
                table: "WasteManagementUnitsInfos",
                column: "LastLicenseFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WastesShipments_Uploads_EliminationFileNameId",
                table: "WastesShipments",
                column: "EliminationFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WastesShipments_Uploads_HazardousMaterialTransportingLicense~",
                table: "WastesShipments",
                column: "HazardousMaterialTransportingLicenseFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WastesShipments_Uploads_LoadingSupervisionAgendaFileNameId",
                table: "WastesShipments",
                column: "LoadingSupervisionAgendaFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WastesShipments_Uploads_SupervisionOverDischargeFileNameId",
                table: "WastesShipments",
                column: "SupervisionOverDischargeFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WastesShipments_Uploads_WayBillFileNameId",
                table: "WastesShipments",
                column: "WayBillFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransfers_Uploads_WasteAnalysisFileNameId",
                table: "WasteTransfers",
                column: "WasteAnalysisFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransfers_Uploads_WasteAnalysisResultFileNameId",
                table: "WasteTransfers",
                column: "WasteAnalysisResultFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Uploads_DesAdminAgreementFileNameId",
                table: "WasteTransportation",
                column: "DesAdminAgreementFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Uploads_EliminationFormFileNameId",
                table: "WasteTransportation",
                column: "EliminationFormFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Uploads_LoadingSupervisionAgendaFileName~",
                table: "WasteTransportation",
                column: "LoadingSupervisionAgendaFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Uploads_SaleInvoiceFileNameId",
                table: "WasteTransportation",
                column: "SaleInvoiceFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Uploads_SupervisionOverDischargeFileName~",
                table: "WasteTransportation",
                column: "SupervisionOverDischargeFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Uploads_WasteAnalysisFileNameId",
                table: "WasteTransportation",
                column: "WasteAnalysisFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Uploads_WaybillFileNameId",
                table: "WasteTransportation",
                column: "WaybillFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WwHasPurificationSystems_Uploads_PlanSiteFileNameId",
                table: "WwHasPurificationSystems",
                column: "PlanSiteFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WwHasPurificationSystems_Uploads_RefineryHydraulicPlanFileNa~",
                table: "WwHasPurificationSystems",
                column: "RefineryHydraulicPlanFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Uploads_CalibrationLicensePhotoFileNameId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Uploads_EquipmentPhotoFileNameId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_GreenIndustries_Uploads_PayBillFileNameId",
                table: "GreenIndustries");

            migrationBuilder.DropForeignKey(
                name: "FK_GreenIndustryStrategies_Uploads_DocumentFileNameId",
                table: "GreenIndustryStrategies");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialTownsSpecialtyInfos_Uploads_CommitmentsFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialTownsSpecialtyInfos_Uploads_EstablishedIndustryMap~",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialTownsSpecialtyInfos_Uploads_EstablishmentZoningFil~",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialTownsSpecialtyInfos_Uploads_LicenseFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Uploads_IndustryContractFileN~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Uploads_LabPartnerContractFil~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Uploads_OrganizationRepresent~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryInspections_Uploads_InspectDocumentFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryInspections_Uploads_InspectingAgendaFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryInspections_Uploads_InspectingExpertReportFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryInspections_Uploads_MonitoringTypesDocumentFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryPollutions_Uploads_DocumentFileNameId",
                table: "IndustryPollutions");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryPollutions_Uploads_PollutionDetectionCommitteeFileNa~",
                table: "IndustryPollutions");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryWarnings_Uploads_AdministrationLetterFileNameId",
                table: "IndustryWarnings");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryWarnings_Uploads_WarningDocumentFileNameId",
                table: "IndustryWarnings");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_Uploads_ClassificationDocumentFileNameId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_Uploads_OwnershipStatusDocumentFileNameId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_LivestockSpecialtyInfos_Uploads_BuildingMapFileNameId",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_LivestockSpecialtyInfos_Uploads_MinistryOfAgricultureLicense~",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_LivestockSpecialtyInfos_Uploads_MinistryOfIndustryLicenseFil~",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturedProducts_Uploads_ScannerBlockDiagramFileNameId",
                table: "ManufacturedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_NormalWasteInformations_Uploads_ContractFileNameId",
                table: "NormalWasteInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersSamplingResults_Uploads_DocumentsFileNameId",
                table: "ParametersSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Uploads_DegreeOfEducationFileNameId",
                table: "Personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Uploads_NationalCardPhotoFileNameId",
                table: "Personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Uploads_PersonnelHistoryFileNameId",
                table: "Personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_Uploads_MinistryOfAgricultureLi~",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_SlaughterHouseSpecialtyInfos_Uploads_MinistryOfIndustryLicen~",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsInfos_Uploads_LastLicenseFileNameId",
                table: "WasteManagementUnitsInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WastesShipments_Uploads_EliminationFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropForeignKey(
                name: "FK_WastesShipments_Uploads_HazardousMaterialTransportingLicense~",
                table: "WastesShipments");

            migrationBuilder.DropForeignKey(
                name: "FK_WastesShipments_Uploads_LoadingSupervisionAgendaFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropForeignKey(
                name: "FK_WastesShipments_Uploads_SupervisionOverDischargeFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropForeignKey(
                name: "FK_WastesShipments_Uploads_WayBillFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransfers_Uploads_WasteAnalysisFileNameId",
                table: "WasteTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransfers_Uploads_WasteAnalysisResultFileNameId",
                table: "WasteTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Uploads_DesAdminAgreementFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Uploads_EliminationFormFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Uploads_LoadingSupervisionAgendaFileName~",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Uploads_SaleInvoiceFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Uploads_SupervisionOverDischargeFileName~",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Uploads_WasteAnalysisFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Uploads_WaybillFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WwHasPurificationSystems_Uploads_PlanSiteFileNameId",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_WwHasPurificationSystems_Uploads_RefineryHydraulicPlanFileNa~",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropIndex(
                name: "IX_WwHasPurificationSystems_PlanSiteFileNameId",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropIndex(
                name: "IX_WwHasPurificationSystems_RefineryHydraulicPlanFileNameId",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransportation_DesAdminAgreementFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransportation_EliminationFormFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransportation_LoadingSupervisionAgendaFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransportation_SaleInvoiceFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransportation_SupervisionOverDischargeFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransportation_WasteAnalysisFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransportation_WaybillFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransfers_WasteAnalysisFileNameId",
                table: "WasteTransfers");

            migrationBuilder.DropIndex(
                name: "IX_WasteTransfers_WasteAnalysisResultFileNameId",
                table: "WasteTransfers");

            migrationBuilder.DropIndex(
                name: "IX_WastesShipments_EliminationFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropIndex(
                name: "IX_WastesShipments_HazardousMaterialTransportingLicenseFileName~",
                table: "WastesShipments");

            migrationBuilder.DropIndex(
                name: "IX_WastesShipments_LoadingSupervisionAgendaFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropIndex(
                name: "IX_WastesShipments_SupervisionOverDischargeFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropIndex(
                name: "IX_WastesShipments_WayBillFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropIndex(
                name: "IX_WasteManagementUnitsInfos_LastLicenseFileNameId",
                table: "WasteManagementUnitsInfos");

            migrationBuilder.DropIndex(
                name: "IX_SlaughterHouseSpecialtyInfos_MinistryOfAgricultureLicenseFil~",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_SlaughterHouseSpecialtyInfos_MinistryOfIndustryLicenseFileNa~",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_DegreeOfEducationFileNameId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_NationalCardPhotoFileNameId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_PersonnelHistoryFileNameId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_ParametersSamplingResults_DocumentsFileNameId",
                table: "ParametersSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_NormalWasteInformations_ContractFileNameId",
                table: "NormalWasteInformations");

            migrationBuilder.DropIndex(
                name: "IX_ManufacturedProducts_ScannerBlockDiagramFileNameId",
                table: "ManufacturedProducts");

            migrationBuilder.DropIndex(
                name: "IX_LivestockSpecialtyInfos_BuildingMapFileNameId",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_LivestockSpecialtyInfos_MinistryOfAgricultureLicenseFileName~",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_LivestockSpecialtyInfos_MinistryOfIndustryLicenseFileNameId",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_Labs_ClassificationDocumentFileNameId",
                table: "Labs");

            migrationBuilder.DropIndex(
                name: "IX_Labs_OwnershipStatusDocumentFileNameId",
                table: "Labs");

            migrationBuilder.DropIndex(
                name: "IX_IndustryWarnings_AdministrationLetterFileNameId",
                table: "IndustryWarnings");

            migrationBuilder.DropIndex(
                name: "IX_IndustryWarnings_WarningDocumentFileNameId",
                table: "IndustryWarnings");

            migrationBuilder.DropIndex(
                name: "IX_IndustryPollutions_DocumentFileNameId",
                table: "IndustryPollutions");

            migrationBuilder.DropIndex(
                name: "IX_IndustryPollutions_PollutionDetectionCommitteeFileNameId",
                table: "IndustryPollutions");

            migrationBuilder.DropIndex(
                name: "IX_IndustryInspections_InspectDocumentFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropIndex(
                name: "IX_IndustryInspections_InspectingAgendaFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropIndex(
                name: "IX_IndustryInspections_InspectingExpertReportFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropIndex(
                name: "IX_IndustryInspections_MonitoringTypesDocumentFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_IndustryContractFileNameId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_LabPartnerContractFileNameId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_OrganizationRepresentativeAtt~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_CommitmentsFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_EstablishedIndustryMapFileName~",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_EstablishmentZoningFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_LicenseFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropIndex(
                name: "IX_GreenIndustryStrategies_DocumentFileNameId",
                table: "GreenIndustryStrategies");

            migrationBuilder.DropIndex(
                name: "IX_GreenIndustries_PayBillFileNameId",
                table: "GreenIndustries");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_CalibrationLicensePhotoFileNameId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_EquipmentPhotoFileNameId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "PlanSiteFileNameId",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropColumn(
                name: "RefineryHydraulicPlanFileNameId",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropColumn(
                name: "DesAdminAgreementFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "EliminationFormFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "LoadingSupervisionAgendaFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "SaleInvoiceFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "SupervisionOverDischargeFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "WasteAnalysisFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "WaybillFileNameId",
                table: "WasteTransportation");

            migrationBuilder.DropColumn(
                name: "WasteAnalysisFileNameId",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "WasteAnalysisResultFileNameId",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "EliminationFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "HazardousMaterialTransportingLicenseFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "LoadingSupervisionAgendaFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "SupervisionOverDischargeFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "WayBillFileNameId",
                table: "WastesShipments");

            migrationBuilder.DropColumn(
                name: "LastLicenseFileNameId",
                table: "WasteManagementUnitsInfos");

            migrationBuilder.DropColumn(
                name: "MinistryOfAgricultureLicenseFileNameId",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "MinistryOfIndustryLicenseFileNameId",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "DegreeOfEducationFileNameId",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "NationalCardPhotoFileNameId",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "PersonnelHistoryFileNameId",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "DocumentsFileNameId",
                table: "ParametersSamplingResults");

            migrationBuilder.DropColumn(
                name: "ContractFileNameId",
                table: "NormalWasteInformations");

            migrationBuilder.DropColumn(
                name: "ScannerBlockDiagramFileNameId",
                table: "ManufacturedProducts");

            migrationBuilder.DropColumn(
                name: "BuildingMapFileNameId",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "MinistryOfAgricultureLicenseFileNameId",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "MinistryOfIndustryLicenseFileNameId",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "ClassificationDocumentFileNameId",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "OwnershipStatusDocumentFileNameId",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "AdministrationLetterFileNameId",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "WarningDocumentFileNameId",
                table: "IndustryWarnings");

            migrationBuilder.DropColumn(
                name: "DocumentFileNameId",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "PollutionDetectionCommitteeFileNameId",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "InspectDocumentFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "InspectingAgendaFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "InspectingExpertReportFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "MonitoringTypesDocumentFileNameId",
                table: "IndustryInspections");

            migrationBuilder.DropColumn(
                name: "IndustryContractFileNameId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "LabPartnerContractFileNameId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "OrganizationRepresentativeAttendanceFileNameId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "CommitmentsFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "EstablishedIndustryMapFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "EstablishmentZoningFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "LicenseFileNameId",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "DocumentFileNameId",
                table: "GreenIndustryStrategies");

            migrationBuilder.DropColumn(
                name: "PayBillFileNameId",
                table: "GreenIndustries");

            migrationBuilder.DropColumn(
                name: "CalibrationLicensePhotoFileNameId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "EquipmentPhotoFileNameId",
                table: "Equipments");

            migrationBuilder.AddColumn<string>(
                name: "PlanSiteFileName",
                table: "WwHasPurificationSystems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefineryHydraulicPlanFileName",
                table: "WwHasPurificationSystems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesAdminAgreementFileName",
                table: "WasteTransportation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EliminationFormFileName",
                table: "WasteTransportation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoadingSupervisionAgendaFileName",
                table: "WasteTransportation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleInvoiceFileName",
                table: "WasteTransportation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisionOverDischargeFileName",
                table: "WasteTransportation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WasteAnalysisFileName",
                table: "WasteTransportation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WaybillFileName",
                table: "WasteTransportation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WasteAnalysisFileName",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WasteAnalysisResultFileName",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EliminationFileName",
                table: "WastesShipments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HazardousMaterialTransportingLicenseFileName",
                table: "WastesShipments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoadingSupervisionAgendaFileName",
                table: "WastesShipments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisionOverDischargeFileName",
                table: "WastesShipments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WayBillFileName",
                table: "WastesShipments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastLicensePhotoName",
                table: "WasteManagementUnitsInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImgFileName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinistryOfAgricultureLicenseFileName",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinistryOfIndustryLicenseFileName",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeOfEducationFileName",
                table: "Personnels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalCardPhotoFileName",
                table: "Personnels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonnelHistoryFileName",
                table: "Personnels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentsFileName",
                table: "ParametersSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContractFileName",
                table: "NormalWasteInformations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScannerBlockDiagramFileName",
                table: "ManufacturedProducts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuildingMapFileName",
                table: "LivestockSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinistryOfAgricultureLicenseFileName",
                table: "LivestockSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinistryOfIndustryLicenseFileName",
                table: "LivestockSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassificationDocumentFileName",
                table: "Labs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnershipStatusDocumentFileName",
                table: "Labs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdministrationLetterFileName",
                table: "IndustryWarnings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarningDocumentFileName",
                table: "IndustryWarnings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentFileName",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PollutionDetectionCommitteeFileName",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectDocumentFileName",
                table: "IndustryInspections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectingAgendaFileName",
                table: "IndustryInspections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectingExpertReportFileName",
                table: "IndustryInspections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonitoringTypesDocumentFileName",
                table: "IndustryInspections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustryContractFileName",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabPartnerContractFileName",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganizationRepresentativeAttendanceFileName",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommitmentsFileName",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstablishedIndustryMapFileName",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentZoningFileName",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LicenseFileName",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentFileName",
                table: "GreenIndustryStrategies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayBillFileName",
                table: "GreenIndustries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CalibrationLicensePhotoFileName",
                table: "Equipments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentPhotoFileName",
                table: "Equipments",
                nullable: true);
        }
    }
}
