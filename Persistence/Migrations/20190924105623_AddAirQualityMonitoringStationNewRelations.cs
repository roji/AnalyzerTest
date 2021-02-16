using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAirQualityMonitoringStationNewRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirQualityStationParametersAnalyzerId",
                table: "AirQualityStationSpareParts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirQualityStationParametersAnalyzerId",
                table: "AirQualityStationConsumables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationSpareParts_AirQualityStationParametersAnaly~",
                table: "AirQualityStationSpareParts",
                column: "AirQualityStationParametersAnalyzerId");

            migrationBuilder.CreateIndex(
                name: "IX_AirQualityStationConsumables_AirQualityStationParametersAnal~",
                table: "AirQualityStationConsumables",
                column: "AirQualityStationParametersAnalyzerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AirQualityStationConsumables_AirQualityStationParametersAnal~",
                table: "AirQualityStationConsumables",
                column: "AirQualityStationParametersAnalyzerId",
                principalTable: "AirQualityStationParametersAnalyzers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirQualityStationSpareParts_AirQualityStationParametersAnaly~",
                table: "AirQualityStationSpareParts",
                column: "AirQualityStationParametersAnalyzerId",
                principalTable: "AirQualityStationParametersAnalyzers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirQualityStationConsumables_AirQualityStationParametersAnal~",
                table: "AirQualityStationConsumables");

            migrationBuilder.DropForeignKey(
                name: "FK_AirQualityStationSpareParts_AirQualityStationParametersAnaly~",
                table: "AirQualityStationSpareParts");

            migrationBuilder.DropIndex(
                name: "IX_AirQualityStationSpareParts_AirQualityStationParametersAnaly~",
                table: "AirQualityStationSpareParts");

            migrationBuilder.DropIndex(
                name: "IX_AirQualityStationConsumables_AirQualityStationParametersAnal~",
                table: "AirQualityStationConsumables");

            migrationBuilder.DropColumn(
                name: "AirQualityStationParametersAnalyzerId",
                table: "AirQualityStationSpareParts");

            migrationBuilder.DropColumn(
                name: "AirQualityStationParametersAnalyzerId",
                table: "AirQualityStationConsumables");
        }
    }
}
