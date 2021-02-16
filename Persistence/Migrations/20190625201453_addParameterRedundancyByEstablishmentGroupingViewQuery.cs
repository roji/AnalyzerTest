using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addParameterRedundancyByEstablishmentGroupingViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_paramredundancybyestablishmentgroupingclassificationdashboard AS 
                ( SELECT
                        mp.ParamId AS ParamId,
                        paraminfo.Title AS ParamTitle,
                        EstablishmentGroupingClassification.Title AS EstablishmentGroupingClassificationTitle,
                        industrialunitssamplingresults.MonitoringYear AS MonitoringYear,
                        count( 0 ) AS ParameterCount,
                        0 AS PollutionTypeId,
                        'ambientair' AS PollutionType 
                        FROM
                            industrialunitssamplingresults
                            JOIN parameterssamplingresults psr ON industrialunitssamplingresults.Id = psr.IndustrialUnitsSamplingResultId
                            JOIN monitoringparameters mp ON mp.Id = psr.MonitoringParametersId
                            JOIN ambientairparametersresults amb ON amb.ParametersSamplingResultsId = psr.Id
                            JOIN enumdata paraminfo ON paraminfo.Id = mp.ParamId
                            JOIN industries ON industries.Id = industrialunitssamplingresults.IndustryId
                            JOIN enumdata EstablishmentGrouping ON EstablishmentGrouping.Id = industries.EstablishmentGroupingId
                            JOIN enumdata EstablishmentGroupingClassification ON EstablishmentGrouping.ParentId = EstablishmentGroupingClassification.Id 
                        WHERE
                            industrialunitssamplingresults.FinalSave = 1 
                            AND amb.Quantity > mp.PollutionLimitQuantity 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                            EstablishmentGroupingClassification.Id 
                        ) UNION
                        (
                        SELECT
                            mp.ParamId AS ParamId,
                            paraminfo.Title AS ParamTitle,
                            EstablishmentGroupingClassification.Title AS EstablishmentGroupingClassificationTitle,
                            industrialunitssamplingresults.MonitoringYear AS MonitoringYear,
                            count( 0 ) AS ParameterCount,
                            1 AS PollutionTypeId,
                            'chimney' AS PollutionType 
                        FROM
                            industrialunitssamplingresults
                            JOIN parameterssamplingresults psr ON industrialunitssamplingresults.Id = psr.IndustrialUnitsSamplingResultId
                            JOIN monitoringparameters mp ON mp.Id = psr.MonitoringParametersId
                            JOIN chimneyparametersresults chm ON chm.ParametersSamplingResultsId = psr.Id
                            JOIN enumdata paraminfo ON paraminfo.Id = mp.ParamId
                            JOIN industries ON industries.Id = industrialunitssamplingresults.IndustryId
                            JOIN enumdata EstablishmentGrouping ON EstablishmentGrouping.Id = industries.EstablishmentGroupingId
                            JOIN enumdata EstablishmentGroupingClassification ON EstablishmentGrouping.ParentId = EstablishmentGroupingClassification.Id 
                        WHERE
                            industrialunitssamplingresults.FinalSave = 1 
                            AND chm.Quantity > mp.PollutionLimitQuantity 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                            EstablishmentGroupingClassification.Id 
                        ) UNION
                        (
                        SELECT
                            mp.ParamId AS ParamId,
                            paraminfo.Title AS ParamTitle,
                            EstablishmentGroupingClassification.Title AS EstablishmentGroupingClassificationTitle,
                            industrialunitssamplingresults.MonitoringYear AS MonitoringYear,
                            count( 0 ) AS ParameterCount,
                            2 AS PollutionTypeId,
                            'wastewater' AS PollutionType 
                        FROM
                            industrialunitssamplingresults
                            JOIN parameterssamplingresults psr ON industrialunitssamplingresults.Id = psr.IndustrialUnitsSamplingResultId
                            JOIN monitoringparameters mp ON mp.Id = psr.MonitoringParametersId
                            JOIN wastewaterparametersresults ww ON ww.ParametersSamplingResultsId = psr.Id
                            JOIN enumdata paraminfo ON paraminfo.Id = mp.ParamId
                            JOIN industries ON industries.Id = industrialunitssamplingresults.IndustryId
                            JOIN enumdata EstablishmentGrouping ON EstablishmentGrouping.Id = industries.EstablishmentGroupingId
                            JOIN enumdata EstablishmentGroupingClassification ON EstablishmentGrouping.ParentId = EstablishmentGroupingClassification.Id 
                        WHERE
                            industrialunitssamplingresults.FinalSave = 1 
                            AND ww.Quantity > mp.PollutionLimitQuantity 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                            EstablishmentGroupingClassification.Id 
                        ) UNION
                        (
                        SELECT
                            mp.ParamId AS ParamId,
                            paraminfo.Title AS ParamTitle,
                            EstablishmentGroupingClassification.Title AS EstablishmentGroupingClassificationTitle,
                            industrialunitssamplingresults.MonitoringYear AS MonitoringYear,
                            count( 0 ) AS ParameterCount,
                            3 AS PollutionTypeId,
                            'waste' AS PollutionType 
                        FROM
                            industrialunitssamplingresults
                            JOIN parameterssamplingresults psr ON industrialunitssamplingresults.Id = psr.IndustrialUnitsSamplingResultId
                            JOIN monitoringparameters mp ON mp.Id = psr.MonitoringParametersId
                            JOIN wasteparametersresults waste ON waste.ParametersSamplingResultsId = psr.Id
                            JOIN enumdata paraminfo ON paraminfo.Id = mp.ParamId
                            JOIN industries ON industries.Id = industrialunitssamplingresults.IndustryId
                            JOIN enumdata EstablishmentGrouping ON EstablishmentGrouping.Id = industries.EstablishmentGroupingId
                            JOIN enumdata EstablishmentGroupingClassification ON EstablishmentGrouping.ParentId = EstablishmentGroupingClassification.Id 
                        WHERE
                            industrialunitssamplingresults.FinalSave = 1 
                            AND waste.Quantity > mp.PollutionLimitQuantity 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                            EstablishmentGroupingClassification.Id 
                        ) UNION
                        (
                        SELECT
                            mp.ParamId AS ParamId,
                            paraminfo.Title AS ParamTitle,
                            EstablishmentGroupingClassification.Title AS EstablishmentGroupingClassificationTitle,
                            industrialunitssamplingresults.MonitoringYear AS MonitoringYear,
                            count( 0 ) AS ParameterCount,
                            4 AS PollutionTypeId,
                            'soundandwave' AS PollutionType 
                        FROM
                            industrialunitssamplingresults
                            JOIN parameterssamplingresults psr ON industrialunitssamplingresults.Id = psr.IndustrialUnitsSamplingResultId
                            JOIN monitoringparameters mp ON mp.Id = psr.MonitoringParametersId
                            JOIN soundandwavesparametersresults sw ON sw.ParametersSamplingResultsId = psr.Id
                            JOIN enumdata paraminfo ON paraminfo.Id = mp.ParamId
                            JOIN industries ON industries.Id = industrialunitssamplingresults.IndustryId
                            JOIN enumdata EstablishmentGrouping ON EstablishmentGrouping.Id = industries.EstablishmentGroupingId
                            JOIN enumdata EstablishmentGroupingClassification ON EstablishmentGrouping.ParentId = EstablishmentGroupingClassification.Id 
                        WHERE
                            industrialunitssamplingresults.FinalSave = 1 
                            AND sw.Quantity > mp.PollutionLimitQuantity 
                        GROUP BY
                            mp.ParamId,
                            industrialunitssamplingresults.MonitoringYear,
                        EstablishmentGroupingClassification.Id 
                        )";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_paramredundancybyestablishmentgroupingclassificationdashboard`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
