using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryMonitoringDashboardView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_industrymonitoringdashboard AS 
                    SELECT
                    ( CASE WHEN isnull( `ostanenums`.`Title` ) THEN 'نامشخص' ELSE `ostanenums`.`Title` END ) AS `Province`,
                    sum( ( CASE WHEN monitoringinfos.NeedMonitoring = 0 THEN 1 ELSE 0 END ) ) AS `NoNeedToBeCoveredIndustries`, 
                    sum( ( CASE WHEN isnull( monitoringinfos.NeedMonitoring ) || monitoringinfos.NeedMonitoring = 1  THEN 1 ELSE 0 END ) ) AS `MonitoringCoveredIndustries`
                    FROM
                    `industries`
                    LEFT JOIN `industry_workshopaddresses` ON  `industry_workshopaddresses`.`IndustryId` = `industries`.`Id` 
                    LEFT JOIN `enumdata` `ostanenums` ON  `industry_workshopaddresses`.`ProvinceId` = `ostanenums`.`Id`  
                    LEFT JOIN monitoringinfos ON monitoringinfos.IndustryId = industries.Id
                    GROUP BY
                    `industry_workshopaddresses`.`ProvinceId`";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_industrymonitoringdashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
