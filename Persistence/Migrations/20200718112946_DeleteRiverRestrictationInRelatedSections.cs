using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DeleteRiverRestrictationInRelatedSections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HydrometryStations_Rivers_RiverId",
                table: "HydrometryStations");

            migrationBuilder.DropForeignKey(
                name: "FK_WaterQualityMonitoringStations_Rivers_RiverId",
                table: "WaterQualityMonitoringStations");

            migrationBuilder.AddForeignKey(
                name: "FK_HydrometryStations_Rivers_RiverId",
                table: "HydrometryStations",
                column: "RiverId",
                principalTable: "Rivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WaterQualityMonitoringStations_Rivers_RiverId",
                table: "WaterQualityMonitoringStations",
                column: "RiverId",
                principalTable: "Rivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HydrometryStations_Rivers_RiverId",
                table: "HydrometryStations");

            migrationBuilder.DropForeignKey(
                name: "FK_WaterQualityMonitoringStations_Rivers_RiverId",
                table: "WaterQualityMonitoringStations");

            migrationBuilder.AddForeignKey(
                name: "FK_HydrometryStations_Rivers_RiverId",
                table: "HydrometryStations",
                column: "RiverId",
                principalTable: "Rivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WaterQualityMonitoringStations_Rivers_RiverId",
                table: "WaterQualityMonitoringStations",
                column: "RiverId",
                principalTable: "Rivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
