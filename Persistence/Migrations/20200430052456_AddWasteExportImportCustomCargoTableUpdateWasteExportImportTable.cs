using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWasteExportImportCustomCargoTableUpdateWasteExportImportTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteExportImports_Industries_InternalTransitId",
                table: "WasteExportImports");

            migrationBuilder.DropIndex(
                name: "IX_WasteExportImports_InternalTransitId",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "InternalTransitId",
                table: "WasteExportImports");

            migrationBuilder.AddColumn<bool>(
                name: "ApproveProformaDocument",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ApprovedByInspectingRepresentative",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedByInspectingRepresentativeDate",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ApprovedByMonitoringRepresentative",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedByMonitoringRepresentativeDate",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ApprovedBySecretariatCommittee",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedBySecretariatCommitteeDate",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ApprovedBySecurityRepresentative",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedBySecurityRepresentativeDate",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ApprovedByWasteRepresentative",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedByWasteRepresentativeDate",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ApprovedQuantityByGeneralAdministration",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ApprovedQuantityBySecretariat",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasValidLicense",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectingRepresentativeDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InternalTransitCustomId",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LicenseExpireDate",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonitoringRepresentativeDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderRegisteredApproverAdminDate",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderRegisteredApproverAdminDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderRegisteredApproverAdminFullName",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderRegisteredApproverAdminHour",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderRegisteredApproverExpertDate",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderRegisteredApproverExpertDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderRegisteredApproverExpertFullName",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderRegisteredApproverExpertHour",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProformaDocumentDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecretariatCommitteeDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityRepresentativeDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValidLicenseDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ViolationHistory",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViolationHistoryDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WasteRepresentativeDescription",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WasteExportImportCustomCargos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<double>(nullable: true),
                    ShipmentDate = table.Column<int>(nullable: true),
                    InternalTransitCustomNumber = table.Column<string>(nullable: true),
                    InternalTransitCustomDate = table.Column<int>(nullable: true),
                    InternalTransitCustomStatementNumber = table.Column<string>(nullable: true),
                    InternalTransitCustomStatementDate = table.Column<int>(nullable: true),
                    InternalTransitCustomStatementFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    LabId = table.Column<int>(nullable: true),
                    SamplingDate = table.Column<int>(nullable: true),
                    SamplingAnalysisFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    HasAnotherCargo = table.Column<bool>(nullable: true),
                    HasProductInspectionCertificate = table.Column<bool>(nullable: true),
                    InspectionCompanyName = table.Column<string>(nullable: true),
                    ProductInspectionCertificateFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    ApproveWasteAnalysisByMonitoringRepresentative = table.Column<bool>(nullable: true),
                    MonitoringRepresentativeWasteAnalysisDescription = table.Column<string>(nullable: true),
                    ApproveCustomDocumentBySecretariatCommittee = table.Column<bool>(nullable: true),
                    SecretariatCommitteeCustomDocumentDescription = table.Column<string>(nullable: true),
                    OrderRegisteredApproverExpertFullName = table.Column<string>(nullable: true),
                    OrderRegisteredApproverExpertDate = table.Column<int>(nullable: true),
                    OrderRegisteredApproverExpertHour = table.Column<string>(nullable: true),
                    OrderRegisteredApproverExpertDescription = table.Column<string>(nullable: true),
                    OrderRegisteredApproverAdminFullName = table.Column<string>(nullable: true),
                    OrderRegisteredApproverAdminDate = table.Column<int>(nullable: true),
                    OrderRegisteredApproverAdminHour = table.Column<string>(nullable: true),
                    OrderRegisteredApproverAdminDescription = table.Column<string>(nullable: true),
                    CargoExitFromCustomDate = table.Column<int>(nullable: true),
                    EnteringRecycleUnitDate = table.Column<int>(nullable: true),
                    RecycleDate = table.Column<int>(nullable: true),
                    ProductIsSellingInside = table.Column<bool>(nullable: true),
                    ProductIsExporting = table.Column<bool>(nullable: true),
                    GeneralAdministrationInspectorWasPresent = table.Column<bool>(nullable: true),
                    InspectorFullName = table.Column<string>(nullable: true),
                    InspectingDocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    CargoObservedStandardRules = table.Column<bool>(nullable: true),
                    CargoObservedStandardRulesDescription = table.Column<string>(nullable: true),
                    WasteExportImportId = table.Column<int>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteExportImportCustomCargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustomCargos_Uploads_InspectingDocumentFile~",
                        column: x => x.InspectingDocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustomCargos_Uploads_InternalTransitCustomS~",
                        column: x => x.InternalTransitCustomStatementFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustomCargos_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustomCargos_Uploads_ProductInspectionCerti~",
                        column: x => x.ProductInspectionCertificateFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustomCargos_Uploads_SamplingAnalysisFileNa~",
                        column: x => x.SamplingAnalysisFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustomCargos_WasteExportImports_WasteExport~",
                        column: x => x.WasteExportImportId,
                        principalTable: "WasteExportImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_InternalTransitCustomId",
                table: "WasteExportImports",
                column: "InternalTransitCustomId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustomCargos_InspectingDocumentFileNameId",
                table: "WasteExportImportCustomCargos",
                column: "InspectingDocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustomCargos_InternalTransitCustomStatement~",
                table: "WasteExportImportCustomCargos",
                column: "InternalTransitCustomStatementFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustomCargos_LabId",
                table: "WasteExportImportCustomCargos",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustomCargos_ProductInspectionCertificateFi~",
                table: "WasteExportImportCustomCargos",
                column: "ProductInspectionCertificateFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustomCargos_SamplingAnalysisFileNameId",
                table: "WasteExportImportCustomCargos",
                column: "SamplingAnalysisFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustomCargos_WasteExportImportId",
                table: "WasteExportImportCustomCargos",
                column: "WasteExportImportId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteExportImports_Industries_InternalTransitCustomId",
                table: "WasteExportImports",
                column: "InternalTransitCustomId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteExportImports_Industries_InternalTransitCustomId",
                table: "WasteExportImports");

            migrationBuilder.DropTable(
                name: "WasteExportImportCustomCargos");

            migrationBuilder.DropIndex(
                name: "IX_WasteExportImports_InternalTransitCustomId",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApproveProformaDocument",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedByInspectingRepresentative",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedByInspectingRepresentativeDate",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedByMonitoringRepresentative",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedByMonitoringRepresentativeDate",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedBySecretariatCommittee",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedBySecretariatCommitteeDate",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedBySecurityRepresentative",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedBySecurityRepresentativeDate",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedByWasteRepresentative",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedByWasteRepresentativeDate",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedQuantityByGeneralAdministration",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApprovedQuantityBySecretariat",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "HasValidLicense",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "InspectingRepresentativeDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "InternalTransitCustomId",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "LicenseExpireDate",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "MonitoringRepresentativeDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "OrderRegisteredApproverAdminDate",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "OrderRegisteredApproverAdminDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "OrderRegisteredApproverAdminFullName",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "OrderRegisteredApproverAdminHour",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "OrderRegisteredApproverExpertDate",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "OrderRegisteredApproverExpertDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "OrderRegisteredApproverExpertFullName",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "OrderRegisteredApproverExpertHour",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ProformaDocumentDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "SecretariatCommitteeDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "SecurityRepresentativeDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ValidLicenseDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ViolationHistory",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ViolationHistoryDescription",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "WasteRepresentativeDescription",
                table: "WasteExportImports");

            migrationBuilder.AddColumn<int>(
                name: "InternalTransitId",
                table: "WasteExportImports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_InternalTransitId",
                table: "WasteExportImports",
                column: "InternalTransitId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteExportImports_Industries_InternalTransitId",
                table: "WasteExportImports",
                column: "InternalTransitId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
