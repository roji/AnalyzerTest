using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMonitoringTypeToInspectingMonitoringtypesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonitoringTypeId",
                table: "IndustryInspectingMonitoringTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryInspectingMonitoringTypes_MonitoringTypeId",
                table: "IndustryInspectingMonitoringTypes",
                column: "MonitoringTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryInspectingMonitoringTypes_EnumData_MonitoringTypeId",
                table: "IndustryInspectingMonitoringTypes",
                column: "MonitoringTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryInspectingMonitoringTypes_EnumData_MonitoringTypeId",
                table: "IndustryInspectingMonitoringTypes");

            migrationBuilder.DropIndex(
                name: "IX_IndustryInspectingMonitoringTypes_MonitoringTypeId",
                table: "IndustryInspectingMonitoringTypes");

            migrationBuilder.DropColumn(
                name: "MonitoringTypeId",
                table: "IndustryInspectingMonitoringTypes");
        }
    }
}
