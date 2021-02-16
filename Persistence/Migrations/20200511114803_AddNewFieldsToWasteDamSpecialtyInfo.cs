using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToWasteDamSpecialtyInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "hasCurrentAndFinalGroundSurvey",
                table: "WasteDamSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "hasCurrentConditionSurvey",
                table: "WasteDamSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "hasWeatherConditionSurvey",
                table: "WasteDamSpecialtyInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hasCurrentAndFinalGroundSurvey",
                table: "WasteDamSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "hasCurrentConditionSurvey",
                table: "WasteDamSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "hasWeatherConditionSurvey",
                table: "WasteDamSpecialtyInfos");
        }
    }
}
