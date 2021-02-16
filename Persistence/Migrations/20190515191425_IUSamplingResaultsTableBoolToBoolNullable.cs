using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IUSamplingResaultsTableBoolToBoolNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "OrganizationRepresentativeAttendance",
                table: "IndustrialUnitsSamplingResults",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsMonitoringDone",
                table: "IndustrialUnitsSamplingResults",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "OrganizationRepresentativeAttendance",
                table: "IndustrialUnitsSamplingResults",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMonitoringDone",
                table: "IndustrialUnitsSamplingResults",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
