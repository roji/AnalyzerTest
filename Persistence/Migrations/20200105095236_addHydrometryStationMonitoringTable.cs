using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addHydrometryStationMonitoringTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HydrometryStationMonitorings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringParameterId = table.Column<int>(nullable: false),
                    MonitoringFrequencyId = table.Column<int>(nullable: false),
                    HydrometryStationId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HydrometryStationMonitorings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HydrometryStationMonitorings_HydrometryStations_HydrometrySt~",
                        column: x => x.HydrometryStationId,
                        principalTable: "HydrometryStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HydrometryStationMonitorings_EnumData_MonitoringFrequencyId",
                        column: x => x.MonitoringFrequencyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HydrometryStationMonitorings_EnumData_MonitoringParameterId",
                        column: x => x.MonitoringParameterId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStationMonitorings_HydrometryStationId",
                table: "HydrometryStationMonitorings",
                column: "HydrometryStationId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStationMonitorings_MonitoringFrequencyId",
                table: "HydrometryStationMonitorings",
                column: "MonitoringFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HydrometryStationMonitorings_MonitoringParameterId",
                table: "HydrometryStationMonitorings",
                column: "MonitoringParameterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HydrometryStationMonitorings");
        }
    }
}
