using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class HospitalDisinfectionDeviceResultMakeBooleansNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PreVacuumAutoClaveGuidanceMonitoringCondition",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "PreVacuumAutoClaveClassFiveSixChemicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "PreVacuumAutoClaveBowieDickChemicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "PreVacuumAutoClaveBiologicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsMonitoringCenterSite",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsEliminationHappenInHospital",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "HydroAutoClaveBiologicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "GravityAutoClaveGuidanceMonitoringCondition",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "GravityAutoClaveClassFiveSixChemicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "GravityAutoClaveBiologicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "EliminateOtherHospitalsWaste",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "DryHeatBiologicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PreVacuumAutoClaveGuidanceMonitoringCondition",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PreVacuumAutoClaveClassFiveSixChemicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PreVacuumAutoClaveBowieDickChemicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PreVacuumAutoClaveBiologicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMonitoringCenterSite",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsEliminationHappenInHospital",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HydroAutoClaveBiologicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GravityAutoClaveGuidanceMonitoringCondition",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GravityAutoClaveClassFiveSixChemicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GravityAutoClaveBiologicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EliminateOtherHospitalsWaste",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DryHeatBiologicalIndex",
                table: "HospitalDisinfectionDeviceResults",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
