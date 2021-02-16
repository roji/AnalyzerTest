using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMonitoringReferenceAgendaFileNameFieldToIndustrialUnitSamplingResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MonitoringReferenceAgendaFileNameId",
                table: "IndustrialUnitsSamplingResults",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_MonitoringReferenceAgendaFile~",
                table: "IndustrialUnitsSamplingResults",
                column: "MonitoringReferenceAgendaFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Uploads_MonitoringReferenceAg~",
                table: "IndustrialUnitsSamplingResults",
                column: "MonitoringReferenceAgendaFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Uploads_MonitoringReferenceAg~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_MonitoringReferenceAgendaFile~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "MonitoringReferenceAgendaFileNameId",
                table: "IndustrialUnitsSamplingResults");
        }
    }
}
