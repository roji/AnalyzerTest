using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addRefineryOutputAnalyzeResultAndDateToWwHasPurification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefineryOutputAnalyzeResult",
                table: "WwHasPurificationSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefineryOutputAnalyzeResultDate",
                table: "WwHasPurificationSystems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefineryOutputAnalyzeResult",
                table: "WwHasPurificationSystems");

            migrationBuilder.DropColumn(
                name: "RefineryOutputAnalyzeResultDate",
                table: "WwHasPurificationSystems");
        }
    }
}
