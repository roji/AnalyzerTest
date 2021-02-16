using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeDeleveBehaviorOfLabRelatedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryInspections_Industries_IndustryId",
                table: "IndustryInspections");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryWarnings_Industries_IndustryId",
                table: "IndustryWarnings");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "ParametersAndMeasurementMethods",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParametersAndMeasurementMethods_EquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryInspections_Industries_IndustryId",
                table: "IndustryInspections",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryWarnings_Industries_IndustryId",
                table: "IndustryWarnings",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_EquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryInspections_Industries_IndustryId",
                table: "IndustryInspections");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryWarnings_Industries_IndustryId",
                table: "IndustryWarnings");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropIndex(
                name: "IX_ParametersAndMeasurementMethods_EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryInspections_Industries_IndustryId",
                table: "IndustryInspections",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryWarnings_Industries_IndustryId",
                table: "IndustryWarnings",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
