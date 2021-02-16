using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNeedMonitoringTypesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NeedMonitoring",
                table: "MonitoringInfos");

            migrationBuilder.CreateTable(
                name: "NeedMonitoringTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringTypeId = table.Column<int>(nullable: false),
                    NeedMonitoring = table.Column<bool>(nullable: false),
                    MonitoringInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_NeedMonitoringTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NeedMonitoringTypes_MonitoringInfos_MonitoringInfoId",
                        column: x => x.MonitoringInfoId,
                        principalTable: "MonitoringInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NeedMonitoringTypes_EnumData_MonitoringTypeId",
                        column: x => x.MonitoringTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NeedMonitoringTypes_MonitoringInfoId",
                table: "NeedMonitoringTypes",
                column: "MonitoringInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_NeedMonitoringTypes_MonitoringTypeId",
                table: "NeedMonitoringTypes",
                column: "MonitoringTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NeedMonitoringTypes");

            migrationBuilder.AddColumn<bool>(
                name: "NeedMonitoring",
                table: "MonitoringInfos",
                nullable: false,
                defaultValue: false);
        }
    }
}
