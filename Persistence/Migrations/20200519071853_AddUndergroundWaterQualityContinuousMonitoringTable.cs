using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddUndergroundWaterQualityContinuousMonitoringTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UndergroundWaterQualityContinuousMonitorings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringDate = table.Column<int>(nullable: true),
                    LabId = table.Column<int>(nullable: false),
                    IsResultSatisfactory = table.Column<bool>(nullable: true),
                    AnalysisFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_UndergroundWaterQualityContinuousMonitorings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UndergroundWaterQualityContinuousMonitorings_Uploads_Analysi~",
                        column: x => x.AnalysisFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UndergroundWaterQualityContinuousMonitorings_Industries_Indu~",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UndergroundWaterQualityContinuousMonitorings_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UndergroundWaterQualityContinuousMonitorings_AnalysisFileNam~",
                table: "UndergroundWaterQualityContinuousMonitorings",
                column: "AnalysisFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_UndergroundWaterQualityContinuousMonitorings_IndustryId",
                table: "UndergroundWaterQualityContinuousMonitorings",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_UndergroundWaterQualityContinuousMonitorings_LabId",
                table: "UndergroundWaterQualityContinuousMonitorings",
                column: "LabId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UndergroundWaterQualityContinuousMonitorings");
        }
    }
}
