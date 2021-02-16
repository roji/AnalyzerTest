using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UsingEquipmentInParameterAndMeasurementCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "UsingEquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "UsingEquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
