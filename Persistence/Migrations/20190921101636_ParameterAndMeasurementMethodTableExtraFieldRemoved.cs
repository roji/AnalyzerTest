using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ParameterAndMeasurementMethodTableExtraFieldRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropIndex(
                name: "IX_ParametersAndMeasurementMethods_EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "UsingEquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "ParametersAndMeasurementMethods",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParametersAndMeasurementMethods_EquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_EquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "UsingEquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
