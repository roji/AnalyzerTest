using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveTwoExtraFieldsFromGreenIndustryAddShowResultForIndustryField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasPollutionInLastYear",
                table: "GreenIndustries");

            migrationBuilder.DropColumn(
                name: "ShowingMarkForIndustryDate",
                table: "GreenIndustries");

            migrationBuilder.AddColumn<bool>(
                name: "ShowResultForIndustry",
                table: "GreenIndustries",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowResultForIndustry",
                table: "GreenIndustries");

            migrationBuilder.AddColumn<bool>(
                name: "HasPollutionInLastYear",
                table: "GreenIndustries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowingMarkForIndustryDate",
                table: "GreenIndustries",
                nullable: true);
        }
    }
}
