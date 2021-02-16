using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMonitoringTypeMapListView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_monitoringtypemaplist AS 
                   select `industries`.`Name` AS `IndustryName`,`industrialunitssamplingresults`.`MonitoringYear` AS `MonitoringYear`,`province`.`Title` AS `ProvinceTitle`,`monitoringperiod`.`Title` AS `MonitoringPeriod`,`monitoringtype`.`Title` AS `MonitoringTypeTitle`,`monitoringtype`.`Data` AS `MonitoringTypeClassification`,`industries`.`Id` AS `IndustryId`,`industrialunitssamplingresults`.`Id` AS `IusrId`,`parameterssamplingresults`.`MonitoringTypeId` AS `MonitoringTypeId`,`industry_workshopaddresses`.`Latitude` AS `Geo_Latitude`,`industry_workshopaddresses`.`Longitude` AS `Geo_Longitude`,`monitoringperiod`.`Data` AS `MonitoringPeriodData` from ((((((`industrialunitssamplingresults` join `industries` on((`industries`.`Id` = `industrialunitssamplingresults`.`IndustryId`))) join `industry_workshopaddresses` on((`industry_workshopaddresses`.`IndustryId` = `industries`.`Id`))) join `parameterssamplingresults` on((`parameterssamplingresults`.`IndustrialUnitsSamplingResultId` = `industrialunitssamplingresults`.`Id`))) join `enumdata` `province` on((`province`.`Id` = `industry_workshopaddresses`.`ProvinceId`))) join `enumdata` `monitoringperiod` on((`monitoringperiod`.`Id` = `industrialunitssamplingresults`.`MonitoringPeriodId`))) join `enumdata` `monitoringtype` on((`monitoringtype`.`Id` = `parameterssamplingresults`.`MonitoringTypeId`))) where (`industrialunitssamplingresults`.`FinalSave` = 1)";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_monitoringtypemaplist`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
