using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveHcunitMeasurementIdFieldsFromWmuDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropIndex(
                name: "IX_WasteManagementUnitsDetails_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropColumn(
                name: "HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagementUnitsDetails_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails",
                column: "HcUnitMeasurementId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails",
                column: "HcUnitMeasurementId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
