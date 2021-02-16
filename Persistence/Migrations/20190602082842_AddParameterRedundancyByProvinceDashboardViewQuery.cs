using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddParameterRedundancyByProvinceDashboardViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_parameterredundancybyprovincedashboard AS 
                   ( -- ambientair
                        SELECT
                            mp.ParamId,
                            paramInfo.Title AS ParamTitle,
                            ostan.Title AS Province,
                            industrialunitssamplingresults.MonitoringYear,
                            COUNT( * ) AS ParameterCount,
                            0 AS PollutionTypeId,
                            'ambientair' AS PollutionType 
                        FROM
                            `industrialunitssamplingresults`
                            JOIN `parameterssamplingresults` `psr` ON `industrialunitssamplingresults`.`Id` = `psr`.`IndustrialUnitsSamplingResultId`
                            JOIN `monitoringparameters` `mp` ON `mp`.`Id` = `psr`.`MonitoringParametersId`
                            JOIN `ambientairparametersresults` `amb` ON `amb`.`ParametersSamplingResultsId` = `psr`.`Id`
                            JOIN enumdata paramInfo ON paramInfo.Id = mp.ParamId
                            JOIN industry_workshopaddresses ON industry_workshopaddresses.IndustryId = industrialunitssamplingresults.IndustryId
                            JOIN enumdata ostan ON ostan.Id = industry_workshopaddresses.ProvinceId 
                        WHERE
                            `industrialunitssamplingresults`.`FinalSave` = 1 
                            AND `amb`.`Quantity` > `mp`.`PollutionLimitQuantity` 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                            industry_workshopaddresses.ProvinceId 
                        )
                        UNION
                        (-- chimney
                        SELECT
                            mp.ParamId,
                            paramInfo.Title AS ParamTitle,
                            ostan.Title AS Province,
                            industrialunitssamplingresults.MonitoringYear,
                            COUNT( * ) AS ParameterCount,
                            1 AS PollutionTypeId,
                            'chimney' AS PollutionType 
                        FROM
                            `industrialunitssamplingresults`
                            JOIN `parameterssamplingresults` `psr` ON `industrialunitssamplingresults`.`Id` = `psr`.`IndustrialUnitsSamplingResultId`
                            JOIN `monitoringparameters` `mp` ON `mp`.`Id` = `psr`.`MonitoringParametersId`
                            JOIN chimneyparametersresults `chm` ON `chm`.`ParametersSamplingResultsId` = `psr`.`Id`
                            JOIN enumdata paramInfo ON paramInfo.Id = mp.ParamId
                            JOIN industry_workshopaddresses ON industry_workshopaddresses.IndustryId = industrialunitssamplingresults.IndustryId
                            JOIN enumdata ostan ON ostan.Id = industry_workshopaddresses.ProvinceId 
                        WHERE
                            `industrialunitssamplingresults`.`FinalSave` = 1 
                            AND `chm`.`Quantity` > `mp`.`PollutionLimitQuantity` 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                        industry_workshopaddresses.ProvinceId 
                        )
                        UNION
                        (-- wastewater
                        SELECT
                            mp.ParamId,
                            paramInfo.Title AS ParamTitle,
                            ostan.Title AS Province,
                            industrialunitssamplingresults.MonitoringYear,
                            COUNT( * ) AS ParameterCount,
                            2 AS PollutionTypeId,
                            'wastewater' AS PollutionType 
                        FROM
                            `industrialunitssamplingresults`
                            JOIN `parameterssamplingresults` `psr` ON `industrialunitssamplingresults`.`Id` = `psr`.`IndustrialUnitsSamplingResultId`
                            JOIN `monitoringparameters` `mp` ON `mp`.`Id` = `psr`.`MonitoringParametersId`
                            JOIN wastewaterparametersresults `ww` ON `ww`.`ParametersSamplingResultsId` = `psr`.`Id`
                            JOIN enumdata paramInfo ON paramInfo.Id = mp.ParamId
                            JOIN industry_workshopaddresses ON industry_workshopaddresses.IndustryId = industrialunitssamplingresults.IndustryId
                            JOIN enumdata ostan ON ostan.Id = industry_workshopaddresses.ProvinceId 
                        WHERE
                            `industrialunitssamplingresults`.`FinalSave` = 1 
                            AND `ww`.`Quantity` > `mp`.`PollutionLimitQuantity` 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                        industry_workshopaddresses.ProvinceId 
                        )
                            UNION
                        (-- waste
                        SELECT
                            mp.ParamId,
                            paramInfo.Title AS ParamTitle,
                            ostan.Title AS Province,
                            industrialunitssamplingresults.MonitoringYear,
                            COUNT( * ) AS ParameterCount,
                            3 AS PollutionTypeId,
                            'waste' AS PollutionType 
                        FROM
                            `industrialunitssamplingresults`
                            JOIN `parameterssamplingresults` `psr` ON `industrialunitssamplingresults`.`Id` = `psr`.`IndustrialUnitsSamplingResultId`
                            JOIN `monitoringparameters` `mp` ON `mp`.`Id` = `psr`.`MonitoringParametersId`
                            JOIN wasteparametersresults `waste` ON `waste`.`ParametersSamplingResultsId` = `psr`.`Id`
                            JOIN enumdata paramInfo ON paramInfo.Id = mp.ParamId
                            JOIN industry_workshopaddresses ON industry_workshopaddresses.IndustryId = industrialunitssamplingresults.IndustryId
                            JOIN enumdata ostan ON ostan.Id = industry_workshopaddresses.ProvinceId 
                        WHERE
                            `industrialunitssamplingresults`.`FinalSave` = 1 
                            AND `waste`.`Quantity` > `mp`.`PollutionLimitQuantity` 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                        industry_workshopaddresses.ProvinceId 
                        )
                                UNION
                        (-- soundAndwave
                        SELECT
                            mp.ParamId,
                            paramInfo.Title AS ParamTitle,
                            ostan.Title AS Province,
                            industrialunitssamplingresults.MonitoringYear,
                            COUNT( * ) AS ParameterCount,
                            4 AS PollutionTypeId,
                            'soundandwave' AS PollutionType 
                        FROM
                            `industrialunitssamplingresults`
                            JOIN `parameterssamplingresults` `psr` ON `industrialunitssamplingresults`.`Id` = `psr`.`IndustrialUnitsSamplingResultId`
                            JOIN `monitoringparameters` `mp` ON `mp`.`Id` = `psr`.`MonitoringParametersId`
                            JOIN soundandwavesparametersresults `sw` ON `sw`.`ParametersSamplingResultsId` = `psr`.`Id`
                            JOIN enumdata paramInfo ON paramInfo.Id = mp.ParamId
                            JOIN industry_workshopaddresses ON industry_workshopaddresses.IndustryId = industrialunitssamplingresults.IndustryId
                            JOIN enumdata ostan ON ostan.Id = industry_workshopaddresses.ProvinceId 
                        WHERE
                            `industrialunitssamplingresults`.`FinalSave` = 1 
                            AND `sw`.`Quantity` > `mp`.`PollutionLimitQuantity` 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                        industry_workshopaddresses.ProvinceId 
                        )";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_parameterredundancybyprovincedashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
