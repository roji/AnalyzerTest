using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWaterQualityMonitoringStationSamplingResultTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RiverDepth",
                table: "WaterQualityMonitoringStations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStationSamplingResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WaterStationSamplingReasonId = table.Column<int>(nullable: false),
                    SamplingDate = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    WaterYearId = table.Column<int>(nullable: false),
                    SamplingHour = table.Column<string>(nullable: true),
                    AirAppearanceId = table.Column<int>(nullable: true),
                    FlowAppearanceId = table.Column<int>(nullable: true),
                    WaterAppearanceId = table.Column<int>(nullable: true),
                    IrwqiVariable = table.Column<double>(nullable: true),
                    FinalSave = table.Column<bool>(nullable: false),
                    FinalSaveDate = table.Column<DateTimeOffset>(nullable: true),
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
                    table.PrimaryKey("PK_WaterQualityMonitoringStationSamplingResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingResults_EnumData_AirApp~",
                        column: x => x.AirAppearanceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingResults_EnumData_FlowAp~",
                        column: x => x.FlowAppearanceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingResults_EnumData_Season~",
                        column: x => x.SeasonId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingResults_EnumData_WaterA~",
                        column: x => x.WaterAppearanceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingResults_WaterQualityMon~",
                        column: x => x.WaterQualityMonitoringStationId,
                        principalTable: "WaterQualityMonitoringStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingResults_EnumData_WaterS~",
                        column: x => x.WaterStationSamplingReasonId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingResults_EnumData_WaterY~",
                        column: x => x.WaterYearId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStationSamplingExperts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WaterQualityMonitoringStationSamplingResultId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_WaterQualityMonitoringStationSamplingExperts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingExperts_WaterQualityMon~",
                        column: x => x.WaterQualityMonitoringStationSamplingResultId,
                        principalTable: "WaterQualityMonitoringStationSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterQualityMonitoringStationSamplingParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WaterQualityMonitoringStationSamplingResultId = table.Column<int>(nullable: false),
                    MonitoringId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
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
                    table.PrimaryKey("PK_WaterQualityMonitoringStationSamplingParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingParameters_WaterQuality~",
                        column: x => x.MonitoringId,
                        principalTable: "WaterQualityMonitoringStationMonitorings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterQualityMonitoringStationSamplingParameters_WaterQualit~1",
                        column: x => x.WaterQualityMonitoringStationSamplingResultId,
                        principalTable: "WaterQualityMonitoringStationSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingExperts_WaterQualityMon~",
                table: "WaterQualityMonitoringStationSamplingExperts",
                column: "WaterQualityMonitoringStationSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingParameters_MonitoringId",
                table: "WaterQualityMonitoringStationSamplingParameters",
                column: "MonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingParameters_WaterQuality~",
                table: "WaterQualityMonitoringStationSamplingParameters",
                column: "WaterQualityMonitoringStationSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_AirAppearanceId",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "AirAppearanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_FinalSave",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "FinalSave");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_FlowAppearanceId",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "FlowAppearanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_SeasonId",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_WaterAppearance~",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "WaterAppearanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_WaterQualityMon~",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "WaterQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_WaterStationSam~",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "WaterStationSamplingReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_WaterYearId",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "WaterYearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStationSamplingExperts");

            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStationSamplingParameters");

            migrationBuilder.DropTable(
                name: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "RiverDepth",
                table: "WaterQualityMonitoringStations");
        }
    }
}
