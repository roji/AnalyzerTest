using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ConsumingMaterialFieldChangesApplied : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumingMaterials_ConventionChemicals_ConventionChemicalId",
                table: "ConsumingMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ConsumingMaterials_ConventionChemicalId",
                table: "ConsumingMaterials");

            migrationBuilder.DropColumn(
                name: "CmConsumptionPlacesIds",
                table: "ConsumingMaterials");

            migrationBuilder.DropColumn(
                name: "ConventionChemicalId",
                table: "ConsumingMaterials");

            migrationBuilder.AddColumn<string>(
                name: "ConsumptionDescription",
                table: "ConsumingMaterials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConventionChemical",
                table: "ConsumingMaterials",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsumptionDescription",
                table: "ConsumingMaterials");

            migrationBuilder.DropColumn(
                name: "ConventionChemical",
                table: "ConsumingMaterials");

            migrationBuilder.AddColumn<string>(
                name: "CmConsumptionPlacesIds",
                table: "ConsumingMaterials",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConventionChemicalId",
                table: "ConsumingMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_ConventionChemicalId",
                table: "ConsumingMaterials",
                column: "ConventionChemicalId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumingMaterials_ConventionChemicals_ConventionChemicalId",
                table: "ConsumingMaterials",
                column: "ConventionChemicalId",
                principalTable: "ConventionChemicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
