using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixValidationScoresUnderZeroInLabsAndIndustries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var updateCmd = @"
            UPDATE industries SET ValidationScore=0 WHERE industries.ValidationScore < 0;
            UPDATE labs SET ValidationScore=0 WHERE labs.ValidationScore < 0;
            ";
            migrationBuilder.Sql(updateCmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
