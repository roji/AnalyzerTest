using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IndustryInspectingMoveFileFromSubTabletoMainTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentFileName",
                table: "IndustryInspectingMonitoringTypes");

            migrationBuilder.AddColumn<string>(
                name: "MonitoringTypesDocumentFileName",
                table: "IndustryInspections",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonitoringTypesDocumentFileName",
                table: "IndustryInspections");

            migrationBuilder.AddColumn<string>(
                name: "DocumentFileName",
                table: "IndustryInspectingMonitoringTypes",
                nullable: true);
        }
    }
}
