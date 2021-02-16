using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixParameterAndMeasurementMethodRelationFieldBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropIndex(
                name: "IX_ParametersAndMeasurementMethods_EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "ParametersAndMeasurementMethods");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "ParametersAndMeasurementMethods",
                type: "int",
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
        }
    }
}
