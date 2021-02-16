using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRepositoriesTableUpdateWasteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_EnumData_RlessUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_EnumData_RssUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropIndex(
                name: "IX_Wastes_RlessUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropIndex(
                name: "IX_Wastes_RssUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "FireAlarm",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "FireFight",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "ImpermeableRoof",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "ImpermeableRoofless",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "RlessUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "RoofStorageSize",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "RooflessStorageSize",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "RssUnitMeasurementId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "StandardEquipment",
                table: "Wastes");

            migrationBuilder.CreateTable(
                name: "Repositories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: false),
                    RoofArea = table.Column<double>(nullable: false),
                    RooflessArea = table.Column<double>(nullable: false),
                    MaintainableMaterialClassificationIds = table.Column<string>(nullable: true),
                    StandardEquipment = table.Column<bool>(nullable: false),
                    FireAlarm = table.Column<bool>(nullable: false),
                    FireFight = table.Column<bool>(nullable: false),
                    ImpermeableRoofless = table.Column<bool>(nullable: false),
                    ImpermeableRoof = table.Column<bool>(nullable: false),
                    RooflessStorageSize = table.Column<int>(nullable: true),
                    RlessUnitMeasurementId = table.Column<int>(nullable: true),
                    RoofStorageSize = table.Column<int>(nullable: true),
                    RssUnitMeasurementId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repositories_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repositories_EnumData_RlessUnitMeasurementId",
                        column: x => x.RlessUnitMeasurementId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repositories_EnumData_RssUnitMeasurementId",
                        column: x => x.RssUnitMeasurementId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_IndustryId",
                table: "Repositories",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_RlessUnitMeasurementId",
                table: "Repositories",
                column: "RlessUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_RssUnitMeasurementId",
                table: "Repositories",
                column: "RssUnitMeasurementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.AddColumn<bool>(
                name: "FireAlarm",
                table: "Wastes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FireFight",
                table: "Wastes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ImpermeableRoof",
                table: "Wastes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ImpermeableRoofless",
                table: "Wastes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RlessUnitMeasurementId",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoofStorageSize",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RooflessStorageSize",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RssUnitMeasurementId",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StandardEquipment",
                table: "Wastes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_RlessUnitMeasurementId",
                table: "Wastes",
                column: "RlessUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_RssUnitMeasurementId",
                table: "Wastes",
                column: "RssUnitMeasurementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_EnumData_RlessUnitMeasurementId",
                table: "Wastes",
                column: "RlessUnitMeasurementId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_EnumData_RssUnitMeasurementId",
                table: "Wastes",
                column: "RssUnitMeasurementId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
