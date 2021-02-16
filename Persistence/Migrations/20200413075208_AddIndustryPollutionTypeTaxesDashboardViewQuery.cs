using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryPollutionTypeTaxesDashboardViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var addCmd = @"CREATE VIEW v_industrypollutiontypetaxesdashboard AS 
                   SELECT
                        Province.Title AS Province,
                        Season.Id AS SeasonId,
                        Season.Title AS SeasonTitle,
                        industrypollutions.`Year`,
                        sum( CASE WHEN PollutionType.Id = 2802 THEN 1 ELSE 0 END ) AS Air,
                        sum( CASE WHEN PollutionType.Id = 2909 THEN 1 ELSE 0 END ) AS RisklessMedicalDevices,
                        sum( CASE WHEN PollutionType.Id = 2911 THEN 1 ELSE 0 END ) AS WastewaterAndMedical,
                        sum( CASE WHEN PollutionType.Id = 2912 THEN 1 ELSE 0 END ) AS Waste,
                        sum( CASE WHEN PollutionType.Id = 2915 THEN 1 ELSE 0 END ) AS WaterResource,
                        sum( CASE WHEN PollutionType.Id = 2916 THEN 1 ELSE 0 END ) AS DustResource,
                        sum( CASE WHEN PollutionType.Id = 21555 THEN 1 ELSE 0 END ) AS MercuryAndHazardousChemicals,
                        sum( CASE WHEN PollutionType.Id = 22700 THEN 1 ELSE 0 END ) AS Chimney,
                        sum( CASE WHEN PollutionType.Id = 22702 THEN 1 ELSE 0 END ) AS SoundAndWave,
                        Count(*) AS Total 
                    FROM
                        industrypollutiontypes
                        JOIN industrypollutions ON industrypollutions.Id = industrypollutiontypes.IndustryPollutionId
                        LEFT JOIN industry_workshopaddresses ON industry_workshopaddresses.IndustryId = industrypollutions.IndustryId
                        LEFT JOIN enumdata Province ON Province.Id = industry_workshopaddresses.ProvinceId
                        LEFT JOIN enumdata Season ON Season.Id = industrypollutions.SeasonId
                        LEFT JOIN enumdata PollutionType ON PollutionType.Id = industrypollutiontypes.PollutionTypeId 
                    WHERE
                        industrypollutions.FinalSave = TRUE 
                    GROUP BY
                        industrypollutions.`Year`,
                        Season.Id,
                        Province.Id";
            migrationBuilder.Sql(addCmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var deleteCmd = @"DROP VIEW IF EXISTS `v_industrypollutiontypetaxesdashboard`;";
            migrationBuilder.Sql(deleteCmd);
        }
    }
}
