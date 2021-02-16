using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMonitoringResultFieldsToHospitalSamplingResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasDisinfectionDevicePollution",
                table: "HospitalSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasPollution",
                table: "HospitalSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasWastePollution",
                table: "HospitalSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PollutionDescription",
                table: "HospitalSamplingResults",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasDisinfectionDevicePollution",
                table: "HospitalSamplingResults");

            migrationBuilder.DropColumn(
                name: "HasPollution",
                table: "HospitalSamplingResults");

            migrationBuilder.DropColumn(
                name: "HasWastePollution",
                table: "HospitalSamplingResults");

            migrationBuilder.DropColumn(
                name: "PollutionDescription",
                table: "HospitalSamplingResults");
        }
    }
}
