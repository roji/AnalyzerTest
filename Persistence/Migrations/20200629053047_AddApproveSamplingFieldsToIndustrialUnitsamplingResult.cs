using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddApproveSamplingFieldsToIndustrialUnitsamplingResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ApproveSampling",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ApproveSamplingDateTime",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApproveSamplingDescription",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApproveSamplingExpertId",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisapproveSamplingReason",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IndustryHasPollution",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustryPollutionReason",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_ApproveSamplingExpertId",
                table: "IndustrialUnitsSamplingResults",
                column: "ApproveSamplingExpertId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Users_ApproveSamplingExpertId",
                table: "IndustrialUnitsSamplingResults",
                column: "ApproveSamplingExpertId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Users_ApproveSamplingExpertId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_ApproveSamplingExpertId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "ApproveSampling",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "ApproveSamplingDateTime",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "ApproveSamplingDescription",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "ApproveSamplingExpertId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "DisapproveSamplingReason",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "IndustryHasPollution",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "IndustryPollutionReason",
                table: "IndustrialUnitsSamplingResults");
        }
    }
}
