using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddConventionChemicalFieldsInRawMaterialAndConsumingMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "ConventionChemicalHsCodeMixtures");

            migrationBuilder.AddColumn<int>(
                name: "ConventionChemicalId",
                table: "RawMaterials",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConventionChemicalId",
                table: "ConsumingMaterials",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_ConventionChemicalId",
                table: "RawMaterials",
                column: "ConventionChemicalId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterials_ConventionChemicals_ConventionChemicalId",
                table: "RawMaterials",
                column: "ConventionChemicalId",
                principalTable: "ConventionChemicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumingMaterials_ConventionChemicals_ConventionChemicalId",
                table: "ConsumingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterials_ConventionChemicals_ConventionChemicalId",
                table: "RawMaterials");

            migrationBuilder.DropIndex(
                name: "IX_RawMaterials_ConventionChemicalId",
                table: "RawMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ConsumingMaterials_ConventionChemicalId",
                table: "ConsumingMaterials");

            migrationBuilder.DropColumn(
                name: "ConventionChemicalId",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "ConventionChemicalId",
                table: "ConsumingMaterials");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "ConventionChemicalHsCodeMixtures",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "ConventionChemicalHsCodeMixtures",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ConventionChemicalHsCodeMixtures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "ConventionChemicalHsCodeMixtures",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "ConventionChemicalHsCodeMixtures",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "ConventionChemicalHsCodeMixtures",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "ConventionChemicalHsCodeMixtures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "ConventionChemicalHsCodeMixtures",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
