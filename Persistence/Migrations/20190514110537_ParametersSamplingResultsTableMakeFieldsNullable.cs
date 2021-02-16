using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ParametersSamplingResultsTableMakeFieldsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Debi",
                table: "WastewaterParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "BuildYear",
                table: "MotorVehiclesParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "WetConditionDensity",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ThermalEfficiencyPercentage",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Temperature",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "SamplingPlaceElevation",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "RelativeHumidity",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "OxygenVolumePercentage",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "OutputGasSpeed",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "MeasurementDuration",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "InnerDiameter",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "GasOutletDebi",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ExtraAirVolumePercentage",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "EntryPointElevation",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "EnergyLoss",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "DynamicPressure",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "DryConditionDensity",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "DioxideCarbonVolumePercentage",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Density",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "AmbientPressure",
                table: "ChimneyParametersResults",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "MeasurementDuration",
                table: "AmbientAirParametersResults",
                nullable: true,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Debi",
                table: "WastewaterParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "BuildYear",
                table: "MotorVehiclesParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "WetConditionDensity",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ThermalEfficiencyPercentage",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Temperature",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "SamplingPlaceElevation",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RelativeHumidity",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "OxygenVolumePercentage",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "OutputGasSpeed",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "MeasurementDuration",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "InnerDiameter",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "GasOutletDebi",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ExtraAirVolumePercentage",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "EntryPointElevation",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "EnergyLoss",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DynamicPressure",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DryConditionDensity",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DioxideCarbonVolumePercentage",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Density",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "AmbientPressure",
                table: "ChimneyParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "MeasurementDuration",
                table: "AmbientAirParametersResults",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
