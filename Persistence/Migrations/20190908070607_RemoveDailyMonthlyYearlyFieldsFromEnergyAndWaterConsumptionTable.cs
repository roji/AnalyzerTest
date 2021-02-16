using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveDailyMonthlyYearlyFieldsFromEnergyAndWaterConsumptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CvDailyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "CvMonthlyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "CvYearlyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "GwDailyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "GwMonthlyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "GwYearlyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SeawDailyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SeawMonthlyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SeawYearlyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SwDailyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SwMonthlyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SwYearlyAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "EcDailyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "EcMonthlyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "EcYearlyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GcDailyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GcMonthlyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GcYearlyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GlcDailyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GlcMonthlyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GlcYearlyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "McDailyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "McMonthlyAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "McYearlyAverageConsumption",
                table: "EnergyConsumptions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CvDailyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CvMonthlyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CvYearlyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GwDailyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GwMonthlyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GwYearlyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeawDailyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeawMonthlyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeawYearlyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwDailyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwMonthlyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwYearlyAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EcDailyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EcMonthlyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EcYearlyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GcDailyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GcMonthlyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GcYearlyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GlcDailyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GlcMonthlyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GlcYearlyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McDailyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McMonthlyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McYearlyAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);
        }
    }
}
