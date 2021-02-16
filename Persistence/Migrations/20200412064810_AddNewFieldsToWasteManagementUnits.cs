using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToWasteManagementUnits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdministrationDescription",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasBeenApprovedByGeneralAdminstration",
                table: "WasteManagementUnitsDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperationDocumentFileNameId",
                table: "WasteManagementUnitsDetails",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagementUnitsDetails_OperationDocumentFileNameId",
                table: "WasteManagementUnitsDetails",
                column: "OperationDocumentFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsDetails_Uploads_OperationDocumentFileNam~",
                table: "WasteManagementUnitsDetails",
                column: "OperationDocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsDetails_Uploads_OperationDocumentFileNam~",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropIndex(
                name: "IX_WasteManagementUnitsDetails_OperationDocumentFileNameId",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "AdministrationDescription",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "HasBeenApprovedByGeneralAdminstration",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "OperationDocumentFileNameId",
                table: "WasteManagementUnitsDetails");
        }
    }
}
