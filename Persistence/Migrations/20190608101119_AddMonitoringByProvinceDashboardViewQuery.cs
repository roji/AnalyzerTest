using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMonitoringByProvinceDashboardViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_monitoringbyprovincedashboard AS 
                 select count(`industrialunitssamplingresults`.`Id`) AS `Total`,`ostan`.`Title` AS `Province`,`industrialunitssamplingresults`.`MonitoringYear` AS `MonitoringYear`,`fasl`.`Title` AS `MonitoringPeriodTitle`,`fasl`.`Id` AS `MonitoringPeriodId`,`fasl`.`Data` AS `MonitoringPeriodData` from (((`industrialunitssamplingresults` join `industry_workshopaddresses` on((`industry_workshopaddresses`.`IndustryId` = `industrialunitssamplingresults`.`IndustryId`))) join `enumdata` `ostan` on((`ostan`.`Id` = `industry_workshopaddresses`.`ProvinceId`))) join `enumdata` `fasl` on((`fasl`.`Id` = `industrialunitssamplingresults`.`MonitoringPeriodId`))) where (`industrialunitssamplingresults`.`FinalSave` = 1) group by `industry_workshopaddresses`.`ProvinceId`,`industrialunitssamplingresults`.`MonitoringYear`,`industrialunitssamplingresults`.`MonitoringPeriodId`";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_monitoringbyprovincedashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
