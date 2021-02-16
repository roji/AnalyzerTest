using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addWaterQualityMonitoringStationAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    DifinitiveCode = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    RiverId = table.Column<int>(nullable: false),
                    Zone = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: true),
                    LaunchingYear = table.Column<int>(nullable: true),
                    MainBasinId = table.Column<int>(nullable: false),
                    SecondaryBasinId = table.Column<int>(nullable: false),
                    RiverRangeId = table.Column<int>(nullable: false),
                    WaterQualityStationTypeId = table.Column<int>(nullable: true),
                    IsInBorder = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsBase = table.Column<bool>(nullable: true),
                    ClassificationCode = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_WaterQualityMonitoringStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStations_EnumData_MainBasinId",
                        column: x => x.MainBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStations_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStations_EnumData_RiverRangeId",
                        column: x => x.RiverRangeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStations_EnumData_SecondaryBasinId",
                        column: x => x.SecondaryBasinId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStations_EnumData_WaterQualityStationT~",
                        column: x => x.WaterQualityStationTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStation_Addresses",
                columns: table => new
                {
                    WaterQualityMonitoringStationId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    IndustrialTown = table.Column<string>(nullable: true),
                    AddressDetails = table.Column<string>(nullable: true),
                    IsInTownEnv = table.Column<bool>(nullable: true),
                    DistanceToCity = table.Column<int>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Elevation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterQualityMonitoringStation_Addresses", x => x.WaterQualityMonitoringStationId);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStation_Addresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStation_Addresses_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStation_Addresses_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStation_Addresses_WaterQualityMonitori~",
                        column: x => x.WaterQualityMonitoringStationId,
                        principalTable: "WaterQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStationClosedYears",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterQualityMonitoringStationClosedYears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationClosedYears_WaterQualityMonitor~",
                        column: x => x.WaterQualityMonitoringStationId,
                        principalTable: "WaterQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStationMonitorings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringParameterId = table.Column<int>(nullable: false),
                    MonitoringFrequencyId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterQualityMonitoringStationMonitorings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationMonitorings_EnumData_Monitoring~",
                        column: x => x.MonitoringFrequencyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationMonitorings_EnumData_Monitorin~1",
                        column: x => x.MonitoringParameterId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationMonitorings_WaterQualityMonitor~",
                        column: x => x.WaterQualityMonitoringStationId,
                        principalTable: "WaterQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStation_Addresses_CityId",
                table: "WaterQualityMonitoringStation_Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStation_Addresses_ProvinceId",
                table: "WaterQualityMonitoringStation_Addresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStation_Addresses_StateId",
                table: "WaterQualityMonitoringStation_Addresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationClosedYears_WaterQualityMonitor~",
                table: "WaterQualityMonitoringStationClosedYears",
                column: "WaterQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationMonitorings_MonitoringFrequency~",
                table: "WaterQualityMonitoringStationMonitorings",
                column: "MonitoringFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationMonitorings_MonitoringParameter~",
                table: "WaterQualityMonitoringStationMonitorings",
                column: "MonitoringParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationMonitorings_WaterQualityMonitor~",
                table: "WaterQualityMonitoringStationMonitorings",
                column: "WaterQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStations_MainBasinId",
                table: "WaterQualityMonitoringStations",
                column: "MainBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStations_RiverId",
                table: "WaterQualityMonitoringStations",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStations_RiverRangeId",
                table: "WaterQualityMonitoringStations",
                column: "RiverRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStations_SecondaryBasinId",
                table: "WaterQualityMonitoringStations",
                column: "SecondaryBasinId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStations_WaterQualityStationTypeId",
                table: "WaterQualityMonitoringStations",
                column: "WaterQualityStationTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStation_Addresses");

            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStationClosedYears");

            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStationMonitorings");

            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStations");
        }
    }
}
