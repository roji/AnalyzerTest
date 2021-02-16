using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RawMaterialTableFieldsChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterials_ConventionChemicals_ConventionChemicalId",
                table: "RawMaterials");

            migrationBuilder.DropIndex(
                name: "IX_RawMaterials_ConventionChemicalId",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "ConventionChemicalId",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "RmConsumptionPlacesIds",
                table: "RawMaterials");

            migrationBuilder.AddColumn<string>(
                name: "ConsumptionDescription",
                table: "RawMaterials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConventionChemical",
                table: "RawMaterials",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsumptionDescription",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "ConventionChemical",
                table: "RawMaterials");

            migrationBuilder.AddColumn<int>(
                name: "ConventionChemicalId",
                table: "RawMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RmConsumptionPlacesIds",
                table: "RawMaterials",
                type: "longtext",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_ConventionChemicalId",
                table: "RawMaterials",
                column: "ConventionChemicalId");

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterials_ConventionChemicals_ConventionChemicalId",
                table: "RawMaterials",
                column: "ConventionChemicalId",
                principalTable: "ConventionChemicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
