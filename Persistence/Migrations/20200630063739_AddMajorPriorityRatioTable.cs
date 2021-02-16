using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMajorPriorityRatioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MajorPriorityRatios",
                columns: table => new
                {
                    MonitoringTypeId = table.Column<int>(nullable: false),
                    MajorId = table.Column<int>(nullable: false),
                    Ratio = table.Column<double>(nullable: false),
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
                    table.PrimaryKey("PK_MajorPriorityRatios", x => new { x.MonitoringTypeId, x.MajorId });
                    table.ForeignKey(
                        name: "FK_MajorPriorityRatios_EnumData_MajorId",
                        column: x => x.MajorId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MajorPriorityRatios_EnumData_MonitoringTypeId",
                        column: x => x.MonitoringTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MajorPriorityRatios_MajorId",
                table: "MajorPriorityRatios",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_MajorPriorityRatios_MonitoringTypeId",
                table: "MajorPriorityRatios",
                column: "MonitoringTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MajorPriorityRatios");
        }
    }
}
