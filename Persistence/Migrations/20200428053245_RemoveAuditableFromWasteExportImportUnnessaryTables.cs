using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveAuditableFromWasteExportImportUnnessaryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "WasteExportImportRepresentatives");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "WasteExportImportRepresentatives");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "WasteExportImportRepresentatives");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "WasteExportImportRepresentatives");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "WasteExportImportRepresentatives");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "WasteExportImportRepresentatives");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "WasteExportImportRepresentatives");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "WasteExportImportRepresentatives");

            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "WasteExportImportProformas");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "WasteExportImportProformas");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "WasteExportImportProformas");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "WasteExportImportProformas");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "WasteExportImportProformas");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "WasteExportImportProformas");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "WasteExportImportProformas");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "WasteExportImportProformas");

            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "WasteExportImportPassingProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "WasteExportImportPassingProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "WasteExportImportPassingProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "WasteExportImportPassingProvinces");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "WasteExportImportPassingProvinces");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "WasteExportImportPassingProvinces");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "WasteExportImportPassingProvinces");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "WasteExportImportPassingProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "WasteExportImportCustoms");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "WasteExportImportCustoms");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "WasteExportImportCustoms");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "WasteExportImportCustoms");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "WasteExportImportCustoms");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "WasteExportImportCustoms");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "WasteExportImportCustoms");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "WasteExportImportCustoms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "WasteExportImportRepresentatives",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "WasteExportImportRepresentatives",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "WasteExportImportRepresentatives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "WasteExportImportRepresentatives",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "WasteExportImportRepresentatives",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "WasteExportImportRepresentatives",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "WasteExportImportRepresentatives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "WasteExportImportRepresentatives",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "WasteExportImportProformas",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "WasteExportImportProformas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "WasteExportImportProformas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "WasteExportImportProformas",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "WasteExportImportProformas",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "WasteExportImportProformas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "WasteExportImportProformas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "WasteExportImportProformas",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "WasteExportImportPassingProvinces",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "WasteExportImportPassingProvinces",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "WasteExportImportPassingProvinces",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "WasteExportImportPassingProvinces",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "WasteExportImportPassingProvinces",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "WasteExportImportPassingProvinces",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "WasteExportImportPassingProvinces",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "WasteExportImportPassingProvinces",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "WasteExportImportCustoms",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "WasteExportImportCustoms",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "WasteExportImportCustoms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "WasteExportImportCustoms",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "WasteExportImportCustoms",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "WasteExportImportCustoms",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "WasteExportImportCustoms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "WasteExportImportCustoms",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
