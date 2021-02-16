using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddExpertsScoringFieldsToStrategyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "OrganizationExpertScore",
                table: "GreenIndustryStrategies",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProvinceExpertScore",
                table: "GreenIndustryStrategies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryStrategies_OrganizationExpertScore",
                table: "GreenIndustryStrategies",
                column: "OrganizationExpertScore");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryStrategies_ProvinceExpertScore",
                table: "GreenIndustryStrategies",
                column: "ProvinceExpertScore");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GreenIndustryStrategies_OrganizationExpertScore",
                table: "GreenIndustryStrategies");

            migrationBuilder.DropIndex(
                name: "IX_GreenIndustryStrategies_ProvinceExpertScore",
                table: "GreenIndustryStrategies");

            migrationBuilder.DropColumn(
                name: "OrganizationExpertScore",
                table: "GreenIndustryStrategies");

            migrationBuilder.DropColumn(
                name: "ProvinceExpertScore",
                table: "GreenIndustryStrategies");
        }
    }
}
