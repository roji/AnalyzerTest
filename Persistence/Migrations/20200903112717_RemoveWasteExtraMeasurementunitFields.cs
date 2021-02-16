using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveWasteExtraMeasurementunitFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_EnumData_AqUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_EnumData_RmpUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_EnumData_VmpUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropIndex(
                name: "IX_Wastes_AqUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropIndex(
                name: "IX_Wastes_RmpUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropIndex(
                name: "IX_Wastes_VmpUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "AqUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "RmpUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "VmpUnitMeasurementId",
                table: "Wastes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AqUnitMeasurementId",
                table: "Wastes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RmpUnitMeasurementId",
                table: "Wastes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VmpUnitMeasurementId",
                table: "Wastes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_AqUnitMeasurementId",
                table: "Wastes",
                column: "AqUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_RmpUnitMeasurementId",
                table: "Wastes",
                column: "RmpUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_VmpUnitMeasurementId",
                table: "Wastes",
                column: "VmpUnitMeasurementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_EnumData_AqUnitMeasurementId",
                table: "Wastes",
                column: "AqUnitMeasurementId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_EnumData_RmpUnitMeasurementId",
                table: "Wastes",
                column: "RmpUnitMeasurementId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_EnumData_VmpUnitMeasurementId",
                table: "Wastes",
                column: "VmpUnitMeasurementId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
