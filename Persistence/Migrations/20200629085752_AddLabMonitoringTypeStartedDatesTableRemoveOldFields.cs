using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddLabMonitoringTypeStartedDatesTableRemoveOldFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirSoundStartedDate",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "BiologyStartedDate",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "PhysicsChemistryStartedDate",
                table: "Labs");

            migrationBuilder.CreateTable(
                name: "LabMonitoringTypeStartedDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringTypeId = table.Column<int>(nullable: false),
                    StartedDate = table.Column<int>(nullable: false),
                    LabId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_LabMonitoringTypeStartedDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabMonitoringTypeStartedDates_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabMonitoringTypeStartedDates_EnumData_MonitoringTypeId",
                        column: x => x.MonitoringTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabMonitoringTypeStartedDates_LabId",
                table: "LabMonitoringTypeStartedDates",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_LabMonitoringTypeStartedDates_MonitoringTypeId",
                table: "LabMonitoringTypeStartedDates",
                column: "MonitoringTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabMonitoringTypeStartedDates");

            migrationBuilder.AddColumn<int>(
                name: "AirSoundStartedDate",
                table: "Labs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BiologyStartedDate",
                table: "Labs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhysicsChemistryStartedDate",
                table: "Labs",
                type: "int",
                nullable: true);
        }
    }
}
