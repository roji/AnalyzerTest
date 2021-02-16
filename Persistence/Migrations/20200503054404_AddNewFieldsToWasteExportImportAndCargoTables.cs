using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToWasteExportImportAndCargoTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BaselDocumentFileNameId",
                table: "WasteExportImports",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApproveCustomDocumentBySecretariatCommitteeDate",
                table: "WasteExportImportCustomCargos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApproveWasteAnalysisByMonitoringRepresentativeDate",
                table: "WasteExportImportCustomCargos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_BaselDocumentFileNameId",
                table: "WasteExportImports",
                column: "BaselDocumentFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteExportImports_Uploads_BaselDocumentFileNameId",
                table: "WasteExportImports",
                column: "BaselDocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteExportImports_Uploads_BaselDocumentFileNameId",
                table: "WasteExportImports");

            migrationBuilder.DropIndex(
                name: "IX_WasteExportImports_BaselDocumentFileNameId",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "BaselDocumentFileNameId",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "ApproveCustomDocumentBySecretariatCommitteeDate",
                table: "WasteExportImportCustomCargos");

            migrationBuilder.DropColumn(
                name: "ApproveWasteAnalysisByMonitoringRepresentativeDate",
                table: "WasteExportImportCustomCargos");
        }
    }
}
