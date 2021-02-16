using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewBigIndustryManagementDashboardViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var deleteCmd = @"DROP VIEW IF EXISTS `v_bigindustrymanagementdashboard`;";
            migrationBuilder.Sql(deleteCmd);
            var cmd = @"CREATE VIEW v_bigindustrymanagementdashboard AS 
                SELECT
                    Province.Title AS Province,
                    EstablishmentGroupingClassification.Title AS EstablishmentGroupingClassificationTitle,
                    EstablishmentGroupingClassification.Id As EstablishmentGroupingClassificationId,
                    count(0) as Count
                FROM
                    industries
                    INNER JOIN industry_workshopaddresses ON industries.Id = industry_workshopaddresses.IndustryId
                    INNER JOIN enumdata Province ON industry_workshopaddresses.ProvinceId = Province.Id
                    INNER JOIN enumdata EstablishmentGrouping ON industries.EstablishmentGroupingId = EstablishmentGrouping.Id
                    INNER JOIN enumdata EstablishmentGroupingClassification ON EstablishmentGroupingClassification.Id = EstablishmentGrouping.ParentId
                    GROUP BY
                    Province.Id,
                    EstablishmentGroupingClassification.Id";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_bigindustrymanagementdashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
