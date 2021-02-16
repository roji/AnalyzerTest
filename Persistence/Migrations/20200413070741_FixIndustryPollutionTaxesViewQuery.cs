using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixIndustryPollutionTaxesViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var deleteCmd = @"DROP VIEW IF EXISTS `v_pollutiontaxesdashboard`;";
            migrationBuilder.Sql(deleteCmd);
            var addCmd = @"CREATE VIEW v_pollutiontaxesdashboard AS 
                   SELECT
                        Season.Id AS SeasonId,
                        Season.Title AS Season,
                        industrypollutions.`Year` AS `Year`,
                        Province.Title AS Province,
                        Count( industrypollutions.Id ) AS Total 
                    FROM
                        industries
                        JOIN industry_workshopaddresses ON industry_workshopaddresses.IndustryId = industries.Id
                        JOIN enumdata AS Province ON industry_workshopaddresses.ProvinceId = Province.Id
                        JOIN industrypollutions ON industrypollutions.IndustryId = industries.Id
                        JOIN enumdata AS Season ON industrypollutions.SeasonId = Season.Id 
                        WHERE industrypollutions.FinalSave = true
                    GROUP BY
                        ProvinceId,
                        industrypollutions.`Year`,
                        SeasonId";
            migrationBuilder.Sql(addCmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var deleteCmd = @"DROP VIEW IF EXISTS `v_pollutiontaxesdashboard`;";
            migrationBuilder.Sql(deleteCmd);
        }
    }
}
