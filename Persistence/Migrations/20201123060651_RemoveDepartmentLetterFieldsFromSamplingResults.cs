using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveDepartmentLetterFieldsFromSamplingResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentLetterDate",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "DepartmentLetterNumber",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "DepartmentLetterDate",
                table: "HospitalSamplingResults");

            migrationBuilder.DropColumn(
                name: "DepartmentLetterNumber",
                table: "HospitalSamplingResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentLetterDate",
                table: "IndustrialUnitsSamplingResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentLetterNumber",
                table: "IndustrialUnitsSamplingResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentLetterDate",
                table: "HospitalSamplingResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentLetterNumber",
                table: "HospitalSamplingResults",
                type: "int",
                nullable: true);
        }
    }
}
