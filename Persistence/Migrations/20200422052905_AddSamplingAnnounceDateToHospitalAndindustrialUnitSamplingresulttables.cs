using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddSamplingAnnounceDateToHospitalAndindustrialUnitSamplingresulttables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalSamplingResults_Industries_IndustryId",
                table: "HospitalSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Industries_IndustryId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_WaterQualityMonitoringStationSamplingResults_WaterQualityMon~",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SamplingAnnounceDate",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SamplingAnnounceDate",
                table: "HospitalSamplingResults",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalSamplingResults_Industries_IndustryId",
                table: "HospitalSamplingResults",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Industries_IndustryId",
                table: "IndustrialUnitsSamplingResults",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WaterQualityMonitoringStationSamplingResults_WaterQualityMon~",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "WaterQualityMonitoringStationId",
                principalTable: "WaterQualityMonitoringStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalSamplingResults_Industries_IndustryId",
                table: "HospitalSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Industries_IndustryId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_WaterQualityMonitoringStationSamplingResults_WaterQualityMon~",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "SamplingAnnounceDate",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "SamplingAnnounceDate",
                table: "HospitalSamplingResults");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalSamplingResults_Industries_IndustryId",
                table: "HospitalSamplingResults",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Industries_IndustryId",
                table: "IndustrialUnitsSamplingResults",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WaterQualityMonitoringStationSamplingResults_WaterQualityMon~",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "WaterQualityMonitoringStationId",
                principalTable: "WaterQualityMonitoringStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
