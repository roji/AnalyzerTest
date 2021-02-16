using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndexToMultipleFieldInMonitoringForOptimizingPurposes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_WastewaterParametersResults_Quantity",
                table: "WastewaterParametersResults",
                column: "Quantity");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParametersResults_Quantity",
                table: "WasteParametersResults",
                column: "Quantity");

            migrationBuilder.CreateIndex(
                name: "IX_SoundAndWavesParametersResults_Quantity",
                table: "SoundAndWavesParametersResults",
                column: "Quantity");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringParameters_LimitAmountQuantity",
                table: "MonitoringParameters",
                column: "LimitAmountQuantity");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringParameters_PollutionLimitQuantity",
                table: "MonitoringParameters",
                column: "PollutionLimitQuantity");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_FinalSave",
                table: "IndustrialUnitsSamplingResults",
                column: "FinalSave");

            migrationBuilder.CreateIndex(
                name: "IX_ChimneyParametersResults_Quantity",
                table: "ChimneyParametersResults",
                column: "Quantity");

            migrationBuilder.CreateIndex(
                name: "IX_AmbientAirParametersResults_Quantity",
                table: "AmbientAirParametersResults",
                column: "Quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WastewaterParametersResults_Quantity",
                table: "WastewaterParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_WasteParametersResults_Quantity",
                table: "WasteParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_SoundAndWavesParametersResults_Quantity",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_MonitoringParameters_LimitAmountQuantity",
                table: "MonitoringParameters");

            migrationBuilder.DropIndex(
                name: "IX_MonitoringParameters_PollutionLimitQuantity",
                table: "MonitoringParameters");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_FinalSave",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_ChimneyParametersResults_Quantity",
                table: "ChimneyParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_AmbientAirParametersResults_Quantity",
                table: "AmbientAirParametersResults");
        }
    }
}
