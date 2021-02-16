using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAuditableToChimneyWasteWastewaterAirSoundAndwaveParameterSamplingResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "WastewaterParametersResults",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "WastewaterParametersResults",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "WastewaterParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "WastewaterParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "WastewaterParametersResults",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "WastewaterParametersResults",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "WastewaterParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "WastewaterParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "WasteParametersResults",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "WasteParametersResults",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "WasteParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "WasteParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "WasteParametersResults",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "WasteParametersResults",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "WasteParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "WasteParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "SoundAndWavesParametersResults",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "SoundAndWavesParametersResults",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "SoundAndWavesParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "SoundAndWavesParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "SoundAndWavesParametersResults",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "SoundAndWavesParametersResults",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "SoundAndWavesParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "SoundAndWavesParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "ChimneyParametersResults",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "ChimneyParametersResults",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ChimneyParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "ChimneyParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "ChimneyParametersResults",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "ChimneyParametersResults",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "ChimneyParametersResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "ChimneyParametersResults",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "ChimneyParametersResults");
        }
    }
}
