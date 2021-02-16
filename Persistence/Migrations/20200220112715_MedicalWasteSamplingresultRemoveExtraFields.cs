using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class MedicalWasteSamplingresultRemoveExtraFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveBeds",
                table: "HospitalMedicalWasteStatusResults");

            migrationBuilder.DropColumn(
                name: "ApprovedBeds",
                table: "HospitalMedicalWasteStatusResults");

            migrationBuilder.DropColumn(
                name: "IndustryEnvironmentHealthExpertFullName",
                table: "HospitalMedicalWasteStatusResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActiveBeds",
                table: "HospitalMedicalWasteStatusResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedBeds",
                table: "HospitalMedicalWasteStatusResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IndustryEnvironmentHealthExpertFullName",
                table: "HospitalMedicalWasteStatusResults",
                type: "longtext",
                nullable: true);
        }
    }
}
