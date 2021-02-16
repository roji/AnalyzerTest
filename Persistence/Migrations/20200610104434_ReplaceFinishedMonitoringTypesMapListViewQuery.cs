using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ReplaceFinishedMonitoringTypesMapListViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var deleteCmd = @"DROP VIEW IF EXISTS `v_finishedmonitoringtypesmaplist`;";
            migrationBuilder.Sql(deleteCmd);
            var addCmd = @"CREATE VIEW v_finishedmonitoringtypesmaplist AS 
                        SELECT
                            `industries`.`Name` AS `IndustryName`,
                            `industrialunitssamplingresults`.`MonitoringYear` AS `MonitoringYear`,
                            `province`.`Title` AS `ProvinceTitle`,
                            `monitoringperiod`.`Title` AS `MonitoringPeriod`,
                            `monitoringtype`.`Title` AS `MonitoringTypeTitle`,
                            `monitoringtype`.`Data` AS `MonitoringTypeClassification`,
                            `industries`.`Id` AS `IndustryId`,
                            `industrialunitssamplingresults`.`Id` AS `IusrId`,
                            `parameterssamplingresults`.`MonitoringTypeId` AS `MonitoringTypeId`,
                            `industry_workshopaddresses`.`Latitude` AS `Geo_Latitude`,
                            `industry_workshopaddresses`.`Longitude` AS `Geo_Longitude`,
                            `monitoringperiod`.`Data` AS `MonitoringPeriodData` 
                        FROM
                            ((((((
                                                    `industrialunitssamplingresults`
                                                    JOIN `industries` ON ( `industries`.`Id` = `industrialunitssamplingresults`.`IndustryId` ))
                                                JOIN `industry_workshopaddresses` ON ( `industry_workshopaddresses`.`IndustryId` = `industries`.`Id` ))
                                            JOIN `parameterssamplingresults` ON ( `parameterssamplingresults`.`IndustrialUnitsSamplingResultId` = `industrialunitssamplingresults`.`Id` ))
                                        JOIN `enumdata` `province` ON ( `province`.`Id` = `industry_workshopaddresses`.`ProvinceId` ))
                                    JOIN `enumdata` `monitoringperiod` ON ( `monitoringperiod`.`Id` = `industrialunitssamplingresults`.`MonitoringPeriodId` ))
                            JOIN `enumdata` `monitoringtype` ON ( `monitoringtype`.`Id` = `parameterssamplingresults`.`MonitoringTypeId` )) 
                        WHERE
                            `industrialunitssamplingresults`.`FinalSave` = 1 
                        GROUP BY
                            `parameterssamplingresults`.`MonitoringTypeId`,
                            `industrialunitssamplingresults`.`Id` 
                        ORDER BY
                            `industrialunitssamplingresults`.`MonitoringYear` DESC,
                            `industries`.`Name`
            ";
            migrationBuilder.Sql(addCmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var deleteCmd = @"DROP VIEW IF EXISTS `v_finishedmonitoringtypesmaplist`;";
            migrationBuilder.Sql(deleteCmd);
            var addCmd = @"CREATE VIEW v_finishedmonitoringtypesmaplist AS 
                        SELECT
                            `industries`.`Name` AS `IndustryName`,
                            `industrialunitssamplingresults`.`MonitoringYear` AS `MonitoringYear`,
                            `province`.`Title` AS `ProvinceTitle`,
                            `monitoringperiod`.`Title` AS `MonitoringPeriod`,
                            `monitoringtype`.`Title` AS `MonitoringTypeTitle`,
                            `monitoringtype`.`Data` AS `MonitoringTypeClassification`,
                            `industries`.`Id` AS `IndustryId`,
                            `industrialunitssamplingresults`.`Id` AS `IusrId`,
                            `parameterssamplingresults`.`MonitoringTypeId` AS `MonitoringTypeId`,
                            `industry_workshopaddresses`.`Latitude` AS `Geo_Latitude`,
                            `industry_workshopaddresses`.`Longitude` AS `Geo_Longitude`,
                            `monitoringperiod`.`Data` AS `MonitoringPeriodData` 
                        FROM
                            ((((((
                                                    `industrialunitssamplingresults`
                                                    JOIN `industries` ON ( `industries`.`Id` = `industrialunitssamplingresults`.`IndustryId` ))
                                                JOIN `industry_workshopaddresses` ON ( `industry_workshopaddresses`.`IndustryId` = `industries`.`Id` ))
                                            JOIN `parameterssamplingresults` ON ( `parameterssamplingresults`.`IndustrialUnitsSamplingResultId` = `industrialunitssamplingresults`.`Id` ))
                                        JOIN `enumdata` `province` ON ( `province`.`Id` = `industry_workshopaddresses`.`ProvinceId` ))
                                    JOIN `enumdata` `monitoringperiod` ON ( `monitoringperiod`.`Id` = `industrialunitssamplingresults`.`MonitoringPeriodId` ))
                            JOIN `enumdata` `monitoringtype` ON ( `monitoringtype`.`Id` = `parameterssamplingresults`.`MonitoringTypeId` )) 
                        WHERE
                            `industrialunitssamplingresults`.`FinalSave` = 1 
                        GROUP BY
                            `parameterssamplingresults`.`MonitoringTypeId`,
                            `industrialunitssamplingresults`.`Id` 
                        ORDER BY
                            `industrialunitssamplingresults`.`MonitoringYear` DESC,
                            `industries`.`Name`
            ";
            migrationBuilder.Sql(addCmd);
        }
    }
}
