using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTwoTablesRelatedToWaterQualityMonitoringStation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStationFacilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StationUpstairsFacilityAndStructureId = table.Column<int>(nullable: false),
                    WaterQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterQualityMonitoringStationFacilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationFacilities_EnumData_StationUpst~",
                        column: x => x.StationUpstairsFacilityAndStructureId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationFacilities_WaterQualityMonitori~",
                        column: x => x.WaterQualityMonitoringStationId,
                        principalTable: "WaterQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStationRiverUsages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RiverUsageId = table.Column<int>(nullable: false),
                    WaterQualityMonitoringStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterQualityMonitoringStationRiverUsages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationRiverUsages_EnumData_RiverUsage~",
                        column: x => x.RiverUsageId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationRiverUsages_WaterQualityMonitor~",
                        column: x => x.WaterQualityMonitoringStationId,
                        principalTable: "WaterQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationFacilities_StationUpstairsFacil~",
                table: "WaterQualityMonitoringStationFacilities",
                column: "StationUpstairsFacilityAndStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationFacilities_WaterQualityMonitori~",
                table: "WaterQualityMonitoringStationFacilities",
                column: "WaterQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationRiverUsages_RiverUsageId",
                table: "WaterQualityMonitoringStationRiverUsages",
                column: "RiverUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationRiverUsages_WaterQualityMonitor~",
                table: "WaterQualityMonitoringStationRiverUsages",
                column: "WaterQualityMonitoringStationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStationFacilities");

            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStationRiverUsages");
        }
    }
}
