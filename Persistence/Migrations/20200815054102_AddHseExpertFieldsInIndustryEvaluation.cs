using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHseExpertFieldsInIndustryEvaluation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HseExpertEmail",
                table: "IndustryEvaluations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HseExpertFullName",
                table: "IndustryEvaluations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HseExpertMobile",
                table: "IndustryEvaluations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HseExpertEmail",
                table: "IndustryEvaluations");

            migrationBuilder.DropColumn(
                name: "HseExpertFullName",
                table: "IndustryEvaluations");

            migrationBuilder.DropColumn(
                name: "HseExpertMobile",
                table: "IndustryEvaluations");
        }
    }
}
