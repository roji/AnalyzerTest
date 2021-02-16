using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryPollutionViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_industrypollutiondashboard AS 
                   SELECT
                        Season.Id As SeasonId,
                        Season.Title As Season,
                        industrypollutions.`Year` As `Year`,
                        Province.Title As Province,
                        Count(industrypollutions.Id) as Total
                        FROM
                        industries
                        JOIN industry_workshopaddresses ON industry_workshopaddresses.IndustryId = industries.Id 
                        JOIN enumdata as Province ON industry_workshopaddresses.ProvinceId = Province.Id
                        JOIN industrypollutions ON industrypollutions.IndustryId = industries.Id
                        JOIN enumdata as Season ON industrypollutions.SeasonId = Season.Id
                        Group By ProvinceId,industrypollutions.`Year`,SeasonId";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_industrypollutiondashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
