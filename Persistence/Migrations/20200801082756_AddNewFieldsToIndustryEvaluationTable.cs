using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToIndustryEvaluationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActivityAndEnvironmentalHistory",
                table: "IndustryEvaluations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dimensions",
                table: "IndustryEvaluations",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FacilityInfrastructure",
                table: "IndustryEvaluations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitHomogeneityAndCoordinationWithEnvironment",
                table: "IndustryEvaluations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityAndEnvironmentalHistory",
                table: "IndustryEvaluations");

            migrationBuilder.DropColumn(
                name: "Dimensions",
                table: "IndustryEvaluations");

            migrationBuilder.DropColumn(
                name: "FacilityInfrastructure",
                table: "IndustryEvaluations");

            migrationBuilder.DropColumn(
                name: "UnitHomogeneityAndCoordinationWithEnvironment",
                table: "IndustryEvaluations");
        }
    }
}
