using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddSeasonFieldsToWaterAndEnergyconsumption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CvAutumnAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CvSpringAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CvSummerAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CvWinterAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GwAutumnAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GwSpringAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GwSummerAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GwWinterAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeawAutumnAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeawSpringAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeawSummerAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeawWinterAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwAutumnAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwSpringAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwSummerAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwWinterAverageConsumption",
                table: "WaterConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EcAutumnAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EcSpringAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EcSummerAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EcWinterAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GcAutumnAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GcSpringAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GcSummerAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GcWinterAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GlcAutumnAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GlcSpringAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GlcSummerAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GlcWinterAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McAutumnAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McSpringAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McSummerAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McWinterAverageConsumption",
                table: "EnergyConsumptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CvAutumnAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "CvSpringAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "CvSummerAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "CvWinterAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "GwAutumnAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "GwSpringAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "GwSummerAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "GwWinterAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SeawAutumnAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SeawSpringAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SeawSummerAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SeawWinterAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SwAutumnAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SwSpringAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SwSummerAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "SwWinterAverageConsumption",
                table: "WaterConsumptions");

            migrationBuilder.DropColumn(
                name: "EcAutumnAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "EcSpringAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "EcSummerAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "EcWinterAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GcAutumnAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GcSpringAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GcSummerAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GcWinterAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GlcAutumnAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GlcSpringAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GlcSummerAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "GlcWinterAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "McAutumnAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "McSpringAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "McSummerAverageConsumption",
                table: "EnergyConsumptions");

            migrationBuilder.DropColumn(
                name: "McWinterAverageConsumption",
                table: "EnergyConsumptions");
        }
    }
}
