using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateMonitoringTypeDashboard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var deleteCmd = @"DROP VIEW IF EXISTS `v_monitoringtypedashboard`;";
            migrationBuilder.Sql(deleteCmd);
            var cmd = @"CREATE VIEW v_monitoringtypedashboard AS 
                    select `ostanenums`.`Title` AS `Province`,count(0) AS `Count`,`parameternames`.`Title` AS `MonitoringTypeTitle`,`parameternames`.`Id` AS `MonitoringTypeId`,`parameternames`.`Category` AS `Color`,`industrialunitssamplingresults`.`MonitoringYear` AS `MonitoringYear` from (((((`industries` join `industry_workshopaddresses` on(`industry_workshopaddresses`.`IndustryId` = `industries`.`Id`)) join `enumdata` `ostanenums` on(`industry_workshopaddresses`.`ProvinceId` = `ostanenums`.`Id`)) join `industrialunitssamplingresults` on(`industrialunitssamplingresults`.`IndustryId` = `industries`.`Id`)) join `parameterssamplingresults` on(`parameterssamplingresults`.`IndustrialUnitsSamplingResultId` = `industrialunitssamplingresults`.`Id`)) join `enumdata` `parameternames` on(`parameterssamplingresults`.`MonitoringTypeId` = `parameternames`.`Id`)) where `industrialunitssamplingresults`.`FinalSave` = 1 group by `industry_workshopaddresses`.`ProvinceId`,`parameterssamplingresults`.`MonitoringTypeId`,`industrialunitssamplingresults`.`MonitoringYear`";
            migrationBuilder.Sql(cmd);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_monitoringtypedashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
