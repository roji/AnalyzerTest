using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWaterAppearanceFieldsToWaterStationSamplingResulttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WaterQualityMonitoringStationSamplingResults_EnumData_WaterA~",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_WaterAppearance~",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "WaterAppearanceId",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.AddColumn<string>(
                name: "AquaticAnimalsDescription",
                table: "WaterQualityMonitoringStationSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorDescription",
                table: "WaterQualityMonitoringStationSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonitoringYear",
                table: "WaterQualityMonitoringStationSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpacityDescription",
                table: "WaterQualityMonitoringStationSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherWaterAppearanceDescription",
                table: "WaterQualityMonitoringStationSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlantsDescription",
                table: "WaterQualityMonitoringStationSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PollutionFloorDescription",
                table: "WaterQualityMonitoringStationSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmellDescription",
                table: "WaterQualityMonitoringStationSamplingResults",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AquaticAnimalsDescription",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "ColorDescription",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "MonitoringYear",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "OpacityDescription",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "OtherWaterAppearanceDescription",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "PlantsDescription",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "PollutionFloorDescription",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.DropColumn(
                name: "SmellDescription",
                table: "WaterQualityMonitoringStationSamplingResults");

            migrationBuilder.AddColumn<int>(
                name: "WaterAppearanceId",
                table: "WaterQualityMonitoringStationSamplingResults",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WaterQualityMonitoringStationSamplingResults_WaterAppearance~",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "WaterAppearanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_WaterQualityMonitoringStationSamplingResults_EnumData_WaterA~",
                table: "WaterQualityMonitoringStationSamplingResults",
                column: "WaterAppearanceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
