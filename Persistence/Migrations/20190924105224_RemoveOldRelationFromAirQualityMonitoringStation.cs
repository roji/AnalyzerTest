using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveOldRelationFromAirQualityMonitoringStation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirQualityStationConsumables_AirQualityMonitoringStations_Ai~",
                table: "AirQualityStationConsumables");

            migrationBuilder.DropForeignKey(
                name: "FK_AirQualityStationSpareParts_AirQualityMonitoringStations_Air~",
                table: "AirQualityStationSpareParts");

            migrationBuilder.DropIndex(
                name: "IX_AirQualityStationSpareParts_AirQualityMonitoringStationId",
                table: "AirQualityStationSpareParts");

            migrationBuilder.DropIndex(
                name: "IX_AirQualityStationConsumables_AirQualityMonitoringStationId",
                table: "AirQualityStationConsumables");

            migrationBuilder.DropColumn(
                name: "AirQualityMonitoringStationId",
                table: "AirQualityStationSpareParts");

            migrationBuilder.DropColumn(
                name: "AirQualityMonitoringStationId",
                table: "AirQualityStationConsumables");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirQualityMonitoringStationId",
                table: "AirQualityStationSpareParts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirQualityMonitoringStationId",
                table: "AirQualityStationConsumables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationSpareParts_AirQualityMonitoringStationId",
                table: "AirQualityStationSpareParts",
                column: "AirQualityMonitoringStationId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationConsumables_AirQualityMonitoringStationId",
                table: "AirQualityStationConsumables",
                column: "AirQualityMonitoringStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AirQualityStationConsumables_AirQualityMonitoringStations_Ai~",
                table: "AirQualityStationConsumables",
                column: "AirQualityMonitoringStationId",
                principalTable: "AirQualityMonitoringStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirQualityStationSpareParts_AirQualityMonitoringStations_Air~",
                table: "AirQualityStationSpareParts",
                column: "AirQualityMonitoringStationId",
                principalTable: "AirQualityMonitoringStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
