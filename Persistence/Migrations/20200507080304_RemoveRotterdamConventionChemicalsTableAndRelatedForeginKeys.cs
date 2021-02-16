using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveRotterdamConventionChemicalsTableAndRelatedForeginKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumingMaterials_RotterdamConventionChemicals_RotterdamCon~",
                table: "ConsumingMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterials_RotterdamConventionChemicals_RotterdamConventio~",
                table: "RawMaterials");

            migrationBuilder.DropTable(
                name: "RotterdamConventionChemicals");

            migrationBuilder.DropIndex(
                name: "IX_RawMaterials_RotterdamConventionChemicalId",
                table: "RawMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ConsumingMaterials_RotterdamConventionChemicalId",
                table: "ConsumingMaterials");

            migrationBuilder.DropColumn(
                name: "RotterdamConventionChemicalId",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "RotterdamConventionChemicalId",
                table: "ConsumingMaterials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RotterdamConventionChemicalId",
                table: "RawMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RotterdamConventionChemicalId",
                table: "ConsumingMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RotterdamConventionChemicals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClassNumber = table.Column<string>(type: "longtext", nullable: true),
                    Classification = table.Column<string>(type: "longtext", nullable: true),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    RiskIdentificationNumber = table.Column<string>(type: "longtext", nullable: true),
                    Tag = table.Column<string>(type: "longtext", nullable: true),
                    UnIdentityNumber = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotterdamConventionChemicals", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_RotterdamConventionChemicalId",
                table: "RawMaterials",
                column: "RotterdamConventionChemicalId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_RotterdamConventionChemicalId",
                table: "ConsumingMaterials",
                column: "RotterdamConventionChemicalId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumingMaterials_RotterdamConventionChemicals_RotterdamCon~",
                table: "ConsumingMaterials",
                column: "RotterdamConventionChemicalId",
                principalTable: "RotterdamConventionChemicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterials_RotterdamConventionChemicals_RotterdamConventio~",
                table: "RawMaterials",
                column: "RotterdamConventionChemicalId",
                principalTable: "RotterdamConventionChemicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
